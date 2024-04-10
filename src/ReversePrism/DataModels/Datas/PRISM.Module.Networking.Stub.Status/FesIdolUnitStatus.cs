using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<FesIdolUnitStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 FesUnitIdFieldNumber                     int IL2CPP_TYPE_I4
    // 018 FesUnitId                                000186671910 ModelPrimitiveType string string string String
    // 000 MstUnitIdFieldNumber                     int IL2CPP_TYPE_I4
    // 020 MstUnitId                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 NameFieldNumber                          int IL2CPP_TYPE_I4
    // 028 Name                                     000186671910 ModelPrimitiveType string string string String
    // 000 ParameterFieldNumber                     int IL2CPP_TYPE_I4
    // 030 Parameter                                0001865627F0 ModelClassType ProduceParameterStatus ProduceParameterStatus ProduceParameterStatus Pointer
    // 000 RankFieldNumber                          int IL2CPP_TYPE_I4
    // 038 Rank                                     000186562070 ModelEnumType ProduceParameterRank ProduceParameterRank ProduceParameterRank Int32
    // 000 FesIdolListFieldNumber                   int IL2CPP_TYPE_I4
    // 008 _repeated_fesIdolList_codec              FieldCodec`1<FesUnitIdolStatus> IL2CPP_TYPE_GENERICINST
    // 040 FesIdolList                              000185CD8208 ModelClassListType RepeatedField`1<FesUnitIdolStatus> RepeatedField`1<FesUnitIdolStatus> List<FesUnitIdolStatus> Pointer
    // 000 SupportCharacterListFieldNumber          int IL2CPP_TYPE_I4
    // 010 _repeated_supportCharacterList_codec     FieldCodec`1<FesUnitSupportCharacterStatus> IL2CPP_TYPE_GENERICINST
    // 048 SupportCharacterList                     000185CD8678 ModelClassListType RepeatedField`1<FesUnitSupportCharacterStatus> RepeatedField`1<FesUnitSupportCharacterStatus> List<FesUnitSupportCharacterStatus> Pointer
    // 000 SupportSkillListFieldNumber              int IL2CPP_TYPE_I4
    // 018 _repeated_supportSkillList_codec         FieldCodec`1<FesUnitAttachedSupportSkillStatus> IL2CPP_TYPE_GENERICINST
    // 050 SupportSkillList                         000185CD7F78 ModelClassListType RepeatedField`1<FesUnitAttachedSupportSkillStatus> RepeatedField`1<FesUnitAttachedSupportSkillStatus> List<FesUnitAttachedSupportSkillStatus> Pointer
    // 000 CardDeckFieldNumber                      int IL2CPP_TYPE_I4
    // 058 CardDeck                                 000186536800 ModelClassType ProduceCardDeckStatus ProduceCardDeckStatus ProduceCardDeckStatus Pointer
    public partial class FesIdolUnitStatus : DataModel
    {
        public string                                   FesUnitId                               { get; set; }
        public int                                      MstUnitId                               { get; set; }
        public string                                   Name                                    { get; set; }
        public ProduceParameterStatus?                  Parameter                               { get; set; }
        public ProduceParameterRank                     Rank                                    { get; set; }
        public List<FesUnitIdolStatus>?                 FesIdolList                             { get; set; }
        public List<FesUnitSupportCharacterStatus>?     SupportCharacterList                    { get; set; }
        public List<FesUnitAttachedSupportSkillStatus>? SupportSkillList                        { get; set; }
        public ProduceCardDeckStatus?                   CardDeck                                { get; set; }

        public static FesIdolUnitStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FesIdolUnitStatus() { Pointer= p0 };

            value.FesUnitId                                 = GetString(new IntPtr(p + 0x018)); // 02466122AFC8 0x18 FesUnitId                   ( 000186671910 ModelPrimitiveType string string string String )
            value.MstUnitId                                 = GetInt32(new IntPtr(p + 0x020)); // 02466122B008 0x20 MstUnitId                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Name                                      = GetString(new IntPtr(p + 0x028)); // 02466122B048 0x28 Name                        ( 000186671910 ModelPrimitiveType string string string String )
            value.Parameter                                 = GetObject<ProduceParameterStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.ProduceParameterStatus.FromPointer); // 02466122B088 0x30 Parameter                   ( 0001865627F0 ModelClassType ProduceParameterStatus ProduceParameterStatus ProduceParameterStatus Pointer )
            value.Rank                                      = (ProduceParameterRank)GetInt32(new IntPtr(p + 0x038)); // 02466122B0C8 0x38 Rank                        ( 000186562070 ModelEnumType ProduceParameterRank ProduceParameterRank ProduceParameterRank Int32 )
            value.FesIdolList                               = GetObjectList<FesUnitIdolStatus>(new IntPtr(p + 0x040), ReversePrism.DataModels.FesUnitIdolStatus.FromPointer); // 02466122B128 0x40 FesIdolList                 ( 000185CD8208 ModelClassListType RepeatedField`1<FesUnitIdolStatus> RepeatedField`1<FesUnitIdolStatus> List<FesUnitIdolStatus> Pointer )
            value.SupportCharacterList                      = GetObjectList<FesUnitSupportCharacterStatus>(new IntPtr(p + 0x048), ReversePrism.DataModels.FesUnitSupportCharacterStatus.FromPointer); // 02466122B188 0x48 SupportCharacterList        ( 000185CD8678 ModelClassListType RepeatedField`1<FesUnitSupportCharacterStatus> RepeatedField`1<FesUnitSupportCharacterStatus> List<FesUnitSupportCharacterStatus> Pointer )
            value.SupportSkillList                          = GetObjectList<FesUnitAttachedSupportSkillStatus>(new IntPtr(p + 0x050), ReversePrism.DataModels.FesUnitAttachedSupportSkillStatus.FromPointer); // 02466122B1E8 0x50 SupportSkillList            ( 000185CD7F78 ModelClassListType RepeatedField`1<FesUnitAttachedSupportSkillStatus> RepeatedField`1<FesUnitAttachedSupportSkillStatus> List<FesUnitAttachedSupportSkillStatus> Pointer )
            value.CardDeck                                  = GetObject<ProduceCardDeckStatus>(new IntPtr(p + 0x058), ReversePrism.DataModels.ProduceCardDeckStatus.FromPointer); // 02466122B228 0x58 CardDeck                    ( 000186536800 ModelClassType ProduceCardDeckStatus ProduceCardDeckStatus ProduceCardDeckStatus Pointer )

            return value;
        }
    }
}
