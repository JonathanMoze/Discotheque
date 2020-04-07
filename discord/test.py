# @copyright 2004-2020 Bordeaux INP, CNRS (LaBRI UMR 5800), Inria, Univ. Bordeaux. All rights reserved.
# @version 0.1
# @author Mathieu Faverge
# @author Pierre Ramet
# @date 2020-04-07

import discord
import sys, traceback
from os import path
import importlib

guilds = None
guild_id = 123456789123456789

channels = None
categories = None

roles = {}

msglib = importlib.import_module( 'client' )

class MyClient(discord.Client):
    guild = None

    async def on_ready(self):
        print('Logged on as {0}!'.format(self.user))

        self.guild = self.get_guild( guild_id )
        print( "Guild initialized with ", self.guild.name )

    async def on_message(self, message):
        if message.author == self.user:
            return

        importlib.reload(msglib)
        server = msglib.Myserver()
        await server.handle_message( self.guild, client, message )

    async def on_member_join( self, member ):
        server = msglib.Myserver()
        await server.member_join( self.guild, client, member )

    async def on_member_update(self, before, after):
        if before == self.user:
            return
        importlib.reload(msglib)
        server = msglib.Myserver()
        await server.user_update( self.guild, client, before, after )

    async def on_user_update(self, before, after):
        if before == self.user:
            return
        importlib.reload(msglib)
        server = msglib.Myserver()
        await server.user_update( self.guild, client, before, after )

client = MyClient()
client.run('BlaBlaBlaBlaBlaBlaBlaBlaBlaBlaBlaBlaBlaBlaBlaBlaBlaBlaBlaBla')
