using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 Response                                 ModelClassType IgnoreListResult IgnoreListResult IgnoreListResult Pointer
    public partial class OsapiIgnoreListResult : DataModel
    {
        public IgnoreListResult?                        Response                                { get; set; }

        public static OsapiIgnoreListResult? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new OsapiIgnoreListResult() { Pointer= p0 };

            value.Response                                  = GetObject<IgnoreListResult>(new IntPtr(p + 0x040), ReversePrism.DataModels.IgnoreListResult.FromPointer); // 0x40 Response                    ( ModelClassType IgnoreListResult IgnoreListResult IgnoreListResult Pointer )

            return value;
        }
    }
}
