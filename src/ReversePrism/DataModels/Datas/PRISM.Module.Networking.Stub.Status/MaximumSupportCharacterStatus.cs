using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<MaximumSupportCharacterStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstSupportCharacterIdFieldNumber         int IL2CPP_TYPE_I4
    // 018 MstSupportCharacterId                    ModelPrimitiveType int int int Int32
    // 000 RarityFieldNumber                        int IL2CPP_TYPE_I4
    // 01C Rarity                                   ModelEnumType SupportCharacterRarity SupportCharacterRarity SupportCharacterRarity Int32
    // 000 DiamondFieldNumber                       int IL2CPP_TYPE_I4
    // 020 Diamond                                  ModelClassType LimitedValueStatus LimitedValueStatus LimitedValueStatus Pointer
    // 000 SupportSkillSlotAmountFieldNumber        int IL2CPP_TYPE_I4
    // 028 SupportSkillSlotAmount                   ModelClassType LimitedValueStatus LimitedValueStatus LimitedValueStatus Pointer
    // 000 SupportEffectListFieldNumber             int IL2CPP_TYPE_I4
    // 008 _repeated_supportEffectList_codec        FieldCodec`1<SupportEffectStatus> IL2CPP_TYPE_GENERICINST
    // 030 SupportEffectList                        ModelClassListType RepeatedField`1<SupportEffectStatus> RepeatedField`1<SupportEffectStatus> List<SupportEffectStatus> Pointer
    // 000 PotentialSupportSkillListFieldNumber     int IL2CPP_TYPE_I4
    // 010 _repeated_potentialSupportSkillList_codec FieldCodec`1<PotentialSupportSkillStatus> IL2CPP_TYPE_GENERICINST
    // 038 PotentialSupportSkillList                ModelClassListType RepeatedField`1<PotentialSupportSkillStatus> RepeatedField`1<PotentialSupportSkillStatus> List<PotentialSupportSkillStatus> Pointer
    // 000 SupportCharacterEventListFieldNumber     int IL2CPP_TYPE_I4
    // 018 _repeated_supportCharacterEventList_codec FieldCodec`1<SupportCharacterEventStatus> IL2CPP_TYPE_GENERICINST
    // 040 SupportCharacterEventList                ModelClassListType RepeatedField`1<SupportCharacterEventStatus> RepeatedField`1<SupportCharacterEventStatus> List<SupportCharacterEventStatus> Pointer
    // 000 MstCharacterInfoIdFieldNumber            int IL2CPP_TYPE_I4
    // 048 MstCharacterInfoId                       ModelPrimitiveType int int int Int32
    // 000 CardIdFieldNumber                        int IL2CPP_TYPE_I4
    // 04C CardId                                   ModelPrimitiveType int int int Int32
    // 000 GoodScheduleDetailTypeFieldNumber        int IL2CPP_TYPE_I4
    // 050 GoodScheduleDetailType                   ModelEnumType ScheduleDetailType ScheduleDetailType ScheduleDetailType Int32
    // 000 LevelFieldNumber                         int IL2CPP_TYPE_I4
    // 058 Level                                    ModelClassType LimitedValueStatus LimitedValueStatus LimitedValueStatus Pointer
    public partial class MaximumSupportCharacterStatus : DataModel
    {
        public int                                      MstSupportCharacterId                   { get; set; }
        public SupportCharacterRarity                   Rarity                                  { get; set; }
        public LimitedValueStatus?                      Diamond                                 { get; set; }
        public LimitedValueStatus?                      SupportSkillSlotAmount                  { get; set; }
        public List<SupportEffectStatus>?               SupportEffectList                       { get; set; }
        public List<PotentialSupportSkillStatus>?       PotentialSupportSkillList               { get; set; }
        public List<SupportCharacterEventStatus>?       SupportCharacterEventList               { get; set; }
        public int                                      MstCharacterInfoId                      { get; set; }
        public int                                      CardId                                  { get; set; }
        public ScheduleDetailType                       GoodScheduleDetailType                  { get; set; }
        public LimitedValueStatus?                      Level                                   { get; set; }

        public static MaximumSupportCharacterStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MaximumSupportCharacterStatus() { Pointer= p0 };

            value.MstSupportCharacterId                     = GetInt32(new IntPtr(p + 0x018)); // 0x18 MstSupportCharacterId       ( ModelPrimitiveType int int int Int32 )
            value.Rarity                                    = (SupportCharacterRarity)GetInt32(new IntPtr(p + 0x01C)); // 0x1C Rarity                      ( ModelEnumType SupportCharacterRarity SupportCharacterRarity SupportCharacterRarity Int32 )
            value.Diamond                                   = GetObject<LimitedValueStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.LimitedValueStatus.FromPointer); // 0x20 Diamond                     ( ModelClassType LimitedValueStatus LimitedValueStatus LimitedValueStatus Pointer )
            value.SupportSkillSlotAmount                    = GetObject<LimitedValueStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.LimitedValueStatus.FromPointer); // 0x28 SupportSkillSlotAmount      ( ModelClassType LimitedValueStatus LimitedValueStatus LimitedValueStatus Pointer )
            value.SupportEffectList                         = GetObjectList<SupportEffectStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.SupportEffectStatus.FromPointer); // 0x30 SupportEffectList           ( ModelClassListType RepeatedField`1<SupportEffectStatus> RepeatedField`1<SupportEffectStatus> List<SupportEffectStatus> Pointer )
            value.PotentialSupportSkillList                 = GetObjectList<PotentialSupportSkillStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.PotentialSupportSkillStatus.FromPointer); // 0x38 PotentialSupportSkillList   ( ModelClassListType RepeatedField`1<PotentialSupportSkillStatus> RepeatedField`1<PotentialSupportSkillStatus> List<PotentialSupportSkillStatus> Pointer )
            value.SupportCharacterEventList                 = GetObjectList<SupportCharacterEventStatus>(new IntPtr(p + 0x040), ReversePrism.DataModels.SupportCharacterEventStatus.FromPointer); // 0x40 SupportCharacterEventList   ( ModelClassListType RepeatedField`1<SupportCharacterEventStatus> RepeatedField`1<SupportCharacterEventStatus> List<SupportCharacterEventStatus> Pointer )
            value.MstCharacterInfoId                        = GetInt32(new IntPtr(p + 0x048)); // 0x48 MstCharacterInfoId          ( ModelPrimitiveType int int int Int32 )
            value.CardId                                    = GetInt32(new IntPtr(p + 0x04C)); // 0x4C CardId                      ( ModelPrimitiveType int int int Int32 )
            value.GoodScheduleDetailType                    = (ScheduleDetailType)GetInt32(new IntPtr(p + 0x050)); // 0x50 GoodScheduleDetailType      ( ModelEnumType ScheduleDetailType ScheduleDetailType ScheduleDetailType Int32 )
            value.Level                                     = GetObject<LimitedValueStatus>(new IntPtr(p + 0x058), ReversePrism.DataModels.LimitedValueStatus.FromPointer); // 0x58 Level                       ( ModelClassType LimitedValueStatus LimitedValueStatus LimitedValueStatus Pointer )

            return value;
        }
    }
}
