using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CharacterId                              0001865F4940 ModelPrimitiveType int int int Int32
    // 014 Level                                    0001865E5C60 ModelEnumType IdolLevelUpParamViewModel IdolLevelUpParamViewModel IdolLevelUpParamViewModel Int32
    // 01C DearnessLevel                            0001865E5C60 ModelEnumType IdolLevelUpParamViewModel IdolLevelUpParamViewModel IdolLevelUpParamViewModel Int32
    // 024 Vocal                                    0001865E5C60 ModelEnumType IdolLevelUpParamViewModel IdolLevelUpParamViewModel IdolLevelUpParamViewModel Int32
    // 02C Dance                                    0001865E5C60 ModelEnumType IdolLevelUpParamViewModel IdolLevelUpParamViewModel IdolLevelUpParamViewModel Int32
    // 034 Visual                                   0001865E5C60 ModelEnumType IdolLevelUpParamViewModel IdolLevelUpParamViewModel IdolLevelUpParamViewModel Int32
    // 03C Mental                                   0001865E5C60 ModelEnumType IdolLevelUpParamViewModel IdolLevelUpParamViewModel IdolLevelUpParamViewModel Int32
    // 044 IsLevelUp                                000186596AF0 ModelPrimitiveType bool bool bool Bool
    public partial class IdolLevelUpIdolViewModel
    {
        public int                                      CharacterId                             { get; set; }
        public IdolLevelUpParamViewModel                Level                                   { get; set; }
        public IdolLevelUpParamViewModel                DearnessLevel                           { get; set; }
        public IdolLevelUpParamViewModel                Vocal                                   { get; set; }
        public IdolLevelUpParamViewModel                Dance                                   { get; set; }
        public IdolLevelUpParamViewModel                Visual                                  { get; set; }
        public IdolLevelUpParamViewModel                Mental                                  { get; set; }
        public bool                                     IsLevelUp                               { get; set; }

        public static IdolLevelUpIdolViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IdolLevelUpIdolViewModel();

            value.CharacterId                               = GetInt32(new IntPtr(p + 0x010)); // 0270D4C52B70 0x10 CharacterId                 ( 0001865F4940 ModelPrimitiveType int int int Int32 )
            value.Level                                     = (IdolLevelUpParamViewModel)GetInt32(new IntPtr(p + 0x014)); // 0270D4C52B90 0x14 Level                       ( 0001865E5C60 ModelEnumType IdolLevelUpParamViewModel IdolLevelUpParamViewModel IdolLevelUpParamViewModel Int32 )
            value.DearnessLevel                             = (IdolLevelUpParamViewModel)GetInt32(new IntPtr(p + 0x01C)); // 0270D4C52BB0 0x1C DearnessLevel               ( 0001865E5C60 ModelEnumType IdolLevelUpParamViewModel IdolLevelUpParamViewModel IdolLevelUpParamViewModel Int32 )
            value.Vocal                                     = (IdolLevelUpParamViewModel)GetInt32(new IntPtr(p + 0x024)); // 0270D4C52BD0 0x24 Vocal                       ( 0001865E5C60 ModelEnumType IdolLevelUpParamViewModel IdolLevelUpParamViewModel IdolLevelUpParamViewModel Int32 )
            value.Dance                                     = (IdolLevelUpParamViewModel)GetInt32(new IntPtr(p + 0x02C)); // 0270D4C52BF0 0x2C Dance                       ( 0001865E5C60 ModelEnumType IdolLevelUpParamViewModel IdolLevelUpParamViewModel IdolLevelUpParamViewModel Int32 )
            value.Visual                                    = (IdolLevelUpParamViewModel)GetInt32(new IntPtr(p + 0x034)); // 0270D4C52C10 0x34 Visual                      ( 0001865E5C60 ModelEnumType IdolLevelUpParamViewModel IdolLevelUpParamViewModel IdolLevelUpParamViewModel Int32 )
            value.Mental                                    = (IdolLevelUpParamViewModel)GetInt32(new IntPtr(p + 0x03C)); // 0270D4C52C30 0x3C Mental                      ( 0001865E5C60 ModelEnumType IdolLevelUpParamViewModel IdolLevelUpParamViewModel IdolLevelUpParamViewModel Int32 )
            value.IsLevelUp                                 = GetBool(new IntPtr(p + 0x044)); // 0270D4C52C50 0x44 IsLevelUp                   ( 000186596AF0 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
