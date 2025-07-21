using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<MaximumProduceIdolStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstProduceIdolIdFieldNumber              int IL2CPP_TYPE_I4
    // 018 MstProduceIdolId                         ModelPrimitiveType int int int Int32
    // 000 CostFieldNumber                          int IL2CPP_TYPE_I4
    // 01C Cost                                     ModelPrimitiveType int int int Int32
    // 000 StarFieldNumber                          int IL2CPP_TYPE_I4
    // 020 Star                                     ModelClassType LimitedValueStatus LimitedValueStatus LimitedValueStatus Pointer
    // 000 EvolutionLevelFieldNumber                int IL2CPP_TYPE_I4
    // 028 EvolutionLevel                           ModelClassType LimitedValueStatus LimitedValueStatus LimitedValueStatus Pointer
    // 000 IdolParameterFieldNumber                 int IL2CPP_TYPE_I4
    // 030 IdolParameter                            ModelClassType IdolParameterStatus IdolParameterStatus IdolParameterStatus Pointer
    // 000 IdolSkillListFieldNumber                 int IL2CPP_TYPE_I4
    // 008 _repeated_idolSkillList_codec            FieldCodec`1<IdolSkillStatus> IL2CPP_TYPE_GENERICINST
    // 038 IdolSkillList                            ModelClassListType RepeatedField`1<IdolSkillStatus> RepeatedField`1<IdolSkillStatus> List<IdolSkillStatus> Pointer
    // 000 ProduceIdolEventListFieldNumber          int IL2CPP_TYPE_I4
    // 010 _repeated_produceIdolEventList_codec     FieldCodec`1<ProduceIdolEventStatus> IL2CPP_TYPE_GENERICINST
    // 040 ProduceIdolEventList                     ModelClassListType RepeatedField`1<ProduceIdolEventStatus> RepeatedField`1<ProduceIdolEventStatus> List<ProduceIdolEventStatus> Pointer
    // 000 PotentialLiveSkillListFieldNumber        int IL2CPP_TYPE_I4
    // 018 _repeated_potentialLiveSkillList_codec   FieldCodec`1<PotentialLiveSkillStatus> IL2CPP_TYPE_GENERICINST
    // 048 PotentialLiveSkillList                   ModelClassListType RepeatedField`1<PotentialLiveSkillStatus> RepeatedField`1<PotentialLiveSkillStatus> List<PotentialLiveSkillStatus> Pointer
    // 000 DressSetListFieldNumber                  int IL2CPP_TYPE_I4
    // 020 _repeated_dressSetList_codec             FieldCodec`1<ProduceIdolDressSetStatus> IL2CPP_TYPE_GENERICINST
    // 050 DressSetList                             ModelClassListType RepeatedField`1<ProduceIdolDressSetStatus> RepeatedField`1<ProduceIdolDressSetStatus> List<ProduceIdolDressSetStatus> Pointer
    // 000 MstUnitIdFieldNumber                     int IL2CPP_TYPE_I4
    // 058 MstUnitId                                ModelPrimitiveType int int int Int32
    // 000 MstIdolIdFieldNumber                     int IL2CPP_TYPE_I4
    // 05C MstIdolId                                ModelPrimitiveType int int int Int32
    // 000 MstCharacterInfoIdFieldNumber            int IL2CPP_TYPE_I4
    // 060 MstCharacterInfoId                       ModelPrimitiveType int int int Int32
    // 000 InitialStarFieldNumber                   int IL2CPP_TYPE_I4
    // 064 InitialStar                              ModelPrimitiveType int int int Int32
    // 000 CardIdFieldNumber                        int IL2CPP_TYPE_I4
    // 068 CardId                                   ModelPrimitiveType int int int Int32
    public partial class MaximumProduceIdolStatus : DataModel
    {
        public int                                      MstProduceIdolId                        { get; set; }
        public int                                      Cost                                    { get; set; }
        public LimitedValueStatus?                      Star                                    { get; set; }
        public LimitedValueStatus?                      EvolutionLevel                          { get; set; }
        public IdolParameterStatus?                     IdolParameter                           { get; set; }
        public List<IdolSkillStatus>?                   IdolSkillList                           { get; set; }
        public List<ProduceIdolEventStatus>?            ProduceIdolEventList                    { get; set; }
        public List<PotentialLiveSkillStatus>?          PotentialLiveSkillList                  { get; set; }
        public List<ProduceIdolDressSetStatus>?         DressSetList                            { get; set; }
        public int                                      MstUnitId                               { get; set; }
        public int                                      MstIdolId                               { get; set; }
        public int                                      MstCharacterInfoId                      { get; set; }
        public int                                      InitialStar                             { get; set; }
        public int                                      CardId                                  { get; set; }

        public static MaximumProduceIdolStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MaximumProduceIdolStatus() { Pointer= p0 };

            value.MstProduceIdolId                          = GetInt32(new IntPtr(p + 0x018)); // 0x18 MstProduceIdolId            ( ModelPrimitiveType int int int Int32 )
            value.Cost                                      = GetInt32(new IntPtr(p + 0x01C)); // 0x1C Cost                        ( ModelPrimitiveType int int int Int32 )
            value.Star                                      = GetObject<LimitedValueStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.LimitedValueStatus.FromPointer); // 0x20 Star                        ( ModelClassType LimitedValueStatus LimitedValueStatus LimitedValueStatus Pointer )
            value.EvolutionLevel                            = GetObject<LimitedValueStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.LimitedValueStatus.FromPointer); // 0x28 EvolutionLevel              ( ModelClassType LimitedValueStatus LimitedValueStatus LimitedValueStatus Pointer )
            value.IdolParameter                             = GetObject<IdolParameterStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.IdolParameterStatus.FromPointer); // 0x30 IdolParameter               ( ModelClassType IdolParameterStatus IdolParameterStatus IdolParameterStatus Pointer )
            value.IdolSkillList                             = GetObjectList<IdolSkillStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.IdolSkillStatus.FromPointer); // 0x38 IdolSkillList               ( ModelClassListType RepeatedField`1<IdolSkillStatus> RepeatedField`1<IdolSkillStatus> List<IdolSkillStatus> Pointer )
            value.ProduceIdolEventList                      = GetObjectList<ProduceIdolEventStatus>(new IntPtr(p + 0x040), ReversePrism.DataModels.ProduceIdolEventStatus.FromPointer); // 0x40 ProduceIdolEventList        ( ModelClassListType RepeatedField`1<ProduceIdolEventStatus> RepeatedField`1<ProduceIdolEventStatus> List<ProduceIdolEventStatus> Pointer )
            value.PotentialLiveSkillList                    = GetObjectList<PotentialLiveSkillStatus>(new IntPtr(p + 0x048), ReversePrism.DataModels.PotentialLiveSkillStatus.FromPointer); // 0x48 PotentialLiveSkillList      ( ModelClassListType RepeatedField`1<PotentialLiveSkillStatus> RepeatedField`1<PotentialLiveSkillStatus> List<PotentialLiveSkillStatus> Pointer )
            value.DressSetList                              = GetObjectList<ProduceIdolDressSetStatus>(new IntPtr(p + 0x050), ReversePrism.DataModels.ProduceIdolDressSetStatus.FromPointer); // 0x50 DressSetList                ( ModelClassListType RepeatedField`1<ProduceIdolDressSetStatus> RepeatedField`1<ProduceIdolDressSetStatus> List<ProduceIdolDressSetStatus> Pointer )
            value.MstUnitId                                 = GetInt32(new IntPtr(p + 0x058)); // 0x58 MstUnitId                   ( ModelPrimitiveType int int int Int32 )
            value.MstIdolId                                 = GetInt32(new IntPtr(p + 0x05C)); // 0x5C MstIdolId                   ( ModelPrimitiveType int int int Int32 )
            value.MstCharacterInfoId                        = GetInt32(new IntPtr(p + 0x060)); // 0x60 MstCharacterInfoId          ( ModelPrimitiveType int int int Int32 )
            value.InitialStar                               = GetInt32(new IntPtr(p + 0x064)); // 0x64 InitialStar                 ( ModelPrimitiveType int int int Int32 )
            value.CardId                                    = GetInt32(new IntPtr(p + 0x068)); // 0x68 CardId                      ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
