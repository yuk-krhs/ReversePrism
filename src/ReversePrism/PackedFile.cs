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

        public unsafe static PackedFile FromEncryptedFile(string file, long label, long encrypt)
        {
            var input   = File.ReadAllBytes(file);
            var output  = new byte[input.Length];
            var key     = CatalogDB.CalcKey(input.Length, label, encrypt);

            using(var aes= new AesCtr())
            {
                fixed(byte* pIn = &input[0])
                fixed(byte* pOut= &output[0])
                fixed(byte* pKey= &key[0])
                {
                    aes.SetKey(pKey + 0, 128);
                    aes.Transform(pIn, pOut, input.Length, pKey + 4);
                }
            }

            using(var lz4= new Lz4Decompressor())
            {
                output = lz4.Decompress(output);
            }

            return new PackedFile(file, output);
        }
    }
}
