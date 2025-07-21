using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CharacterId                              ModelPrimitiveType int int int Int32
    // 014 Level                                    ModelEnumType IdolLevelUpParamViewModel IdolLevelUpParamViewModel IdolLevelUpParamViewModel Int32
    // 01C DearnessLevel                            ModelEnumType IdolLevelUpParamViewModel IdolLevelUpParamViewModel IdolLevelUpParamViewModel Int32
    // 024 Vocal                                    ModelEnumType IdolLevelUpParamViewModel IdolLevelUpParamViewModel IdolLevelUpParamViewModel Int32
    // 02C Dance                                    ModelEnumType IdolLevelUpParamViewModel IdolLevelUpParamViewModel IdolLevelUpParamViewModel Int32
    // 034 Visual                                   ModelEnumType IdolLevelUpParamViewModel IdolLevelUpParamViewModel IdolLevelUpParamViewModel Int32
    // 03C Mental                                   ModelEnumType IdolLevelUpParamViewModel IdolLevelUpParamViewModel IdolLevelUpParamViewModel Int32
    // 044 IsLevelUp                                ModelPrimitiveType bool bool bool Bool
    public partial class IdolLevelUpIdolViewModel : DataModel
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
            var value   = new IdolLevelUpIdolViewModel() { Pointer= p0 };

            value.CharacterId                               = GetInt32(new IntPtr(p + 0x010)); // 0x10 CharacterId                 ( ModelPrimitiveType int int int Int32 )
            value.Level                                     = (IdolLevelUpParamViewModel)GetInt32(new IntPtr(p + 0x014)); // 0x14 Level                       ( ModelEnumType IdolLevelUpParamViewModel IdolLevelUpParamViewModel IdolLevelUpParamViewModel Int32 )
            value.DearnessLevel                             = (IdolLevelUpParamViewModel)GetInt32(new IntPtr(p + 0x01C)); // 0x1C DearnessLevel               ( ModelEnumType IdolLevelUpParamViewModel IdolLevelUpParamViewModel IdolLevelUpParamViewModel Int32 )
            value.Vocal                                     = (IdolLevelUpParamViewModel)GetInt32(new IntPtr(p + 0x024)); // 0x24 Vocal                       ( ModelEnumType IdolLevelUpParamViewModel IdolLevelUpParamViewModel IdolLevelUpParamViewModel Int32 )
            value.Dance                                     = (IdolLevelUpParamViewModel)GetInt32(new IntPtr(p + 0x02C)); // 0x2C Dance                       ( ModelEnumType IdolLevelUpParamViewModel IdolLevelUpParamViewModel IdolLevelUpParamViewModel Int32 )
            value.Visual                                    = (IdolLevelUpParamViewModel)GetInt32(new IntPtr(p + 0x034)); // 0x34 Visual                      ( ModelEnumType IdolLevelUpParamViewModel IdolLevelUpParamViewModel IdolLevelUpParamViewModel Int32 )
            value.Mental                                    = (IdolLevelUpParamViewModel)GetInt32(new IntPtr(p + 0x03C)); // 0x3C Mental                      ( ModelEnumType IdolLevelUpParamViewModel IdolLevelUpParamViewModel IdolLevelUpParamViewModel Int32 )
            value.IsLevelUp                                 = GetBool(new IntPtr(p + 0x044)); // 0x44 IsLevelUp                   ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
