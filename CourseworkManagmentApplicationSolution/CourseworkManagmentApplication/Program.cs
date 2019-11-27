using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CourseworkManagmentApplication
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            List<User> listOfUsers = new List<User>();

            string line;
            StreamReader reader = new StreamReader(@".\\userclasses.txt");
            while ((line = reader.ReadLine()) != null)
            {
                string[] bits = line.Split(',');
                if (bits.Length == 3)
                {
                    if (bits[2] == "DirectorOfStudy")
                    {
                        listOfUsers.Add(new DirectorOfStudy(bits[0], bits[1]));
                    }
                    if (bits[2] == "ProgrammeDirector")
                    {
                        listOfUsers.Add(new ProgrammeDirector(bits[0], bits[1]));
                    }
                    if (bits[2] == "ModuleLeader")
                    {
                        listOfUsers.Add(new ModuleLeader(bits[0], bits[1]));
                    }
                    if (bits[2] == "Academic")
                    {
                        listOfUsers.Add(new Academic(bits[0], bits[1]));
                    }
                    if (bits[2] == "Moderator")
                    {
                        listOfUsers.Add(new Moderator(bits[0], bits[1]));
                    }
                    if (bits[2] == "FacultyHub")
                    {
                        listOfUsers.Add(new FacultyHub(bits[0], bits[1]));
                    }
                }                
            }

            reader.Close();

            Application.Run(new Form1());
        }
    }
}