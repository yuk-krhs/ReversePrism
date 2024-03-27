using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 Variables                                00018650BA20 ModelClassType Variables Variables Variables Pointer
    public partial class GetUploadURLRequest
    {
        public Variables?                               Variables                               { get; set; }

        public static GetUploadURLRequest? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetUploadURLRequest();

            value.Variables                                 = GetObject<Variables>(new IntPtr(p + 0x018), ReversePrism.DataModels.Variables.FromPointer); // 0270DBDD9000 0x18 Variables                   ( 00018650BA20 ModelClassType Variables Variables Variables Pointer )

            return value;
        }
    }
}
