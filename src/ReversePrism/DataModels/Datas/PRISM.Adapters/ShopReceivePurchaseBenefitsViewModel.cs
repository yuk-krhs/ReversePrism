using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ReceivedPassProductList                  ModelClassListType IReadOnlyList`1<IProductWithAmountStatus> IReadOnlyList`1<IProductWithAmountStatus> List<IProductWithAmountStatus> Pointer
    // 018 ShopGroupType                            ModelEnumType GroupType GroupType GroupType Int32
    public partial class ShopReceivePurchaseBenefitsViewModel : DataModel
    {
        public List<IProductWithAmountStatus>?          ReceivedPassProductList                 { get; set; }
        public GroupType                                ShopGroupType                           { get; set; }

        public static ShopReceivePurchaseBenefitsViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ShopReceivePurchaseBenefitsViewModel() { Pointer= p0 };

            value.ReceivedPassProductList                   = GetObjectList<IProductWithAmountStatus>(new IntPtr(p + 0x010), ReversePrism.DataModels.IProductWithAmountStatus.FromPointer); // 0x10 ReceivedPassProductList     ( ModelClassListType IReadOnlyList`1<IProductWithAmountStatus> IReadOnlyList`1<IProductWithAmountStatus> List<IProductWithAmountStatus> Pointer )
            value.ShopGroupType                             = (GroupType)GetInt32(new IntPtr(p + 0x018)); // 0x18 ShopGroupType               ( ModelEnumType GroupType GroupType GroupType Int32 )

            return value;
        }
    }
}
