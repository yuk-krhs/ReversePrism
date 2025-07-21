using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 GridView                                 ModelClassType ShopCostumeGridView ShopCostumeGridView ShopCostumeGridView Pointer
    // 028 CanvasGroup                              ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 030 HorizontalTabGroup                       ModelClassType UITabGroupEx UITabGroupEx UITabGroupEx Pointer
    public partial class ShopCostumeSellingView : DataModel
    {
        public ShopCostumeGridView?                     GridView                                { get; set; }
        public CanvasGroup?                             CanvasGroup                             { get; set; }
        public UITabGroupEx?                            HorizontalTabGroup                      { get; set; }

        public static ShopCostumeSellingView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ShopCostumeSellingView() { Pointer= p0 };

            value.GridView                                  = GetObject<ShopCostumeGridView>(new IntPtr(p + 0x020), ReversePrism.DataModels.ShopCostumeGridView.FromPointer); // 0x20 GridView                    ( ModelClassType ShopCostumeGridView ShopCostumeGridView ShopCostumeGridView Pointer )
            value.CanvasGroup                               = GetObject<CanvasGroup>(new IntPtr(p + 0x028), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0x28 CanvasGroup                 ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.HorizontalTabGroup                        = GetObject<UITabGroupEx>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITabGroupEx.FromPointer); // 0x30 HorizontalTabGroup          ( ModelClassType UITabGroupEx UITabGroupEx UITabGroupEx Pointer )

            return value;
        }
    }
}
