using System;
using System.IO;
using School.Pages;
using School.dbHelper;


namespace School
{

    class Logger
    {
        string filePath = @"log.txt";
        //string username = /*CurrentUserHelper.Get().curName;*/

        Login lgin = new Login();

        public void WriteSignup(string value)
        {
            File.AppendAllText(filePath, value + "this file was created at --->" + DateTime.Now.ToString() + Environment.NewLine);
        }

        public void WriteLogin(string value)
        {

            File.AppendAllText(filePath, "\"" + value + "\"" + "user logged in system at " + DateTime.Now.ToString() + Environment.NewLine);
        }
        public void WriteLogger()
        {
            File.AppendAllText(filePath, CurrentUserHelper.Get().curName+ " user enterd log.txt  " + DateTime.Now.ToString() + Environment.NewLine);
        }
        public void WriteExit()
        {
            File.AppendAllText(filePath, CurrentUserHelper.Get().curName + " user Closed Programm " + DateTime.Now.ToString() + Environment.NewLine + Environment.NewLine);
        }
        public void WriteProfile()
        {
            File.AppendAllText(filePath, CurrentUserHelper.Get().curName + " user entered profile " + DateTime.Now.ToString() + Environment.NewLine);
        }
        public void WriteClasses()
        {
            File.AppendAllText(filePath, CurrentUserHelper.Get().curName + " user entered Classes " + DateTime.Now.ToString() + Environment.NewLine);
        }

        public void WriteEnterSheadule(int value)
        {
            File.AppendAllText(filePath, CurrentUserHelper.Get().curName + " user entered " + value + " Classes " + DateTime.Now.ToString() + Environment.NewLine);
        }


    }
}
