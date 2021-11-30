using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoReminder
{   /// <summary>
    /// A container class Handling a list of task objects
    /// uses a generic list to store tasks
    /// [Serializable]
    /// </summary>

    class TaskManager
    {
        //Declare a  List<T> object where T is the Task type
        List<Task> taskList;

        //Create  the  taskList in the Constructor
        public TaskManager()
        {
            taskList = new List<Task>();
        }
        public Task GetTask(int index)
        {
            if (CheckIndex(index))
                return taskList[index];
            else
                return null;
        }
        public bool CheckIndex(int index)
        {
            bool ok = false;
            if ((index >= 0) && (index < taskList.Count))
            {
                ok = true;
            }
            return ok;
        }
        /// <summary>
        /// Add a new object at the end of the taskList
        /// </summary>
        /// <param name="newTask">The task object that is to be added</param>
        /// <returns>true if the task is added successfully , false otherwise </returns>
        public bool AddNewTask(Task newTask)
        {
            bool success = true;
            if (newTask != null)
                taskList.Add(newTask);
            else
                success = false;
            return success;

        }
        public bool DeleteTaskAt(int index)
        {
            bool ok = false;
            if ((index >= 0) && (index < taskList.Count))
            {
                taskList.RemoveAt(index);
                ok = true;

            }
            return ok;
        }
        public bool AddNewTask(DateTime newtime, string description, PriorityType priority)
        {
            bool ok = true;
            //Create a new object with the given values above
            Task newTask = new Task(newtime, description, priority);
            if (newTask != null)
                taskList.Add(newTask);
            else
                ok = false;

            return ok;

        }
        /// <summary>
        /// change an object in the taskList in a given position with a new object
        /// </summary>
        /// <param name="task">The object to replace a the  existing at the index position</param>
        /// <param name="index">The position in the  taskList where changes take place</param>
        /// <returns> true if successful otherwise false</returns>
        public bool ChangeTaskAt(Task task, int index)
        {
            bool ok = true;
            // Check tahe the task is not null and index is not in range
            if ((task != null) && CheckIndex(index))
                taskList[index] = task;
            else
                ok = false;
            return ok;

        }
        public string[] GetInfoString()
        {
            // Creating a local array of string elements with a capacity = num
            //of elements in the taskList
            string[] infoString = new string[taskList.Count];

            for (int i = 0; i < infoString.Length; i++)
            {
                infoString[i] = taskList[i].ToString();
            }
            return infoString;
        }
        /// <summary>
        /// File manager is a class that saving and reading data
        /// ti and from a text file. Send the taskList from which
        /// data is read and saved to the file filename
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        public bool WriteDataToFile(string filename)
        {
            FileManager fileManager = new FileManager();
            return fileManager.SaveTaskListTOFile(taskList, filename);
        }
        /// <summary>
        /// send the taskList object declaired in above to whcich
        /// data from the filename is saved. As taskList is an object 
        /// it will have the changes made in the FileManager when
        /// when the method ReadTaskListFile returns
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        public bool ReadDataFromFile(string filename)
        {
            FileManager filemanager = new FileManager();

            //objects are passed by ref so taskList will be updated.
            return filemanager.ReadTaskListFromFile(taskList, filename);
        }


    }
}
