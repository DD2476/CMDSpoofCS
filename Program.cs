using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMDSpoofcs
{
    class Program
    {
        static void Main()
        {
            Title = "C:\\Windows\\System32\\cmd.exe";
            WriteLine("Microsoft Windows [Build " + Environment.Version.Build + "]");
            WriteLine("(c) Microsoft Corporation. All rights reserved.");
            WriteLine("");
            CIN();
        }
        static void CIN()
        {
            string inp;
            Write("C:\\Windows\\System32>");
            inp = ReadLine().ToLower();
            if (inp.Replace(" ", "") == "") {
            } else if (inp.StartsWith("help")) {
                ForegroundColor = ConsoleColor.Yellow;
                WriteLine("CMD Spoof. Made by DoggoBytes.");
                WriteLine("Source code available here: https://github.com/DD2476/CMDSpoofCS/");
                WriteLine("Project website: https://dd2476ste1.7m.pl/projects/CMDSpoof/");
                WriteLine("There are no 'default' commands. You will have to create your own inside the source code.");
                WriteLine("");
                ForegroundColor = ConsoleColor.Red;
                WriteLine("REMOVING THE CREDITS OR HIDING THEM IS STRICTLY PROHIBITED!");
                WriteLine("");
                WriteLine("This work is licensed under a Creative Commons Attribution-NonCommercial-NoDerivatives 4.0 International License.");
                WriteLine("╔═══════════════╗");
                WriteLine("║ (CC) BY-NC-ND ║");
                WriteLine("╚═══════════════╝");
                ForegroundColor = ConsoleColor.White;
                WriteLine("");
            } else if (inp.StartsWith("find")) {
                if (Properties.Settings.Default.findItems.Contains(inp.Substring(5, inp.Length - 5))) {
                    WriteLine("Item found.");
                } else {
                    WriteLine("Couldn't find the item specified.");
                }
                //WriteLine(input.Substring(5, (input.Length - 5)))
                WriteLine("");
            } else if (inp.StartsWith("t")) {
                if (Properties.Settings.Default.triggers.Contains(inp.Substring(2, inp.Length - 2))) {
                    WriteLine(Properties.Settings.Default.responses[Properties.Settings.Default.triggers.IndexOf(inp.Substring(2, inp.Length - 2))]);
                } else {
                    WriteLine("Invalid trigger.");
                }
                WriteLine("");
            } else if (inp == "clear") {
                Clear();
                Main();
            } else {
                WriteLine("'" + inp + "' is not recognized as an internal or external command,\noperable program or batch file.");
                WriteLine("");
            }
            CIN();
        }
    }
}
