using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism
{
    public class Lz4File
    {
        public string                   FileName                { get; set; }
        public byte[]                   Data                    { get; set; }

        public Lz4File(string file, byte[] data)
        {
            FileName= file;
            Data    = data;
        }

        public static Lz4File FromFile(string file)
            => new Lz4File(file, LoadDataFromFile(file));

        public static byte[] LoadDataFromFile(string file)
        {
            var indata  = File.ReadAllBytes(file);

            using(var lz4= new Lz4Decompressor())
                return lz4.Decompress(indata);
        }
    }
}
