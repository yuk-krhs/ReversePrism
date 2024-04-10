using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 CurExchangeCounText                      0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 068 PieceRatePrefab                          000186742560 ModelClassType PieceExchangeRateCell PieceExchangeRateCell PieceExchangeRateCell Pointer
    // 070 RateViewArea                             0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 078 PieceIcons                               000185D03748 ModelClassListType List`1<RewardItem> List`1<RewardItem> List<RewardItem> Pointer
    public partial class PieceExchangeRatePopupContent : DataModel
    {
        public UITextMeshProUGUI?                       CurExchangeCounText                     { get; set; }
        public PieceExchangeRateCell?                   PieceRatePrefab                         { get; set; }
        public GameObject?                              RateViewArea                            { get; set; }
        public List<RewardItem>?                        PieceIcons                              { get; set; }

        public static PieceExchangeRatePopupContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PieceExchangeRatePopupContent() { Pointer= p0 };

            value.CurExchangeCounText                       = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x060), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 024665564130 0x60 CurExchangeCounText         ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.PieceRatePrefab                           = GetObject<PieceExchangeRateCell>(new IntPtr(p + 0x068), ReversePrism.DataModels.PieceExchangeRateCell.FromPointer); // 024665564150 0x68 PieceRatePrefab             ( 000186742560 ModelClassType PieceExchangeRateCell PieceExchangeRateCell PieceExchangeRateCell Pointer )
            value.RateViewArea                              = GetObject<GameObject>(new IntPtr(p + 0x070), ReversePrism.DataModels.GameObject.FromPointer); // 024665564170 0x70 RateViewArea                ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.PieceIcons                                = GetObjectList<RewardItem>(new IntPtr(p + 0x078), ReversePrism.DataModels.RewardItem.FromPointer); // 024665564190 0x78 PieceIcons                  ( 000185D03748 ModelClassListType List`1<RewardItem> List`1<RewardItem> List<RewardItem> Pointer )

            return value;
        }
    }
}
