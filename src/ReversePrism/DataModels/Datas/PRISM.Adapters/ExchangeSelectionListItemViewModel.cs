using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 PieceLabelNotHavingTextKey               int IL2CPP_TYPE_I4
    // 000 PieceLabelHavingTextKey                  int IL2CPP_TYPE_I4
    // 020 ExchangeIdolProductName                  000186671910 ModelPrimitiveType string string string String
    // 028 RainbowCrystalProductName                000186671910 ModelPrimitiveType string string string String
    // 030 UseTicketProductName                     000186671910 ModelPrimitiveType string string string String
    // 038 TicketProduct                            0001865F9F40 ModelClassType IProductWithAmountStatus IProductWithAmountStatus IProductWithAmountStatus Pointer
    // 040 IdolPieceProduct                         0001865F9930 ModelClassType IProductStatus IProductStatus IProductStatus Pointer
    // 048 RainbowCrystalProductWithAmount          0001865F9F40 ModelClassType IProductWithAmountStatus IProductWithAmountStatus IProductWithAmountStatus Pointer
    // 050 ProductWithAmount                        0001865FA400 ModelClassType IProductWithAmountStatus IProductWithAmountStatus IProductWithAmountStatus Pointer
    // 058 IsHaving                                 0001865965D0 ModelPrimitiveType bool bool bool Bool
    // 05C RequiredAmount                           0001865F4260 ModelPrimitiveType int int int Int32
    // 060 IdolPieceAmount                          0001865F4260 ModelPrimitiveType int int int Int32
    // 064 RainbowCrystalAmount                     0001865F4260 ModelPrimitiveType int int int Int32
    // 068 MstId                                    0001865F4260 ModelPrimitiveType int int int Int32
    // 06C MstTicketProductId                       0001865F4260 ModelPrimitiveType int int int Int32
    // 070 ReplacedCount                            0001865F4260 ModelPrimitiveType int int int Int32
    // 074 ExchangeLimitCount                       0001865F4260 ModelPrimitiveType int int int Int32
    // 078 ExchangeResetType                        0001865F3460 ModelEnumType ExchangeProductResetPurchaseCountType ExchangeProductResetPurchaseCountType ExchangeProductResetPurchaseCountType Int32
    public partial class ExchangeSelectionListItemViewModel
    {
        public string                                   ExchangeIdolProductName                 { get; set; }
        public string                                   RainbowCrystalProductName               { get; set; }
        public string                                   UseTicketProductName                    { get; set; }
        public IProductWithAmountStatus?                TicketProduct                           { get; set; }
        public IProductStatus?                          IdolPieceProduct                        { get; set; }
        public IProductWithAmountStatus?                RainbowCrystalProductWithAmount         { get; set; }
        public IProductWithAmountStatus?                ProductWithAmount                       { get; set; }
        public bool                                     IsHaving                                { get; set; }
        public int                                      RequiredAmount                          { get; set; }
        public int                                      IdolPieceAmount                         { get; set; }
        public int                                      RainbowCrystalAmount                    { get; set; }
        public int                                      MstId                                   { get; set; }
        public int                                      MstTicketProductId                      { get; set; }
        public int                                      ReplacedCount                           { get; set; }
        public int                                      ExchangeLimitCount                      { get; set; }
        public ExchangeProductResetPurchaseCountType    ExchangeResetType                       { get; set; }

        public static ExchangeSelectionListItemViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExchangeSelectionListItemViewModel();

            value.ExchangeIdolProductName                   = GetString(new IntPtr(p + 0x020)); // 0270D62E04E0 0x20 ExchangeIdolProductName     ( 000186671910 ModelPrimitiveType string string string String )
            value.RainbowCrystalProductName                 = GetString(new IntPtr(p + 0x028)); // 0270D62E0500 0x28 RainbowCrystalProductName   ( 000186671910 ModelPrimitiveType string string string String )
            value.UseTicketProductName                      = GetString(new IntPtr(p + 0x030)); // 0270D62E0520 0x30 UseTicketProductName        ( 000186671910 ModelPrimitiveType string string string String )
            value.TicketProduct                             = GetObject<IProductWithAmountStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.IProductWithAmountStatus.FromPointer); // 0270D62E0540 0x38 TicketProduct               ( 0001865F9F40 ModelClassType IProductWithAmountStatus IProductWithAmountStatus IProductWithAmountStatus Pointer )
            value.IdolPieceProduct                          = GetObject<IProductStatus>(new IntPtr(p + 0x040), ReversePrism.DataModels.IProductStatus.FromPointer); // 0270D62E0560 0x40 IdolPieceProduct            ( 0001865F9930 ModelClassType IProductStatus IProductStatus IProductStatus Pointer )
            value.RainbowCrystalProductWithAmount           = GetObject<IProductWithAmountStatus>(new IntPtr(p + 0x048), ReversePrism.DataModels.IProductWithAmountStatus.FromPointer); // 0270D62E0580 0x48 RainbowCrystalProductWithAmount ( 0001865F9F40 ModelClassType IProductWithAmountStatus IProductWithAmountStatus IProductWithAmountStatus Pointer )
            value.ProductWithAmount                         = GetObject<IProductWithAmountStatus>(new IntPtr(p + 0x050), ReversePrism.DataModels.IProductWithAmountStatus.FromPointer); // 0270D62E05A0 0x50 ProductWithAmount           ( 0001865FA400 ModelClassType IProductWithAmountStatus IProductWithAmountStatus IProductWithAmountStatus Pointer )
            value.IsHaving                                  = GetBool(new IntPtr(p + 0x058)); // 0270D62E05C0 0x58 IsHaving                    ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )
            value.RequiredAmount                            = GetInt32(new IntPtr(p + 0x05C)); // 0270D62E05E0 0x5C RequiredAmount              ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.IdolPieceAmount                           = GetInt32(new IntPtr(p + 0x060)); // 0270D62E0600 0x60 IdolPieceAmount             ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.RainbowCrystalAmount                      = GetInt32(new IntPtr(p + 0x064)); // 0270D62E0620 0x64 RainbowCrystalAmount        ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.MstId                                     = GetInt32(new IntPtr(p + 0x068)); // 0270D62E0640 0x68 MstId                       ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.MstTicketProductId                        = GetInt32(new IntPtr(p + 0x06C)); // 0270D62E0660 0x6C MstTicketProductId          ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.ReplacedCount                             = GetInt32(new IntPtr(p + 0x070)); // 0270D62E0680 0x70 ReplacedCount               ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.ExchangeLimitCount                        = GetInt32(new IntPtr(p + 0x074)); // 0270D62E06A0 0x74 ExchangeLimitCount          ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.ExchangeResetType                         = (ExchangeProductResetPurchaseCountType)GetInt32(new IntPtr(p + 0x078)); // 0270D62E06C0 0x78 ExchangeResetType           ( 0001865F3460 ModelEnumType ExchangeProductResetPurchaseCountType ExchangeProductResetPurchaseCountType ExchangeProductResetPurchaseCountType Int32 )

            return value;
        }
    }
}
