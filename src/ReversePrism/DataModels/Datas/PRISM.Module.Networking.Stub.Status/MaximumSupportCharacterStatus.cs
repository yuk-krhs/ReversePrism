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
    // 018 MstSupportCharacterId                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 RarityFieldNumber                        int IL2CPP_TYPE_I4
    // 01C Rarity                                   0001865EB1C0 ModelEnumType SupportCharacterRarity SupportCharacterRarity SupportCharacterRarity Int32
    // 000 DiamondFieldNumber                       int IL2CPP_TYPE_I4
    // 020 Diamond                                  00018652EBE0 ModelClassType LimitedValueStatus LimitedValueStatus LimitedValueStatus Pointer
    // 000 SupportSkillSlotAmountFieldNumber        int IL2CPP_TYPE_I4
    // 028 SupportSkillSlotAmount                   00018652EBE0 ModelClassType LimitedValueStatus LimitedValueStatus LimitedValueStatus Pointer
    // 000 SupportEffectListFieldNumber             int IL2CPP_TYPE_I4
    // 008 _repeated_supportEffectList_codec        FieldCodec`1<SupportEffectStatus> IL2CPP_TYPE_GENERICINST
    // 030 SupportEffectList                        000185CF44F8 ModelClassListType RepeatedField`1<SupportEffectStatus> RepeatedField`1<SupportEffectStatus> List<SupportEffectStatus> Pointer
    // 000 PotentialSupportSkillListFieldNumber     int IL2CPP_TYPE_I4
    // 010 _repeated_potentialSupportSkillList_codec FieldCodec`1<PotentialSupportSkillStatus> IL2CPP_TYPE_GENERICINST
    // 038 PotentialSupportSkillList                000185CE95A8 ModelClassListType RepeatedField`1<PotentialSupportSkillStatus> RepeatedField`1<PotentialSupportSkillStatus> List<PotentialSupportSkillStatus> Pointer
    // 000 SupportCharacterEventListFieldNumber     int IL2CPP_TYPE_I4
    // 018 _repeated_supportCharacterEventList_codec FieldCodec`1<SupportCharacterEventStatus> IL2CPP_TYPE_GENERICINST
    // 040 SupportCharacterEventList                000185CF3DF8 ModelClassListType RepeatedField`1<SupportCharacterEventStatus> RepeatedField`1<SupportCharacterEventStatus> List<SupportCharacterEventStatus> Pointer
    // 000 MstCharacterInfoIdFieldNumber            int IL2CPP_TYPE_I4
    // 048 MstCharacterInfoId                       0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 CardIdFieldNumber                        int IL2CPP_TYPE_I4
    // 04C CardId                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 GoodScheduleDetailTypeFieldNumber        int IL2CPP_TYPE_I4
    // 050 GoodScheduleDetailType                   0001866D43F0 ModelEnumType ScheduleDetailType ScheduleDetailType ScheduleDetailType Int32
    // 000 LevelFieldNumber                         int IL2CPP_TYPE_I4
    // 058 Level                                    00018652EBE0 ModelClassType LimitedValueStatus LimitedValueStatus LimitedValueStatus Pointer
    public partial class MaximumSupportCharacterStatus
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
            var value   = new MaximumSupportCharacterStatus();

            value.MstSupportCharacterId                     = GetInt32(new IntPtr(p + 0x018)); // 0270D1A2B248 0x18 MstSupportCharacterId       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Rarity                                    = (SupportCharacterRarity)GetInt32(new IntPtr(p + 0x01C)); // 0270D1A2B288 0x1C Rarity                      ( 0001865EB1C0 ModelEnumType SupportCharacterRarity SupportCharacterRarity SupportCharacterRarity Int32 )
            value.Diamond                                   = GetObject<LimitedValueStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.LimitedValueStatus.FromPointer); // 0270D1A2B2C8 0x20 Diamond                     ( 00018652EBE0 ModelClassType LimitedValueStatus LimitedValueStatus LimitedValueStatus Pointer )
            value.SupportSkillSlotAmount                    = GetObject<LimitedValueStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.LimitedValueStatus.FromPointer); // 0270D1A2B308 0x28 SupportSkillSlotAmount      ( 00018652EBE0 ModelClassType LimitedValueStatus LimitedValueStatus LimitedValueStatus Pointer )
            value.SupportEffectList                         = GetObjectList<SupportEffectStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.SupportEffectStatus.FromPointer); // 0270D1A2B368 0x30 SupportEffectList           ( 000185CF44F8 ModelClassListType RepeatedField`1<SupportEffectStatus> RepeatedField`1<SupportEffectStatus> List<SupportEffectStatus> Pointer )
            value.PotentialSupportSkillList                 = GetObjectList<PotentialSupportSkillStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.PotentialSupportSkillStatus.FromPointer); // 0270D1A2B3C8 0x38 PotentialSupportSkillList   ( 000185CE95A8 ModelClassListType RepeatedField`1<PotentialSupportSkillStatus> RepeatedField`1<PotentialSupportSkillStatus> List<PotentialSupportSkillStatus> Pointer )
            value.SupportCharacterEventList                 = GetObjectList<SupportCharacterEventStatus>(new IntPtr(p + 0x040), ReversePrism.DataModels.SupportCharacterEventStatus.FromPointer); // 0270D1A2B428 0x40 SupportCharacterEventList   ( 000185CF3DF8 ModelClassListType RepeatedField`1<SupportCharacterEventStatus> RepeatedField`1<SupportCharacterEventStatus> List<SupportCharacterEventStatus> Pointer )
            value.MstCharacterInfoId                        = GetInt32(new IntPtr(p + 0x048)); // 0270D1A2B468 0x48 MstCharacterInfoId          ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.CardId                                    = GetInt32(new IntPtr(p + 0x04C)); // 0270D1A2B4A8 0x4C CardId                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.GoodScheduleDetailType                    = (ScheduleDetailType)GetInt32(new IntPtr(p + 0x050)); // 0270D1A2B4E8 0x50 GoodScheduleDetailType      ( 0001866D43F0 ModelEnumType ScheduleDetailType ScheduleDetailType ScheduleDetailType Int32 )
            value.Level                                     = GetObject<LimitedValueStatus>(new IntPtr(p + 0x058), ReversePrism.DataModels.LimitedValueStatus.FromPointer); // 0270D1A2B528 0x58 Level                       ( 00018652EBE0 ModelClassType LimitedValueStatus LimitedValueStatus LimitedValueStatus Pointer )

            return value;
        }
    }
}
