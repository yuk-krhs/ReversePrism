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
    // 018 MstProduceIdolId                         0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 CostFieldNumber                          int IL2CPP_TYPE_I4
    // 01C Cost                                     0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 StarFieldNumber                          int IL2CPP_TYPE_I4
    // 020 Star                                     00018652EBE0 ModelClassType LimitedValueStatus LimitedValueStatus LimitedValueStatus Pointer
    // 000 EvolutionLevelFieldNumber                int IL2CPP_TYPE_I4
    // 028 EvolutionLevel                           00018652EBE0 ModelClassType LimitedValueStatus LimitedValueStatus LimitedValueStatus Pointer
    // 000 IdolParameterFieldNumber                 int IL2CPP_TYPE_I4
    // 030 IdolParameter                            0001866B60B0 ModelClassType IdolParameterStatus IdolParameterStatus IdolParameterStatus Pointer
    // 000 IdolSkillListFieldNumber                 int IL2CPP_TYPE_I4
    // 008 _repeated_idolSkillList_codec            FieldCodec`1<IdolSkillStatus> IL2CPP_TYPE_GENERICINST
    // 038 IdolSkillList                            000185CE0458 ModelClassListType RepeatedField`1<IdolSkillStatus> RepeatedField`1<IdolSkillStatus> List<IdolSkillStatus> Pointer
    // 000 ProduceIdolEventListFieldNumber          int IL2CPP_TYPE_I4
    // 010 _repeated_produceIdolEventList_codec     FieldCodec`1<ProduceIdolEventStatus> IL2CPP_TYPE_GENERICINST
    // 040 ProduceIdolEventList                     000185CEBB58 ModelClassListType RepeatedField`1<ProduceIdolEventStatus> RepeatedField`1<ProduceIdolEventStatus> List<ProduceIdolEventStatus> Pointer
    // 000 PotentialLiveSkillListFieldNumber        int IL2CPP_TYPE_I4
    // 018 _repeated_potentialLiveSkillList_codec   FieldCodec`1<PotentialLiveSkillStatus> IL2CPP_TYPE_GENERICINST
    // 048 PotentialLiveSkillList                   000185CE9368 ModelClassListType RepeatedField`1<PotentialLiveSkillStatus> RepeatedField`1<PotentialLiveSkillStatus> List<PotentialLiveSkillStatus> Pointer
    // 000 DressSetListFieldNumber                  int IL2CPP_TYPE_I4
    // 020 _repeated_dressSetList_codec             FieldCodec`1<ProduceIdolDressSetStatus> IL2CPP_TYPE_GENERICINST
    // 050 DressSetList                             000185CEB928 ModelClassListType RepeatedField`1<ProduceIdolDressSetStatus> RepeatedField`1<ProduceIdolDressSetStatus> List<ProduceIdolDressSetStatus> Pointer
    // 000 MstUnitIdFieldNumber                     int IL2CPP_TYPE_I4
    // 058 MstUnitId                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 MstIdolIdFieldNumber                     int IL2CPP_TYPE_I4
    // 05C MstIdolId                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 MstCharacterInfoIdFieldNumber            int IL2CPP_TYPE_I4
    // 060 MstCharacterInfoId                       0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 InitialStarFieldNumber                   int IL2CPP_TYPE_I4
    // 064 InitialStar                              0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 CardIdFieldNumber                        int IL2CPP_TYPE_I4
    // 068 CardId                                   0001865F2AF0 ModelPrimitiveType int int int Int32
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

            value.MstProduceIdolId                          = GetInt32(new IntPtr(p + 0x018)); // 0246619BA808 0x18 MstProduceIdolId            ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Cost                                      = GetInt32(new IntPtr(p + 0x01C)); // 0246619BA848 0x1C Cost                        ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Star                                      = GetObject<LimitedValueStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.LimitedValueStatus.FromPointer); // 0246619BA888 0x20 Star                        ( 00018652EBE0 ModelClassType LimitedValueStatus LimitedValueStatus LimitedValueStatus Pointer )
            value.EvolutionLevel                            = GetObject<LimitedValueStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.LimitedValueStatus.FromPointer); // 0246619BA8C8 0x28 EvolutionLevel              ( 00018652EBE0 ModelClassType LimitedValueStatus LimitedValueStatus LimitedValueStatus Pointer )
            value.IdolParameter                             = GetObject<IdolParameterStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.IdolParameterStatus.FromPointer); // 0246619BA908 0x30 IdolParameter               ( 0001866B60B0 ModelClassType IdolParameterStatus IdolParameterStatus IdolParameterStatus Pointer )
            value.IdolSkillList                             = GetObjectList<IdolSkillStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.IdolSkillStatus.FromPointer); // 0246619BA968 0x38 IdolSkillList               ( 000185CE0458 ModelClassListType RepeatedField`1<IdolSkillStatus> RepeatedField`1<IdolSkillStatus> List<IdolSkillStatus> Pointer )
            value.ProduceIdolEventList                      = GetObjectList<ProduceIdolEventStatus>(new IntPtr(p + 0x040), ReversePrism.DataModels.ProduceIdolEventStatus.FromPointer); // 0246619BA9C8 0x40 ProduceIdolEventList        ( 000185CEBB58 ModelClassListType RepeatedField`1<ProduceIdolEventStatus> RepeatedField`1<ProduceIdolEventStatus> List<ProduceIdolEventStatus> Pointer )
            value.PotentialLiveSkillList                    = GetObjectList<PotentialLiveSkillStatus>(new IntPtr(p + 0x048), ReversePrism.DataModels.PotentialLiveSkillStatus.FromPointer); // 0246619BAA28 0x48 PotentialLiveSkillList      ( 000185CE9368 ModelClassListType RepeatedField`1<PotentialLiveSkillStatus> RepeatedField`1<PotentialLiveSkillStatus> List<PotentialLiveSkillStatus> Pointer )
            value.DressSetList                              = GetObjectList<ProduceIdolDressSetStatus>(new IntPtr(p + 0x050), ReversePrism.DataModels.ProduceIdolDressSetStatus.FromPointer); // 0246619BAA88 0x50 DressSetList                ( 000185CEB928 ModelClassListType RepeatedField`1<ProduceIdolDressSetStatus> RepeatedField`1<ProduceIdolDressSetStatus> List<ProduceIdolDressSetStatus> Pointer )
            value.MstUnitId                                 = GetInt32(new IntPtr(p + 0x058)); // 0246619BAAC8 0x58 MstUnitId                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MstIdolId                                 = GetInt32(new IntPtr(p + 0x05C)); // 0246619BAB08 0x5C MstIdolId                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MstCharacterInfoId                        = GetInt32(new IntPtr(p + 0x060)); // 0246619BAB48 0x60 MstCharacterInfoId          ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.InitialStar                               = GetInt32(new IntPtr(p + 0x064)); // 0246619BAB88 0x64 InitialStar                 ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.CardId                                    = GetInt32(new IntPtr(p + 0x068)); // 0246619BABC8 0x68 CardId                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
