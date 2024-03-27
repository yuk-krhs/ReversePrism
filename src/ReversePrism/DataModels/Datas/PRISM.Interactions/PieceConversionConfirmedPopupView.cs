using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 GridView                                 000186734B50 ModelClassType EnhancedPieceSelectGridView EnhancedPieceSelectGridView EnhancedPieceSelectGridView Pointer
    // 028 TxtBeforePoint                           0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 TxtAfterPoint                            0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 TxtAttention                             0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 onClick                                  Subject`1<bool> IL2CPP_TYPE_GENERICINST
    // 048 Parent                                   0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class PieceConversionConfirmedPopupView
    {
        public EnhancedPieceSelectGridView?             GridView                                { get; set; }
        public UITextMeshProUGUI?                       TxtBeforePoint                          { get; set; }
        public UITextMeshProUGUI?                       TxtAfterPoint                           { get; set; }
        public UITextMeshProUGUI?                       TxtAttention                            { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static PieceConversionConfirmedPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PieceConversionConfirmedPopupView();

            value.GridView                                  = GetObject<EnhancedPieceSelectGridView>(new IntPtr(p + 0x020), ReversePrism.DataModels.EnhancedPieceSelectGridView.FromPointer); // 0270DA317350 0x20 GridView                    ( 000186734B50 ModelClassType EnhancedPieceSelectGridView EnhancedPieceSelectGridView EnhancedPieceSelectGridView Pointer )
            value.TxtBeforePoint                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA317370 0x28 TxtBeforePoint              ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtAfterPoint                             = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA317390 0x30 TxtAfterPoint               ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtAttention                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA3173B0 0x38 TxtAttention                ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x048), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0270DA3173F0 0x48 Parent                      ( 0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
