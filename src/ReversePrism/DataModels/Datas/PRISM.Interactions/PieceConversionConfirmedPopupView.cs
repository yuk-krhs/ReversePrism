using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 GridView                                 ModelClassType EnhancedPieceSelectGridView EnhancedPieceSelectGridView EnhancedPieceSelectGridView Pointer
    // 028 TxtBeforePoint                           ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 TxtAfterPoint                            ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 TxtAttention                             ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 onClick                                  Subject`1<bool> IL2CPP_TYPE_GENERICINST
    // 048 Parent                                   ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class PieceConversionConfirmedPopupView : DataModel
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
            var value   = new PieceConversionConfirmedPopupView() { Pointer= p0 };

            value.GridView                                  = GetObject<EnhancedPieceSelectGridView>(new IntPtr(p + 0x020), ReversePrism.DataModels.EnhancedPieceSelectGridView.FromPointer); // 0x20 GridView                    ( ModelClassType EnhancedPieceSelectGridView EnhancedPieceSelectGridView EnhancedPieceSelectGridView Pointer )
            value.TxtBeforePoint                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x28 TxtBeforePoint              ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtAfterPoint                             = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x30 TxtAfterPoint               ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtAttention                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x38 TxtAttention                ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x048), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0x48 Parent                      ( ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
