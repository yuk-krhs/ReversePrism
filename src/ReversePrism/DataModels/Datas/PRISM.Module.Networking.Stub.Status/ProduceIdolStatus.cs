using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CreateDate                               ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 000 _parser                                  MessageParser`1<ProduceIdolStatus> IL2CPP_TYPE_GENERICINST
    // 020 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstProduceIdolIdFieldNumber              int IL2CPP_TYPE_I4
    // 028 MstProduceIdolId                         ModelPrimitiveType int int int Int32
    // 000 CostFieldNumber                          int IL2CPP_TYPE_I4
    // 02C Cost                                     ModelPrimitiveType int int int Int32
    // 000 StarFieldNumber                          int IL2CPP_TYPE_I4
    // 030 Star                                     ModelClassType LimitedValueStatus LimitedValueStatus LimitedValueStatus Pointer
    // 000 EvolutionLevelFieldNumber                int IL2CPP_TYPE_I4
    // 038 EvolutionLevel                           ModelClassType LimitedValueStatus LimitedValueStatus LimitedValueStatus Pointer
    // 000 StarIdolParameterListFieldNumber         int IL2CPP_TYPE_I4
    // 008 _repeated_starIdolParameterList_codec    FieldCodec`1<StarIdolParameterStatus> IL2CPP_TYPE_GENERICINST
    // 040 StarIdolParameterList                    ModelClassListType RepeatedField`1<StarIdolParameterStatus> RepeatedField`1<StarIdolParameterStatus> List<StarIdolParameterStatus> Pointer
    // 000 SelectedMstIdolSkillIdFieldNumber        int IL2CPP_TYPE_I4
    // 048 SelectedMstIdolSkillId                   ModelPrimitiveType int int int Int32
    // 000 MstFavoriteMarkIdFieldNumber             int IL2CPP_TYPE_I4
    // 04C MstFavoriteMarkId                        ModelPrimitiveType int int int Int32
    // 000 IdolSkillListFieldNumber                 int IL2CPP_TYPE_I4
    // 010 _repeated_idolSkillList_codec            FieldCodec`1<IdolSkillStatus> IL2CPP_TYPE_GENERICINST
    // 050 IdolSkillList                            ModelClassListType RepeatedField`1<IdolSkillStatus> RepeatedField`1<IdolSkillStatus> List<IdolSkillStatus> Pointer
    // 000 ProduceIdolEventListFieldNumber          int IL2CPP_TYPE_I4
    // 018 _repeated_produceIdolEventList_codec     FieldCodec`1<ProduceIdolEventStatus> IL2CPP_TYPE_GENERICINST
    // 058 ProduceIdolEventList                     ModelClassListType RepeatedField`1<ProduceIdolEventStatus> RepeatedField`1<ProduceIdolEventStatus> List<ProduceIdolEventStatus> Pointer
    // 000 PotentialLiveSkillListFieldNumber        int IL2CPP_TYPE_I4
    // 020 _repeated_potentialLiveSkillList_codec   FieldCodec`1<PotentialLiveSkillStatus> IL2CPP_TYPE_GENERICINST
    // 060 PotentialLiveSkillList                   ModelClassListType RepeatedField`1<PotentialLiveSkillStatus> RepeatedField`1<PotentialLiveSkillStatus> List<PotentialLiveSkillStatus> Pointer
    // 000 DressSetListFieldNumber                  int IL2CPP_TYPE_I4
    // 028 _repeated_dressSetList_codec             FieldCodec`1<ProduceIdolDressSetStatus> IL2CPP_TYPE_GENERICINST
    // 068 DressSetList                             ModelClassListType RepeatedField`1<ProduceIdolDressSetStatus> RepeatedField`1<ProduceIdolDressSetStatus> List<ProduceIdolDressSetStatus> Pointer
    // 000 CreateDateFieldNumber                    int IL2CPP_TYPE_I4
    // 070 _CreateDate                              ModelClassType Timestamp Timestamp Timestamp Pointer
    // 000 LimitBreakRecipeProductFieldNumber       int IL2CPP_TYPE_I4
    // 078 LimitBreakRecipeProduct                  ModelClassType ProductStatus ProductStatus ProductStatus Pointer
    // 000 EvolutionRecipeGroupIdFieldNumber        int IL2CPP_TYPE_I4
    // 080 EvolutionRecipeGroupId                   ModelPrimitiveType int int int Int32
    // 000 MstUnitIdFieldNumber                     int IL2CPP_TYPE_I4
    // 084 MstUnitId                                ModelPrimitiveType int int int Int32
    // 000 MstIdolIdFieldNumber                     int IL2CPP_TYPE_I4
    // 088 MstIdolId                                ModelPrimitiveType int int int Int32
    // 000 MstCharacterInfoIdFieldNumber            int IL2CPP_TYPE_I4
    // 08C MstCharacterInfoId                       ModelPrimitiveType int int int Int32
    // 000 InitialStarFieldNumber                   int IL2CPP_TYPE_I4
    // 090 InitialStar                              ModelPrimitiveType int int int Int32
    // 000 CardIdFieldNumber                        int IL2CPP_TYPE_I4
    // 094 CardId                                   ModelPrimitiveType int int int Int32
    public partial class ProduceIdolStatus : DataModel
    {
        public DateTime                                 CreateDate                              { get; set; }
        public int                                      MstProduceIdolId                        { get; set; }
        public int                                      Cost                                    { get; set; }
        public LimitedValueStatus?                      Star                                    { get; set; }
        public LimitedValueStatus?                      EvolutionLevel                          { get; set; }
        public List<StarIdolParameterStatus>?           StarIdolParameterList                   { get; set; }
        public int                                      SelectedMstIdolSkillId                  { get; set; }
        public int                                      MstFavoriteMarkId                       { get; set; }
        public List<IdolSkillStatus>?                   IdolSkillList                           { get; set; }
        public List<ProduceIdolEventStatus>?            ProduceIdolEventList                    { get; set; }
        public List<PotentialLiveSkillStatus>?          PotentialLiveSkillList                  { get; set; }
        public List<ProduceIdolDressSetStatus>?         DressSetList                            { get; set; }
        public Timestamp?                               _CreateDate                             { get; set; }
        public ProductStatus?                           LimitBreakRecipeProduct                 { get; set; }
        public int                                      EvolutionRecipeGroupId                  { get; set; }
        public int                                      MstUnitId                               { get; set; }
        public int                                      MstIdolId                               { get; set; }
        public int                                      MstCharacterInfoId                      { get; set; }
        public int                                      InitialStar                             { get; set; }
        public int                                      CardId                                  { get; set; }

        public static ProduceIdolStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceIdolStatus() { Pointer= p0 };

            value.CreateDate                                = GetDateTime(new IntPtr(p + 0x010)); // 0x10 CreateDate                  ( ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.MstProduceIdolId                          = GetInt32(new IntPtr(p + 0x028)); // 0x28 MstProduceIdolId            ( ModelPrimitiveType int int int Int32 )
            value.Cost                                      = GetInt32(new IntPtr(p + 0x02C)); // 0x2C Cost                        ( ModelPrimitiveType int int int Int32 )
            value.Star                                      = GetObject<LimitedValueStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.LimitedValueStatus.FromPointer); // 0x30 Star                        ( ModelClassType LimitedValueStatus LimitedValueStatus LimitedValueStatus Pointer )
            value.EvolutionLevel                            = GetObject<LimitedValueStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.LimitedValueStatus.FromPointer); // 0x38 EvolutionLevel              ( ModelClassType LimitedValueStatus LimitedValueStatus LimitedValueStatus Pointer )
            value.StarIdolParameterList                     = GetObjectList<StarIdolParameterStatus>(new IntPtr(p + 0x040), ReversePrism.DataModels.StarIdolParameterStatus.FromPointer); // 0x40 StarIdolParameterList       ( ModelClassListType RepeatedField`1<StarIdolParameterStatus> RepeatedField`1<StarIdolParameterStatus> List<StarIdolParameterStatus> Pointer )
            value.SelectedMstIdolSkillId                    = GetInt32(new IntPtr(p + 0x048)); // 0x48 SelectedMstIdolSkillId      ( ModelPrimitiveType int int int Int32 )
            value.MstFavoriteMarkId                         = GetInt32(new IntPtr(p + 0x04C)); // 0x4C MstFavoriteMarkId           ( ModelPrimitiveType int int int Int32 )
            value.IdolSkillList                             = GetObjectList<IdolSkillStatus>(new IntPtr(p + 0x050), ReversePrism.DataModels.IdolSkillStatus.FromPointer); // 0x50 IdolSkillList               ( ModelClassListType RepeatedField`1<IdolSkillStatus> RepeatedField`1<IdolSkillStatus> List<IdolSkillStatus> Pointer )
            value.ProduceIdolEventList                      = GetObjectList<ProduceIdolEventStatus>(new IntPtr(p + 0x058), ReversePrism.DataModels.ProduceIdolEventStatus.FromPointer); // 0x58 ProduceIdolEventList        ( ModelClassListType RepeatedField`1<ProduceIdolEventStatus> RepeatedField`1<ProduceIdolEventStatus> List<ProduceIdolEventStatus> Pointer )
            value.PotentialLiveSkillList                    = GetObjectList<PotentialLiveSkillStatus>(new IntPtr(p + 0x060), ReversePrism.DataModels.PotentialLiveSkillStatus.FromPointer); // 0x60 PotentialLiveSkillList      ( ModelClassListType RepeatedField`1<PotentialLiveSkillStatus> RepeatedField`1<PotentialLiveSkillStatus> List<PotentialLiveSkillStatus> Pointer )
            value.DressSetList                              = GetObjectList<ProduceIdolDressSetStatus>(new IntPtr(p + 0x068), ReversePrism.DataModels.ProduceIdolDressSetStatus.FromPointer); // 0x68 DressSetList                ( ModelClassListType RepeatedField`1<ProduceIdolDressSetStatus> RepeatedField`1<ProduceIdolDressSetStatus> List<ProduceIdolDressSetStatus> Pointer )
            value._CreateDate                               = GetObject<Timestamp>(new IntPtr(p + 0x070), ReversePrism.DataModels.Timestamp.FromPointer); // 0x70 _CreateDate                 ( ModelClassType Timestamp Timestamp Timestamp Pointer )
            value.LimitBreakRecipeProduct                   = GetObject<ProductStatus>(new IntPtr(p + 0x078), ReversePrism.DataModels.ProductStatus.FromPointer); // 0x78 LimitBreakRecipeProduct     ( ModelClassType ProductStatus ProductStatus ProductStatus Pointer )
            value.EvolutionRecipeGroupId                    = GetInt32(new IntPtr(p + 0x080)); // 0x80 EvolutionRecipeGroupId      ( ModelPrimitiveType int int int Int32 )
            value.MstUnitId                                 = GetInt32(new IntPtr(p + 0x084)); // 0x84 MstUnitId                   ( ModelPrimitiveType int int int Int32 )
            value.MstIdolId                                 = GetInt32(new IntPtr(p + 0x088)); // 0x88 MstIdolId                   ( ModelPrimitiveType int int int Int32 )
            value.MstCharacterInfoId                        = GetInt32(new IntPtr(p + 0x08C)); // 0x8C MstCharacterInfoId          ( ModelPrimitiveType int int int Int32 )
            value.InitialStar                               = GetInt32(new IntPtr(p + 0x090)); // 0x90 InitialStar                 ( ModelPrimitiveType int int int Int32 )
            value.CardId                                    = GetInt32(new IntPtr(p + 0x094)); // 0x94 CardId                      ( ModelPrimitiveType int int int Int32 )
            value.CreateDate                    = ToDateTime(value._CreateDate);

            return value;
        }
    }
}
