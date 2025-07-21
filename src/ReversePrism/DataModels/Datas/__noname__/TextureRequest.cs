using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Url                                      ModelPrimitiveType string string string String
    // 018 IsDone                                   ModelPrimitiveType bool bool bool Bool
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

            value.Url                                       = GetString(new IntPtr(p + 0x010)); // 0x10 Url                         ( ModelPrimitiveType string string string String )
            value.IsDone                                    = GetBool(new IntPtr(p + 0x018)); // 0x18 IsDone                      ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
