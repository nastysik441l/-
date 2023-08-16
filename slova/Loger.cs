using System;
using System.IO;

namespace ConsoleApp2
{
    internal class Logs : LogsBase
    {
        private FileStream fs;
        private string v;

        public Logs(FileStream fs, string v)
        {
            this.fs = fs;
            this.v = v;
        }
    }
}