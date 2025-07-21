using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MstSupportCharacterId                    ModelPrimitiveType int int int Int32
    // 014 Rarity                                   ModelEnumType SupportCharacterRarity SupportCharacterRarity SupportCharacterRarity Int32
    // 018 Level                                    ModelPrimitiveType int int int Int32
    // 01C Diamond                                  ModelPrimitiveType int int int Int32
    // 020 SupportSkillSlotAmount                   ModelPrimitiveType int int int Int32
    public partial class UnitSupportCharacterViewModel : DataModel
    {
        public int                                      MstSupportCharacterId                   { get; set; }
        public SupportCharacterRarity                   Rarity                                  { get; set; }
        public int                                      Level                                   { get; set; }
        public int                                      Diamond                                 { get; set; }
        public int                                      SupportSkillSlotAmount                  { get; set; }

        public static UnitSupportCharacterViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UnitSupportCharacterViewModel() { Pointer= p0 };

            value.MstSupportCharacterId                     = GetInt32(new IntPtr(p + 0x010)); // 0x10 MstSupportCharacterId       ( ModelPrimitiveType int int int Int32 )
            value.Rarity                                    = (SupportCharacterRarity)GetInt32(new IntPtr(p + 0x014)); // 0x14 Rarity                      ( ModelEnumType SupportCharacterRarity SupportCharacterRarity SupportCharacterRarity Int32 )
            value.Level                                     = GetInt32(new IntPtr(p + 0x018)); // 0x18 Level                       ( ModelPrimitiveType int int int Int32 )
            value.Diamond                                   = GetInt32(new IntPtr(p + 0x01C)); // 0x1C Diamond                     ( ModelPrimitiveType int int int Int32 )
            value.SupportSkillSlotAmount                    = GetInt32(new IntPtr(p + 0x020)); // 0x20 SupportSkillSlotAmount      ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
