using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 Response                                 0001866801D0 ModelClassType ActivityResult ActivityResult ActivityResult Pointer
    public partial class OsapiActivityResult
    {
        public ActivityResult?                          Response                                { get; set; }

        public static OsapiActivityResult? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new OsapiActivityResult();

            value.Response                                  = GetObject<ActivityResult>(new IntPtr(p + 0x040), ReversePrism.DataModels.ActivityResult.FromPointer); // 0270DB499D50 0x40 Response                    ( 0001866801D0 ModelClassType ActivityResult ActivityResult ActivityResult Pointer )

            return value;
        }
    }
}
