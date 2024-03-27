using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 NewIcon                                  0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 028 IconImage                                000186613190 ModelClassType RawImage RawImage RawImage Pointer
    // 030 PurchaseButton                           0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    public partial class ShopCostumeGridItemView
    {
        public GameObject?                              NewIcon                                 { get; set; }
        public RawImage?                                IconImage                               { get; set; }
        public UIButton?                                PurchaseButton                          { get; set; }

        public static ShopCostumeGridItemView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ShopCostumeGridItemView();

            value.NewIcon                                   = GetObject<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 0270DB80DB80 0x20 NewIcon                     ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.IconImage                                 = GetObject<RawImage>(new IntPtr(p + 0x028), ReversePrism.DataModels.RawImage.FromPointer); // 0270DB80DBA0 0x28 IconImage                   ( 000186613190 ModelClassType RawImage RawImage RawImage Pointer )
            value.PurchaseButton                            = GetObject<UIButton>(new IntPtr(p + 0x030), ReversePrism.DataModels.UIButton.FromPointer); // 0270DB80DBC0 0x30 PurchaseButton              ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )

            return value;
        }
    }
}
