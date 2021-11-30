using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace ToDoReminder
{
    class FileManager
    {
        //Write this as the first line in the textfile as a stample
        //to mark that the file is saved by this application
        private const  string fileVersionToken = "ToDoRe_21";

        //The file version can help you to make old files compatible
        //The file version does not have to be the same as the apps version nr
        private const double fileVersionNr = 1.0;

        public bool SaveTaskListTOFile(List<Task> taskList, string fileName)
        {
            bool ok = true;
            StreamWriter writer = null;
            try
            {
                writer = new StreamWriter(fileName);
                writer.WriteLine(fileVersionToken);
                writer.WriteLine(fileVersionNr);
                writer.WriteLine(taskList.Count);

                for (int i = 0; i < taskList.Count; i++)
                {
                    writer.WriteLine(taskList[i].Description);
                    writer.WriteLine(taskList[i].Priority.ToString());
                    writer.WriteLine(taskList[i].TaskDate.Year);
                    writer.Write(taskList[i].TaskDate.Month);
                    writer.WriteLine(taskList[i].TaskDate.Day);
                    writer.WriteLine(taskList[i].TaskDate.Hour);
                    writer.WriteLine(taskList[i].TaskDate.Minute);
                    writer.WriteLine(taskList[i].TaskDate.Second);
                }
            }
            catch
            {
                //If any error occurs in the above try-block, the excution
                //will jump to this block to avoid program crash

                ok = false;
            }
            finally
            {
                //This block is always executed no matter if an occurs 
                //or not
                if (writer != null)
                    writer.Close();
            }
            return ok;
        }
        public bool ReadTaskListFromFile(List<Task> taskList, string fileName)
        {
            bool ok = true;
            StreamReader reader = null;
            try
            {
                // Clear the contents of taskList
                if (taskList != null)
                    taskList.Clear();
                else
                    taskList = new List<Task>();
                reader = new StreamReader(fileName);

                //Ensure the file is correct 
                string versionTest = reader.ReadLine();

                //Ensure that it has the correct version nr
                double version = double.Parse(reader.ReadLine());

                if ((versionTest == fileVersionToken) && (version == fileVersionNr))
                {
                    //Read the number of tasks to read
                    int count = int.Parse(reader.ReadLine());
                    for (int i = 0; i < count; i++)
                    {
                        Task task = new Task();
                        task.Description = reader.ReadLine();
                        task.Priority = (PriorityType)Enum.Parse(typeof(PriorityType), reader.ReadLine());

                        //Date time .Year,Month, etc are ready!
                        int year = 0, month = 0, day = 0;
                        int hour = 0, minute = 0, second = 0;

                        year = int.Parse(reader.ReadLine());
                        month = int.Parse(reader.ReadLine());
                        day = int.Parse(reader.ReadLine());
                        hour = int.Parse(reader.ReadLine());
                        second = int.Parse(reader.ReadLine());

                        task.TaskDate = new DateTime(year, month, day, hour, minute, second);

                        taskList.Add(task);
                    }
                }
                else
                    ok = false;

            }
            catch
            {
                ok = false;
            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }
            return ok;

        }

    }
}
