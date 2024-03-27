using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<FesUnitStatus> IL2CPP_TYPE_GENERICINST
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
    // 008 _repeated_fesIdolList_codec              FieldCodec`1<FesUnitIdolStatus> IL2CPP_TYPE_GENERICINST
    // 048 FesIdolList                              000185CD8208 ModelClassListType RepeatedField`1<FesUnitIdolStatus> RepeatedField`1<FesUnitIdolStatus> List<FesUnitIdolStatus> Pointer
    // 000 ProduceHistoryFieldNumber                int IL2CPP_TYPE_I4
    // 050 ProduceHistory                           000186545C20 ModelClassType ProduceHistoryStatus ProduceHistoryStatus ProduceHistoryStatus Pointer
    // 000 SupportCharacterListFieldNumber          int IL2CPP_TYPE_I4
    // 010 _repeated_supportCharacterList_codec     FieldCodec`1<FesUnitSupportCharacterStatus> IL2CPP_TYPE_GENERICINST
    // 058 SupportCharacterList                     000185CD8678 ModelClassListType RepeatedField`1<FesUnitSupportCharacterStatus> RepeatedField`1<FesUnitSupportCharacterStatus> List<FesUnitSupportCharacterStatus> Pointer
    // 000 SupportSkillListFieldNumber              int IL2CPP_TYPE_I4
    // 018 _repeated_supportSkillList_codec         FieldCodec`1<FesUnitAttachedSupportSkillStatus> IL2CPP_TYPE_GENERICINST
    // 060 SupportSkillList                         000185CD7F78 ModelClassListType RepeatedField`1<FesUnitAttachedSupportSkillStatus> RepeatedField`1<FesUnitAttachedSupportSkillStatus> List<FesUnitAttachedSupportSkillStatus> Pointer
    // 000 CardDeckFieldNumber                      int IL2CPP_TYPE_I4
    // 068 CardDeck                                 000186536800 ModelClassType ProduceCardDeckStatus ProduceCardDeckStatus ProduceCardDeckStatus Pointer
    // 000 TransferProductListFieldNumber           int IL2CPP_TYPE_I4
    // 020 _repeated_transferProductList_codec      FieldCodec`1<ProductWithAmountStatus> IL2CPP_TYPE_GENERICINST
    // 070 TransferProductList                      000185CECB38 ModelClassListType RepeatedField`1<ProductWithAmountStatus> RepeatedField`1<ProductWithAmountStatus> List<ProductWithAmountStatus> Pointer
    // 000 InheritanceCountFieldNumber              int IL2CPP_TYPE_I4
    // 078 InheritanceCount                         0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class FesUnitStatus
    {
        public string                                   FesUnitId                               { get; set; }
        public int                                      MstUnitId                               { get; set; }
        public string                                   Name                                    { get; set; }
        public int                                      MstFavoriteMarkId                       { get; set; }
        public ProduceParameterStatus?                  Parameter                               { get; set; }
        public ProduceParameterRank                     Rank                                    { get; set; }
        public List<FesUnitIdolStatus>?                 FesIdolList                             { get; set; }
        public ProduceHistoryStatus?                    ProduceHistory                          { get; set; }
        public List<FesUnitSupportCharacterStatus>?     SupportCharacterList                    { get; set; }
        public List<FesUnitAttachedSupportSkillStatus>? SupportSkillList                        { get; set; }
        public ProduceCardDeckStatus?                   CardDeck                                { get; set; }
        public List<ProductWithAmountStatus>?           TransferProductList                     { get; set; }
        public int                                      InheritanceCount                        { get; set; }

        public static FesUnitStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FesUnitStatus();

            value.FesUnitId                                 = GetString(new IntPtr(p + 0x018)); // 0270D144CD38 0x18 FesUnitId                   ( 000186671910 ModelPrimitiveType string string string String )
            value.MstUnitId                                 = GetInt32(new IntPtr(p + 0x020)); // 0270D144CD78 0x20 MstUnitId                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Name                                      = GetString(new IntPtr(p + 0x028)); // 0270D144CDB8 0x28 Name                        ( 000186671910 ModelPrimitiveType string string string String )
            value.MstFavoriteMarkId                         = GetInt32(new IntPtr(p + 0x030)); // 0270D144CDF8 0x30 MstFavoriteMarkId           ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Parameter                                 = GetObject<ProduceParameterStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.ProduceParameterStatus.FromPointer); // 0270D144CE38 0x38 Parameter                   ( 0001865627F0 ModelClassType ProduceParameterStatus ProduceParameterStatus ProduceParameterStatus Pointer )
            value.Rank                                      = (ProduceParameterRank)GetInt32(new IntPtr(p + 0x040)); // 0270D144CE78 0x40 Rank                        ( 000186562070 ModelEnumType ProduceParameterRank ProduceParameterRank ProduceParameterRank Int32 )
            value.FesIdolList                               = GetObjectList<FesUnitIdolStatus>(new IntPtr(p + 0x048), ReversePrism.DataModels.FesUnitIdolStatus.FromPointer); // 0270D144CED8 0x48 FesIdolList                 ( 000185CD8208 ModelClassListType RepeatedField`1<FesUnitIdolStatus> RepeatedField`1<FesUnitIdolStatus> List<FesUnitIdolStatus> Pointer )
            value.ProduceHistory                            = GetObject<ProduceHistoryStatus>(new IntPtr(p + 0x050), ReversePrism.DataModels.ProduceHistoryStatus.FromPointer); // 0270D144CF18 0x50 ProduceHistory              ( 000186545C20 ModelClassType ProduceHistoryStatus ProduceHistoryStatus ProduceHistoryStatus Pointer )
            value.SupportCharacterList                      = GetObjectList<FesUnitSupportCharacterStatus>(new IntPtr(p + 0x058), ReversePrism.DataModels.FesUnitSupportCharacterStatus.FromPointer); // 0270D144CF78 0x58 SupportCharacterList        ( 000185CD8678 ModelClassListType RepeatedField`1<FesUnitSupportCharacterStatus> RepeatedField`1<FesUnitSupportCharacterStatus> List<FesUnitSupportCharacterStatus> Pointer )
            value.SupportSkillList                          = GetObjectList<FesUnitAttachedSupportSkillStatus>(new IntPtr(p + 0x060), ReversePrism.DataModels.FesUnitAttachedSupportSkillStatus.FromPointer); // 0270D144CFD8 0x60 SupportSkillList            ( 000185CD7F78 ModelClassListType RepeatedField`1<FesUnitAttachedSupportSkillStatus> RepeatedField`1<FesUnitAttachedSupportSkillStatus> List<FesUnitAttachedSupportSkillStatus> Pointer )
            value.CardDeck                                  = GetObject<ProduceCardDeckStatus>(new IntPtr(p + 0x068), ReversePrism.DataModels.ProduceCardDeckStatus.FromPointer); // 0270D144D018 0x68 CardDeck                    ( 000186536800 ModelClassType ProduceCardDeckStatus ProduceCardDeckStatus ProduceCardDeckStatus Pointer )
            value.TransferProductList                       = GetObjectList<ProductWithAmountStatus>(new IntPtr(p + 0x070), ReversePrism.DataModels.ProductWithAmountStatus.FromPointer); // 0270D144D078 0x70 TransferProductList         ( 000185CECB38 ModelClassListType RepeatedField`1<ProductWithAmountStatus> RepeatedField`1<ProductWithAmountStatus> List<ProductWithAmountStatus> Pointer )
            value.InheritanceCount                          = GetInt32(new IntPtr(p + 0x078)); // 0270D144D0B8 0x78 InheritanceCount            ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
