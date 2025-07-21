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
    // 020 ExchangeIdolProductName                  ModelPrimitiveType string string string String
    // 028 RainbowCrystalProductName                ModelPrimitiveType string string string String
    // 030 UseTicketProductName                     ModelPrimitiveType string string string String
    // 038 TicketProduct                            ModelClassType IProductWithAmountStatus IProductWithAmountStatus IProductWithAmountStatus Pointer
    // 040 IdolPieceProduct                         ModelClassType IProductStatus IProductStatus IProductStatus Pointer
    // 048 RainbowCrystalProductWithAmount          ModelClassType IProductWithAmountStatus IProductWithAmountStatus IProductWithAmountStatus Pointer
    // 050 ProductWithAmount                        ModelClassType IProductWithAmountStatus IProductWithAmountStatus IProductWithAmountStatus Pointer
    // 058 IsHaving                                 ModelPrimitiveType bool bool bool Bool
    // 05C RequiredAmount                           ModelPrimitiveType int int int Int32
    // 060 IdolPieceAmount                          ModelPrimitiveType int int int Int32
    // 064 RainbowCrystalAmount                     ModelPrimitiveType int int int Int32
    // 068 MstId                                    ModelPrimitiveType int int int Int32
    // 06C MstTicketProductId                       ModelPrimitiveType int int int Int32
    // 070 ReplacedCount                            ModelPrimitiveType int int int Int32
    // 074 ExchangeLimitCount                       ModelPrimitiveType int int int Int32
    // 078 ExchangeResetType                        ModelEnumType ExchangeProductResetPurchaseCountType ExchangeProductResetPurchaseCountType ExchangeProductResetPurchaseCountType Int32
    // 07C IsAlreadyHaving                          ModelPrimitiveType bool bool bool Bool
    public partial class ExchangeSelectionListItemViewModel : DataModel
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
        public bool                                     IsAlreadyHaving                         { get; set; }

        public static ExchangeSelectionListItemViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExchangeSelectionListItemViewModel() { Pointer= p0 };

            value.ExchangeIdolProductName                   = GetString(new IntPtr(p + 0x020)); // 0x20 ExchangeIdolProductName     ( ModelPrimitiveType string string string String )
            value.RainbowCrystalProductName                 = GetString(new IntPtr(p + 0x028)); // 0x28 RainbowCrystalProductName   ( ModelPrimitiveType string string string String )
            value.UseTicketProductName                      = GetString(new IntPtr(p + 0x030)); // 0x30 UseTicketProductName        ( ModelPrimitiveType string string string String )
            value.TicketProduct                             = GetObject<IProductWithAmountStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.IProductWithAmountStatus.FromPointer); // 0x38 TicketProduct               ( ModelClassType IProductWithAmountStatus IProductWithAmountStatus IProductWithAmountStatus Pointer )
            value.IdolPieceProduct                          = GetObject<IProductStatus>(new IntPtr(p + 0x040), ReversePrism.DataModels.IProductStatus.FromPointer); // 0x40 IdolPieceProduct            ( ModelClassType IProductStatus IProductStatus IProductStatus Pointer )
            value.RainbowCrystalProductWithAmount           = GetObject<IProductWithAmountStatus>(new IntPtr(p + 0x048), ReversePrism.DataModels.IProductWithAmountStatus.FromPointer); // 0x48 RainbowCrystalProductWithAmount ( ModelClassType IProductWithAmountStatus IProductWithAmountStatus IProductWithAmountStatus Pointer )
            value.ProductWithAmount                         = GetObject<IProductWithAmountStatus>(new IntPtr(p + 0x050), ReversePrism.DataModels.IProductWithAmountStatus.FromPointer); // 0x50 ProductWithAmount           ( ModelClassType IProductWithAmountStatus IProductWithAmountStatus IProductWithAmountStatus Pointer )
            value.IsHaving                                  = GetBool(new IntPtr(p + 0x058)); // 0x58 IsHaving                    ( ModelPrimitiveType bool bool bool Bool )
            value.RequiredAmount                            = GetInt32(new IntPtr(p + 0x05C)); // 0x5C RequiredAmount              ( ModelPrimitiveType int int int Int32 )
            value.IdolPieceAmount                           = GetInt32(new IntPtr(p + 0x060)); // 0x60 IdolPieceAmount             ( ModelPrimitiveType int int int Int32 )
            value.RainbowCrystalAmount                      = GetInt32(new IntPtr(p + 0x064)); // 0x64 RainbowCrystalAmount        ( ModelPrimitiveType int int int Int32 )
            value.MstId                                     = GetInt32(new IntPtr(p + 0x068)); // 0x68 MstId                       ( ModelPrimitiveType int int int Int32 )
            value.MstTicketProductId                        = GetInt32(new IntPtr(p + 0x06C)); // 0x6C MstTicketProductId          ( ModelPrimitiveType int int int Int32 )
            value.ReplacedCount                             = GetInt32(new IntPtr(p + 0x070)); // 0x70 ReplacedCount               ( ModelPrimitiveType int int int Int32 )
            value.ExchangeLimitCount                        = GetInt32(new IntPtr(p + 0x074)); // 0x74 ExchangeLimitCount          ( ModelPrimitiveType int int int Int32 )
            value.ExchangeResetType                         = (ExchangeProductResetPurchaseCountType)GetInt32(new IntPtr(p + 0x078)); // 0x78 ExchangeResetType           ( ModelEnumType ExchangeProductResetPurchaseCountType ExchangeProductResetPurchaseCountType ExchangeProductResetPurchaseCountType Int32 )
            value.IsAlreadyHaving                           = GetBool(new IntPtr(p + 0x07C)); // 0x7C IsAlreadyHaving             ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
