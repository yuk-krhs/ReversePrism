using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ShopCostumeGridViewModels                ModelClassListType List`1<ShopCostumeGridViewModel> List`1<ShopCostumeGridViewModel> List<ShopCostumeGridViewModel> Pointer
    public partial class ShopCostumeSellingViewModel : DataModel
    {
        public List<ShopCostumeGridViewModel>?          ShopCostumeGridViewModels               { get; set; }

        public static ShopCostumeSellingViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ShopCostumeSellingViewModel() { Pointer= p0 };

            value.ShopCostumeGridViewModels                 = GetObjectList<ShopCostumeGridViewModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.ShopCostumeGridViewModel.FromPointer); // 0x10 ShopCostumeGridViewModels   ( ModelClassListType List`1<ShopCostumeGridViewModel> List`1<ShopCostumeGridViewModel> List<ShopCostumeGridViewModel> Pointer )

            return value;
        }
    }
}
