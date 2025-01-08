using System.Diagnostics;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Q1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 




    //Gemma Ryan 
    //Date: 08/01/2025
    // GitHub Link: 
    public partial class MainWindow : Window            
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private List<Event> events = new List<Event>();    //Add all events 
        private void Objects()      //Initializing all the objects specified in the Main Window to allow us to display on screen
        {
            Event object1 = new Event() { Name = "Oasis Croke Park", EventDate = new DateTime(2025, 06, 20), TypeOfEvent = EventType.Music };       //Dont know how to fix enum error 
            Event object2 = new Event() { Name = "electric Picnic", EventDate = new DateTime(2025, 08, 20), TypeOfEvent = EventType.Music };

            Ticket ticket1 = new Ticket() { Name = "Early Bird", Price = 100m, AvailableTickets = 100 };
            Ticket ticket2 = new Ticket() { Name = "Platinium", Price = 150m, AvailableTickets = 100 };

            VIPTicket vipTicket1 = new VIPTicket() { Name = "Ticket and Hotel Package", Price = 150m, AdditionalCost = 100m, AdditionalExtras = "4* hotel" , AvailableTickets = 100 };
            VIPTicket vipTicket2 = new VIPTicket() { Name = "Weekend Ticket", Price = 200m, AdditionalCost = 100m, AdditionalExtras = "with camping", AvailableTickets = 100 };

            events.Add(object1);
            events.Add(object2);    //Adding thwm all to a list to display in the list box
            events.Add(ticket1);
            events.Add(ticket2);
            events.Add(vipTicket1);
            events.Add(vipTicket2);

            lbEvents.ItemsSource = events;
        }
        private void UpdateListBox()
        {
            lbEvents.ItemsSource = null;        //removing all text currently in the box
            lbTickets.ItemsSource = null;




        }
    }
}