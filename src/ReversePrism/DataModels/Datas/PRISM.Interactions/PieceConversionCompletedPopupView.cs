using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ItemIcon                                 0001865BC1A0 ModelClassType CmnItem CmnItem CmnItem Pointer
    // 028 TxtAcquired                              0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 TxtBeforePoint                           0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 TxtAfterPoint                            0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 onClick                                  Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 048 Parent                                   0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class PieceConversionCompletedPopupView
    {
        public CmnItem?                                 ItemIcon                                { get; set; }
        public UITextMeshProUGUI?                       TxtAcquired                             { get; set; }
        public UITextMeshProUGUI?                       TxtBeforePoint                          { get; set; }
        public UITextMeshProUGUI?                       TxtAfterPoint                           { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static PieceConversionCompletedPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PieceConversionCompletedPopupView();

            value.ItemIcon                                  = GetObject<CmnItem>(new IntPtr(p + 0x020), ReversePrism.DataModels.CmnItem.FromPointer); // 0270DA317068 0x20 ItemIcon                    ( 0001865BC1A0 ModelClassType CmnItem CmnItem CmnItem Pointer )
            value.TxtAcquired                               = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA317088 0x28 TxtAcquired                 ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtBeforePoint                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA3170A8 0x30 TxtBeforePoint              ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtAfterPoint                             = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA3170C8 0x38 TxtAfterPoint               ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x048), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0270DA317108 0x48 Parent                      ( 0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
