using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 FastMode                                 ModelPrimitiveType bool bool bool Bool
    // 011 KeepAlpha                                ModelPrimitiveType bool bool bool Bool
    public partial class FastApproximateAntialiasing : DataModel
    {
        public bool                                     FastMode                                { get; set; }
        public bool                                     KeepAlpha                               { get; set; }

        public static FastApproximateAntialiasing? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FastApproximateAntialiasing() { Pointer= p0 };

            value.FastMode                                  = GetBool(new IntPtr(p + 0x010)); // 0x10 FastMode                    ( ModelPrimitiveType bool bool bool Bool )
            value.KeepAlpha                                 = GetBool(new IntPtr(p + 0x011)); // 0x11 KeepAlpha                   ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
