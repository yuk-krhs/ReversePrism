using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ProductName                              ModelPrimitiveType string string string String
    // 018 Product                                  ModelClassType IProductWithAmountStatus IProductWithAmountStatus IProductWithAmountStatus Pointer
    // 020 ExpireTime                               ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 030 ShowTabType                              ModelEnumType ExchangeTabType ExchangeTabType ExchangeTabType Int32
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

            value.ProductName                               = GetString(new IntPtr(p + 0x010)); // 0x10 ProductName                 ( ModelPrimitiveType string string string String )
            value.Product                                   = GetObject<IProductWithAmountStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.IProductWithAmountStatus.FromPointer); // 0x18 Product                     ( ModelClassType IProductWithAmountStatus IProductWithAmountStatus IProductWithAmountStatus Pointer )
            value.ExpireTime                                = GetDateTime(new IntPtr(p + 0x020)); // 0x20 ExpireTime                  ( ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.ShowTabType                               = (ExchangeTabType)GetInt32(new IntPtr(p + 0x030)); // 0x30 ShowTabType                 ( ModelEnumType ExchangeTabType ExchangeTabType ExchangeTabType Int32 )

            return value;
        }
    }
}
