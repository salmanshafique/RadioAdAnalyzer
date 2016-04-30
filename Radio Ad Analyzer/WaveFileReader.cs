using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Radio_Ad_Analyzer
{
    class WaveFileReader
    {
        private string inPath;

        public WaveFileReader(string inPath)
        {
            // TODO: Complete member initialization
            this.inPath = inPath;
        }

        public int Length { get; set; }

        internal int Read(byte[] buffer, int p, int bytesToRead)
        {
            throw new NotImplementedException();
        }

        public int Position { get; set; }
    }
}
