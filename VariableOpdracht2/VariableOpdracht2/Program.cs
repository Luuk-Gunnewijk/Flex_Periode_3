using System;

namespace VariableOpdracht2
{
    internal class Program
    {
        //class variables & gebruik
        static void Main(string[] args)
        {

            //ga naar de file TwitchStream.cs in je solution explorer in visual studio
            TwitchStream twitchStream = new TwitchStream();

            twitchStream.naam = "Jake ";
            twitchStream.laasteNaam = "Flow ";
            twitchStream.game = "Gta 5 ";
            twitchStream.follwers = 3459;
            twitchStream.automod = true;
            //geef nu de stream de volgende waardes:
            //name, waarde: je favoriete streamer
            //lastStreamName, waarde: de streamname van de laatste keer
            //streamGame, waarde een nieuwe instance van Game (new Game("naam van de game hier"})
            //followers, waarde: hoeveel followers
            //automod, waarde: staat automod aan?


            Console.WriteLine(twitchStream.naam + twitchStream.laasteNaam + twitchStream.game + twitchStream.follwers + " " + twitchStream.automod);
        }
    }
}