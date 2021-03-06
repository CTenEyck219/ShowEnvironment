﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowEnvironmentDetails
{
    class Program
    {
        static int Main(string[] args)
        {

            foreach(string arg in args)
            {
                Console.WriteLine("Arg: {0}", arg);
            }

            Console.WriteLine();
            Console.WriteLine();


            //Helper method within the Program Class.
            ShowEnvironmentDetail();

            Console.ReadLine();

            return -1;
        }

        static void ShowEnvironmentDetail()
        {
            //Print out Drives on this machine
            //Along with other interesting details
            foreach(string drive in Environment.GetLogicalDrives())
            {
                Console.WriteLine("Drives: {0}", drive);
            }

            //OS Version
            Console.WriteLine("OS: {0}", Environment.OSVersion);
            
            // Processers for this computer
            Console.WriteLine("Number of Processers: {0}", Environment.ProcessorCount);
            
            //Version of .NET running on this machine
            Console.WriteLine(".NET Version: {0}", Environment.Version);
            
            //Checking if the current OS is 64-bit
            Console.WriteLine("This maching is running 64-bit Windows: {0}", Environment.Is64BitOperatingSystem);
            
            //Checking if the Current Process is 64-bit
            Console.WriteLine("This machine has a 64-bit Process : {0}", Environment.Is64BitProcess);
            
            //Name of the Machine Currently running this Console App
            Console.WriteLine("This Computer's name is: {0}", Environment.MachineName);

            //Returning the full path to the system directory
            Console.WriteLine("Path to system directory: {0}", Environment.SystemDirectory);

            //Retuning the name of the user who started this application
            Console.WriteLine("Your Username is: {0}", Environment.UserName);

            //Retuning the name of the user who started this application Domain
            Console.WriteLine("Your Domain Name is: {0}", Environment.UserDomainName);

        }
    }
}