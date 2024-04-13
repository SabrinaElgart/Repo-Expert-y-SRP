using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Steven Jhonson", "986782342", "5555-555-555"); 
            Person person2 = new Person("Ralf Manson", "", "5555-555-555");
            Appointment appointment1 = new Appointment(DateTime.Now, "Wall Street", "Armand", person1);
            Appointment appointment2 = new Appointment(DateTime.Now, "Queen Street", "", person2);
            string appoinmenttext1 = CreateAppointment.AppointmentService(appointment1);
            string appoinmenttext2 = CreateAppointment.AppointmentService(appointment2);
           
            Console.WriteLine(appoinmenttext1);
            Console.WriteLine(appoinmenttext2);
        }
    }
}
