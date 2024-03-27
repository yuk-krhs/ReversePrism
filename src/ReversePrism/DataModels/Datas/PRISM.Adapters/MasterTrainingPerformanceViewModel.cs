using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MstCharacterInfoId                       0001865F4260 ModelPrimitiveType int int int Int32
    // 014 MstSupportCharacterId                    0001865F4260 ModelPrimitiveType int int int Int32
    // 018 Rarity                                   0001866201C0 ModelEnumType SupportCharacterRarity SupportCharacterRarity SupportCharacterRarity Int32
    // 01C BeforeDia                                0001865F4260 ModelPrimitiveType int int int Int32
    // 020 AfterDia                                 0001865F4260 ModelPrimitiveType int int int Int32
    // 024 IsMaxLv                                  0001865965D0 ModelPrimitiveType bool bool bool Bool
    // 028 IdolBaseReward                           000186571DC0 ModelClassType IIdolBaseRewardStatus IIdolBaseRewardStatus IIdolBaseRewardStatus Pointer
    public partial class MasterTrainingPerformanceViewModel
    {
        public int                                      MstCharacterInfoId                      { get; set; }
        public int                                      MstSupportCharacterId                   { get; set; }
        public SupportCharacterRarity                   Rarity                                  { get; set; }
        public int                                      BeforeDia                               { get; set; }
        public int                                      AfterDia                                { get; set; }
        public bool                                     IsMaxLv                                 { get; set; }
        public IIdolBaseRewardStatus?                   IdolBaseReward                          { get; set; }

        public static MasterTrainingPerformanceViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MasterTrainingPerformanceViewModel();

            value.MstCharacterInfoId                        = GetInt32(new IntPtr(p + 0x010)); // 0270D604FF78 0x10 MstCharacterInfoId          ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.MstSupportCharacterId                     = GetInt32(new IntPtr(p + 0x014)); // 0270D604FF98 0x14 MstSupportCharacterId       ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.Rarity                                    = (SupportCharacterRarity)GetInt32(new IntPtr(p + 0x018)); // 0270D604FFB8 0x18 Rarity                      ( 0001866201C0 ModelEnumType SupportCharacterRarity SupportCharacterRarity SupportCharacterRarity Int32 )
            value.BeforeDia                                 = GetInt32(new IntPtr(p + 0x01C)); // 0270D604FFD8 0x1C BeforeDia                   ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.AfterDia                                  = GetInt32(new IntPtr(p + 0x020)); // 0270D604FFF8 0x20 AfterDia                    ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.IsMaxLv                                   = GetBool(new IntPtr(p + 0x024)); // 0270D6050018 0x24 IsMaxLv                     ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )
            value.IdolBaseReward                            = GetObject<IIdolBaseRewardStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.IIdolBaseRewardStatus.FromPointer); // 0270D6050038 0x28 IdolBaseReward              ( 000186571DC0 ModelClassType IIdolBaseRewardStatus IIdolBaseRewardStatus IIdolBaseRewardStatus Pointer )

            return value;
        }
    }
}
