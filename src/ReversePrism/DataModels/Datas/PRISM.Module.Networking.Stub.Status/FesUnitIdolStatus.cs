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
    // 018 FesIdolId                                ModelPrimitiveType string string string String
    // 000 MstProduceIdolIdFieldNumber              int IL2CPP_TYPE_I4
    // 020 MstProduceIdolId                         ModelPrimitiveType int int int Int32
    // 000 ParameterFieldNumber                     int IL2CPP_TYPE_I4
    // 028 Parameter                                ModelClassType ProduceParameterStatus ProduceParameterStatus ProduceParameterStatus Pointer
    // 000 RankFieldNumber                          int IL2CPP_TYPE_I4
    // 030 Rank                                     ModelEnumType ProduceParameterRank ProduceParameterRank ProduceParameterRank Int32
    // 000 FesUnitFieldNumber                       int IL2CPP_TYPE_I4
    // 038 FesUnit                                  ModelClassType FesIdolUnitStatus FesIdolUnitStatus FesIdolUnitStatus Pointer
    // 000 AttachedIdolSkillFieldNumber             int IL2CPP_TYPE_I4
    // 040 AttachedIdolSkill                        ModelClassType FesIdolAttachedIdolSkillStatus FesIdolAttachedIdolSkillStatus FesIdolAttachedIdolSkillStatus Pointer
    // 000 AttachedPotentialLiveSkillFieldNumber    int IL2CPP_TYPE_I4
    // 048 AttachedPotentialLiveSkill               ModelClassType FesIdolAttachedPotentialLiveSkillStatus FesIdolAttachedPotentialLiveSkillStatus FesIdolAttachedPotentialLiveSkillStatus Pointer
    // 000 StarFieldNumber                          int IL2CPP_TYPE_I4
    // 050 Star                                     ModelPrimitiveType int int int Int32
    // 000 InitialStarFieldNumber                   int IL2CPP_TYPE_I4
    // 054 InitialStar                              ModelPrimitiveType int int int Int32
    // 000 CardIdFieldNumber                        int IL2CPP_TYPE_I4
    // 058 CardId                                   ModelPrimitiveType int int int Int32
    // 000 MstCharacterInfoIdFieldNumber            int IL2CPP_TYPE_I4
    // 05C MstCharacterInfoId                       ModelPrimitiveType int int int Int32
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

            value.FesIdolId                                 = GetString(new IntPtr(p + 0x018)); // 0x18 FesIdolId                   ( ModelPrimitiveType string string string String )
            value.MstProduceIdolId                          = GetInt32(new IntPtr(p + 0x020)); // 0x20 MstProduceIdolId            ( ModelPrimitiveType int int int Int32 )
            value.Parameter                                 = GetObject<ProduceParameterStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.ProduceParameterStatus.FromPointer); // 0x28 Parameter                   ( ModelClassType ProduceParameterStatus ProduceParameterStatus ProduceParameterStatus Pointer )
            value.Rank                                      = (ProduceParameterRank)GetInt32(new IntPtr(p + 0x030)); // 0x30 Rank                        ( ModelEnumType ProduceParameterRank ProduceParameterRank ProduceParameterRank Int32 )
            value.FesUnit                                   = GetObject<FesIdolUnitStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.FesIdolUnitStatus.FromPointer); // 0x38 FesUnit                     ( ModelClassType FesIdolUnitStatus FesIdolUnitStatus FesIdolUnitStatus Pointer )
            value.AttachedIdolSkill                         = GetObject<FesIdolAttachedIdolSkillStatus>(new IntPtr(p + 0x040), ReversePrism.DataModels.FesIdolAttachedIdolSkillStatus.FromPointer); // 0x40 AttachedIdolSkill           ( ModelClassType FesIdolAttachedIdolSkillStatus FesIdolAttachedIdolSkillStatus FesIdolAttachedIdolSkillStatus Pointer )
            value.AttachedPotentialLiveSkill                = GetObject<FesIdolAttachedPotentialLiveSkillStatus>(new IntPtr(p + 0x048), ReversePrism.DataModels.FesIdolAttachedPotentialLiveSkillStatus.FromPointer); // 0x48 AttachedPotentialLiveSkill  ( ModelClassType FesIdolAttachedPotentialLiveSkillStatus FesIdolAttachedPotentialLiveSkillStatus FesIdolAttachedPotentialLiveSkillStatus Pointer )
            value.Star                                      = GetInt32(new IntPtr(p + 0x050)); // 0x50 Star                        ( ModelPrimitiveType int int int Int32 )
            value.InitialStar                               = GetInt32(new IntPtr(p + 0x054)); // 0x54 InitialStar                 ( ModelPrimitiveType int int int Int32 )
            value.CardId                                    = GetInt32(new IntPtr(p + 0x058)); // 0x58 CardId                      ( ModelPrimitiveType int int int Int32 )
            value.MstCharacterInfoId                        = GetInt32(new IntPtr(p + 0x05C)); // 0x5C MstCharacterInfoId          ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
