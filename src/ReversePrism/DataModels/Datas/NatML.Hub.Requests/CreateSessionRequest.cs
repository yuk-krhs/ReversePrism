using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 Variables                                000186536480 ModelClassType Variables Variables Variables Pointer
    public partial class CreateSessionRequest : DataModel
    {
        public Variables?                               Variables                               { get; set; }

        public static CreateSessionRequest? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CreateSessionRequest() { Pointer= p0 };

            value.Variables                                 = GetObject<Variables>(new IntPtr(p + 0x018), ReversePrism.DataModels.Variables.FromPointer); // 02466BE41830 0x18 Variables                   ( 000186536480 ModelClassType Variables Variables Variables Pointer )

            return value;
        }
    }
}
