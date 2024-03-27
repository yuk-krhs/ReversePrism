using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 Response                                 0001865CE790 ModelClassType MakeRequestResult MakeRequestResult MakeRequestResult Pointer
    public partial class OsapiMakeRequestResult
    {
        public MakeRequestResult?                       Response                                { get; set; }

        public static OsapiMakeRequestResult? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new OsapiMakeRequestResult();

            value.Response                                  = GetObject<MakeRequestResult>(new IntPtr(p + 0x040), ReversePrism.DataModels.MakeRequestResult.FromPointer); // 0270DB498AB0 0x40 Response                    ( 0001865CE790 ModelClassType MakeRequestResult MakeRequestResult MakeRequestResult Pointer )

            return value;
        }
    }
}
