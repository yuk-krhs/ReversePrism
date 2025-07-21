using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Text                                   ModelPrimitiveType string string string String
    // 018 M_Image                                  ModelClassType Sprite Sprite Sprite Pointer
    public partial class OptionData : DataModel
    {
        public string                                   M_Text                                  { get; set; }
        public Sprite?                                  M_Image                                 { get; set; }

        public static OptionData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new OptionData() { Pointer= p0 };

            value.M_Text                                    = GetString(new IntPtr(p + 0x010)); // 0x10 M_Text                      ( ModelPrimitiveType string string string String )
            value.M_Image                                   = GetObject<Sprite>(new IntPtr(p + 0x018), ReversePrism.DataModels.Sprite.FromPointer); // 0x18 M_Image                     ( ModelClassType Sprite Sprite Sprite Pointer )

            return value;
        }
    }
}
