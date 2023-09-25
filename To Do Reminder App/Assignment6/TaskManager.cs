using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    class TaskManager
    {
        List<Task> taskList;
        
        public TaskManager()
        {
            taskList = new List<Task>();
        }
        public Task GetTask(int index)
        {
            if (CheckIndex(index))
            {
                return taskList[index];
            }
            else
            {
                return null;
            }
        }
        public bool CheckIndex(int index)
        {
            bool ok = false;
            if(index >= 0 && index < taskList.Count)
            {
                ok = true;
            }
            return ok;
        }
        /// <summary>
        /// adds an object in the tasklist, the callers can choose between the 2 NewTask methods
        /// </summary>
        /// <param name="newTask"></param>
        /// <returns></returns>
        public bool AddNewTask(Task newTask)
        {
            bool ok = true;
            if(newTask != null)
            {
                taskList.Add(newTask);
            }
            else { ok = false; }
            return ok;
        }
        /// <summary>
        /// adds a new task to taskList using values sent over by caller
        /// </summary>
        /// <param name="time"></param>
        /// <param name="description"></param>
        /// <param name="priority"></param>
        /// <returns></returns>
        public bool AddNewTask(DateTime time, string description, PriorityTypes priority)
        {
            bool ok = true;
            Task newTask = new Task(time, description, priority);
            if(newTask != null)
            {
                taskList.Add(newTask);
            }
            else { ok = false; }
            return ok;
        }
        /// <summary>
        /// changes a task at a given index
        /// </summary>
        /// <param name="task"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        public bool ChangeTask(Task task, int index)
        {
            bool ok = true;
            if (task != null && CheckIndex(index))
            {
                taskList[index] = task;
            }
            else { ok = false; }
            return ok;
        }
        /// <summary>
        /// deletes a task at a given index
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public bool DeleteTask(int index)
        {
            bool ok = false;
            if (CheckIndex(index))
            {
                taskList.RemoveAt(index);
                ok = true;
            }
            return ok;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string[] InfoString()
        {
            string[] info = new string[taskList.Count];
            for(int i = 0; i < info.Length; i++)
            {
                info[i] = taskList[i].ToString();
            }
            return info;
        }
        /// <summary>
        /// uses FileManager to save data to a file in the program folder
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public bool SaveDataToFile(string fileName)
        {
            FileManager fileManager = new FileManager();
            return fileManager.SaveTaskToFile(taskList, fileName);
        }
        /// <summary>
        /// uses FileManager to read the data previously saved on a file
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public bool ReadDataFromFile(string fileName)
        {
            FileManager fileManager = new FileManager();
            return fileManager.ReadTaskFromFile(taskList, fileName);
        }
    }
}
