using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 ConversionCountText                      0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 068 ConversionItemCountText                  000186768A80 ModelClassType ValueFluctionTextPair ValueFluctionTextPair ValueFluctionTextPair Pointer
    // 070 ConversionResultPrefab                   0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 078 ConversionResultViewArea                 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    public partial class ExcnahgePointConversionPopupContent : DataModel
    {
        public UITextMeshProUGUI?                       ConversionCountText                     { get; set; }
        public ValueFluctionTextPair?                   ConversionItemCountText                 { get; set; }
        public GameObject?                              ConversionResultPrefab                  { get; set; }
        public GameObject?                              ConversionResultViewArea                { get; set; }

        public static ExcnahgePointConversionPopupContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExcnahgePointConversionPopupContent() { Pointer= p0 };

            value.ConversionCountText                       = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x060), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 024665570A20 0x60 ConversionCountText         ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ConversionItemCountText                   = GetObject<ValueFluctionTextPair>(new IntPtr(p + 0x068), ReversePrism.DataModels.ValueFluctionTextPair.FromPointer); // 024665570A40 0x68 ConversionItemCountText     ( 000186768A80 ModelClassType ValueFluctionTextPair ValueFluctionTextPair ValueFluctionTextPair Pointer )
            value.ConversionResultPrefab                    = GetObject<GameObject>(new IntPtr(p + 0x070), ReversePrism.DataModels.GameObject.FromPointer); // 024665570A60 0x70 ConversionResultPrefab      ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.ConversionResultViewArea                  = GetObject<GameObject>(new IntPtr(p + 0x078), ReversePrism.DataModels.GameObject.FromPointer); // 024665570A80 0x78 ConversionResultViewArea    ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )

            return value;
        }
    }
}
