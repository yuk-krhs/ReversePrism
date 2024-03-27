using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<InheritanceFesUnitStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 FesUnitIdFieldNumber                     int IL2CPP_TYPE_I4
    // 018 FesUnitId                                000186671910 ModelPrimitiveType string string string String
    // 000 MstUnitIdFieldNumber                     int IL2CPP_TYPE_I4
    // 020 MstUnitId                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 NameFieldNumber                          int IL2CPP_TYPE_I4
    // 028 Name                                     000186671910 ModelPrimitiveType string string string String
    // 000 MstFavoriteMarkIdFieldNumber             int IL2CPP_TYPE_I4
    // 030 MstFavoriteMarkId                        0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 ParameterFieldNumber                     int IL2CPP_TYPE_I4
    // 038 Parameter                                0001865627F0 ModelClassType ProduceParameterStatus ProduceParameterStatus ProduceParameterStatus Pointer
    // 000 RankFieldNumber                          int IL2CPP_TYPE_I4
    // 040 Rank                                     000186562070 ModelEnumType ProduceParameterRank ProduceParameterRank ProduceParameterRank Int32
    // 000 FesIdolListFieldNumber                   int IL2CPP_TYPE_I4
    // 008 _repeated_fesIdolList_codec              FieldCodec`1<InheritanceFesUnitIdolStatus> IL2CPP_TYPE_GENERICINST
    // 048 FesIdolList                              000185CE1628 ModelClassListType RepeatedField`1<InheritanceFesUnitIdolStatus> RepeatedField`1<InheritanceFesUnitIdolStatus> List<InheritanceFesUnitIdolStatus> Pointer
    // 000 ProduceHistoryFieldNumber                int IL2CPP_TYPE_I4
    // 050 ProduceHistory                           0001866EE550 ModelClassType InheritanceProduceHistoryStatus InheritanceProduceHistoryStatus InheritanceProduceHistoryStatus Pointer
    // 000 SupportCharacterListFieldNumber          int IL2CPP_TYPE_I4
    // 010 _repeated_supportCharacterList_codec     FieldCodec`1<InheritanceFesUnitSupportCharacterStatus> IL2CPP_TYPE_GENERICINST
    // 058 SupportCharacterList                     000185CE1868 ModelClassListType RepeatedField`1<InheritanceFesUnitSupportCharacterStatus> RepeatedField`1<InheritanceFesUnitSupportCharacterStatus> List<InheritanceFesUnitSupportCharacterStatus> Pointer
    // 000 SupportSkillListFieldNumber              int IL2CPP_TYPE_I4
    // 018 _repeated_supportSkillList_codec         FieldCodec`1<InheritanceFesUnitAttachedSupportSkillStatus> IL2CPP_TYPE_GENERICINST
    // 060 SupportSkillList                         000185CE13E8 ModelClassListType RepeatedField`1<InheritanceFesUnitAttachedSupportSkillStatus> RepeatedField`1<InheritanceFesUnitAttachedSupportSkillStatus> List<InheritanceFesUnitAttachedSupportSkillStatus> Pointer
    // 000 CardDeckFieldNumber                      int IL2CPP_TYPE_I4
    // 068 CardDeck                                 000186536800 ModelClassType ProduceCardDeckStatus ProduceCardDeckStatus ProduceCardDeckStatus Pointer
    // 000 TransferProductListFieldNumber           int IL2CPP_TYPE_I4
    // 020 _repeated_transferProductList_codec      FieldCodec`1<ProductWithAmountStatus> IL2CPP_TYPE_GENERICINST
    // 070 TransferProductList                      000185CECB38 ModelClassListType RepeatedField`1<ProductWithAmountStatus> RepeatedField`1<ProductWithAmountStatus> List<ProductWithAmountStatus> Pointer
    // 000 InheritanceCountFieldNumber              int IL2CPP_TYPE_I4
    // 078 InheritanceCount                         0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class InheritanceFesUnitStatus
    {
        public string                                   FesUnitId                               { get; set; }
        public int                                      MstUnitId                               { get; set; }
        public string                                   Name                                    { get; set; }
        public int                                      MstFavoriteMarkId                       { get; set; }
        public ProduceParameterStatus?                  Parameter                               { get; set; }
        public ProduceParameterRank                     Rank                                    { get; set; }
        public List<InheritanceFesUnitIdolStatus>?      FesIdolList                             { get; set; }
        public InheritanceProduceHistoryStatus?         ProduceHistory                          { get; set; }
        public List<InheritanceFesUnitSupportCharacterStatus>? SupportCharacterList                    { get; set; }
        public List<InheritanceFesUnitAttachedSupportSkillStatus>? SupportSkillList                        { get; set; }
        public ProduceCardDeckStatus?                   CardDeck                                { get; set; }
        public List<ProductWithAmountStatus>?           TransferProductList                     { get; set; }
        public int                                      InheritanceCount                        { get; set; }

        public static InheritanceFesUnitStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InheritanceFesUnitStatus();

            value.FesUnitId                                 = GetString(new IntPtr(p + 0x018)); // 0270D10EBCD0 0x18 FesUnitId                   ( 000186671910 ModelPrimitiveType string string string String )
            value.MstUnitId                                 = GetInt32(new IntPtr(p + 0x020)); // 0270D10EBD10 0x20 MstUnitId                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Name                                      = GetString(new IntPtr(p + 0x028)); // 0270D10EBD50 0x28 Name                        ( 000186671910 ModelPrimitiveType string string string String )
            value.MstFavoriteMarkId                         = GetInt32(new IntPtr(p + 0x030)); // 0270D10EBD90 0x30 MstFavoriteMarkId           ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Parameter                                 = GetObject<ProduceParameterStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.ProduceParameterStatus.FromPointer); // 0270D10EBDD0 0x38 Parameter                   ( 0001865627F0 ModelClassType ProduceParameterStatus ProduceParameterStatus ProduceParameterStatus Pointer )
            value.Rank                                      = (ProduceParameterRank)GetInt32(new IntPtr(p + 0x040)); // 0270D10EBE10 0x40 Rank                        ( 000186562070 ModelEnumType ProduceParameterRank ProduceParameterRank ProduceParameterRank Int32 )
            value.FesIdolList                               = GetObjectList<InheritanceFesUnitIdolStatus>(new IntPtr(p + 0x048), ReversePrism.DataModels.InheritanceFesUnitIdolStatus.FromPointer); // 0270D10EBE70 0x48 FesIdolList                 ( 000185CE1628 ModelClassListType RepeatedField`1<InheritanceFesUnitIdolStatus> RepeatedField`1<InheritanceFesUnitIdolStatus> List<InheritanceFesUnitIdolStatus> Pointer )
            value.ProduceHistory                            = GetObject<InheritanceProduceHistoryStatus>(new IntPtr(p + 0x050), ReversePrism.DataModels.InheritanceProduceHistoryStatus.FromPointer); // 0270D10EBEB0 0x50 ProduceHistory              ( 0001866EE550 ModelClassType InheritanceProduceHistoryStatus InheritanceProduceHistoryStatus InheritanceProduceHistoryStatus Pointer )
            value.SupportCharacterList                      = GetObjectList<InheritanceFesUnitSupportCharacterStatus>(new IntPtr(p + 0x058), ReversePrism.DataModels.InheritanceFesUnitSupportCharacterStatus.FromPointer); // 0270D10EBF10 0x58 SupportCharacterList        ( 000185CE1868 ModelClassListType RepeatedField`1<InheritanceFesUnitSupportCharacterStatus> RepeatedField`1<InheritanceFesUnitSupportCharacterStatus> List<InheritanceFesUnitSupportCharacterStatus> Pointer )
            value.SupportSkillList                          = GetObjectList<InheritanceFesUnitAttachedSupportSkillStatus>(new IntPtr(p + 0x060), ReversePrism.DataModels.InheritanceFesUnitAttachedSupportSkillStatus.FromPointer); // 0270D10EBF70 0x60 SupportSkillList            ( 000185CE13E8 ModelClassListType RepeatedField`1<InheritanceFesUnitAttachedSupportSkillStatus> RepeatedField`1<InheritanceFesUnitAttachedSupportSkillStatus> List<InheritanceFesUnitAttachedSupportSkillStatus> Pointer )
            value.CardDeck                                  = GetObject<ProduceCardDeckStatus>(new IntPtr(p + 0x068), ReversePrism.DataModels.ProduceCardDeckStatus.FromPointer); // 0270D10EBFB0 0x68 CardDeck                    ( 000186536800 ModelClassType ProduceCardDeckStatus ProduceCardDeckStatus ProduceCardDeckStatus Pointer )
            value.TransferProductList                       = GetObjectList<ProductWithAmountStatus>(new IntPtr(p + 0x070), ReversePrism.DataModels.ProductWithAmountStatus.FromPointer); // 0270D10EC010 0x70 TransferProductList         ( 000185CECB38 ModelClassListType RepeatedField`1<ProductWithAmountStatus> RepeatedField`1<ProductWithAmountStatus> List<ProductWithAmountStatus> Pointer )
            value.InheritanceCount                          = GetInt32(new IntPtr(p + 0x078)); // 0270D10EC050 0x78 InheritanceCount            ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
