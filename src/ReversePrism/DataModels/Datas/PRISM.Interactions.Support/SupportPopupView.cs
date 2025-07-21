using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 AccountDeleteLinkKey                     string IL2CPP_TYPE_STRING
    // 020 ButtonLabelPairs                         ModelClassListType ButtonLabelPair[] ButtonLabelPair[] List<ButtonLabelPair> Pointer
    // 028 onCloseButtonClicked                     Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 030 Parent                                   ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
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

            value.ButtonLabelPairs                          = GetObjectList<ButtonLabelPair>(new IntPtr(p + 0x020), ReversePrism.DataModels.ButtonLabelPair.FromPointer); // 0x20 ButtonLabelPairs            ( ModelClassListType ButtonLabelPair[] ButtonLabelPair[] List<ButtonLabelPair> Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x030), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0x30 Parent                      ( ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
