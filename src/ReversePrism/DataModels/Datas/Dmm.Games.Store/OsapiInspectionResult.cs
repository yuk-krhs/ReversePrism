using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 Response                                 00018670A3A0 ModelClassType InspectionResult InspectionResult InspectionResult Pointer
    public partial class OsapiInspectionResult
    {
        public InspectionResult?                        Response                                { get; set; }

        public static OsapiInspectionResult? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new OsapiInspectionResult();

            value.Response                                  = GetObject<InspectionResult>(new IntPtr(p + 0x040), ReversePrism.DataModels.InspectionResult.FromPointer); // 0270DB499870 0x40 Response                    ( 00018670A3A0 ModelClassType InspectionResult InspectionResult InspectionResult Pointer )

            return value;
        }
    }
}
