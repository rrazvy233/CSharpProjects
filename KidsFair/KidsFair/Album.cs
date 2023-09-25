using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Album
    {
        private string albumName; //name of album
        private string artistName; //artist name
        private int trackNumber; // number of tracks

        public void start()
        {
            Console.WriteLine();
            Console.WriteLine("Album");
            Console.WriteLine();
        }
        public void readAlbumData()
        {
            //read album name
            Console.WriteLine("What is the name of your favorite music album?");
            albumName = Console.ReadLine();
            //read artist name
            Console.WriteLine("Artist/Band name");
            artistName = Console.ReadLine();
            //numbers of tracks on album
            Console.WriteLine("How many tracks does the album have?");
            string trackValue = Console.ReadLine();
            trackNumber = int.Parse(trackValue);
        }
        public void displayAlbumInfo()
        {
            //display album, artist name and number of tracks
            string textOut = "+++++++++++++++++++";
            Console.WriteLine(textOut);
            Console.WriteLine(@"Album Name: " + albumName +
                " \nArtist Name: " + artistName +
                " \nNumber of tracks: " + trackNumber);
            Console.WriteLine(textOut);
        }
    }
}