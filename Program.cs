using System;
using System.Collections.Generic;
using System.Linq;
using JsonData;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Collections to work with
            List<Artist> Artists = MusicStore.GetData().AllArtists;
            List<Group> Groups = MusicStore.GetData().AllGroups;

            //========================================================
            //Solve all of the prompts below using various LINQ queries
            //========================================================

            //There is only one artist in this collection from Mount Vernon, what is their name and age?
            // List<Artist> MountVern = Artists.Where(a => a.Hometown == "Mount Vernon").ToList();
            // System.Console.WriteLine($"Artist Name from Mount Vernon: {MountVern[0].ArtistName}; Age: {MountVern[0].Age}");

            //Who is the youngest artist in our collection of artists?
            // Artist youngest = Artists.OrderByDescending(a => a.Age).Last();
            // System.Console.WriteLine($"Youngest Artist Name: {youngest.ArtistName}; Age: {youngest.Age}");

            //Display all artists with 'William' somewhere in their real name
            // List<Artist> William = Artists.Where(a => a.RealName.Contains("William")).ToList();
            // foreach(var bill in William){
            //     System.Console.WriteLine($"Real Name: {bill.RealName}; Artist Name: {bill.ArtistName}");
            // }

            // Display all groups with names less than 8 characters in length.
            // List<Group> name = Groups.Where(g => g.GroupName.Length < 8).ToList();
            // System.Console.WriteLine(name.Count);
            // foreach (var group in name){
            //     System.Console.WriteLine($"Group Name: {group.GroupName}");
            // }

            //Display the 3 oldest artist from Atlanta
            // List<Artist> FromAtlanta = Artists.Where(a => a.Hometown == "Atlanta").OrderByDescending(a => a.Age).Take(3).ToList();
            // foreach (var a in FromAtlanta){
            //     System.Console.WriteLine(a.ArtistName);
            // }

            //(Optional) Display the Group Name of all groups that have members that are not from New York City


            //(Optional) Display the artist names of all members of the group 'Wu-Tang Clan'
            Group WuTang = Groups.First(g => g.GroupName == "Wu-Tang Clan");
            foreach (var artist in WuTang.Members){
                System.Console.WriteLine($"Name: {artist.ArtistName}");
            }


	        // Console.WriteLine(Groups.Count);
        }
    }
}
