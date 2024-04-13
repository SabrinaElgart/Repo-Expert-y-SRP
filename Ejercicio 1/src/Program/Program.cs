using System;

namespace Ucu.Poo.Expert
{

    class Program
    {
        static void Main()
        {
            NewBook book1 = new NewBook("Design Patterns","Erich Gamma & Others","001-034");
            NewBook book2 = new NewBook("Pro C#","Troelsen","001-035");
            ClassShelveBook.ShelveBook("A","7", book1);
            ClassShelveBook.ShelveBook("B","3", book2);

        }
    }
}