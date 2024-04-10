using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 WriteData                                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 011 ReadData                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class JsonExtensionDataAttribute : DataModel
    {
        public bool                                     WriteData                               { get; set; }
        public bool                                     ReadData                                { get; set; }

        public static JsonExtensionDataAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new JsonExtensionDataAttribute() { Pointer= p0 };

            value.WriteData                                 = GetBool(new IntPtr(p + 0x010)); // 0245A607E900 0x10 WriteData                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.ReadData                                  = GetBool(new IntPtr(p + 0x011)); // 0245A607E920 0x11 ReadData                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
