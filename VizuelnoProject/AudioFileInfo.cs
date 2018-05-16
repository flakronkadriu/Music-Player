using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VizuelnoProject
{
    class AudioFileInfo
    {

        public string filePath { get; set; }
        public string fileName { get; set; }
        public TimeSpan fileDuration { get; set; }

        public override string ToString()
        {
            return String.Format("{0} - {1}:{2:00} ", fileName, fileDuration.Minutes, fileDuration.Seconds);
        }



    }
}
