using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartHub.Utils
{
    class ProgramContainer
    {

        public string name;
        public string fileLoc;
        public string imgLoc;
        public int programId;
        public static Random random = new Random();

        public ProgramContainer(string name, string fileLoc, string imgLoc)
        {
            this.name = name;
            this.fileLoc = fileLoc;
            this.imgLoc = imgLoc;
            programId = random.Next(0, 1000000000);
        }
    }
}
