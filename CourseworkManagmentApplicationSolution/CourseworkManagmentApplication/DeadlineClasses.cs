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
        protected string comment;

        public DeadlineClasses(string name, string dueDate, string setDate)
        {
            this.name = name;
            this.dueDate = dueDate;
            this.setDate = setDate;
        }
        public DeadlineClasses(string name, string dueDate, string setDate, string comment)
        {
            this.name = name;
            this.dueDate = dueDate;
            this.setDate = setDate;
            this.comment = comment;
        }
        public string getName()
        {
            return name;
        }
    }

    class Assignment : DeadlineClasses
    {
        public Assignment(string name, string dueDate, string setDate) : base(name, dueDate, setDate)
        {

        }

        public Assignment(string name, string dueDate, string setDate, string comment) : base(name, dueDate, setDate, comment)
        {

        }

    }

    class AdminPanel : DeadlineClasses
    {
        public AdminPanel(string name, string dueDate, string setDate) : base(name, dueDate, setDate)
        {

        }

        public AdminPanel(string name, string dueDate, string setDate, string comment) : base(name, dueDate, setDate, comment)
        {

        }
    }

    class AdminMeeting : DeadlineClasses
    {
        public AdminMeeting(string name, string dueDate, string setDate) : base(name, dueDate, setDate)
        {

        }

        public AdminMeeting(string name, string dueDate, string setDate, string comment) : base(name, dueDate, setDate, comment)
        {

        }
    }
}
