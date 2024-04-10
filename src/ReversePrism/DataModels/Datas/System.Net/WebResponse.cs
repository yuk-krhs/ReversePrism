using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 M_IsFromCache                            000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class WebResponse : DataModel
    {
        public bool                                     M_IsFromCache                           { get; set; }

        public static WebResponse? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new WebResponse() { Pointer= p0 };

            value.M_IsFromCache                             = GetBool(new IntPtr(p + 0x018)); // 0246674F9A58 0x18 M_IsFromCache               ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
