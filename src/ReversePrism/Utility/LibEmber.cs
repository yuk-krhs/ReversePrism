using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism
{
    public class LibEmber
    {
        [DllImport("kernel32.dll", CharSet= CharSet.Auto, SetLastError= true)]
        public static extern IntPtr LoadLibrary(string dll);

        static LibEmber()
        {
            LoadLibrary(IntPtr.Size == 8 ? @"x64\libember.dll" : @"x86\libember.dll");
        }

        [DllImport("libember")] public extern static IntPtr mbedtlshelper_aes_create();
        [DllImport("libember")] public extern static int    mbedtlshelper_aes_crypt_ctr(IntPtr ctx, IntPtr input, IntPtr output, long length, IntPtr counter);
        [DllImport("libember")] public extern static int    mbedtlshelper_aes_destroy(IntPtr ctx);
        [DllImport("libember")] public extern static int    mbedtlshelper_aes_setkey_enc(IntPtr ctx, IntPtr key, int bits);

        [DllImport("libember")] public extern static IntPtr lz4frameutil_create_context();
        [DllImport("libember")] public extern static int    lz4frameutil_destroy_context(IntPtr ctx);
        [DllImport("libember", CharSet= CharSet.Ansi)]
                                public extern static IntPtr lz4frameutil_compress_file(IntPtr ctx, string srcfile, string dstfile);

        [DllImport("libember")] public extern static IntPtr lz4frameutil_decompressor_create();
        [DllImport("libember")] public extern static int    lz4frameutil_decompressor_destroy(IntPtr ctx);
        [DllImport("libember")] public extern static int    lz4frameutil_decompressor_set_input(IntPtr ctx, IntPtr input, long size);
        [DllImport("libember")] public extern static int    lz4frameutil_decompressor_get_decompress_size(IntPtr ctx);
        [DllImport("libember")] public extern static int    lz4frameutil_decompressor_decompress(IntPtr ctx, IntPtr output, long size);
    }
}
