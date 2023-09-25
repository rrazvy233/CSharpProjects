using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    internal class EventManager
    {
        private double costPerPerson;
        private double feePerPerson;
        private string title;

        ParticipantManager participantManager = new ParticipantManager();
        public EventManager()
        {
            participantManager = new ParticipantManager();
        }
        public ParticipantManager Participants
        {
            get { return participantManager; }
        }
        #region properties
        /// <summary>
        /// gets the title of the event (used to rename GUI wiundow)
        /// gets and sets cost and fee per person
        /// </summary>
        public string Title
        {
            get { return title; }
            set {
                if (!string.IsNullOrEmpty(value))
                    title = value; }
        }
        public double CostPerPerson
        {
            get { return costPerPerson; }
            set {
                if (value >= 0.00)
                {
                    costPerPerson = value;
                }
            }
        }
        public double FeePerPerson
        {
            get { return feePerPerson; }
            set
            {
                if (value >= 0.00)
                {
                    feePerPerson = value;
                }
            }
        }
        #endregion
        #region methods
        /// <summary>
        /// calculates the cost and fee (to be displayed on the GUI)
        /// </summary>
        /// <returns></returns>
        public double CalculateCost()
        {
            return Participants.Count * costPerPerson;
        }
        public double CalculateFee()
        {
            return Participants.Count * feePerPerson;
        }
        #endregion
    }
}
