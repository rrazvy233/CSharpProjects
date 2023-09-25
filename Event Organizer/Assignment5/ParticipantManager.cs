using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    internal class ParticipantManager
    {
        private List<Participants> participants;
        public ParticipantManager()
        {
            participants = new List<Participants>();
            
        }

        public Participants GetParticipant(int index)
        {
            // gets participant at index
            if (index < 0 || index >= participants.Count)
            {
                return null;
            }
            return participants[index];
        }
        public int Count
        {
            get { return participants.Count; }
        }
        public bool AddParticipant(string firstName, string lastName, Address addressIn)
        {
            //adds a participant using the data sent from GUI
            Participants Participants = new Participants(firstName, lastName, addressIn);
            participants.Add(Participants);
            return true;
        }
        public bool AddParticipant(Participants ParticipantIn)
        {
            
            if (ParticipantIn == null)
            {
                return false;
            }
            participants.Add(ParticipantIn);
            return true;
        }
        public bool ChangeAt(Participants ParticipantsIn, int index)
        {
            
            bool ok = true;
            if ((ParticipantsIn != null) && (CheckIndex(index)))
            {
                participants[index] = ParticipantsIn;
            } else
            {
                ok = false;
            }
            return ok;
        }
        public bool CheckIndex(int index)
        {
            return ((index >= 0) && (index <= participants.Count));
        }
        public bool DeleteAt(int index)
        {
            if (CheckIndex(index))
            {
                participants.RemoveAt(index);
            } else
            {
                return false;
            }
            return true;
        }


        public string[] GetParticipantsInfo()
        {
            //reads the info of the item at the selected index
            string[] participantsInfo = new string[participants.Count];
            int i = 0;
            foreach(Participants ParticipantsObj in participants)
            {
                participantsInfo[i++] = ParticipantsObj.ToString(); 
            }
            return participantsInfo;
        }
    }
}
