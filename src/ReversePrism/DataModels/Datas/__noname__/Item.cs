using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Key                                      0001866722E0 ModelPrimitiveType string string string String
    // 018 DisplayName                              0001866722E0 ModelPrimitiveType string string string String
    // 020 Sprite                                   00018666B8E0 ModelClassType Sprite Sprite Sprite Pointer
    public partial class Item : DataModel
    {
        public string                                   Key                                     { get; set; }
        public string                                   DisplayName                             { get; set; }
        public Sprite?                                  Sprite                                  { get; set; }

        public static Item? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Item() { Pointer= p0 };

            value.Key                                       = GetString(new IntPtr(p + 0x010)); // 02466B098C58 0x10 Key                         ( 0001866722E0 ModelPrimitiveType string string string String )
            value.DisplayName                               = GetString(new IntPtr(p + 0x018)); // 02466B098C78 0x18 DisplayName                 ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Sprite                                    = GetObject<Sprite>(new IntPtr(p + 0x020), ReversePrism.DataModels.Sprite.FromPointer); // 02466B098C98 0x20 Sprite                      ( 00018666B8E0 ModelClassType Sprite Sprite Sprite Pointer )

            return value;
        }
    }
}
