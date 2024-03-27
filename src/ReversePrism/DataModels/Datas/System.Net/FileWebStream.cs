using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 070 M_request                                00018657EA90 ModelClassType FileWebRequest FileWebRequest FileWebRequest Pointer
    public partial class FileWebStream
    {
        public FileWebRequest?                          M_request                               { get; set; }

        public static FileWebStream? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FileWebStream();

            value.M_request                                 = GetObject<FileWebRequest>(new IntPtr(p + 0x070), ReversePrism.DataModels.FileWebRequest.FromPointer); // 0270D7A594B8 0x70 M_request                   ( 00018657EA90 ModelClassType FileWebRequest FileWebRequest FileWebRequest Pointer )

            return value;
        }
    }
}
