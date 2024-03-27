using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Small                                    string IL2CPP_TYPE_STRING
    // 008 Normal                                   string IL2CPP_TYPE_STRING
    // 010 Large                                    000186674040 ModelPrimitiveType string string string String
    // 018 Huge                                     000186674040 ModelPrimitiveType string string string String
    public partial class Size
    {
        public string                                   Large                                   { get; set; }
        public string                                   Huge                                    { get; set; }

        public static Size? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Size();

            value.Large                                     = GetString(new IntPtr(p + 0x010)); // 0270DB4B7440 0x10 Large                       ( 000186674040 ModelPrimitiveType string string string String )
            value.Huge                                      = GetString(new IntPtr(p + 0x018)); // 0270DB4B7460 0x18 Huge                        ( 000186674040 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
