using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ReceivedPassProductList                  000185D075A8 ModelClassListType IReadOnlyList`1<IProductWithAmountStatus> IReadOnlyList`1<IProductWithAmountStatus> List<IProductWithAmountStatus> Pointer
    // 018 ShopGroupType                            000186773BB0 ModelEnumType GroupType GroupType GroupType Int32
    public partial class ShopReceivePurchaseBenefitsViewModel
    {
        public List<IProductWithAmountStatus>?          ReceivedPassProductList                 { get; set; }
        public GroupType                                ShopGroupType                           { get; set; }

        public static ShopReceivePurchaseBenefitsViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ShopReceivePurchaseBenefitsViewModel();

            value.ReceivedPassProductList                   = GetObjectList<IProductWithAmountStatus>(new IntPtr(p + 0x010), ReversePrism.DataModels.IProductWithAmountStatus.FromPointer); // 0270036697A0 0x10 ReceivedPassProductList     ( 000185D075A8 ModelClassListType IReadOnlyList`1<IProductWithAmountStatus> IReadOnlyList`1<IProductWithAmountStatus> List<IProductWithAmountStatus> Pointer )
            value.ShopGroupType                             = (GroupType)GetInt32(new IntPtr(p + 0x018)); // 0270036697C0 0x18 ShopGroupType               ( 000186773BB0 ModelEnumType GroupType GroupType GroupType Int32 )

            return value;
        }
    }
}
