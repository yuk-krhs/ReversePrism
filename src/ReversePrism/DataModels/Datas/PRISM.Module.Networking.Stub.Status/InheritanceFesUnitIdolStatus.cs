using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<InheritanceFesUnitIdolStatus> IL2CPP_TYPE_GENERICINST
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
    // 038 FesUnit                                  0001866EC860 ModelClassType InheritanceFesIdolUnitStatus InheritanceFesIdolUnitStatus InheritanceFesIdolUnitStatus Pointer
    // 000 AttachedIdolSkillFieldNumber             int IL2CPP_TYPE_I4
    // 040 AttachedIdolSkill                        0001866EB920 ModelClassType InheritanceFesIdolAttachedIdolSkillStatus InheritanceFesIdolAttachedIdolSkillStatus InheritanceFesIdolAttachedIdolSkillStatus Pointer
    // 000 AttachedPotentialLiveSkillFieldNumber    int IL2CPP_TYPE_I4
    // 048 AttachedPotentialLiveSkill               0001866EC0F0 ModelClassType InheritanceFesIdolAttachedPotentialLiveSkillStatus InheritanceFesIdolAttachedPotentialLiveSkillStatus InheritanceFesIdolAttachedPotentialLiveSkillStatus Pointer
    // 000 StarFieldNumber                          int IL2CPP_TYPE_I4
    // 050 Star                                     0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 InitialStarFieldNumber                   int IL2CPP_TYPE_I4
    // 054 InitialStar                              0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 CardIdFieldNumber                        int IL2CPP_TYPE_I4
    // 058 CardId                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 MstCharacterInfoIdFieldNumber            int IL2CPP_TYPE_I4
    // 05C MstCharacterInfoId                       0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class InheritanceFesUnitIdolStatus : DataModel
    {
        public string                                   FesIdolId                               { get; set; }
        public int                                      MstProduceIdolId                        { get; set; }
        public ProduceParameterStatus?                  Parameter                               { get; set; }
        public ProduceParameterRank                     Rank                                    { get; set; }
        public InheritanceFesIdolUnitStatus?            FesUnit                                 { get; set; }
        public InheritanceFesIdolAttachedIdolSkillStatus? AttachedIdolSkill                       { get; set; }
        public InheritanceFesIdolAttachedPotentialLiveSkillStatus? AttachedPotentialLiveSkill              { get; set; }
        public int                                      Star                                    { get; set; }
        public int                                      InitialStar                             { get; set; }
        public int                                      CardId                                  { get; set; }
        public int                                      MstCharacterInfoId                      { get; set; }

        public static InheritanceFesUnitIdolStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InheritanceFesUnitIdolStatus() { Pointer= p0 };

            value.FesIdolId                                 = GetString(new IntPtr(p + 0x018)); // 0246610742D0 0x18 FesIdolId                   ( 000186671910 ModelPrimitiveType string string string String )
            value.MstProduceIdolId                          = GetInt32(new IntPtr(p + 0x020)); // 024661074310 0x20 MstProduceIdolId            ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Parameter                                 = GetObject<ProduceParameterStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.ProduceParameterStatus.FromPointer); // 024661074350 0x28 Parameter                   ( 0001865627F0 ModelClassType ProduceParameterStatus ProduceParameterStatus ProduceParameterStatus Pointer )
            value.Rank                                      = (ProduceParameterRank)GetInt32(new IntPtr(p + 0x030)); // 024661074390 0x30 Rank                        ( 000186562070 ModelEnumType ProduceParameterRank ProduceParameterRank ProduceParameterRank Int32 )
            value.FesUnit                                   = GetObject<InheritanceFesIdolUnitStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.InheritanceFesIdolUnitStatus.FromPointer); // 0246610743D0 0x38 FesUnit                     ( 0001866EC860 ModelClassType InheritanceFesIdolUnitStatus InheritanceFesIdolUnitStatus InheritanceFesIdolUnitStatus Pointer )
            value.AttachedIdolSkill                         = GetObject<InheritanceFesIdolAttachedIdolSkillStatus>(new IntPtr(p + 0x040), ReversePrism.DataModels.InheritanceFesIdolAttachedIdolSkillStatus.FromPointer); // 024661074410 0x40 AttachedIdolSkill           ( 0001866EB920 ModelClassType InheritanceFesIdolAttachedIdolSkillStatus InheritanceFesIdolAttachedIdolSkillStatus InheritanceFesIdolAttachedIdolSkillStatus Pointer )
            value.AttachedPotentialLiveSkill                = GetObject<InheritanceFesIdolAttachedPotentialLiveSkillStatus>(new IntPtr(p + 0x048), ReversePrism.DataModels.InheritanceFesIdolAttachedPotentialLiveSkillStatus.FromPointer); // 024661074450 0x48 AttachedPotentialLiveSkill  ( 0001866EC0F0 ModelClassType InheritanceFesIdolAttachedPotentialLiveSkillStatus InheritanceFesIdolAttachedPotentialLiveSkillStatus InheritanceFesIdolAttachedPotentialLiveSkillStatus Pointer )
            value.Star                                      = GetInt32(new IntPtr(p + 0x050)); // 024661074490 0x50 Star                        ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.InitialStar                               = GetInt32(new IntPtr(p + 0x054)); // 0246610744D0 0x54 InitialStar                 ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.CardId                                    = GetInt32(new IntPtr(p + 0x058)); // 024661074510 0x58 CardId                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MstCharacterInfoId                        = GetInt32(new IntPtr(p + 0x05C)); // 024661074550 0x5C MstCharacterInfoId          ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
