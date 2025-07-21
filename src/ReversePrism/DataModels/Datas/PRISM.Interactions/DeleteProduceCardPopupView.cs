using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 onClosed                                 Subject`1<IReadOnlyList`1<string>> IL2CPP_TYPE_GENERICINST
    // 028 onClickEndButton                         Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 030 onClickClearButton                       Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 038 onClickDeleteButton                      Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 040 SelectablePCardGridView                  ModelClassType SelectablePCardGridView SelectablePCardGridView SelectablePCardGridView Pointer
    // 048 DeleteCountText                          ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 050 DeckCountWarningText                     ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 058 HavingCardAmount                         ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 060 Parent                                   ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class DeleteProduceCardPopupView : DataModel
    {
        public SelectablePCardGridView?                 SelectablePCardGridView                 { get; set; }
        public UITextMeshProUGUI?                       DeleteCountText                         { get; set; }
        public UITextMeshProUGUI?                       DeckCountWarningText                    { get; set; }
        public UITextMeshProUGUI?                       HavingCardAmount                        { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static DeleteProduceCardPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DeleteProduceCardPopupView() { Pointer= p0 };

            value.SelectablePCardGridView                   = GetObject<SelectablePCardGridView>(new IntPtr(p + 0x040), ReversePrism.DataModels.SelectablePCardGridView.FromPointer); // 0x40 SelectablePCardGridView     ( ModelClassType SelectablePCardGridView SelectablePCardGridView SelectablePCardGridView Pointer )
            value.DeleteCountText                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x48 DeleteCountText             ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.DeckCountWarningText                      = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x050), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x50 DeckCountWarningText        ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.HavingCardAmount                          = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x058), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x58 HavingCardAmount            ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x060), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0x60 Parent                      ( ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
