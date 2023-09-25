using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    internal class FileManager
    {
        private const string fileVersionToken = "PR_22";
        private const double fileVersionNr = 1.0;

        /// <summary>
        /// this method saves all the items in the list to a text file in the app folder
        /// </summary>
        /// <param name="taskList"></param>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public bool SaveTaskToFile(List<Task> taskList, string fileName)
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
                    writer.WriteLine(taskList[i].TaskDate.Month);
                    writer.WriteLine(taskList[i].TaskDate.Day);
                    writer.WriteLine(taskList[i].TaskDate.Hour);
                    writer.WriteLine(taskList[i].TaskDate.Minute);
                    writer.WriteLine(taskList[i].TaskDate.Second);
                }
            }
            catch
            {
                ok = false;
            }
            finally
            {
                if(writer != null)
                {
                    writer.Close();
                }
            }
            return ok;
        }
        /// <summary>
        /// reads saved task from a file
        /// note that the version token and version number must be the same for this to work
        /// </summary>
        /// <param name="taskList"></param>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public bool ReadTaskFromFile(List<Task> taskList, string fileName)
        {
            bool ok = true;
            StreamReader reader = null;

            try
            {
                if(taskList != null)
                {
                    taskList.Clear();
                } else
                {
                    taskList = new List<Task>();
                }
                reader = new StreamReader(fileName);
                string versionTest = reader.ReadLine();
                double version = double.Parse(reader.ReadLine());
                if((versionTest == fileVersionToken) && (version == fileVersionNr))
                {
                    int count = int.Parse(reader.ReadLine());
                    for(int i = 0; i < count; i++)
                    {
                        Task task = new Task();
                        task.Description = reader.ReadLine();
                        task.Priority = (PriorityTypes)Enum.Parse(typeof(PriorityTypes), reader.ReadLine());
                        int year = 0, month = 0, day = 0;
                        int hour = 0, minute= 0 , second = 0;

                        year = int.Parse((reader.ReadLine()));
                        month = int.Parse((reader.ReadLine()));
                        day = int.Parse((reader.ReadLine()));
                        hour = int.Parse((reader.ReadLine()));
                        minute = int.Parse((reader.ReadLine()));
                        second = int.Parse((reader.ReadLine()));

                        task.TaskDate = new DateTime(year, month, day, hour, minute, second);

                        taskList.Add(task);

                    }
                }
                else { ok = false; }
            }
            catch
            {
                ok = false;
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
            }
            return ok;
        }
    }
}
