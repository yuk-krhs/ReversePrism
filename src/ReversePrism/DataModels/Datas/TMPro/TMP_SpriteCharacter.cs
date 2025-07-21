using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 M_Name                                   ModelPrimitiveType string string string String
    // 038 M_HashCode                               ModelPrimitiveType int int int Int32
    public partial class TMP_SpriteCharacter : DataModel
    {
        public string                                   M_Name                                  { get; set; }
        public int                                      M_HashCode                              { get; set; }

        public static TMP_SpriteCharacter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TMP_SpriteCharacter() { Pointer= p0 };

            value.M_Name                                    = GetString(new IntPtr(p + 0x030)); // 0x30 M_Name                      ( ModelPrimitiveType string string string String )
            value.M_HashCode                                = GetInt32(new IntPtr(p + 0x038)); // 0x38 M_HashCode                  ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
