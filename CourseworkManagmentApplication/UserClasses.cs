using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseworkManagmentApplication
{
    class User
    {
        protected string username;
        protected string name;

        //Base constructor
        public User(string username, string name)
        {
            this.username = username;
            this.name = name;
        }
        
        public string getName()
        {
            return name;
        }
    }

    //Director of Study class
    class DirectorOfStudy : User
    {
        public DirectorOfStudy(string username, string name) :base(username, name)
        {
        }
    }

    //Programme Director class
    class ProgrammeDirector : User
    {
        public ProgrammeDirector(string username, string name) : base(username, name)
        {

        }
    }

    //Module Leader class
    class ModuleLeader : User
    {
        public ModuleLeader(string username, string name) : base(username, name)
        {

        }
    }

    //Academic class
    class Academic : User
    {
        public Academic(string username, string name) : base(username, name)
        {

        }
    }

    //Moderator class
    class Moderator : User
    {
        public Moderator(string username, string name) : base(username, name)
        {

        }
    }

    //Faculty Hub class
    class FacultyHub : User
    {
        public FacultyHub(string username, string name) : base(username, name)
        {

        }
    }
}
