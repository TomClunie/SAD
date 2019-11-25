using System;

namespace CourseworkManagmentApplication
{
    class User
    {
        string name;

        public User()
        {
        }
        User(string pName)
        {
            name = pName;
        }

        public string getName()
        {
            return name;
        }
    }

    class DirectorOfStudy : User
    {
        DirectorOfStudy()
        {
            
        }
    }

    class ProgrammeDirector : User
    {
        ProgrammeDirector()
        {

        }
    }
    class ModuleLeader : User
    {
        ModuleLeader()
        {

        }
    }

    class Academic : User
    {
        Academic()
        {

        }
    }
    class FacultyHub : User
    {
        FacultyHub()
        {

        }
    }




}
