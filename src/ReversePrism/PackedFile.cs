using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism
{
    public class PackedFile
    {
        public string                   FileName                { get; set; }
        public byte[]                   Data                    { get; set; }

        public PackedFile(string file, byte[] data)
        {
            FileName= file;
            Data    = data;
        }

        public unsafe static PackedFile FromEncryptedFile(string path, ulong label, ulong encrypt)
        {
            var indata  = File.ReadAllBytes(path);
            var outdata = new byte[indata.Length];
            var key     = CatalogDB.CalcKey((ulong)indata.Length, label, encrypt);

            using(var aes= new AesCtr())
            {
                fixed(byte* pIn = &indata[0])
                fixed(byte* pOut= &outdata[0])
                fixed(byte* pKey= &key[0])
                {
                    aes.SetKey(pKey+0, 128);
                    aes.Transform(pIn, pOut, indata.Length, pKey + 4);
                }
            }

            using(var lz4= new Lz4Decompressor())
            {
                outdata = lz4.Decompress(outdata);
            }

            return new PackedFile(path, outdata);
        }
    }
}
