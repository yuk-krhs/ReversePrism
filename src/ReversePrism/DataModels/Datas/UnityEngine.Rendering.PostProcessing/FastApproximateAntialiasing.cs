using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 FastMode                                 000186595960 ModelPrimitiveType bool bool bool Bool
    // 011 KeepAlpha                                000186595960 ModelPrimitiveType bool bool bool Bool
    public partial class FastApproximateAntialiasing
    {
        public bool                                     FastMode                                { get; set; }
        public bool                                     KeepAlpha                               { get; set; }

        public static FastApproximateAntialiasing? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FastApproximateAntialiasing();

            value.FastMode                                  = GetBool(new IntPtr(p + 0x010)); // 0270D33122C0 0x10 FastMode                    ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.KeepAlpha                                 = GetBool(new IntPtr(p + 0x011)); // 0270D33122E0 0x11 KeepAlpha                   ( 000186595960 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
