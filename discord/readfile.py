# @copyright 2004-2020 Bordeaux INP, CNRS (LaBRI UMR 5800), Inria, Univ. Bordeaux. All rights reserved.
# @version 0.1
# @author Mathieu Faverge
# @author Pierre Ramet
# @date 2020-04-07

from lxml import etree
from xml.dom import minidom

color_id = [ [ 255,   0,   0 ],
             [   0, 153, 255 ],
	         [   0, 255,   0 ],
	         [ 255, 204,   0 ] ]

class Project():
    xmlfile  = None

    # List of data
    teacher_role = None
    teacher_group = None
    groups   = {}
    students = {}
    teachers = {}
    teams    = {}
    roles    = {}

    # Connexion between tables
    #group_works = {}
    #group_work_teachers = []
    #student_works       = []
    #group_memberships    = []
    #team_works          = {}
    team_memberships     = []
    #team_work_teachers  = []

    def __init__( self, name ):
        #print("I'm here")
        self.xmlfile = minidom.parse( name )

        # List of data
        self.groups   = self.__create_dict_from_xml( 'group' )
        self.students = self.__create_dict_from_xml( 'student' )
        self.teachers = self.__create_dict_from_xml( 'teacher' )
        self.teams    = self.__create_dict_from_xml( 'team' )
        self.roles    = self.__create_dict_from_xml( 'project_role' )

        # Connexion between tables
        self.group_memberships = self.__create_array_from_xml( 'group_membership' ) # Link student  / group
        self.team_memberships  = self.__create_array_from_xml( 'team_membership' )
        #self.group_works         = create_dict_from_xml('group_work') # Link group / project
        #self.group_work_teachers = create_array_from_xml('group_work_teacher') # Link group / teacher
        #self.student_works       = project.getElementsByTagName('student_work') # Link student / group / project
        #self.team_works          = project.getElementsByTagName('team_work') # Link  Team / project
        #self.team_work_teachers  = project.getElementsByTagName('team_work_teacher')

        self.__add_color_to_group()

    def __create_dict_from_xml( self, fieldname ):
        mydict = {}
        data = self.xmlfile.getElementsByTagName(fieldname)

        for d in data:
            key = None
            values = {}
            for k in d.attributes.keys():
                if k == 'id':
                    key = d.attributes[k].value
                else:
                    values[k] = d.attributes[k].value
                    #print( key, values )
            mydict[key] = values
        return mydict

    def __create_array_from_xml( self, fieldname ):
        myarray = []
        data = self.xmlfile.getElementsByTagName(fieldname)

        for d in data:
            key = None
            values = {}
            for k in d.attributes.keys():
                values[k] = d.attributes[k].value
                #print( key, values )
            myarray.append( values )
        return myarray

    def __add_color_to_group( self ):
        i = 0
        #print( self.groups )
        for gid in self.groups:
            g = self.groups[gid]
            g['color'] = color_id[i]
            print(g)
            i = i+1

    def get_team_by_group( self, gid ):

        def fname( item ):
            return self.teams[item]['group_id'] == gid
        teams = list(filter( fname, self.teams ) )
        return teams

    def get_student( self, gnum, tnum, username ):

        def gfilter( item ):
            return self.groups[item]['name'][-1] == gnum

        gid = list(filter( gfilter, self.groups ))[0]

        teams = self.get_team_by_group( gid )

        def tfilter( item ):
            print( item, tnum )
            return self.teams[item]['name'][-1:] == tnum

        tid = list(filter( tfilter, teams ))[0]

        return( self.groups[gid], self.teams[tid] )

