using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<InheritanceFesIdolUnitStatus> IL2CPP_TYPE_GENERICINST
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
    // 008 _repeated_fesIdolList_codec              FieldCodec`1<InheritanceFesUnitIdolStatus> IL2CPP_TYPE_GENERICINST
    // 040 FesIdolList                              000185CE1628 ModelClassListType RepeatedField`1<InheritanceFesUnitIdolStatus> RepeatedField`1<InheritanceFesUnitIdolStatus> List<InheritanceFesUnitIdolStatus> Pointer
    // 000 SupportCharacterListFieldNumber          int IL2CPP_TYPE_I4
    // 010 _repeated_supportCharacterList_codec     FieldCodec`1<InheritanceFesUnitSupportCharacterStatus> IL2CPP_TYPE_GENERICINST
    // 048 SupportCharacterList                     000185CE1868 ModelClassListType RepeatedField`1<InheritanceFesUnitSupportCharacterStatus> RepeatedField`1<InheritanceFesUnitSupportCharacterStatus> List<InheritanceFesUnitSupportCharacterStatus> Pointer
    // 000 SupportSkillListFieldNumber              int IL2CPP_TYPE_I4
    // 018 _repeated_supportSkillList_codec         FieldCodec`1<InheritanceFesUnitAttachedSupportSkillStatus> IL2CPP_TYPE_GENERICINST
    // 050 SupportSkillList                         000185CE13E8 ModelClassListType RepeatedField`1<InheritanceFesUnitAttachedSupportSkillStatus> RepeatedField`1<InheritanceFesUnitAttachedSupportSkillStatus> List<InheritanceFesUnitAttachedSupportSkillStatus> Pointer
    // 000 CardDeckFieldNumber                      int IL2CPP_TYPE_I4
    // 058 CardDeck                                 000186536800 ModelClassType ProduceCardDeckStatus ProduceCardDeckStatus ProduceCardDeckStatus Pointer
    public partial class InheritanceFesIdolUnitStatus
    {
        public string                                   FesUnitId                               { get; set; }
        public int                                      MstUnitId                               { get; set; }
        public string                                   Name                                    { get; set; }
        public ProduceParameterStatus?                  Parameter                               { get; set; }
        public ProduceParameterRank                     Rank                                    { get; set; }
        public List<InheritanceFesUnitIdolStatus>?      FesIdolList                             { get; set; }
        public List<InheritanceFesUnitSupportCharacterStatus>? SupportCharacterList                    { get; set; }
        public List<InheritanceFesUnitAttachedSupportSkillStatus>? SupportSkillList                        { get; set; }
        public ProduceCardDeckStatus?                   CardDeck                                { get; set; }

        public static InheritanceFesIdolUnitStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InheritanceFesIdolUnitStatus();

            value.FesUnitId                                 = GetString(new IntPtr(p + 0x018)); // 0270D10E5EE0 0x18 FesUnitId                   ( 000186671910 ModelPrimitiveType string string string String )
            value.MstUnitId                                 = GetInt32(new IntPtr(p + 0x020)); // 0270D10E5F20 0x20 MstUnitId                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Name                                      = GetString(new IntPtr(p + 0x028)); // 0270D10E5F60 0x28 Name                        ( 000186671910 ModelPrimitiveType string string string String )
            value.Parameter                                 = GetObject<ProduceParameterStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.ProduceParameterStatus.FromPointer); // 0270D10E5FA0 0x30 Parameter                   ( 0001865627F0 ModelClassType ProduceParameterStatus ProduceParameterStatus ProduceParameterStatus Pointer )
            value.Rank                                      = (ProduceParameterRank)GetInt32(new IntPtr(p + 0x038)); // 0270D10E5FE0 0x38 Rank                        ( 000186562070 ModelEnumType ProduceParameterRank ProduceParameterRank ProduceParameterRank Int32 )
            value.FesIdolList                               = GetObjectList<InheritanceFesUnitIdolStatus>(new IntPtr(p + 0x040), ReversePrism.DataModels.InheritanceFesUnitIdolStatus.FromPointer); // 0270D10E6040 0x40 FesIdolList                 ( 000185CE1628 ModelClassListType RepeatedField`1<InheritanceFesUnitIdolStatus> RepeatedField`1<InheritanceFesUnitIdolStatus> List<InheritanceFesUnitIdolStatus> Pointer )
            value.SupportCharacterList                      = GetObjectList<InheritanceFesUnitSupportCharacterStatus>(new IntPtr(p + 0x048), ReversePrism.DataModels.InheritanceFesUnitSupportCharacterStatus.FromPointer); // 0270D10E60A0 0x48 SupportCharacterList        ( 000185CE1868 ModelClassListType RepeatedField`1<InheritanceFesUnitSupportCharacterStatus> RepeatedField`1<InheritanceFesUnitSupportCharacterStatus> List<InheritanceFesUnitSupportCharacterStatus> Pointer )
            value.SupportSkillList                          = GetObjectList<InheritanceFesUnitAttachedSupportSkillStatus>(new IntPtr(p + 0x050), ReversePrism.DataModels.InheritanceFesUnitAttachedSupportSkillStatus.FromPointer); // 0270D10E6100 0x50 SupportSkillList            ( 000185CE13E8 ModelClassListType RepeatedField`1<InheritanceFesUnitAttachedSupportSkillStatus> RepeatedField`1<InheritanceFesUnitAttachedSupportSkillStatus> List<InheritanceFesUnitAttachedSupportSkillStatus> Pointer )
            value.CardDeck                                  = GetObject<ProduceCardDeckStatus>(new IntPtr(p + 0x058), ReversePrism.DataModels.ProduceCardDeckStatus.FromPointer); // 0270D10E6140 0x58 CardDeck                    ( 000186536800 ModelClassType ProduceCardDeckStatus ProduceCardDeckStatus ProduceCardDeckStatus Pointer )

            return value;
        }
    }
}
