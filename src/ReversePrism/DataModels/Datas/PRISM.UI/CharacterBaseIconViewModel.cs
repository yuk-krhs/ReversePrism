using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CharaId                                  ModelPrimitiveType int int int Int32
    // 018 ColorCode                                ModelPrimitiveType string string string String
    // 020 IsNamePlateActive                        ModelPrimitiveType bool bool bool Bool
    public partial class CharacterBaseIconViewModel : DataModel
    {
        public int                                      CharaId                                 { get; set; }
        public string                                   ColorCode                               { get; set; }
        public bool                                     IsNamePlateActive                       { get; set; }

        public static CharacterBaseIconViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CharacterBaseIconViewModel() { Pointer= p0 };

            value.CharaId                                   = GetInt32(new IntPtr(p + 0x010)); // 0x10 CharaId                     ( ModelPrimitiveType int int int Int32 )
            value.ColorCode                                 = GetString(new IntPtr(p + 0x018)); // 0x18 ColorCode                   ( ModelPrimitiveType string string string String )
            value.IsNamePlateActive                         = GetBool(new IntPtr(p + 0x020)); // 0x20 IsNamePlateActive           ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
