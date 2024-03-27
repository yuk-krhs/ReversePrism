using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 Response                                 0001866CB3E0 ModelClassType IgnoreListResult IgnoreListResult IgnoreListResult Pointer
    public partial class OsapiIgnoreListResult
    {
        public IgnoreListResult?                        Response                                { get; set; }

        public static OsapiIgnoreListResult? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new OsapiIgnoreListResult();

            value.Response                                  = GetObject<IgnoreListResult>(new IntPtr(p + 0x040), ReversePrism.DataModels.IgnoreListResult.FromPointer); // 0270DB49A1F0 0x40 Response                    ( 0001866CB3E0 ModelClassType IgnoreListResult IgnoreListResult IgnoreListResult Pointer )

            return value;
        }
    }
}
