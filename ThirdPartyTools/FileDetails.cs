using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdPartyTools
{
    public class FileDetails
    {
        private readonly Random _version = new Random();
        private readonly Random _size = new Random();

        public int Version(string str)
        {
            return _version.Next();
        }

        public int Size(string str)
        {
            return _size.Next();
        }
    }
}
