using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism
{
    public class AesCtr : IDisposable
    {
        private IntPtr context;
        private bool disposed;

        public AesCtr()
        {
            context = LibEmber.mbedtlshelper_aes_create();
        }

        ~AesCtr()
        {
             Dispose(disposing: false);
        }

        public unsafe int SetKey(byte[] data, int bits)
        {
            fixed(byte* p= &data[0])
                return SetKey(p, bits);
        }

        public unsafe int SetKey(byte* data, int bits)
        {
            return LibEmber.mbedtlshelper_aes_setkey_enc(context, new IntPtr(data), bits);
        }

        public unsafe int Transform(byte[] input, byte[] output, byte[] counter)
        {
            fixed(byte* pIn  = &input[0])
            fixed(byte* pOut = &output[0])
            fixed(byte* pCnt = &counter[0])
                return Transform(pIn, pOut, input.Length, pCnt);
        }

        public unsafe int Transform(byte* input, byte* output, int size, byte* counter)
        {
            return LibEmber.mbedtlshelper_aes_crypt_ctr(context,
                new IntPtr(input),
                new IntPtr(output),
                size,
                new IntPtr(counter));
        }

        public void Close()
        {
            if(IntPtr.Zero == context)
                return;

            LibEmber.mbedtlshelper_aes_destroy(context);

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
