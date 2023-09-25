using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    public class Task
    {
        private DateTime date;
        private string description;
        private PriorityTypes priority;

        public Task()
        {
            //sets the priority to Normal by default
            priority = PriorityTypes.Normal;
        }

        public Task(DateTime taskDate) : this(taskDate, string.Empty, PriorityTypes.Normal)
        {
            // this calls the constructor below and passes the things needed
        }
        public Task(DateTime taskDate, string description, PriorityTypes priority)
        {
            this.date = taskDate;
            this.description = description;
            this.priority = priority;
        }
        #region Getter and setter
        public DateTime DateAndTime
        {
            get { return date; }
            set { date = value; }
        }

        public DateTime TaskDate
        {
            get { return date; }
            set
            {
                date = value;
            }
        }
        public string Description
        {
            get { return description; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    description = value;
                }
            }
        }
        public PriorityTypes Priority
        {
            get { return priority; }
            set { priority = value; }
        }
        #endregion

        private string GetTime()
        {
            //formats the time of a date
            string time = string.Format("{0}:{1}", date.Hour.ToString("00"), date.Minute.ToString("00"));
            return time;
        }
        /// <summary>
        /// this removes the underline character from the priority level
        /// </summary>
        /// <returns>priority level without underline/underscore </returns>
        public string PriorityToString()
        {
            string textOut = Enum.GetName(typeof(PriorityTypes), priority);
            textOut = textOut.Replace("_", " ");
            return textOut;
        }
        /// <summary>
        /// formats the date time and description to be displayed in GUI
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string textOut = $"{date.ToLongDateString(),-25} {GetTime(),12} {" ",6} {PriorityToString(),-16} {description,-20}";
            return textOut;

        }
    }
}
