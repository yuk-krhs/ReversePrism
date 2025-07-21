using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CharacterId                              ModelPrimitiveType int int int Int32
    // 014 TargetSceneType                          ModelEnumType IdolBaseCostumeTargetSceneType IdolBaseCostumeTargetSceneType IdolBaseCostumeTargetSceneType Int32
    // 018 Costume                                  ModelClassType CharacterCostume CharacterCostume CharacterCostume Pointer
    // 020 Enable                                   ModelPrimitiveType bool bool bool Bool
    public partial class CasualCostumeIdol : DataModel
    {
        public int                                      CharacterId                             { get; set; }
        public IdolBaseCostumeTargetSceneType           TargetSceneType                         { get; set; }
        public CharacterCostume?                        Costume                                 { get; set; }
        public bool                                     Enable                                  { get; set; }

        public static CasualCostumeIdol? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CasualCostumeIdol() { Pointer= p0 };

            value.CharacterId                               = GetInt32(new IntPtr(p + 0x010)); // 0x10 CharacterId                 ( ModelPrimitiveType int int int Int32 )
            value.TargetSceneType                           = (IdolBaseCostumeTargetSceneType)GetInt32(new IntPtr(p + 0x014)); // 0x14 TargetSceneType             ( ModelEnumType IdolBaseCostumeTargetSceneType IdolBaseCostumeTargetSceneType IdolBaseCostumeTargetSceneType Int32 )
            value.Costume                                   = GetObject<CharacterCostume>(new IntPtr(p + 0x018), ReversePrism.DataModels.CharacterCostume.FromPointer); // 0x18 Costume                     ( ModelClassType CharacterCostume CharacterCostume CharacterCostume Pointer )
            value.Enable                                    = GetBool(new IntPtr(p + 0x020)); // 0x20 Enable                      ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
