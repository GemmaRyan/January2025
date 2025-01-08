using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    class Ticket : Event
    {
        #region properties      //ticket properties

        public string Name { get; set; }
        public decimal Price { get; set; }
        public int AvailableTickets { get; set; }
        #endregion properities

        public Ticket(string name , decimal price, int availableTickets)        //ticket contructors
        {
            Name = name;
            Price = price;
            AvailableTickets = availableTickets;

        }
        public Ticket() { }





    }
    class VIPTicket : Ticket  //linking the VIP class to the ticket class reach the name , price and available ticket properities
    {
        #region VIPproperities      //all VIP properties specified

        public string AdditionalExtras { get; set; }
        public decimal AdditionalCost { get; set; }
        #endregion VIPproperities


        public VIPTicket( string name , decimal price ,  decimal additionalCost, string additionalExtras, int availableTickets)
        {
            Name = name;
            Price= price;
            AdditionalExtras = additionalExtras;
            AdditionalCost = additionalCost;
            AvailableTickets = availableTickets;
        }

        public VIPTicket()
        {

        }
        
        






    }
}
