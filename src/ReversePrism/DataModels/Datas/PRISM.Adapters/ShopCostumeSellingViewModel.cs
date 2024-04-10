using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ShopCostumeGridViewModels                000185D089C8 ModelClassListType List`1<ShopCostumeGridViewModel> List`1<ShopCostumeGridViewModel> List<ShopCostumeGridViewModel> Pointer
    // 018 HorizontalTabIndex                       0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class ShopCostumeSellingViewModel : DataModel
    {
        public List<ShopCostumeGridViewModel>?          ShopCostumeGridViewModels               { get; set; }
        public int                                      HorizontalTabIndex                      { get; set; }

        public static ShopCostumeSellingViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ShopCostumeSellingViewModel() { Pointer= p0 };

            value.ShopCostumeGridViewModels                 = GetObjectList<ShopCostumeGridViewModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.ShopCostumeGridViewModel.FromPointer); // 0246667924C8 0x10 ShopCostumeGridViewModels   ( 000185D089C8 ModelClassListType List`1<ShopCostumeGridViewModel> List`1<ShopCostumeGridViewModel> List<ShopCostumeGridViewModel> Pointer )
            value.HorizontalTabIndex                        = GetInt32(new IntPtr(p + 0x018)); // 0246667924E8 0x18 HorizontalTabIndex          ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
