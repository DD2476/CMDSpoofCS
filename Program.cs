//README - DO NOT EDIT AT ANY POINT

//Thanks for downloading my project!
//Made by the doggo lmao.

//For a little tutorial on how to add commands, go to line 73.
//This work is licensed under a Creative Commons Attribution-NonCommercial-NoDerivatives 4.0 International License.
//Removing the credits or hiding them is strictly prohibited.
//The project requires the [Properties.Settings.Default] so please don't delete them. If you want to paste the code, create the settings or remove the code that uses them (not recommended).
//It also requires [using System;] and [using static System.Console;], so if you want to remove the uses, make sure to keep these two.
//If you suspect you have an unofficial version, you may download the official one here: https://dd2476ste1.7m.pl/projects/CMDSpoof/
//The GitHub repo for this is here: https://github.com/DD2476/CMDSpoofCS/

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
                //TUTORIAL COMMANDS
            } else if (inp == "example1") { //1 - If the input equals to a string
                WriteLine("Example command. (1)");
                WriteLine("");
            } else if (inp.StartsWith("example2")) { //2 - If the input starts with a string
                WriteLine("Example command. (2)");
                WriteLine("");
            } else if (inp.EndsWith("example3")) { //3 - If the input ends with a string
                WriteLine("Example command. (3)");
                WriteLine("");
            } else if (inp.Contains("example4")) { //4 - If the input contains a string
                WriteLine("Example command. (4)");
                WriteLine("");
                //END TUTORIAL COMMANDS
            } else {
                WriteLine("'" + inp + "' is not recognized as an internal or external command,\noperable program or batch file.");
                WriteLine("");
            }
            CIN();
        }
    }
}