using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 090 GoodsModel                               ModelClassType ExchangeGoodsClientModel ExchangeGoodsClientModel ExchangeGoodsClientModel Pointer
    // 098 ExchangeCount                            ModelPrimitiveType int int int Int32
    // 0A0 BeforePurchaseProductAmount              ModelPrimitiveType long long long Int64
    // 0A8 AfterPurchaseProductAmount               ModelPrimitiveType long long long Int64
    // 0B0 BeforeGoodsAmount                        ModelPrimitiveType long long long Int64
    // 0B8 AfterGoodsAmount                         ModelPrimitiveType long long long Int64
    // 0C0 BeforeExchangeLimmit                     ModelPrimitiveType int int int Int32
    // 0C4 AfterExchangeLimmit                      ModelPrimitiveType int int int Int32
    // 0C8 PieceCharaID                             ModelPrimitiveType int int int Int32
    // 0D0 PurchaseReply                            ModelClassType IPurchaseExchangeProductReply IPurchaseExchangeProductReply IPurchaseExchangeProductReply Pointer
    // 0D8 <OnExchangeCompletedSubject>k__BackingField Subject`1<ValueTuple`2<ExchangeGoodsClientModel, IPurchaseExchangeProductReply>> IL2CPP_TYPE_GENERICINST
    // 0E0 <OnGoToOtherViewSubject>k__BackingField  Subject`1<ValueTuple`3<ButtonGoToType, ExchangeGoodsClientModel, IPurchaseExchangeProductReply>> IL2CPP_TYPE_GENERICINST
    public partial class ExchangePopupDialogParam : DataModel
    {
        public ExchangeGoodsClientModel?                GoodsModel                              { get; set; }
        public int                                      ExchangeCount                           { get; set; }
        public long                                     BeforePurchaseProductAmount             { get; set; }
        public long                                     AfterPurchaseProductAmount              { get; set; }
        public long                                     BeforeGoodsAmount                       { get; set; }
        public long                                     AfterGoodsAmount                        { get; set; }
        public int                                      BeforeExchangeLimmit                    { get; set; }
        public int                                      AfterExchangeLimmit                     { get; set; }
        public int                                      PieceCharaID                            { get; set; }
        public IPurchaseExchangeProductReply?           PurchaseReply                           { get; set; }

        public static ExchangePopupDialogParam? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExchangePopupDialogParam() { Pointer= p0 };

            value.GoodsModel                                = GetObject<ExchangeGoodsClientModel>(new IntPtr(p + 0x090), ReversePrism.DataModels.ExchangeGoodsClientModel.FromPointer); // 0x90 GoodsModel                  ( ModelClassType ExchangeGoodsClientModel ExchangeGoodsClientModel ExchangeGoodsClientModel Pointer )
            value.ExchangeCount                             = GetInt32(new IntPtr(p + 0x098)); // 0x98 ExchangeCount               ( ModelPrimitiveType int int int Int32 )
            value.BeforePurchaseProductAmount               = GetInt64(new IntPtr(p + 0x0A0)); // 0xA0 BeforePurchaseProductAmount ( ModelPrimitiveType long long long Int64 )
            value.AfterPurchaseProductAmount                = GetInt64(new IntPtr(p + 0x0A8)); // 0xA8 AfterPurchaseProductAmount  ( ModelPrimitiveType long long long Int64 )
            value.BeforeGoodsAmount                         = GetInt64(new IntPtr(p + 0x0B0)); // 0xB0 BeforeGoodsAmount           ( ModelPrimitiveType long long long Int64 )
            value.AfterGoodsAmount                          = GetInt64(new IntPtr(p + 0x0B8)); // 0xB8 AfterGoodsAmount            ( ModelPrimitiveType long long long Int64 )
            value.BeforeExchangeLimmit                      = GetInt32(new IntPtr(p + 0x0C0)); // 0xC0 BeforeExchangeLimmit        ( ModelPrimitiveType int int int Int32 )
            value.AfterExchangeLimmit                       = GetInt32(new IntPtr(p + 0x0C4)); // 0xC4 AfterExchangeLimmit         ( ModelPrimitiveType int int int Int32 )
            value.PieceCharaID                              = GetInt32(new IntPtr(p + 0x0C8)); // 0xC8 PieceCharaID                ( ModelPrimitiveType int int int Int32 )
            value.PurchaseReply                             = GetObject<IPurchaseExchangeProductReply>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.IPurchaseExchangeProductReply.FromPointer); // 0xD0 PurchaseReply               ( ModelClassType IPurchaseExchangeProductReply IPurchaseExchangeProductReply IPurchaseExchangeProductReply Pointer )

            return value;
        }
    }
}
