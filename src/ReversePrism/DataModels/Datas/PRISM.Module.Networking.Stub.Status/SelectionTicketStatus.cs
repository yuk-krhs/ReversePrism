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
    // 018 ProductWithAmount                        ModelClassType ProductWithAmountStatus ProductWithAmountStatus ProductWithAmountStatus Pointer
    // 000 IsHavingFieldNumber                      int IL2CPP_TYPE_I4
    // 020 IsHaving                                 ModelPrimitiveType bool bool bool Bool
    // 000 RequiredAmountFieldNumber                int IL2CPP_TYPE_I4
    // 024 RequiredAmount                           ModelPrimitiveType int int int Int32
    // 000 IdolPieceAmountFieldNumber               int IL2CPP_TYPE_I4
    // 028 IdolPieceAmount                          ModelPrimitiveType int int int Int32
    // 000 RainbowCrystalAmountFieldNumber          int IL2CPP_TYPE_I4
    // 02C RainbowCrystalAmount                     ModelPrimitiveType int int int Int32
    // 000 MstSelectionTicketIdFieldNumber          int IL2CPP_TYPE_I4
    // 030 MstSelectionTicketId                     ModelPrimitiveType int int int Int32
    // 000 MstSelectionTicketProductIdFieldNumber   int IL2CPP_TYPE_I4
    // 034 MstSelectionTicketProductId              ModelPrimitiveType int int int Int32
    // 000 PriceProductFieldNumber                  int IL2CPP_TYPE_I4
    // 038 PriceProduct                             ModelClassType ProductWithAmountStatus ProductWithAmountStatus ProductWithAmountStatus Pointer
    // 000 ExchangeCountFieldNumber                 int IL2CPP_TYPE_I4
    // 040 ExchangeCount                            ModelPrimitiveType int int int Int32
    // 000 ExchangeLimitCountFieldNumber            int IL2CPP_TYPE_I4
    // 044 ExchangeLimitCount                       ModelPrimitiveType int int int Int32
    // 000 ExchangeResetTypeFieldNumber             int IL2CPP_TYPE_I4
    // 048 ExchangeResetType                        ModelPrimitiveType int int int Int32
    // 000 IsAlreadyHavingFieldNumber               int IL2CPP_TYPE_I4
    // 04C IsAlreadyHaving                          ModelPrimitiveType bool bool bool Bool
    public partial class SelectionTicketStatus : DataModel
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
        public bool                                     IsAlreadyHaving                         { get; set; }

        public static SelectionTicketStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SelectionTicketStatus() { Pointer= p0 };

            value.ProductWithAmount                         = GetObject<ProductWithAmountStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.ProductWithAmountStatus.FromPointer); // 0x18 ProductWithAmount           ( ModelClassType ProductWithAmountStatus ProductWithAmountStatus ProductWithAmountStatus Pointer )
            value.IsHaving                                  = GetBool(new IntPtr(p + 0x020)); // 0x20 IsHaving                    ( ModelPrimitiveType bool bool bool Bool )
            value.RequiredAmount                            = GetInt32(new IntPtr(p + 0x024)); // 0x24 RequiredAmount              ( ModelPrimitiveType int int int Int32 )
            value.IdolPieceAmount                           = GetInt32(new IntPtr(p + 0x028)); // 0x28 IdolPieceAmount             ( ModelPrimitiveType int int int Int32 )
            value.RainbowCrystalAmount                      = GetInt32(new IntPtr(p + 0x02C)); // 0x2C RainbowCrystalAmount        ( ModelPrimitiveType int int int Int32 )
            value.MstSelectionTicketId                      = GetInt32(new IntPtr(p + 0x030)); // 0x30 MstSelectionTicketId        ( ModelPrimitiveType int int int Int32 )
            value.MstSelectionTicketProductId               = GetInt32(new IntPtr(p + 0x034)); // 0x34 MstSelectionTicketProductId ( ModelPrimitiveType int int int Int32 )
            value.PriceProduct                              = GetObject<ProductWithAmountStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.ProductWithAmountStatus.FromPointer); // 0x38 PriceProduct                ( ModelClassType ProductWithAmountStatus ProductWithAmountStatus ProductWithAmountStatus Pointer )
            value.ExchangeCount                             = GetInt32(new IntPtr(p + 0x040)); // 0x40 ExchangeCount               ( ModelPrimitiveType int int int Int32 )
            value.ExchangeLimitCount                        = GetInt32(new IntPtr(p + 0x044)); // 0x44 ExchangeLimitCount          ( ModelPrimitiveType int int int Int32 )
            value.ExchangeResetType                         = GetInt32(new IntPtr(p + 0x048)); // 0x48 ExchangeResetType           ( ModelPrimitiveType int int int Int32 )
            value.IsAlreadyHaving                           = GetBool(new IntPtr(p + 0x04C)); // 0x4C IsAlreadyHaving             ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
