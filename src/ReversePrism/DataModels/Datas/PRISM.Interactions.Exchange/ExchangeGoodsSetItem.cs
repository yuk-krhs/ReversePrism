using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 RewardItem                               00018667FAC0 ModelClassType RewardItemIcon RewardItemIcon RewardItemIcon Pointer
    // 028 ItemNameText                             0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 AmountText                               0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 SpaceLine                                0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 040 PIdolDetail                              000186709050 ModelClassType PIdolDetailPopupCaller PIdolDetailPopupCaller PIdolDetailPopupCaller Pointer
    // 048 SCharaDetail                             0001866A33D0 ModelClassType SCharaDetailPopupCaller SCharaDetailPopupCaller SCharaDetailPopupCaller Pointer
    public partial class ExchangeGoodsSetItem
    {
        public RewardItemIcon?                          RewardItem                              { get; set; }
        public UITextMeshProUGUI?                       ItemNameText                            { get; set; }
        public UITextMeshProUGUI?                       AmountText                              { get; set; }
        public GameObject?                              SpaceLine                               { get; set; }
        public PIdolDetailPopupCaller?                  PIdolDetail                             { get; set; }
        public SCharaDetailPopupCaller?                 SCharaDetail                            { get; set; }

        public static ExchangeGoodsSetItem? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExchangeGoodsSetItem();

            value.RewardItem                                = GetObject<RewardItemIcon>(new IntPtr(p + 0x020), ReversePrism.DataModels.RewardItemIcon.FromPointer); // 0270DB9082B0 0x20 RewardItem                  ( 00018667FAC0 ModelClassType RewardItemIcon RewardItemIcon RewardItemIcon Pointer )
            value.ItemNameText                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DB9082D0 0x28 ItemNameText                ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.AmountText                                = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DB9082F0 0x30 AmountText                  ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.SpaceLine                                 = GetObject<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 0270DB908310 0x38 SpaceLine                   ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.PIdolDetail                               = GetObject<PIdolDetailPopupCaller>(new IntPtr(p + 0x040), ReversePrism.DataModels.PIdolDetailPopupCaller.FromPointer); // 0270DB908330 0x40 PIdolDetail                 ( 000186709050 ModelClassType PIdolDetailPopupCaller PIdolDetailPopupCaller PIdolDetailPopupCaller Pointer )
            value.SCharaDetail                              = GetObject<SCharaDetailPopupCaller>(new IntPtr(p + 0x048), ReversePrism.DataModels.SCharaDetailPopupCaller.FromPointer); // 0270DB908350 0x48 SCharaDetail                ( 0001866A33D0 ModelClassType SCharaDetailPopupCaller SCharaDetailPopupCaller SCharaDetailPopupCaller Pointer )

            return value;
        }
    }
}
