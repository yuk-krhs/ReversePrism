using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<FesUnitIdolStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 FesIdolIdFieldNumber                     int IL2CPP_TYPE_I4
    // 018 FesIdolId                                000186671910 ModelPrimitiveType string string string String
    // 000 MstProduceIdolIdFieldNumber              int IL2CPP_TYPE_I4
    // 020 MstProduceIdolId                         0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 ParameterFieldNumber                     int IL2CPP_TYPE_I4
    // 028 Parameter                                0001865627F0 ModelClassType ProduceParameterStatus ProduceParameterStatus ProduceParameterStatus Pointer
    // 000 RankFieldNumber                          int IL2CPP_TYPE_I4
    // 030 Rank                                     000186562070 ModelEnumType ProduceParameterRank ProduceParameterRank ProduceParameterRank Int32
    // 000 FesUnitFieldNumber                       int IL2CPP_TYPE_I4
    // 038 FesUnit                                  000186567370 ModelClassType FesIdolUnitStatus FesIdolUnitStatus FesIdolUnitStatus Pointer
    // 000 AttachedIdolSkillFieldNumber             int IL2CPP_TYPE_I4
    // 040 AttachedIdolSkill                        000186560C30 ModelClassType FesIdolAttachedIdolSkillStatus FesIdolAttachedIdolSkillStatus FesIdolAttachedIdolSkillStatus Pointer
    // 000 AttachedPotentialLiveSkillFieldNumber    int IL2CPP_TYPE_I4
    // 048 AttachedPotentialLiveSkill               0001865613F0 ModelClassType FesIdolAttachedPotentialLiveSkillStatus FesIdolAttachedPotentialLiveSkillStatus FesIdolAttachedPotentialLiveSkillStatus Pointer
    // 000 StarFieldNumber                          int IL2CPP_TYPE_I4
    // 050 Star                                     0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 InitialStarFieldNumber                   int IL2CPP_TYPE_I4
    // 054 InitialStar                              0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 CardIdFieldNumber                        int IL2CPP_TYPE_I4
    // 058 CardId                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 MstCharacterInfoIdFieldNumber            int IL2CPP_TYPE_I4
    // 05C MstCharacterInfoId                       0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class FesUnitIdolStatus : DataModel
    {
        public string                                   FesIdolId                               { get; set; }
        public int                                      MstProduceIdolId                        { get; set; }
        public ProduceParameterStatus?                  Parameter                               { get; set; }
        public ProduceParameterRank                     Rank                                    { get; set; }
        public FesIdolUnitStatus?                       FesUnit                                 { get; set; }
        public FesIdolAttachedIdolSkillStatus?          AttachedIdolSkill                       { get; set; }
        public FesIdolAttachedPotentialLiveSkillStatus? AttachedPotentialLiveSkill              { get; set; }
        public int                                      Star                                    { get; set; }
        public int                                      InitialStar                             { get; set; }
        public int                                      CardId                                  { get; set; }
        public int                                      MstCharacterInfoId                      { get; set; }

        public static FesUnitIdolStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FesUnitIdolStatus() { Pointer= p0 };

            value.FesIdolId                                 = GetString(new IntPtr(p + 0x018)); // 02466122DC90 0x18 FesIdolId                   ( 000186671910 ModelPrimitiveType string string string String )
            value.MstProduceIdolId                          = GetInt32(new IntPtr(p + 0x020)); // 02466122DCD0 0x20 MstProduceIdolId            ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Parameter                                 = GetObject<ProduceParameterStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.ProduceParameterStatus.FromPointer); // 02466122DD10 0x28 Parameter                   ( 0001865627F0 ModelClassType ProduceParameterStatus ProduceParameterStatus ProduceParameterStatus Pointer )
            value.Rank                                      = (ProduceParameterRank)GetInt32(new IntPtr(p + 0x030)); // 02466122DD50 0x30 Rank                        ( 000186562070 ModelEnumType ProduceParameterRank ProduceParameterRank ProduceParameterRank Int32 )
            value.FesUnit                                   = GetObject<FesIdolUnitStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.FesIdolUnitStatus.FromPointer); // 02466122DD90 0x38 FesUnit                     ( 000186567370 ModelClassType FesIdolUnitStatus FesIdolUnitStatus FesIdolUnitStatus Pointer )
            value.AttachedIdolSkill                         = GetObject<FesIdolAttachedIdolSkillStatus>(new IntPtr(p + 0x040), ReversePrism.DataModels.FesIdolAttachedIdolSkillStatus.FromPointer); // 02466122DDD0 0x40 AttachedIdolSkill           ( 000186560C30 ModelClassType FesIdolAttachedIdolSkillStatus FesIdolAttachedIdolSkillStatus FesIdolAttachedIdolSkillStatus Pointer )
            value.AttachedPotentialLiveSkill                = GetObject<FesIdolAttachedPotentialLiveSkillStatus>(new IntPtr(p + 0x048), ReversePrism.DataModels.FesIdolAttachedPotentialLiveSkillStatus.FromPointer); // 02466122DE10 0x48 AttachedPotentialLiveSkill  ( 0001865613F0 ModelClassType FesIdolAttachedPotentialLiveSkillStatus FesIdolAttachedPotentialLiveSkillStatus FesIdolAttachedPotentialLiveSkillStatus Pointer )
            value.Star                                      = GetInt32(new IntPtr(p + 0x050)); // 02466122DE50 0x50 Star                        ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.InitialStar                               = GetInt32(new IntPtr(p + 0x054)); // 02466122DE90 0x54 InitialStar                 ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.CardId                                    = GetInt32(new IntPtr(p + 0x058)); // 02466122DED0 0x58 CardId                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MstCharacterInfoId                        = GetInt32(new IntPtr(p + 0x05C)); // 02466122DF10 0x5C MstCharacterInfoId          ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
