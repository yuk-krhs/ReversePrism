using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 AccountDeleteLinkKey                     string IL2CPP_TYPE_STRING
    // 020 ButtonLabelPairs                         000185CC35D8 ModelClassListType ButtonLabelPair[] ButtonLabelPair[] List<ButtonLabelPair> Pointer
    // 028 privacyOptionPopupFactory                PopupViewFactory`1<IPrivacyOptionPopupView> IL2CPP_TYPE_GENERICINST
    // 030 checkJewelPopupViewFactory               PopupViewFactory`1<ICheckJewelPopupView> IL2CPP_TYPE_GENERICINST
    // 038 copyrightPopupViewFactory                PopupViewFactory`1<ICopyrightPopupView> IL2CPP_TYPE_GENERICINST
    // 040 ageLimitPopupViewFactory                 PopupViewFactory`1<IAgePurchaseLimitPopupView> IL2CPP_TYPE_GENERICINST
    // 048 onCloseButtonClicked                     Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 050 Parent                                   0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class SupportPopupView : DataModel
    {
        public List<ButtonLabelPair>?                   ButtonLabelPairs                        { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static SupportPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SupportPopupView() { Pointer= p0 };

            value.ButtonLabelPairs                          = GetObjectList<ButtonLabelPair>(new IntPtr(p + 0x020), ReversePrism.DataModels.ButtonLabelPair.FromPointer); // 02466BEF4940 0x20 ButtonLabelPairs            ( 000185CC35D8 ModelClassListType ButtonLabelPair[] ButtonLabelPair[] List<ButtonLabelPair> Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x050), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 02466BEF4A00 0x50 Parent                      ( 0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
