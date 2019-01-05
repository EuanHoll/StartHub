using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StartHub.Utils
{
    class UtilMethods
    {

        private static bool fileModified = false;
        private static int fileInt = -1;
        private static Random random = new Random();
        private static string loc = AppDomain.CurrentDomain.BaseDirectory + "/programs.startHub";

        public static void addToFile(string name, string exeLoc, string imgLoc)
        {
            fileModified = true;
            fileInt = random.Next(0, 1234567890);
            string line = "{" + name + "," + exeLoc + "," + imgLoc + "}";

            File.AppendAllText(loc, line + Environment.NewLine);
        }

        public static bool checkFile()
        {
            fileModified = true;
            fileInt = random.Next(0, 1234567890);
            if (!File.Exists(loc))
            {
                File.Create(loc).Close();
                return false;
            }
            return true;
        }

        public static void removeLine(string name, string exeLoc, string imgLoc)
        {
            if (checkFile() == false)
            {
                throw new Exception("File Not Found");
            }

            string line = "{" + name + "," + exeLoc + "," + imgLoc + "}";

            string[] lines = File.ReadAllLines(loc);

            if (lines.Contains(line))
            {

                string[] newLines = new string[lines.Length - 1];
                int i = 0;

                foreach (string ln in lines)
                {
                    if (ln != line)
                    {
                        newLines[i] = ln;
                        i++;
                    }
                }

                File.WriteAllLines(loc, newLines);

            }
            else
            {
                Console.WriteLine(name + exeLoc + imgLoc);
                throw new Exception("Line Not Found");
            }

        }

        public static List<ProgramContainer> getProgramList()
        {
            List<ProgramContainer> pList = new List<ProgramContainer>();

            string[] lines = File.ReadAllLines(loc);

            foreach (string line in lines)
            {
                string ln = Regex.Replace(line, "{", "");
                ln = Regex.Replace(ln, "}", "");
                string[] lnSplit = ln.Split(',');
                pList.Add(new ProgramContainer(lnSplit[0], lnSplit[1], lnSplit[2]));
            }

            return pList;
        }

        public static bool hasFileBeenUpdated(int lineCount, int fileNum)
        {
            bool timeBool = false;
            if (fileModified == true)
            {
                timeBool = true;
                fileModified = false;
            }
            bool fileCountBool = File.ReadAllLines(loc).Length != lineCount;
            bool filei = fileNum != fileInt;
            if (filei == true)
            {
                fileNum = fileInt;
            }

            return timeBool || fileCountBool;
        }

        public static int getFileInt()
        {
            return fileInt;
        }

        public static int getLineCount()
        {
            return File.ReadAllLines(loc).Length;
        }

        public static ProgramContainer stringToPC(string text, List<ProgramContainer> programs)
        {
            if (text == null)
            {
                return null;
            }

            string number = Regex.Replace(text.Split(':')[1], " ", "");

            foreach (ProgramContainer pro in programs)
            {
                if (pro.programId == Int32.Parse(number))
                {
                    return pro;
                }
            }

            return null;
        }

        public static string FirstLetterToUpperCaseOrConvertNullToEmptyString(string s)
        {
            if (string.IsNullOrEmpty(s))
                return string.Empty;

            char[] a = s.ToCharArray();
            a[0] = char.ToUpper(a[0]);
            return new string(a);
        }

        public static FileEnum hasHighQualityIcon(string name)
        {
            name = name.ToLower();
            switch (name)
            {
                case "chrome":
                    return FileEnum.Chrome;
                case "firefox":
                    return FileEnum.Firefox;
                case "launcher":
                    return FileEnum.Opera;
                case "microsoftedge":
                    return FileEnum.Edge;
                case "iexplorer":
                    return FileEnum.InternetEx;
                case "discord":
                    return FileEnum.Discord;
                case "spotify":
                    return FileEnum.Spotify;
                case "devenv":
                    return FileEnum.VisualStudio;
                case "eclipse":
                    return FileEnum.Eclipse;
                case "steam":
                    return FileEnum.Steam;
                case "winword":
                    return FileEnum.Word;
                case "outlook":
                    return FileEnum.Outlook;
                case "excel":
                    return FileEnum.Excel;
                case "itunes":
                    return FileEnum.Itunes;
                case "audacity":
                    return FileEnum.Audacity;
                case "twitch":
                    return FileEnum.Twitch;
                default:
                    return FileEnum.None;
            }

        }

        public static string getFileName(string exeLoc)
        {
            string exe = exeLoc.ToLower().Split('\\')[exeLoc.Split('\\').Length - 1];
            exe = Regex.Replace(exe, ".exe", "");
            exe = Regex.Replace(exe, ".jar", "");
            exe = Regex.Replace(exe, ".bat", "");
            return exe;
        }

        public static string getNameFromFileEnum(FileEnum fileEnum)
        {
            switch (fileEnum)
            {
                case FileEnum.Chrome:
                    return "Google Chrome";
                case FileEnum.Firefox:
                    return "Mozilla Firefox";
                case FileEnum.Opera:
                    return "Opera Launcher";
                case FileEnum.Edge:
                    return "Microsoft Edge";
                case FileEnum.InternetEx:
                    return "Internet Explorer";
                case FileEnum.Discord:
                    return "Discord";
                case FileEnum.Spotify:
                    return "Spotify";
                case FileEnum.VisualStudio:
                    return "Microsoft Visual Studio";
                case FileEnum.Eclipse:
                    return "Eclipse IDE";
                case FileEnum.Steam:
                    return "Steam";
                case FileEnum.Word:
                    return "Microsoft Office Word";
                case FileEnum.Outlook:
                    return "Microsoft Outlook";
                case FileEnum.Excel:
                    return "Mircosoft Office Excel";
                case FileEnum.Itunes:
                    return "Itunes";
                case FileEnum.Audacity:
                    return "Audacity";
                case FileEnum.Twitch:
                    return "Twitch";
                default:
                    return null;
            }
        }

        public static string getImageNameFromFileEnum(FileEnum fileEnum)
        {
            switch (fileEnum)
            {
                case FileEnum.Chrome:
                    return "chrome";
                case FileEnum.Firefox:
                    return "firefox";
                case FileEnum.Opera:
                    return "opera";
                case FileEnum.Edge:
                    return "edge";
                case FileEnum.InternetEx:
                    return "internetexplorer";
                case FileEnum.Discord:
                    return "discord";
                case FileEnum.Spotify:
                    return "spotify";
                case FileEnum.VisualStudio:
                    return "visualstudio";
                case FileEnum.Eclipse:
                    return "eclipse";
                case FileEnum.Steam:
                    return "steam";
                case FileEnum.Word:
                    return "word";
                case FileEnum.Outlook:
                    return "outlook";
                case FileEnum.Excel:
                    return "excel";
                case FileEnum.Itunes:
                    return "itunes";
                case FileEnum.Audacity:
                    return "audacity";
                case FileEnum.Twitch:
                    return "twitch";
                default:
                    return null;
            }
        }

        public static Bitmap getBitMapFromResource(string resourceName)
        {

            string name = resourceName.Split(':')[1];
            switch (name)
            {
                case "chrome":
                    return Resources.chrome;
                case "firefox":
                    return Resources.firefox;
                case "launcher":
                    return Resources.opera;
                case "microsoftedge":
                    return Resources.edge;
                case "iexplorer":
                    return Resources.internetexplorer;
                case "discord":
                    return Resources.discord;
                case "spotify":
                    return Resources.spotify;
                case "devenv":
                    return Resources.visualstudio;
                case "eclipse":
                    return Resources.eclipse;
                case "steam":
                    return Resources.steam;
                case "winword":
                    return Resources.word;
                case "outlook":
                    return Resources.outlook;
                case "excel":
                    return Resources.excel;
                case "itunes":
                    return Resources.itunes;
                case "audacity":
                    return Resources.audacity;
                case "twitch":
                    return Resources.twitch;
                default:
                    Console.WriteLine("Could not find resource : " + resourceName);
                    return null;
            }
        }

    }

    public enum FileEnum
    {
        Firefox,
        Chrome,
        Opera,
        Edge,
        InternetEx,
        Discord,
        Spotify,
        VisualStudio,
        Eclipse,
        Steam,
        Word,
        Outlook,
        Excel,
        Audacity,
        Twitch,
        Itunes,
        None
    }

}
