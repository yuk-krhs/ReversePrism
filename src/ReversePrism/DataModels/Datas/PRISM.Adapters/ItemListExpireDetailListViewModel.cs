using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Status                                   ModelClassType IHavingProductStatus IHavingProductStatus IHavingProductStatus Pointer
    // 018 ExpireDate                               ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 028 Amount                                   ModelPrimitiveType long long long Int64
    public partial class ItemListExpireDetailListViewModel : DataModel
    {
        public IHavingProductStatus?                    Status                                  { get; set; }
        public DateTime                                 ExpireDate                              { get; set; }
        public long                                     Amount                                  { get; set; }

        public static ItemListExpireDetailListViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ItemListExpireDetailListViewModel() { Pointer= p0 };

            value.Status                                    = GetObject<IHavingProductStatus>(new IntPtr(p + 0x010), ReversePrism.DataModels.IHavingProductStatus.FromPointer); // 0x10 Status                      ( ModelClassType IHavingProductStatus IHavingProductStatus IHavingProductStatus Pointer )
            value.ExpireDate                                = GetDateTime(new IntPtr(p + 0x018)); // 0x18 ExpireDate                  ( ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.Amount                                    = GetInt64(new IntPtr(p + 0x028)); // 0x28 Amount                      ( ModelPrimitiveType long long long Int64 )

            return value;
        }
    }
}
