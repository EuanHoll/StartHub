using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
            if (!File.Exists(loc)){
                File.Create(loc).Close();
                return false;
            }
            return true;
        }
        
        public static void removeLine(string name, string exeLoc, string imgLoc)
        {
            if(checkFile() == false)
            {
                throw new Exception("File Not Found");
            }

            string line = "{" + name + "," + exeLoc + "," + imgLoc + "}";

            string[] lines = File.ReadAllLines(loc);

            if (lines.Contains(line)) {

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

            foreach(string line in lines)
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
            if(fileModified == true)
            {
                timeBool = true;
                fileModified = false;
            }
            bool fileCountBool = File.ReadAllLines(loc).Length != lineCount;
            bool filei = fileNum != fileInt;
            if(filei == true)
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
            if(text == null)
            {
                return null;
            }

            string number = Regex.Replace(text.Split(':')[1], " ", "");

            foreach(ProgramContainer pro in programs)
            {
                if(pro.programId == Int32.Parse(number))
                {
                    return pro;
                }
            }

            return null;
        }

    }
}
