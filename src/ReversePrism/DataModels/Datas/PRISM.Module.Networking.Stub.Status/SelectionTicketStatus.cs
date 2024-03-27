using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<SelectionTicketStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 ProductWithAmountFieldNumber             int IL2CPP_TYPE_I4
    // 018 ProductWithAmount                        0001865A6D10 ModelClassType ProductWithAmountStatus ProductWithAmountStatus ProductWithAmountStatus Pointer
    // 000 IsHavingFieldNumber                      int IL2CPP_TYPE_I4
    // 020 IsHaving                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 000 RequiredAmountFieldNumber                int IL2CPP_TYPE_I4
    // 024 RequiredAmount                           0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 IdolPieceAmountFieldNumber               int IL2CPP_TYPE_I4
    // 028 IdolPieceAmount                          0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 RainbowCrystalAmountFieldNumber          int IL2CPP_TYPE_I4
    // 02C RainbowCrystalAmount                     0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 MstSelectionTicketIdFieldNumber          int IL2CPP_TYPE_I4
    // 030 MstSelectionTicketId                     0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 MstSelectionTicketProductIdFieldNumber   int IL2CPP_TYPE_I4
    // 034 MstSelectionTicketProductId              0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 PriceProductFieldNumber                  int IL2CPP_TYPE_I4
    // 038 PriceProduct                             0001865A6D10 ModelClassType ProductWithAmountStatus ProductWithAmountStatus ProductWithAmountStatus Pointer
    // 000 ExchangeCountFieldNumber                 int IL2CPP_TYPE_I4
    // 040 ExchangeCount                            0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 ExchangeLimitCountFieldNumber            int IL2CPP_TYPE_I4
    // 044 ExchangeLimitCount                       0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 ExchangeResetTypeFieldNumber             int IL2CPP_TYPE_I4
    // 048 ExchangeResetType                        0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class SelectionTicketStatus
    {
        public ProductWithAmountStatus?                 ProductWithAmount                       { get; set; }
        public bool                                     IsHaving                                { get; set; }
        public int                                      RequiredAmount                          { get; set; }
        public int                                      IdolPieceAmount                         { get; set; }
        public int                                      RainbowCrystalAmount                    { get; set; }
        public int                                      MstSelectionTicketId                    { get; set; }
        public int                                      MstSelectionTicketProductId             { get; set; }
        public ProductWithAmountStatus?                 PriceProduct                            { get; set; }
        public int                                      ExchangeCount                           { get; set; }
        public int                                      ExchangeLimitCount                      { get; set; }
        public int                                      ExchangeResetType                       { get; set; }

        public static SelectionTicketStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SelectionTicketStatus();

            value.ProductWithAmount                         = GetObject<ProductWithAmountStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.ProductWithAmountStatus.FromPointer); // 0270D1232600 0x18 ProductWithAmount           ( 0001865A6D10 ModelClassType ProductWithAmountStatus ProductWithAmountStatus ProductWithAmountStatus Pointer )
            value.IsHaving                                  = GetBool(new IntPtr(p + 0x020)); // 0270D1232640 0x20 IsHaving                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.RequiredAmount                            = GetInt32(new IntPtr(p + 0x024)); // 0270D1232680 0x24 RequiredAmount              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.IdolPieceAmount                           = GetInt32(new IntPtr(p + 0x028)); // 0270D12326C0 0x28 IdolPieceAmount             ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.RainbowCrystalAmount                      = GetInt32(new IntPtr(p + 0x02C)); // 0270D1232700 0x2C RainbowCrystalAmount        ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MstSelectionTicketId                      = GetInt32(new IntPtr(p + 0x030)); // 0270D1232740 0x30 MstSelectionTicketId        ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MstSelectionTicketProductId               = GetInt32(new IntPtr(p + 0x034)); // 0270D1232780 0x34 MstSelectionTicketProductId ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.PriceProduct                              = GetObject<ProductWithAmountStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.ProductWithAmountStatus.FromPointer); // 0270D12327C0 0x38 PriceProduct                ( 0001865A6D10 ModelClassType ProductWithAmountStatus ProductWithAmountStatus ProductWithAmountStatus Pointer )
            value.ExchangeCount                             = GetInt32(new IntPtr(p + 0x040)); // 0270D1232800 0x40 ExchangeCount               ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ExchangeLimitCount                        = GetInt32(new IntPtr(p + 0x044)); // 0270D1232840 0x44 ExchangeLimitCount          ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ExchangeResetType                         = GetInt32(new IntPtr(p + 0x048)); // 0270D1232880 0x48 ExchangeResetType           ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
