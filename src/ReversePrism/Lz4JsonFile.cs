using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism
{
    public class Lz4JsonFile : Lz4File
    {
        public string                   Json                    => Encoding.UTF8.GetString(Data);

        public Lz4JsonFile(string file, byte[] data)
            : base(file, data)
        {
        }

        public new static Lz4JsonFile FromFile(string file)
            => new Lz4JsonFile(file, LoadDataFromFile(file));
    }
}
