using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 CurExchangeCounText                      ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 068 PieceRatePrefab                          ModelClassType PieceExchangeRateCell PieceExchangeRateCell PieceExchangeRateCell Pointer
    // 070 RateViewArea                             ModelClassType GameObject GameObject GameObject Pointer
    // 078 PieceIcons                               ModelClassListType List`1<RewardItem> List`1<RewardItem> List<RewardItem> Pointer
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

            value.CurExchangeCounText                       = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x060), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x60 CurExchangeCounText         ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.PieceRatePrefab                           = GetObject<PieceExchangeRateCell>(new IntPtr(p + 0x068), ReversePrism.DataModels.PieceExchangeRateCell.FromPointer); // 0x68 PieceRatePrefab             ( ModelClassType PieceExchangeRateCell PieceExchangeRateCell PieceExchangeRateCell Pointer )
            value.RateViewArea                              = GetObject<GameObject>(new IntPtr(p + 0x070), ReversePrism.DataModels.GameObject.FromPointer); // 0x70 RateViewArea                ( ModelClassType GameObject GameObject GameObject Pointer )
            value.PieceIcons                                = GetObjectList<RewardItem>(new IntPtr(p + 0x078), ReversePrism.DataModels.RewardItem.FromPointer); // 0x78 PieceIcons                  ( ModelClassListType List`1<RewardItem> List`1<RewardItem> List<RewardItem> Pointer )

            return value;
        }
    }
}
