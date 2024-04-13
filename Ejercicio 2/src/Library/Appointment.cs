using System;
using System.Text;

namespace Library
{
    public class Appointment
    {
        public Boolean isValid {get; set;}
        public DateTime date {get; set;}
        public string appointmentPlace{get; set;}
        public string doctorName {get; set;}
        public Person person {get; set;}

        public Appointment(DateTime Date, string AppointmentPlace, string DoctorName, Person person)
        {
            this.isValid = true;
            this.appointmentPlace = AppointmentPlace;
            this.doctorName = DoctorName;
            this.date = Date;
            this.person = person;

        }

        public string CheckAppointment()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(this.person.CheckValid());

            if (! person.isValid)
            {
                this.isValid = false; 
            }

            if (string.IsNullOrEmpty(this.appointmentPlace))
            {
                stringBuilder.Append("Unable to schedule appointment, 'appointment place' is required\n");
                this.isValid = false;
            }


            if (string.IsNullOrEmpty(this.doctorName))
            {
                stringBuilder.Append("Unable to schedule appointment, 'doctor name' is required\n");
                this.isValid = false;
            }

            return stringBuilder.ToString();
        }
    }


}