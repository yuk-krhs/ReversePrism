using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<FesIdolStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 FesIdolIdFieldNumber                     int IL2CPP_TYPE_I4
    // 018 FesIdolId                                000186671910 ModelPrimitiveType string string string String
    // 000 MstProduceIdolIdFieldNumber              int IL2CPP_TYPE_I4
    // 020 MstProduceIdolId                         0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 MstFavoriteMarkIdFieldNumber             int IL2CPP_TYPE_I4
    // 024 MstFavoriteMarkId                        0001865F2AF0 ModelPrimitiveType int int int Int32
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
    // 000 TransferProductListFieldNumber           int IL2CPP_TYPE_I4
    // 008 _repeated_transferProductList_codec      FieldCodec`1<ProductWithAmountStatus> IL2CPP_TYPE_GENERICINST
    // 050 TransferProductList                      000185CECB38 ModelClassListType RepeatedField`1<ProductWithAmountStatus> RepeatedField`1<ProductWithAmountStatus> List<ProductWithAmountStatus> Pointer
    // 000 ProduceHistoryFieldNumber                int IL2CPP_TYPE_I4
    // 058 ProduceHistory                           000186545C20 ModelClassType ProduceHistoryStatus ProduceHistoryStatus ProduceHistoryStatus Pointer
    // 000 StarFieldNumber                          int IL2CPP_TYPE_I4
    // 060 Star                                     0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 InitialStarFieldNumber                   int IL2CPP_TYPE_I4
    // 064 InitialStar                              0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 CardIdFieldNumber                        int IL2CPP_TYPE_I4
    // 068 CardId                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 MstCharacterInfoIdFieldNumber            int IL2CPP_TYPE_I4
    // 06C MstCharacterInfoId                       0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 FesIdolListFieldNumber                   int IL2CPP_TYPE_I4
    // 010 _repeated_fesIdolList_codec              FieldCodec`1<FesUnitIdolStatus> IL2CPP_TYPE_GENERICINST
    // 070 FesIdolList                              000185CD8208 ModelClassListType RepeatedField`1<FesUnitIdolStatus> RepeatedField`1<FesUnitIdolStatus> List<FesUnitIdolStatus> Pointer
    public partial class FesIdolStatus
    {
        public string                                   FesIdolId                               { get; set; }
        public int                                      MstProduceIdolId                        { get; set; }
        public int                                      MstFavoriteMarkId                       { get; set; }
        public ProduceParameterStatus?                  Parameter                               { get; set; }
        public ProduceParameterRank                     Rank                                    { get; set; }
        public FesIdolUnitStatus?                       FesUnit                                 { get; set; }
        public FesIdolAttachedIdolSkillStatus?          AttachedIdolSkill                       { get; set; }
        public FesIdolAttachedPotentialLiveSkillStatus? AttachedPotentialLiveSkill              { get; set; }
        public List<ProductWithAmountStatus>?           TransferProductList                     { get; set; }
        public ProduceHistoryStatus?                    ProduceHistory                          { get; set; }
        public int                                      Star                                    { get; set; }
        public int                                      InitialStar                             { get; set; }
        public int                                      CardId                                  { get; set; }
        public int                                      MstCharacterInfoId                      { get; set; }
        public List<FesUnitIdolStatus>?                 FesIdolList                             { get; set; }

        public static FesIdolStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FesIdolStatus();

            value.FesIdolId                                 = GetString(new IntPtr(p + 0x018)); // 0270D12A9DC0 0x18 FesIdolId                   ( 000186671910 ModelPrimitiveType string string string String )
            value.MstProduceIdolId                          = GetInt32(new IntPtr(p + 0x020)); // 0270D12A9E00 0x20 MstProduceIdolId            ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MstFavoriteMarkId                         = GetInt32(new IntPtr(p + 0x024)); // 0270D12A9E40 0x24 MstFavoriteMarkId           ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Parameter                                 = GetObject<ProduceParameterStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.ProduceParameterStatus.FromPointer); // 0270D12A9E80 0x28 Parameter                   ( 0001865627F0 ModelClassType ProduceParameterStatus ProduceParameterStatus ProduceParameterStatus Pointer )
            value.Rank                                      = (ProduceParameterRank)GetInt32(new IntPtr(p + 0x030)); // 0270D12A9EC0 0x30 Rank                        ( 000186562070 ModelEnumType ProduceParameterRank ProduceParameterRank ProduceParameterRank Int32 )
            value.FesUnit                                   = GetObject<FesIdolUnitStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.FesIdolUnitStatus.FromPointer); // 0270D12A9F00 0x38 FesUnit                     ( 000186567370 ModelClassType FesIdolUnitStatus FesIdolUnitStatus FesIdolUnitStatus Pointer )
            value.AttachedIdolSkill                         = GetObject<FesIdolAttachedIdolSkillStatus>(new IntPtr(p + 0x040), ReversePrism.DataModels.FesIdolAttachedIdolSkillStatus.FromPointer); // 0270D12A9F40 0x40 AttachedIdolSkill           ( 000186560C30 ModelClassType FesIdolAttachedIdolSkillStatus FesIdolAttachedIdolSkillStatus FesIdolAttachedIdolSkillStatus Pointer )
            value.AttachedPotentialLiveSkill                = GetObject<FesIdolAttachedPotentialLiveSkillStatus>(new IntPtr(p + 0x048), ReversePrism.DataModels.FesIdolAttachedPotentialLiveSkillStatus.FromPointer); // 0270D12A9F80 0x48 AttachedPotentialLiveSkill  ( 0001865613F0 ModelClassType FesIdolAttachedPotentialLiveSkillStatus FesIdolAttachedPotentialLiveSkillStatus FesIdolAttachedPotentialLiveSkillStatus Pointer )
            value.TransferProductList                       = GetObjectList<ProductWithAmountStatus>(new IntPtr(p + 0x050), ReversePrism.DataModels.ProductWithAmountStatus.FromPointer); // 0270D12A9FE0 0x50 TransferProductList         ( 000185CECB38 ModelClassListType RepeatedField`1<ProductWithAmountStatus> RepeatedField`1<ProductWithAmountStatus> List<ProductWithAmountStatus> Pointer )
            value.ProduceHistory                            = GetObject<ProduceHistoryStatus>(new IntPtr(p + 0x058), ReversePrism.DataModels.ProduceHistoryStatus.FromPointer); // 0270D12AA020 0x58 ProduceHistory              ( 000186545C20 ModelClassType ProduceHistoryStatus ProduceHistoryStatus ProduceHistoryStatus Pointer )
            value.Star                                      = GetInt32(new IntPtr(p + 0x060)); // 0270D12AA060 0x60 Star                        ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.InitialStar                               = GetInt32(new IntPtr(p + 0x064)); // 0270D12AA0A0 0x64 InitialStar                 ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.CardId                                    = GetInt32(new IntPtr(p + 0x068)); // 0270D12AA0E0 0x68 CardId                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MstCharacterInfoId                        = GetInt32(new IntPtr(p + 0x06C)); // 0270D12AA120 0x6C MstCharacterInfoId          ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.FesIdolList                               = GetObjectList<FesUnitIdolStatus>(new IntPtr(p + 0x070), ReversePrism.DataModels.FesUnitIdolStatus.FromPointer); // 0270D12AA180 0x70 FesIdolList                 ( 000185CD8208 ModelClassListType RepeatedField`1<FesUnitIdolStatus> RepeatedField`1<FesUnitIdolStatus> List<FesUnitIdolStatus> Pointer )

            return value;
        }
    }
}
