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
    public partial class TextureRequest
    {
        public string                                   Url                                     { get; set; }
        public bool                                     IsDone                                  { get; set; }

        public static TextureRequest? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TextureRequest();

            value.Url                                       = GetString(new IntPtr(p + 0x010)); // 0270D4B5D7A8 0x10 Url                         ( 0001866736C0 ModelPrimitiveType string string string String )
            value.IsDone                                    = GetBool(new IntPtr(p + 0x018)); // 0270D4B5D7C8 0x18 IsDone                      ( 000186595960 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
