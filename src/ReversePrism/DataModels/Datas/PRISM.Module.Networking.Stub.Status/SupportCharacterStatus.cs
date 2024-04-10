using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CreateDate                               000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 000 _parser                                  MessageParser`1<SupportCharacterStatus> IL2CPP_TYPE_GENERICINST
    // 020 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstSupportCharacterIdFieldNumber         int IL2CPP_TYPE_I4
    // 028 MstSupportCharacterId                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 RarityFieldNumber                        int IL2CPP_TYPE_I4
    // 02C Rarity                                   0001865EB1C0 ModelEnumType SupportCharacterRarity SupportCharacterRarity SupportCharacterRarity Int32
    // 000 LevelFieldNumber                         int IL2CPP_TYPE_I4
    // 030 Level                                    00018652EBE0 ModelClassType LimitedValueStatus LimitedValueStatus LimitedValueStatus Pointer
    // 000 ExpFieldNumber                           int IL2CPP_TYPE_I4
    // 038 Exp                                      0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 DiamondFieldNumber                       int IL2CPP_TYPE_I4
    // 040 Diamond                                  00018652EBE0 ModelClassType LimitedValueStatus LimitedValueStatus LimitedValueStatus Pointer
    // 000 SupportSkillSlotAmountFieldNumber        int IL2CPP_TYPE_I4
    // 048 SupportSkillSlotAmount                   00018652EBE0 ModelClassType LimitedValueStatus LimitedValueStatus LimitedValueStatus Pointer
    // 000 MstFavoriteMarkIdFieldNumber             int IL2CPP_TYPE_I4
    // 050 MstFavoriteMarkId                        0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 SupportEffectListFieldNumber             int IL2CPP_TYPE_I4
    // 008 _repeated_supportEffectList_codec        FieldCodec`1<SupportEffectStatus> IL2CPP_TYPE_GENERICINST
    // 058 SupportEffectList                        000185CF44F8 ModelClassListType RepeatedField`1<SupportEffectStatus> RepeatedField`1<SupportEffectStatus> List<SupportEffectStatus> Pointer
    // 000 PotentialSupportSkillListFieldNumber     int IL2CPP_TYPE_I4
    // 010 _repeated_potentialSupportSkillList_codec FieldCodec`1<PotentialSupportSkillStatus> IL2CPP_TYPE_GENERICINST
    // 060 PotentialSupportSkillList                000185CE95A8 ModelClassListType RepeatedField`1<PotentialSupportSkillStatus> RepeatedField`1<PotentialSupportSkillStatus> List<PotentialSupportSkillStatus> Pointer
    // 000 SupportCharacterEventListFieldNumber     int IL2CPP_TYPE_I4
    // 018 _repeated_supportCharacterEventList_codec FieldCodec`1<SupportCharacterEventStatus> IL2CPP_TYPE_GENERICINST
    // 068 SupportCharacterEventList                000185CF3DF8 ModelClassListType RepeatedField`1<SupportCharacterEventStatus> RepeatedField`1<SupportCharacterEventStatus> List<SupportCharacterEventStatus> Pointer
    // 000 CreateDateFieldNumber                    int IL2CPP_TYPE_I4
    // 070 _CreateDate                              000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer
    // 000 LimitBreakRecipeProductFieldNumber       int IL2CPP_TYPE_I4
    // 078 LimitBreakRecipeProduct                  0001865A5470 ModelClassType ProductStatus ProductStatus ProductStatus Pointer
    // 000 MstCharacterInfoIdFieldNumber            int IL2CPP_TYPE_I4
    // 080 MstCharacterInfoId                       0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 CardIdFieldNumber                        int IL2CPP_TYPE_I4
    // 084 CardId                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 GoodScheduleDetailTypeFieldNumber        int IL2CPP_TYPE_I4
    // 088 GoodScheduleDetailType                   0001866D43F0 ModelEnumType ScheduleDetailType ScheduleDetailType ScheduleDetailType Int32
    // 000 ProduceEntrustFieldNumber                int IL2CPP_TYPE_I4
    // 090 ProduceEntrust                           00018653E020 ModelClassType ProduceEntrustStatus ProduceEntrustStatus ProduceEntrustStatus Pointer
    public partial class SupportCharacterStatus : DataModel
    {
        public DateTime                                 CreateDate                              { get; set; }
        public int                                      MstSupportCharacterId                   { get; set; }
        public SupportCharacterRarity                   Rarity                                  { get; set; }
        public LimitedValueStatus?                      Level                                   { get; set; }
        public int                                      Exp                                     { get; set; }
        public LimitedValueStatus?                      Diamond                                 { get; set; }
        public LimitedValueStatus?                      SupportSkillSlotAmount                  { get; set; }
        public int                                      MstFavoriteMarkId                       { get; set; }
        public List<SupportEffectStatus>?               SupportEffectList                       { get; set; }
        public List<PotentialSupportSkillStatus>?       PotentialSupportSkillList               { get; set; }
        public List<SupportCharacterEventStatus>?       SupportCharacterEventList               { get; set; }
        public Timestamp?                               _CreateDate                             { get; set; }
        public ProductStatus?                           LimitBreakRecipeProduct                 { get; set; }
        public int                                      MstCharacterInfoId                      { get; set; }
        public int                                      CardId                                  { get; set; }
        public ScheduleDetailType                       GoodScheduleDetailType                  { get; set; }
        public ProduceEntrustStatus?                    ProduceEntrust                          { get; set; }

        public static SupportCharacterStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SupportCharacterStatus() { Pointer= p0 };

            value.CreateDate                                = GetDateTime(new IntPtr(p + 0x010)); // 0246613A43E8 0x10 CreateDate                  ( 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.MstSupportCharacterId                     = GetInt32(new IntPtr(p + 0x028)); // 0246613A4468 0x28 MstSupportCharacterId       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Rarity                                    = (SupportCharacterRarity)GetInt32(new IntPtr(p + 0x02C)); // 0246613A44A8 0x2C Rarity                      ( 0001865EB1C0 ModelEnumType SupportCharacterRarity SupportCharacterRarity SupportCharacterRarity Int32 )
            value.Level                                     = GetObject<LimitedValueStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.LimitedValueStatus.FromPointer); // 0246613A44E8 0x30 Level                       ( 00018652EBE0 ModelClassType LimitedValueStatus LimitedValueStatus LimitedValueStatus Pointer )
            value.Exp                                       = GetInt32(new IntPtr(p + 0x038)); // 0246613A4528 0x38 Exp                         ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Diamond                                   = GetObject<LimitedValueStatus>(new IntPtr(p + 0x040), ReversePrism.DataModels.LimitedValueStatus.FromPointer); // 0246613A4568 0x40 Diamond                     ( 00018652EBE0 ModelClassType LimitedValueStatus LimitedValueStatus LimitedValueStatus Pointer )
            value.SupportSkillSlotAmount                    = GetObject<LimitedValueStatus>(new IntPtr(p + 0x048), ReversePrism.DataModels.LimitedValueStatus.FromPointer); // 0246613A45A8 0x48 SupportSkillSlotAmount      ( 00018652EBE0 ModelClassType LimitedValueStatus LimitedValueStatus LimitedValueStatus Pointer )
            value.MstFavoriteMarkId                         = GetInt32(new IntPtr(p + 0x050)); // 0246613A45E8 0x50 MstFavoriteMarkId           ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.SupportEffectList                         = GetObjectList<SupportEffectStatus>(new IntPtr(p + 0x058), ReversePrism.DataModels.SupportEffectStatus.FromPointer); // 0246613A4648 0x58 SupportEffectList           ( 000185CF44F8 ModelClassListType RepeatedField`1<SupportEffectStatus> RepeatedField`1<SupportEffectStatus> List<SupportEffectStatus> Pointer )
            value.PotentialSupportSkillList                 = GetObjectList<PotentialSupportSkillStatus>(new IntPtr(p + 0x060), ReversePrism.DataModels.PotentialSupportSkillStatus.FromPointer); // 0246613A46A8 0x60 PotentialSupportSkillList   ( 000185CE95A8 ModelClassListType RepeatedField`1<PotentialSupportSkillStatus> RepeatedField`1<PotentialSupportSkillStatus> List<PotentialSupportSkillStatus> Pointer )
            value.SupportCharacterEventList                 = GetObjectList<SupportCharacterEventStatus>(new IntPtr(p + 0x068), ReversePrism.DataModels.SupportCharacterEventStatus.FromPointer); // 0246613A4708 0x68 SupportCharacterEventList   ( 000185CF3DF8 ModelClassListType RepeatedField`1<SupportCharacterEventStatus> RepeatedField`1<SupportCharacterEventStatus> List<SupportCharacterEventStatus> Pointer )
            value._CreateDate                               = GetObject<Timestamp>(new IntPtr(p + 0x070), ReversePrism.DataModels.Timestamp.FromPointer); // 0246613A4748 0x70 _CreateDate                 ( 000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer )
            value.LimitBreakRecipeProduct                   = GetObject<ProductStatus>(new IntPtr(p + 0x078), ReversePrism.DataModels.ProductStatus.FromPointer); // 0246613A4788 0x78 LimitBreakRecipeProduct     ( 0001865A5470 ModelClassType ProductStatus ProductStatus ProductStatus Pointer )
            value.MstCharacterInfoId                        = GetInt32(new IntPtr(p + 0x080)); // 0246613A47C8 0x80 MstCharacterInfoId          ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.CardId                                    = GetInt32(new IntPtr(p + 0x084)); // 0246613A4808 0x84 CardId                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.GoodScheduleDetailType                    = (ScheduleDetailType)GetInt32(new IntPtr(p + 0x088)); // 0246613A4848 0x88 GoodScheduleDetailType      ( 0001866D43F0 ModelEnumType ScheduleDetailType ScheduleDetailType ScheduleDetailType Int32 )
            value.ProduceEntrust                            = GetObject<ProduceEntrustStatus>(new IntPtr(p + 0x090), ReversePrism.DataModels.ProduceEntrustStatus.FromPointer); // 0246613A4888 0x90 ProduceEntrust              ( 00018653E020 ModelClassType ProduceEntrustStatus ProduceEntrustStatus ProduceEntrustStatus Pointer )
            value.CreateDate                    = ToDateTime(value._CreateDate);

            return value;
        }
    }
}
