using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{

    class MainProgram
    {
        static void Main(string[] args)
        {
            //Create object of the Pet class
            Pet petObj = new Pet();
            //Use object pet
            petObj.start();
            petObj.readAndSavePetData();
            petObj.displayPetInfo();

            Console.WriteLine("Press Enter to start next object!");
            Console.ReadLine();

            //use object album
            Album albumObj = new Album();
            albumObj.start();
            albumObj.readAlbumData();
            albumObj.displayAlbumInfo();

            Console.WriteLine("Press Enter to start next object");
            Console.ReadLine();

            //use object ticket
            Ticket ticketObj = new Ticket();
            ticketObj.start();

            Console.WriteLine("End of program");
            Console.WriteLine();
        }
    }
}