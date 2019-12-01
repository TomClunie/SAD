using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseworkManagmentApplication
{
    class DeadlineClasses
    {
        protected string name;
        protected string dueDate;
        protected string setDate;
        protected string username;
        protected string comment;

        public DeadlineClasses(string name,string username, string dueDate, string setDate)
        {
            this.name = name;
            this.username = username;
            this.dueDate = dueDate;
            this.setDate = setDate;
        }
        public DeadlineClasses(string name, string username, string dueDate, string setDate, string comment)
        {
            this.name = name;
            this.username = username;
            this.dueDate = dueDate;
            this.setDate = setDate;
            this.comment = comment;
        }

        public string getName()
        {
            return name;
        }

        public string getDueDate()
        {
            return dueDate;
        }

        public string getComment()
        {
            return comment;
        }

        public string getUser()
        {
            return username;
        }
    }

    class Assignment : DeadlineClasses
    {
        public Assignment(string name, string username, string dueDate, string setDate) : base(name, username, dueDate, setDate)
        {

        }

        public Assignment(string name, string username, string dueDate, string setDate, string comment) : base(name, username, dueDate, setDate, comment)
        {

        }

        public string getType()
        {
            return "Assignment";
        }

        public string getInfo()
        {
            return "Assignment," + name + "," + username + "," + dueDate + "," + setDate + "," + comment;
        }

    }

    class AdminPanel : DeadlineClasses
    {
        public AdminPanel(string name, string username, string dueDate, string setDate) : base(name, username, dueDate, setDate)
        {

        }

        public AdminPanel(string name, string username, string dueDate, string setDate, string comment) : base(name, username, dueDate, setDate, comment)
        {
        

        }

        public string getType()
        {
            return "Admin: Administer Panel";
        }

        public string getInfo()
        {
            return "Admin: Administer Panel," + name + "," + username + "," + dueDate + "," + setDate + "," + comment;
        }
    }

    class AdminMeeting : DeadlineClasses
    {
        public AdminMeeting(string name, string username, string dueDate, string setDate) : base(name, username, dueDate, setDate)
        {

        }

        public AdminMeeting(string name, string username, string dueDate, string setDate, string comment) : base(name, username, dueDate, setDate, comment)
        {

        }

        public string getType()
        {
            return "Admin: Book Meeting Room";
        }

        public string getInfo()
        {
            return "Admin: Book Meeting Room," + name + "," + username + "," + dueDate + "," + setDate + "," + comment;
        }
    }
}
