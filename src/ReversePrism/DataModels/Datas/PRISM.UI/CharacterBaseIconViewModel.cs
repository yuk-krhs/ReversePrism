using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CharaId                                  0001865F2AF0 ModelPrimitiveType int int int Int32
    // 018 ColorCode                                000186671910 ModelPrimitiveType string string string String
    // 020 IsNamePlateActive                        000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class CharacterBaseIconViewModel
    {
        public int                                      CharaId                                 { get; set; }
        public string                                   ColorCode                               { get; set; }
        public bool                                     IsNamePlateActive                       { get; set; }

        public static CharacterBaseIconViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CharacterBaseIconViewModel();

            value.CharaId                                   = GetInt32(new IntPtr(p + 0x010)); // 027005D68558 0x10 CharaId                     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ColorCode                                 = GetString(new IntPtr(p + 0x018)); // 027005D68578 0x18 ColorCode                   ( 000186671910 ModelPrimitiveType string string string String )
            value.IsNamePlateActive                         = GetBool(new IntPtr(p + 0x020)); // 027005D68598 0x20 IsNamePlateActive           ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
