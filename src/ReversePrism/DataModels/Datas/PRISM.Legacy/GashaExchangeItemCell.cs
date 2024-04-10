using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 GashaProductItem                         000186610A30 ModelClassType GashaProductItemPresenter GashaProductItemPresenter GashaProductItemPresenter Pointer
    // 028 RewardPieceItem                          00018667EAE0 ModelClassType RewardItem RewardItem RewardItem Pointer
    // 030 TxtPieceDetail                           0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 RewardPieceItemFrame                     0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 040 TxtItemName                              0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 GoKakutoku                               0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 050 GoMiKakutoku                             0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 058 TxtPoint                                 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 060 BtnExChange                              000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 068 GoDisableBtn                             0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 070 GoRainbowCrystals                        0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 078 TxtLimit                                 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 080 CurrentGashaExchangeReward               0001865243C0 ModelClassType IGashaExchangeRewardStatus IGashaExchangeRewardStatus IGashaExchangeRewardStatus Pointer
    // 088 OnClickItem                              Subject`1<string> IL2CPP_TYPE_GENERICINST
    public partial class GashaExchangeItemCell : DataModel
    {
        public GashaProductItemPresenter?               GashaProductItem                        { get; set; }
        public RewardItem?                              RewardPieceItem                         { get; set; }
        public UITextMeshProUGUI?                       TxtPieceDetail                          { get; set; }
        public GameObject?                              RewardPieceItemFrame                    { get; set; }
        public UITextMeshProUGUI?                       TxtItemName                             { get; set; }
        public GameObject?                              GoKakutoku                              { get; set; }
        public GameObject?                              GoMiKakutoku                            { get; set; }
        public UITextMeshProUGUI?                       TxtPoint                                { get; set; }
        public ButtonBase?                              BtnExChange                             { get; set; }
        public GameObject?                              GoDisableBtn                            { get; set; }
        public GameObject?                              GoRainbowCrystals                       { get; set; }
        public UITextMeshProUGUI?                       TxtLimit                                { get; set; }
        public IGashaExchangeRewardStatus?              CurrentGashaExchangeReward              { get; set; }

        public static GashaExchangeItemCell? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GashaExchangeItemCell() { Pointer= p0 };

            value.GashaProductItem                          = GetObject<GashaProductItemPresenter>(new IntPtr(p + 0x020), ReversePrism.DataModels.GashaProductItemPresenter.FromPointer); // 024665E6A490 0x20 GashaProductItem            ( 000186610A30 ModelClassType GashaProductItemPresenter GashaProductItemPresenter GashaProductItemPresenter Pointer )
            value.RewardPieceItem                           = GetObject<RewardItem>(new IntPtr(p + 0x028), ReversePrism.DataModels.RewardItem.FromPointer); // 024665E6A4B0 0x28 RewardPieceItem             ( 00018667EAE0 ModelClassType RewardItem RewardItem RewardItem Pointer )
            value.TxtPieceDetail                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 024665E6A4D0 0x30 TxtPieceDetail              ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.RewardPieceItemFrame                      = GetObject<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 024665E6A4F0 0x38 RewardPieceItemFrame        ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.TxtItemName                               = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 024665E6A510 0x40 TxtItemName                 ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.GoKakutoku                                = GetObject<GameObject>(new IntPtr(p + 0x048), ReversePrism.DataModels.GameObject.FromPointer); // 024665E6A530 0x48 GoKakutoku                  ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.GoMiKakutoku                              = GetObject<GameObject>(new IntPtr(p + 0x050), ReversePrism.DataModels.GameObject.FromPointer); // 024665E6A550 0x50 GoMiKakutoku                ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.TxtPoint                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x058), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 024665E6A570 0x58 TxtPoint                    ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.BtnExChange                               = GetObject<ButtonBase>(new IntPtr(p + 0x060), ReversePrism.DataModels.ButtonBase.FromPointer); // 024665E6A590 0x60 BtnExChange                 ( 000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.GoDisableBtn                              = GetObject<GameObject>(new IntPtr(p + 0x068), ReversePrism.DataModels.GameObject.FromPointer); // 024665E6A5B0 0x68 GoDisableBtn                ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.GoRainbowCrystals                         = GetObject<GameObject>(new IntPtr(p + 0x070), ReversePrism.DataModels.GameObject.FromPointer); // 024665E6A5D0 0x70 GoRainbowCrystals           ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.TxtLimit                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x078), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 024665E6A5F0 0x78 TxtLimit                    ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.CurrentGashaExchangeReward                = GetObject<IGashaExchangeRewardStatus>(new IntPtr(p + 0x080), ReversePrism.DataModels.IGashaExchangeRewardStatus.FromPointer); // 024665E6A610 0x80 CurrentGashaExchangeReward  ( 0001865243C0 ModelClassType IGashaExchangeRewardStatus IGashaExchangeRewardStatus IGashaExchangeRewardStatus Pointer )

            return value;
        }
    }
}
