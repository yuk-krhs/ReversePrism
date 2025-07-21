using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 GashaProductItem                         ModelClassType GashaProductItemPresenter GashaProductItemPresenter GashaProductItemPresenter Pointer
    // 028 RewardPieceItem                          ModelClassType RewardItem RewardItem RewardItem Pointer
    // 030 TxtPieceDetail                           ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 RewardPieceItemFrame                     ModelClassType GameObject GameObject GameObject Pointer
    // 040 TxtItemName                              ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 GoKakutoku                               ModelClassType GameObject GameObject GameObject Pointer
    // 050 GoMiKakutoku                             ModelClassType GameObject GameObject GameObject Pointer
    // 058 TxtPoint                                 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 060 BtnExChange                              ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 068 GoDisableBtn                             ModelClassType GameObject GameObject GameObject Pointer
    // 070 GoRainbowCrystals                        ModelClassType GameObject GameObject GameObject Pointer
    // 078 TxtLimit                                 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 080 CurrentGashaExchangeReward               ModelClassType IGashaExchangeRewardStatus IGashaExchangeRewardStatus IGashaExchangeRewardStatus Pointer
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

            value.GashaProductItem                          = GetObject<GashaProductItemPresenter>(new IntPtr(p + 0x020), ReversePrism.DataModels.GashaProductItemPresenter.FromPointer); // 0x20 GashaProductItem            ( ModelClassType GashaProductItemPresenter GashaProductItemPresenter GashaProductItemPresenter Pointer )
            value.RewardPieceItem                           = GetObject<RewardItem>(new IntPtr(p + 0x028), ReversePrism.DataModels.RewardItem.FromPointer); // 0x28 RewardPieceItem             ( ModelClassType RewardItem RewardItem RewardItem Pointer )
            value.TxtPieceDetail                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x30 TxtPieceDetail              ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.RewardPieceItemFrame                      = GetObject<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 0x38 RewardPieceItemFrame        ( ModelClassType GameObject GameObject GameObject Pointer )
            value.TxtItemName                               = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x40 TxtItemName                 ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.GoKakutoku                                = GetObject<GameObject>(new IntPtr(p + 0x048), ReversePrism.DataModels.GameObject.FromPointer); // 0x48 GoKakutoku                  ( ModelClassType GameObject GameObject GameObject Pointer )
            value.GoMiKakutoku                              = GetObject<GameObject>(new IntPtr(p + 0x050), ReversePrism.DataModels.GameObject.FromPointer); // 0x50 GoMiKakutoku                ( ModelClassType GameObject GameObject GameObject Pointer )
            value.TxtPoint                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x058), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x58 TxtPoint                    ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.BtnExChange                               = GetObject<ButtonBase>(new IntPtr(p + 0x060), ReversePrism.DataModels.ButtonBase.FromPointer); // 0x60 BtnExChange                 ( ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.GoDisableBtn                              = GetObject<GameObject>(new IntPtr(p + 0x068), ReversePrism.DataModels.GameObject.FromPointer); // 0x68 GoDisableBtn                ( ModelClassType GameObject GameObject GameObject Pointer )
            value.GoRainbowCrystals                         = GetObject<GameObject>(new IntPtr(p + 0x070), ReversePrism.DataModels.GameObject.FromPointer); // 0x70 GoRainbowCrystals           ( ModelClassType GameObject GameObject GameObject Pointer )
            value.TxtLimit                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x078), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x78 TxtLimit                    ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.CurrentGashaExchangeReward                = GetObject<IGashaExchangeRewardStatus>(new IntPtr(p + 0x080), ReversePrism.DataModels.IGashaExchangeRewardStatus.FromPointer); // 0x80 CurrentGashaExchangeReward  ( ModelClassType IGashaExchangeRewardStatus IGashaExchangeRewardStatus IGashaExchangeRewardStatus Pointer )

            return value;
        }
    }
}
