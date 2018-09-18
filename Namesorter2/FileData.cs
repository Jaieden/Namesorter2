using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Namesorter2
{
    class FileData
    {
        public FileData(string filepath)
        {
            Filepath = filepath;
        }

        public string Filepath { get; set; }
        public string[] FileContents
        {
            get
            {
                return File.ReadAllLines(Filepath);
            }
            set
            {
                File.WriteAllLines(Filepath, value);
            }
        }

    }
}
