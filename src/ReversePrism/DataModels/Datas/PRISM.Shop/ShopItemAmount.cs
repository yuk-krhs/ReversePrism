using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Panel                                    0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 028 BeforeItemmountText                      0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 AfterItemAmountText                      0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    public partial class ShopItemAmount : DataModel
    {
        public GameObject?                              Panel                                   { get; set; }
        public UITextMeshProUGUI?                       BeforeItemmountText                     { get; set; }
        public UITextMeshProUGUI?                       AfterItemAmountText                     { get; set; }

        public static ShopItemAmount? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ShopItemAmount() { Pointer= p0 };

            value.Panel                                     = GetObject<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 02466557F120 0x20 Panel                       ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.BeforeItemmountText                       = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466557F140 0x28 BeforeItemmountText         ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.AfterItemAmountText                       = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466557F160 0x30 AfterItemAmountText         ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )

            return value;
        }
    }
}
