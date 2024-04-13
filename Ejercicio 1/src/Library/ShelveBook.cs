 using System;

 namespace Ucu.Poo.Expert
 {
    public class ClassShelveBook
    {
       
        public static void ShelveBook(String sector, String shelve, NewBook Book) 
             {
                 Book.LibrarySector = sector;
                 Book.LibraryShelve = shelve;
             }

    }
}



