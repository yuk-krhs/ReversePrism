using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 Response                                 ModelClassType ActivityResult ActivityResult ActivityResult Pointer
    public partial class OsapiActivityResult : DataModel
    {
        public ActivityResult?                          Response                                { get; set; }

        public static OsapiActivityResult? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new OsapiActivityResult() { Pointer= p0 };

            value.Response                                  = GetObject<ActivityResult>(new IntPtr(p + 0x040), ReversePrism.DataModels.ActivityResult.FromPointer); // 0x40 Response                    ( ModelClassType ActivityResult ActivityResult ActivityResult Pointer )

            return value;
        }
    }
}
