using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ProductName                              000186672F10 ModelPrimitiveType string string string String
    // 018 Product                                  0001865FA400 ModelClassType IProductWithAmountStatus IProductWithAmountStatus IProductWithAmountStatus Pointer
    // 020 ExpireTime                               000185D00B98 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 030 ShowTabType                              0001866410A0 ModelEnumType ExchangeTabType ExchangeTabType ExchangeTabType Int32
    public partial class ExchangeLargeSpaceGoodsGridViewModel : DataModel
    {
        public string                                   ProductName                             { get; set; }
        public IProductWithAmountStatus?                Product                                 { get; set; }
        public DateTime                                 ExpireTime                              { get; set; }
        public ExchangeTabType                          ShowTabType                             { get; set; }

        public static ExchangeLargeSpaceGoodsGridViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExchangeLargeSpaceGoodsGridViewModel() { Pointer= p0 };

            value.ProductName                               = GetString(new IntPtr(p + 0x010)); // 02466633D2E0 0x10 ProductName                 ( 000186672F10 ModelPrimitiveType string string string String )
            value.Product                                   = GetObject<IProductWithAmountStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.IProductWithAmountStatus.FromPointer); // 02466633D300 0x18 Product                     ( 0001865FA400 ModelClassType IProductWithAmountStatus IProductWithAmountStatus IProductWithAmountStatus Pointer )
            value.ExpireTime                                = GetDateTime(new IntPtr(p + 0x020)); // 02466633D320 0x20 ExpireTime                  ( 000185D00B98 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.ShowTabType                               = (ExchangeTabType)GetInt32(new IntPtr(p + 0x030)); // 02466633D340 0x30 ShowTabType                 ( 0001866410A0 ModelEnumType ExchangeTabType ExchangeTabType ExchangeTabType Int32 )

            return value;
        }
    }
}
