using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Url                                      0001866736C0 ModelPrimitiveType string string string String
    // 018 IsDone                                   000186595960 ModelPrimitiveType bool bool bool Bool
    public partial class TextureRequest : DataModel
    {
        public string                                   Url                                     { get; set; }
        public bool                                     IsDone                                  { get; set; }

        public static TextureRequest? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TextureRequest() { Pointer= p0 };

            value.Url                                       = GetString(new IntPtr(p + 0x010)); // 024664BD1468 0x10 Url                         ( 0001866736C0 ModelPrimitiveType string string string String )
            value.IsDone                                    = GetBool(new IntPtr(p + 0x018)); // 024664BD1488 0x18 IsDone                      ( 000186595960 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
