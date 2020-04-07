# @copyright 2004-2020 Bordeaux INP, CNRS (LaBRI UMR 5800), Inria, Univ. Bordeaux. All rights reserved.
# @version 0.1
# @author Mathieu Faverge
# @author Pierre Ramet
# @date 2020-04-07

import discord
from readfile import *
import importlib
import re

#student_permissions=(104328256 & 0x00000200)
student_permissions=104328768
teacher_permissions=8

class Myserver():
    guild=None
    client=None
    project=None

    async def handle_message( self, guild, client, message ):
        return

    async def create_role( self, roles, role, permissions, color=None ):
        guild_role = None

        for r in roles:
            if str(r) == role:
                message = "Found role: %s\n" %  ( role )
                guild_role = r
                break;

        if guild_role == None:
            message = "Create role: %s\n" %  ( role )
            if color:
                guild_role = await self.guild.create_role( name=role,
                                                           colour=color,
                                                           hoist=True,
                                                           mentionable=True,
                                                           permissions=discord.Permissions(permissions) )
            else:
                guild_role = await self.guild.create_role( name=role,
                                                           hoist=True,
                                                           mentionable=True,
                                                           permissions=discord.Permissions(permissions) )
        #print(message)
        return (guild_role, message)

    async def create_roles( self, channel=None ):
        full_msg = ""
        roles = self.guild.roles #await self.guild.fetch_roles()
        (r, msg) = await self.create_role( roles, 'enseignants', teacher_permissions )
        full_msg += msg
        self.project.teacher_role = r

        for tid in self.project.teams.keys():
            t = self.project.teams[tid]
            gid = t['group_id']
            g = self.project.groups[gid]
            team_name = g['name'][3:] + " - " + t['name'] + " - " + tid[-4:]

            color = discord.Colour.from_rgb( g['color'][0], g['color'][1], g['color'][2] )

            (r, msg) = await self.create_role( roles, team_name, student_permissions, color=color )
            full_msg += msg
            t['role'] = r

        if channel:
            await channel.send( full_msg )

    async def create_group_category( self, groups, group, teams ):
        guild_group = None
        message = ""

        # Look for existing channel
        for r in groups:
            if str(r) == group:
                message = "Found category: %s\n" %  ( group )
                guild_group = r
                break;

        # channel = await self.guild.create_text_channel('secret', overwrites=overwrites)

        if guild_group == None:
            overwrites = { self.guild.default_role: discord.PermissionOverwrite(read_messages=False) }
            perm = discord.PermissionOverwrite(read_messages=True)

            for tid in teams:
                t = self.project.teams[tid]
                overwrites[ t['role'] ] = perm

            message = "Create category: %s\n" %  ( group )
            guild_group = await self.guild.create_category_channel( group, overwrites=overwrites )

        return (guild_group, message)

    async def create_group_categories( self, channel=None ):
        full_msg = ""
        groups = self.guild.channels

        for gid in self.project.groups.keys():
            g = self.project.groups[gid]
            group_name = "Groupe " + g['name'][-1:]

            def fname( item ):
                return self.project.teams[item]['group_id'] == gid
            teams = list(filter( fname, self.project.teams ) )

            (c, msg) = await self.create_group_category( groups, group_name, teams )
            full_msg += msg
            g['category'] = c

        if channel:
            await channel.send( full_msg )

    async def create_team_channels( self, channels, group, team, channel_text, channel_voice ):
        message = ""
        guild_text = None
        guild_voice = None

        # Look for existing channel
        for c in channels:
            if str(c) == channel_text:
                message += "Found text channel: %s\n" %  ( channel_text )
                guild_text = c
            if str(c) == channel_voice:
                message += "Found voice channel: %s\n" %  ( channel_voice )
                guild_voice = c
            if (guild_text != None) and (guild_voice != None):
                break

        # channel = await guild.create_text_channel('secret', overwrites=overwrites)
        if guild_text == None:
            overwrites = {
                self.guild.default_role: discord.PermissionOverwrite(read_messages=False),
                team['role']: discord.PermissionOverwrite(read_messages=True)
            }

            message += "Create text channel: %s\n" %  ( channel_text )
            guild_text = await self.guild.create_text_channel( channel_text,
                                                               category=group['category'],
                                                               overwrites=overwrites )

        if guild_voice == None:
            overwrites = {
                self.guild.default_role: discord.PermissionOverwrite(read_messages=False),
                team['role']: discord.PermissionOverwrite(read_messages=True)
            }

            message += "Create voice channel: %s\n" %  ( channel_voice )
            guild_voice = await self.guild.create_voice_channel( channel_voice,
                                                                 category=group['category'],
                                                                 overwrites=overwrites )

        team['channel_text']  = guild_text
        team['channel_voice'] = guild_voice
        return message

    async def create_teams_channels( self, channel=None ):
        full_msg = ""
        channels = self.guild.channels

        for tid in self.project.teams.keys():
            t = self.project.teams[tid]
            gid = t['group_id']
            g = self.project.groups[gid]

            channel_text = "g" + g['name'][-1:] + "-team" + t['name'][-1] + "-" + tid[-4:]
            channel_voice = "G" + g['name'][-1:] + " - Team " + t['name'][-1] + " - " + tid[-4:]

            msg = await self.create_team_channels( channels, g, t, channel_text, channel_voice )
            full_msg += msg

        if channel:
            await channel.send( full_msg )

    async def load_project( self, project_id, channel=None ):
        self.project = Project( "m" + project_id + ".xml" )
        if ( self.project == None ):
            await channel.send( "Failed to load project\n" )
            return

        if channel:
            await channel.send( "Load project: `%s`\n" % ( project_id ) )
        await self.create_roles( channel )
        await self.create_group_categories( channel )
        await self.create_teams_channels( channel )

    async def user_update( self, g, c, before, after ):
        self.guild = g
        self.client = c
        msg = ""

        if ( self.guild == None ):
            self.guild = after.guild

        if before.display_name == after.display_name:
            return

        await self.load_project( "2106" ) # , self.guild.system_channel )

        m = re.search(r"^G([1-4])E([1-6]) - (.*)$", after.display_name )
        if not m:
            await self.guild.system_channel.send( "{0.mention}: your pseudo is incorrect. Please update to the correct format **GxEy - Lastname Firstname**".format(after) )
            return

        if len( after.roles ) > 1:
            await self.guild.system_channel.send( "{0.mention}: you are already assigned to a group. You can't get assigned autmatically to a new team. Please contact your teacher".format(after) )
            return

        gid = m.group(1)
        tid = m.group(2)
        username = m.group(3)

        ( group, team ) = self.project.get_student( gid, tid, username )
        #print( group )
        #print( team )
        await after.add_roles( team['role'] )
        await self.guild.system_channel.send( "{0.mention} has been added to the team ".format(after) +
                                              group['name'] + " - " + team['name'] + " !!!\n" )

    async def member_join( self, g, c, member ):
        self.guild  = g
        self.client = c

        self.guild = member.guild
        if g != self.guild:
            print( "What the fuck !!!!" )

        await self.load_project( "2106" ) # , self.guild.system_channel )

        if self.guild.system_channel is not None:
            to_send = 'Welcome {0.mention} on server {1.name}!\n'.format(member, self.guild)
            to_send += "Please change your nickname following the format **GxEy - Lastname Firstname** to be enrolled in your team"

            await self.guild.system_channel.send(to_send)
