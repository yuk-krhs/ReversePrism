using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism
{
    public class Lz4FrameUtilContext : IDisposable
    {
        private IntPtr context;
        private bool disposed;

        public Lz4FrameUtilContext()
        {
            context = LibEmber.lz4frameutil_create_context();
        }

        ~Lz4FrameUtilContext()
        {
             Dispose(disposing: false);
        }

        public unsafe IntPtr CompressFile(string srcfile, string dstfile)
        {
            return LibEmber.lz4frameutil_compress_file(context, srcfile, dstfile);
        }

        public void Close()
        {
            if(IntPtr.Zero == context)
                return;

            LibEmber.lz4frameutil_destroy_context(context);

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
