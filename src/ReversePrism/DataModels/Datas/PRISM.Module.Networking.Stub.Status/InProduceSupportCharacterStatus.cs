using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CreateDate                               ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 000 _parser                                  MessageParser`1<InProduceSupportCharacterStatus> IL2CPP_TYPE_GENERICINST
    // 020 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstSupportCharacterIdFieldNumber         int IL2CPP_TYPE_I4
    // 028 MstSupportCharacterId                    ModelPrimitiveType int int int Int32
    // 000 RarityFieldNumber                        int IL2CPP_TYPE_I4
    // 02C Rarity                                   ModelEnumType SupportCharacterRarity SupportCharacterRarity SupportCharacterRarity Int32
    // 000 LevelFieldNumber                         int IL2CPP_TYPE_I4
    // 030 Level                                    ModelClassType LimitedValueStatus LimitedValueStatus LimitedValueStatus Pointer
    // 000 ExpFieldNumber                           int IL2CPP_TYPE_I4
    // 038 Exp                                      ModelPrimitiveType int int int Int32
    // 000 DiamondFieldNumber                       int IL2CPP_TYPE_I4
    // 040 Diamond                                  ModelClassType LimitedValueStatus LimitedValueStatus LimitedValueStatus Pointer
    // 000 SupportSkillSlotAmountFieldNumber        int IL2CPP_TYPE_I4
    // 048 SupportSkillSlotAmount                   ModelClassType LimitedValueStatus LimitedValueStatus LimitedValueStatus Pointer
    // 000 MstFavoriteMarkIdFieldNumber             int IL2CPP_TYPE_I4
    // 050 MstFavoriteMarkId                        ModelPrimitiveType int int int Int32
    // 000 SupportEffectListFieldNumber             int IL2CPP_TYPE_I4
    // 008 _repeated_supportEffectList_codec        FieldCodec`1<InProduceSupportEffectStatus> IL2CPP_TYPE_GENERICINST
    // 058 SupportEffectList                        ModelClassListType RepeatedField`1<InProduceSupportEffectStatus> RepeatedField`1<InProduceSupportEffectStatus> List<InProduceSupportEffectStatus> Pointer
    // 000 PotentialSupportSkillListFieldNumber     int IL2CPP_TYPE_I4
    // 010 _repeated_potentialSupportSkillList_codec FieldCodec`1<PotentialSupportSkillStatus> IL2CPP_TYPE_GENERICINST
    // 060 PotentialSupportSkillList                ModelClassListType RepeatedField`1<PotentialSupportSkillStatus> RepeatedField`1<PotentialSupportSkillStatus> List<PotentialSupportSkillStatus> Pointer
    // 000 SupportCharacterEventListFieldNumber     int IL2CPP_TYPE_I4
    // 018 _repeated_supportCharacterEventList_codec FieldCodec`1<SupportCharacterEventStatus> IL2CPP_TYPE_GENERICINST
    // 068 SupportCharacterEventList                ModelClassListType RepeatedField`1<SupportCharacterEventStatus> RepeatedField`1<SupportCharacterEventStatus> List<SupportCharacterEventStatus> Pointer
    // 000 CreateDateFieldNumber                    int IL2CPP_TYPE_I4
    // 070 _CreateDate                              ModelClassType Timestamp Timestamp Timestamp Pointer
    // 000 LimitBreakRecipeProductFieldNumber       int IL2CPP_TYPE_I4
    // 078 LimitBreakRecipeProduct                  ModelClassType ProductStatus ProductStatus ProductStatus Pointer
    // 000 MstCharacterInfoIdFieldNumber            int IL2CPP_TYPE_I4
    // 080 MstCharacterInfoId                       ModelPrimitiveType int int int Int32
    // 000 CardIdFieldNumber                        int IL2CPP_TYPE_I4
    // 084 CardId                                   ModelPrimitiveType int int int Int32
    // 000 GoodScheduleDetailTypeFieldNumber        int IL2CPP_TYPE_I4
    // 088 GoodScheduleDetailType                   ModelEnumType ScheduleDetailType ScheduleDetailType ScheduleDetailType Int32
    // 000 ProduceEntrustFieldNumber                int IL2CPP_TYPE_I4
    // 090 ProduceEntrust                           ModelClassType ProduceEntrustStatus ProduceEntrustStatus ProduceEntrustStatus Pointer
    public partial class InProduceSupportCharacterStatus : DataModel
    {
        public DateTime                                 CreateDate                              { get; set; }
        public int                                      MstSupportCharacterId                   { get; set; }
        public SupportCharacterRarity                   Rarity                                  { get; set; }
        public LimitedValueStatus?                      Level                                   { get; set; }
        public int                                      Exp                                     { get; set; }
        public LimitedValueStatus?                      Diamond                                 { get; set; }
        public LimitedValueStatus?                      SupportSkillSlotAmount                  { get; set; }
        public int                                      MstFavoriteMarkId                       { get; set; }
        public List<InProduceSupportEffectStatus>?      SupportEffectList                       { get; set; }
        public List<PotentialSupportSkillStatus>?       PotentialSupportSkillList               { get; set; }
        public List<SupportCharacterEventStatus>?       SupportCharacterEventList               { get; set; }
        public Timestamp?                               _CreateDate                             { get; set; }
        public ProductStatus?                           LimitBreakRecipeProduct                 { get; set; }
        public int                                      MstCharacterInfoId                      { get; set; }
        public int                                      CardId                                  { get; set; }
        public ScheduleDetailType                       GoodScheduleDetailType                  { get; set; }
        public ProduceEntrustStatus?                    ProduceEntrust                          { get; set; }

        public static InProduceSupportCharacterStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InProduceSupportCharacterStatus() { Pointer= p0 };

            value.CreateDate                                = GetDateTime(new IntPtr(p + 0x010)); // 0x10 CreateDate                  ( ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.MstSupportCharacterId                     = GetInt32(new IntPtr(p + 0x028)); // 0x28 MstSupportCharacterId       ( ModelPrimitiveType int int int Int32 )
            value.Rarity                                    = (SupportCharacterRarity)GetInt32(new IntPtr(p + 0x02C)); // 0x2C Rarity                      ( ModelEnumType SupportCharacterRarity SupportCharacterRarity SupportCharacterRarity Int32 )
            value.Level                                     = GetObject<LimitedValueStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.LimitedValueStatus.FromPointer); // 0x30 Level                       ( ModelClassType LimitedValueStatus LimitedValueStatus LimitedValueStatus Pointer )
            value.Exp                                       = GetInt32(new IntPtr(p + 0x038)); // 0x38 Exp                         ( ModelPrimitiveType int int int Int32 )
            value.Diamond                                   = GetObject<LimitedValueStatus>(new IntPtr(p + 0x040), ReversePrism.DataModels.LimitedValueStatus.FromPointer); // 0x40 Diamond                     ( ModelClassType LimitedValueStatus LimitedValueStatus LimitedValueStatus Pointer )
            value.SupportSkillSlotAmount                    = GetObject<LimitedValueStatus>(new IntPtr(p + 0x048), ReversePrism.DataModels.LimitedValueStatus.FromPointer); // 0x48 SupportSkillSlotAmount      ( ModelClassType LimitedValueStatus LimitedValueStatus LimitedValueStatus Pointer )
            value.MstFavoriteMarkId                         = GetInt32(new IntPtr(p + 0x050)); // 0x50 MstFavoriteMarkId           ( ModelPrimitiveType int int int Int32 )
            value.SupportEffectList                         = GetObjectList<InProduceSupportEffectStatus>(new IntPtr(p + 0x058), ReversePrism.DataModels.InProduceSupportEffectStatus.FromPointer); // 0x58 SupportEffectList           ( ModelClassListType RepeatedField`1<InProduceSupportEffectStatus> RepeatedField`1<InProduceSupportEffectStatus> List<InProduceSupportEffectStatus> Pointer )
            value.PotentialSupportSkillList                 = GetObjectList<PotentialSupportSkillStatus>(new IntPtr(p + 0x060), ReversePrism.DataModels.PotentialSupportSkillStatus.FromPointer); // 0x60 PotentialSupportSkillList   ( ModelClassListType RepeatedField`1<PotentialSupportSkillStatus> RepeatedField`1<PotentialSupportSkillStatus> List<PotentialSupportSkillStatus> Pointer )
            value.SupportCharacterEventList                 = GetObjectList<SupportCharacterEventStatus>(new IntPtr(p + 0x068), ReversePrism.DataModels.SupportCharacterEventStatus.FromPointer); // 0x68 SupportCharacterEventList   ( ModelClassListType RepeatedField`1<SupportCharacterEventStatus> RepeatedField`1<SupportCharacterEventStatus> List<SupportCharacterEventStatus> Pointer )
            value._CreateDate                               = GetObject<Timestamp>(new IntPtr(p + 0x070), ReversePrism.DataModels.Timestamp.FromPointer); // 0x70 _CreateDate                 ( ModelClassType Timestamp Timestamp Timestamp Pointer )
            value.LimitBreakRecipeProduct                   = GetObject<ProductStatus>(new IntPtr(p + 0x078), ReversePrism.DataModels.ProductStatus.FromPointer); // 0x78 LimitBreakRecipeProduct     ( ModelClassType ProductStatus ProductStatus ProductStatus Pointer )
            value.MstCharacterInfoId                        = GetInt32(new IntPtr(p + 0x080)); // 0x80 MstCharacterInfoId          ( ModelPrimitiveType int int int Int32 )
            value.CardId                                    = GetInt32(new IntPtr(p + 0x084)); // 0x84 CardId                      ( ModelPrimitiveType int int int Int32 )
            value.GoodScheduleDetailType                    = (ScheduleDetailType)GetInt32(new IntPtr(p + 0x088)); // 0x88 GoodScheduleDetailType      ( ModelEnumType ScheduleDetailType ScheduleDetailType ScheduleDetailType Int32 )
            value.ProduceEntrust                            = GetObject<ProduceEntrustStatus>(new IntPtr(p + 0x090), ReversePrism.DataModels.ProduceEntrustStatus.FromPointer); // 0x90 ProduceEntrust              ( ModelClassType ProduceEntrustStatus ProduceEntrustStatus ProduceEntrustStatus Pointer )
            value.CreateDate                    = ToDateTime(value._CreateDate);

            return value;
        }
    }
}
