using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 PopupFrameParameter                      ModelClassType PopupFrameParameter PopupFrameParameter PopupFrameParameter Pointer
    // 028 ParameterType                            ModelEnumType GashaStartType GashaStartType GashaStartType Int32
    // 030 GashaExchangeRewardId                    ModelPrimitiveType string string string String
    // 038 TxtMessage                               ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 GoDivItem1                               ModelClassType GameObject GameObject GameObject Pointer
    // 048 GoDivItem1PieceBase                      ModelClassType GameObject GameObject GameObject Pointer
    // 050 TxtDivItem1PieceDetail                   ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 058 GoDivItem2                               ModelClassType GameObject GameObject GameObject Pointer
    // 060 GoDivItem2PieceBase                      ModelClassType GameObject GameObject GameObject Pointer
    // 068 TxtDivItem2PieceDetail                   ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 070 Div1Item                                 ModelClassType GashaProductItemPresenter GashaProductItemPresenter GashaProductItemPresenter Pointer
    // 078 Div1Text                                 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 080 Div2Item                                 ModelClassType GashaProductItemPresenter GashaProductItemPresenter GashaProductItemPresenter Pointer
    // 088 Div2Text                                 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 090 Points                                   ModelClassListType GashaExchangeConfirmationPoint[] GashaExchangeConfirmationPoint[] List<GashaExchangeConfirmationPoint> Pointer
    // 098 onClosed                                 Subject`1<string> IL2CPP_TYPE_GENERICINST
    // 0A0 Parent                                   ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class GashaExchangeConfirmationPopupView : DataModel
    {
        public PopupFrameParameter?                     PopupFrameParameter                     { get; set; }
        public GashaStartType                           ParameterType                           { get; set; }
        public string                                   GashaExchangeRewardId                   { get; set; }
        public UITextMeshProUGUI?                       TxtMessage                              { get; set; }
        public GameObject?                              GoDivItem1                              { get; set; }
        public GameObject?                              GoDivItem1PieceBase                     { get; set; }
        public UITextMeshProUGUI?                       TxtDivItem1PieceDetail                  { get; set; }
        public GameObject?                              GoDivItem2                              { get; set; }
        public GameObject?                              GoDivItem2PieceBase                     { get; set; }
        public UITextMeshProUGUI?                       TxtDivItem2PieceDetail                  { get; set; }
        public GashaProductItemPresenter?               Div1Item                                { get; set; }
        public UITextMeshProUGUI?                       Div1Text                                { get; set; }
        public GashaProductItemPresenter?               Div2Item                                { get; set; }
        public UITextMeshProUGUI?                       Div2Text                                { get; set; }
        public List<GashaExchangeConfirmationPoint>?    Points                                  { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static GashaExchangeConfirmationPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GashaExchangeConfirmationPopupView() { Pointer= p0 };

            value.PopupFrameParameter                       = GetObject<PopupFrameParameter>(new IntPtr(p + 0x020), ReversePrism.DataModels.PopupFrameParameter.FromPointer); // 0x20 PopupFrameParameter         ( ModelClassType PopupFrameParameter PopupFrameParameter PopupFrameParameter Pointer )
            value.ParameterType                             = (GashaStartType)GetInt32(new IntPtr(p + 0x028)); // 0x28 ParameterType               ( ModelEnumType GashaStartType GashaStartType GashaStartType Int32 )
            value.GashaExchangeRewardId                     = GetString(new IntPtr(p + 0x030)); // 0x30 GashaExchangeRewardId       ( ModelPrimitiveType string string string String )
            value.TxtMessage                                = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x38 TxtMessage                  ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.GoDivItem1                                = GetObject<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 0x40 GoDivItem1                  ( ModelClassType GameObject GameObject GameObject Pointer )
            value.GoDivItem1PieceBase                       = GetObject<GameObject>(new IntPtr(p + 0x048), ReversePrism.DataModels.GameObject.FromPointer); // 0x48 GoDivItem1PieceBase         ( ModelClassType GameObject GameObject GameObject Pointer )
            value.TxtDivItem1PieceDetail                    = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x050), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x50 TxtDivItem1PieceDetail      ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.GoDivItem2                                = GetObject<GameObject>(new IntPtr(p + 0x058), ReversePrism.DataModels.GameObject.FromPointer); // 0x58 GoDivItem2                  ( ModelClassType GameObject GameObject GameObject Pointer )
            value.GoDivItem2PieceBase                       = GetObject<GameObject>(new IntPtr(p + 0x060), ReversePrism.DataModels.GameObject.FromPointer); // 0x60 GoDivItem2PieceBase         ( ModelClassType GameObject GameObject GameObject Pointer )
            value.TxtDivItem2PieceDetail                    = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x068), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x68 TxtDivItem2PieceDetail      ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.Div1Item                                  = GetObject<GashaProductItemPresenter>(new IntPtr(p + 0x070), ReversePrism.DataModels.GashaProductItemPresenter.FromPointer); // 0x70 Div1Item                    ( ModelClassType GashaProductItemPresenter GashaProductItemPresenter GashaProductItemPresenter Pointer )
            value.Div1Text                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x078), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x78 Div1Text                    ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.Div2Item                                  = GetObject<GashaProductItemPresenter>(new IntPtr(p + 0x080), ReversePrism.DataModels.GashaProductItemPresenter.FromPointer); // 0x80 Div2Item                    ( ModelClassType GashaProductItemPresenter GashaProductItemPresenter GashaProductItemPresenter Pointer )
            value.Div2Text                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x088), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x88 Div2Text                    ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.Points                                    = GetObjectList<GashaExchangeConfirmationPoint>(new IntPtr(p + 0x090), ReversePrism.DataModels.GashaExchangeConfirmationPoint.FromPointer); // 0x90 Points                      ( ModelClassListType GashaExchangeConfirmationPoint[] GashaExchangeConfirmationPoint[] List<GashaExchangeConfirmationPoint> Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0xA0 Parent                      ( ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
