using System;
using System.Text;

namespace Library{

    public class Person
    {
        public Boolean isValid {get; set;}
        public string name{get; set;}
        public string id {get; set;}
        public string phoneNumber{get; set;}

        public Person(string Name, string Id, string PhoneNumber)
        {
            this.isValid = true;
            this.name = Name;
            this.id = Id;
            this.phoneNumber = PhoneNumber;

        }

        public string CheckValid()
        {
            StringBuilder stringBuilder = new StringBuilder();
            if (string.IsNullOrEmpty(this.name))
            {
                stringBuilder.Append("Unable to schedule appointment, 'name' is required\n");
                this.isValid = false;
            }

            if (string.IsNullOrEmpty(this.id))
            {
                stringBuilder.Append("Unable to schedule appointment, 'id' is required\n");
                this.isValid = false;
            }

            if (string.IsNullOrEmpty(this.phoneNumber))
            {
                stringBuilder.Append("Unable to schedule appointment, 'phone number' is required\n");
                this.isValid = false;
            }

            return stringBuilder.ToString();
        }

        
    }
}


// No cumple con el criterio SRP, ya que la clase CreateAppointment tienes más de una responsabilidad. 
// ÉStas son: validar los datos de la persona, validar los datos del lugar, de la fecha y nombre del doctor.
// También tiene la responsabilidad de crear la cita. 
// Por lo tanto, se tiene que conoce muchos datos de la persona y del appointment, los cuales no los necesita para poder imprimir una cita. 
// En conclusión, se crean tres clases: una que conoce los datos de la persona, otra la cual conoce los datos del appointment, y la última imprime la cita.