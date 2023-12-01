/*Instancie manualmente os objetos mostrados abaixo e mostre-os na tela do
terminal, conforme exemplo.
-> Traveling to New Zealand
12 Likes - 21/06/2018 13:05:44
I'm going to visit this wonderful country!
Comments:
Have a nice trip
Wow that's awesome!

Good night guys
5 Likes - 28/07/2018 23:14:19
See you tomorrow
Comments:
Good night
May the Force be with you 
 */

/*
using ProfNelioAlves.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ProfNelioAlves
{
    internal class Program21ExercStringBuilder
    {
        public static void Main(string[] args) 
        {

            //Instanciando os Comment 
            Comment comment01 = new Comment("Have a nice trip!");
            Comment comment02 = new Comment("Wow that's awesome!");

            //Instanciando os Post's
            Post post01 = new Post(
                    DateTime.Parse("21/06/2018 13:05:44"),
                    "Traveling to new zealand",
                    "Im going to visit this wonderful country",
                    12
                );
            //Adcionando o comentario ao post
            post01.addComment( comment01);
            post01.addComment( comment02 );

            //-----------------------------------------------------------------


            Comment comment03 = new Comment("Good night");
            Comment comment04 = new Comment("May the force be with you");

            Post post02 = new Post(
                    DateTime.Parse("28/07/2018 23:14:19"),
                    "Good night guys",
                    "See you tomorrow",
                    5
                );

            post02.addComment( comment03 );
            post02.addComment( comment04 );

            Console.WriteLine(post01);
            Console.Write("------------------------------------");
            Console.WriteLine(post02);

        }
    }
}



*/