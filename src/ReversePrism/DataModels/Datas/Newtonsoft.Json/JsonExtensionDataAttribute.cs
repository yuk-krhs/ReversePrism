using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 WriteData                                ModelPrimitiveType bool bool bool Bool
    // 011 ReadData                                 ModelPrimitiveType bool bool bool Bool
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

            value.WriteData                                 = GetBool(new IntPtr(p + 0x010)); // 0x10 WriteData                   ( ModelPrimitiveType bool bool bool Bool )
            value.ReadData                                  = GetBool(new IntPtr(p + 0x011)); // 0x11 ReadData                    ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
