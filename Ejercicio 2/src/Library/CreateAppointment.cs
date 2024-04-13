using System;
using System.Text;

namespace Library
{
    public class CreateAppointment
    {
        public static string AppointmentService(Appointment appointment)
        {
            StringBuilder stringBuilder = new StringBuilder("Scheduling appointment...\n");
            stringBuilder.Append(appointment.CheckAppointment());
            
            if (appointment.isValid)
            {
                stringBuilder.Append("Appointment scheduled.");
            }

            return stringBuilder.ToString();
        }
    }

}