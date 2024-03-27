using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 Variables                                0001865333C0 ModelClassType Variables Variables Variables Pointer
    public partial class CreateAppTokenRequest
    {
        public Variables?                               Variables                               { get; set; }

        public static CreateAppTokenRequest? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CreateAppTokenRequest();

            value.Variables                                 = GetObject<Variables>(new IntPtr(p + 0x018), ReversePrism.DataModels.Variables.FromPointer); // 0270DBDC0700 0x18 Variables                   ( 0001865333C0 ModelClassType Variables Variables Variables Pointer )

            return value;
        }
    }
}
