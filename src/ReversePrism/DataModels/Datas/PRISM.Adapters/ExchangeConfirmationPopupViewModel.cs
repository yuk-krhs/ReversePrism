using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ExchangeCount                            0001865F2AF0 ModelPrimitiveType int int int Int32
    // 018 GoodsModel                               0001865146E0 ModelClassType ExchangeProductViewModel ExchangeProductViewModel ExchangeProductViewModel Pointer
    // 020 IsLimit                                  000186594D10 ModelPrimitiveType bool bool bool Bool
    // 028 BeforePurchaseProductAmount              0001865F7700 ModelPrimitiveType long long long Int64
    // 030 AfterPurchaseProductAmount               0001865F7700 ModelPrimitiveType long long long Int64
    // 038 BeforeGoodsAmount                        0001865F7700 ModelPrimitiveType long long long Int64
    // 040 AfterGoodsAmount                         0001865F7700 ModelPrimitiveType long long long Int64
    // 048 BeforeExchangeLimit                      0001865F2AF0 ModelPrimitiveType int int int Int32
    // 04C AfterExchangeLimit                       0001865F2AF0 ModelPrimitiveType int int int Int32
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

            value.ExchangeCount                             = GetInt32(new IntPtr(p + 0x010)); // 024666346C50 0x10 ExchangeCount               ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.GoodsModel                                = GetObject<ExchangeProductViewModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.ExchangeProductViewModel.FromPointer); // 024666346C70 0x18 GoodsModel                  ( 0001865146E0 ModelClassType ExchangeProductViewModel ExchangeProductViewModel ExchangeProductViewModel Pointer )
            value.IsLimit                                   = GetBool(new IntPtr(p + 0x020)); // 024666346C90 0x20 IsLimit                     ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.BeforePurchaseProductAmount               = GetInt64(new IntPtr(p + 0x028)); // 024666346CB0 0x28 BeforePurchaseProductAmount ( 0001865F7700 ModelPrimitiveType long long long Int64 )
            value.AfterPurchaseProductAmount                = GetInt64(new IntPtr(p + 0x030)); // 024666346CD0 0x30 AfterPurchaseProductAmount  ( 0001865F7700 ModelPrimitiveType long long long Int64 )
            value.BeforeGoodsAmount                         = GetInt64(new IntPtr(p + 0x038)); // 024666346CF0 0x38 BeforeGoodsAmount           ( 0001865F7700 ModelPrimitiveType long long long Int64 )
            value.AfterGoodsAmount                          = GetInt64(new IntPtr(p + 0x040)); // 024666346D10 0x40 AfterGoodsAmount            ( 0001865F7700 ModelPrimitiveType long long long Int64 )
            value.BeforeExchangeLimit                       = GetInt32(new IntPtr(p + 0x048)); // 024666346D30 0x48 BeforeExchangeLimit         ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.AfterExchangeLimit                        = GetInt32(new IntPtr(p + 0x04C)); // 024666346D50 0x4C AfterExchangeLimit          ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
