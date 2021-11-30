using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoReminder
{
    [Serializable]
    public  class Task
    {

        private DateTime date; //date and time for the task
        private string description; //Task's notes
        private PriorityType priority; //priority chosen from the enum
        #region CONSTRUCTORS
        //Default Constructor
        public Task()
        {
            //set a default priority type
            priority = PriorityType.Normal;
        }
        /// <summary>
        /// A constructor with one parameter
        /// calling the constructor with four parameters, sendind the one parameter
        /// that comes from the caller (taskDate) and three default value.
        /// The other constructor is called used keyword this
        /// </summary>
        /// <param name="taskDate">Input coming as a parameter from the caller</param>
        public Task(DateTime taskDate) : this(taskDate, string.Empty, PriorityType.Normal)
        {

        }
        public Task(DateTime taskDate, string description, PriorityType priority)
        {
            this.date = taskDate;
            this.description = description;
            this.priority = priority;
        }
        #endregion
        #region PROPERTIES
        public DateTime DateAndTime
        {
            get { return date; }
            set { date = value; }
        }
        //property connectected to the field description
        public string Description
        {
            get { return description; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    description = value;
            }
        }
        public PriorityType Priority
        {
            get { return priority; }
            set { priority = value; }
        }
        public DateTime TaskDate
        {
            get { return date; }
            set => date = value;
        }
        #endregion
        #region OTHERMETHODS
        public string GetPriorityString()
        {
            string txtout = Enum.GetName(typeof(PriorityType), priority);
            txtout = txtout.Replace("_", " ");
            return txtout;

        }
        public string GetTimeString()
        {
            string time = string.Format("{0}:{1}", date.Hour.ToString("0.0"), date.Minute.ToString("0.0"));

            return time;
        }
        public override string ToString()
        {
            string txtout = String.Format("{0, -20} {1, 10} {2, -16} {3, -20}", date.ToLongDateString(), GetTimeString(), GetPriorityString(), Description);

            return txtout;
        }
        #endregion

    }
}
