using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ExchangeCount                            ModelPrimitiveType int int int Int32
    // 018 GoodsModel                               ModelClassType ExchangeProductViewModel ExchangeProductViewModel ExchangeProductViewModel Pointer
    // 020 IsLimit                                  ModelPrimitiveType bool bool bool Bool
    // 028 BeforePurchaseProductAmount              ModelPrimitiveType long long long Int64
    // 030 AfterPurchaseProductAmount               ModelPrimitiveType long long long Int64
    // 038 BeforeGoodsAmount                        ModelPrimitiveType long long long Int64
    // 040 AfterGoodsAmount                         ModelPrimitiveType long long long Int64
    // 048 BeforeExchangeLimit                      ModelPrimitiveType int int int Int32
    // 04C AfterExchangeLimit                       ModelPrimitiveType int int int Int32
    public partial class ExchangeConfirmationPopupViewModel : DataModel
    {
        public int                                      ExchangeCount                           { get; set; }
        public ExchangeProductViewModel?                GoodsModel                              { get; set; }
        public bool                                     IsLimit                                 { get; set; }
        public long                                     BeforePurchaseProductAmount             { get; set; }
        public long                                     AfterPurchaseProductAmount              { get; set; }
        public long                                     BeforeGoodsAmount                       { get; set; }
        public long                                     AfterGoodsAmount                        { get; set; }
        public int                                      BeforeExchangeLimit                     { get; set; }
        public int                                      AfterExchangeLimit                      { get; set; }

        public static ExchangeConfirmationPopupViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExchangeConfirmationPopupViewModel() { Pointer= p0 };

            value.ExchangeCount                             = GetInt32(new IntPtr(p + 0x010)); // 0x10 ExchangeCount               ( ModelPrimitiveType int int int Int32 )
            value.GoodsModel                                = GetObject<ExchangeProductViewModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.ExchangeProductViewModel.FromPointer); // 0x18 GoodsModel                  ( ModelClassType ExchangeProductViewModel ExchangeProductViewModel ExchangeProductViewModel Pointer )
            value.IsLimit                                   = GetBool(new IntPtr(p + 0x020)); // 0x20 IsLimit                     ( ModelPrimitiveType bool bool bool Bool )
            value.BeforePurchaseProductAmount               = GetInt64(new IntPtr(p + 0x028)); // 0x28 BeforePurchaseProductAmount ( ModelPrimitiveType long long long Int64 )
            value.AfterPurchaseProductAmount                = GetInt64(new IntPtr(p + 0x030)); // 0x30 AfterPurchaseProductAmount  ( ModelPrimitiveType long long long Int64 )
            value.BeforeGoodsAmount                         = GetInt64(new IntPtr(p + 0x038)); // 0x38 BeforeGoodsAmount           ( ModelPrimitiveType long long long Int64 )
            value.AfterGoodsAmount                          = GetInt64(new IntPtr(p + 0x040)); // 0x40 AfterGoodsAmount            ( ModelPrimitiveType long long long Int64 )
            value.BeforeExchangeLimit                       = GetInt32(new IntPtr(p + 0x048)); // 0x48 BeforeExchangeLimit         ( ModelPrimitiveType int int int Int32 )
            value.AfterExchangeLimit                        = GetInt32(new IntPtr(p + 0x04C)); // 0x4C AfterExchangeLimit          ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
