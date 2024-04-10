using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 M_Name                                   000186671910 ModelPrimitiveType string string string String
    public partial class SpriteCharacter : DataModel
    {
        public string                                   M_Name                                  { get; set; }

        public static SpriteCharacter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SpriteCharacter() { Pointer= p0 };

            value.M_Name                                    = GetString(new IntPtr(p + 0x030)); // 0245A68AD668 0x30 M_Name                      ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
