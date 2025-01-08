using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    public enum TypeOfEvent { Music, Comedy, Theatre }      //defined enum 
    public class Event : IComparable<EventDate>  //comparing to the time and date of each event     
    {
        #region properties      //all properties marked in the region

        private List<Ticket> Tickets;   //private ticket list 

        public string Name { get; set; }
        public DateTime EventDate { get; set; }
        public TypeOfEvent EventType { get; set; }

        #endregion properties   

        #region contructors
        public Event(string name, DateTime eventDate, TypeOfEvent eventType)
        {
            Name = name;
            EventDate = eventDate;
            EventType = eventType;
        }
        public Event() { }

        #endregion constructors
        private void CompareTo()
        {

        }       // suppose to be used to compare the time and date of each event


        public override string ToString()
        {
            return $"{Name} - {EventDate}";
        }       //creating a tosrting method to display in the list

    }
}
