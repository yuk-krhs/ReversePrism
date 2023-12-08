using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism
{
    public class Lz4Decompressor : IDisposable
    {
        private IntPtr context;
        private bool disposed;

        public Lz4Decompressor()
        {
            context = LibEmber.lz4frameutil_decompressor_create();
        }

        ~Lz4Decompressor()
        {
             Dispose(disposing: false);
        }

        public unsafe byte[] Decompress(byte[] input)
        {
            fixed(byte* pIn= &input[0])
            {
                LibEmber.lz4frameutil_decompressor_set_input(context, new IntPtr(pIn), input.Length);

                var outsize = LibEmber.lz4frameutil_decompressor_get_decompress_size(context);
                var output  = new byte[outsize];

                fixed(byte* pOut= &output[0])
                {
                    LibEmber.lz4frameutil_decompressor_decompress(context, new IntPtr(pOut), output.Length);
                }

                return output;
            }
        }

        public void Close()
        {
            if(IntPtr.Zero == context)
                return;

            LibEmber.lz4frameutil_decompressor_destroy(context);

            context = IntPtr.Zero;
        }

        protected virtual void Dispose(bool disposing)
        {
            if(!disposed)
            {
                Close();

                disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
