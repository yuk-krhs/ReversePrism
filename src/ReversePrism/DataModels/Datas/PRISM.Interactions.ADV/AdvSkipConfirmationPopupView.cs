using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TopText                                  ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 SkipPopupFromNextTimeText                ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 NotionText                               ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 Toggle                                   ModelClassType ToggleButton ToggleButton ToggleButton Pointer
    // 040 AdvInformationField                      ModelClassType GameObject GameObject GameObject Pointer
    // 048 MainHeadline                             ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 050 SubHeadline                              ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 058 Summary                                  ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 060 SizeType                                 ModelEnumType PopupSizeType PopupSizeType PopupSizeType Int32
    // 068 onClosed                                 Subject`1<ValueTuple`2<bool, bool>> IL2CPP_TYPE_GENERICINST
    // 070 Parent                                   ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class AdvSkipConfirmationPopupView : DataModel
    {
        public UITextMeshProUGUI?                       TopText                                 { get; set; }
        public UITextMeshProUGUI?                       SkipPopupFromNextTimeText               { get; set; }
        public UITextMeshProUGUI?                       NotionText                              { get; set; }
        public ToggleButton?                            Toggle                                  { get; set; }
        public GameObject?                              AdvInformationField                     { get; set; }
        public UITextMeshProUGUI?                       MainHeadline                            { get; set; }
        public UITextMeshProUGUI?                       SubHeadline                             { get; set; }
        public UITextMeshProUGUI?                       Summary                                 { get; set; }
        public PopupSizeType                            SizeType                                { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static AdvSkipConfirmationPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AdvSkipConfirmationPopupView() { Pointer= p0 };

            value.TopText                                   = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x20 TopText                     ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.SkipPopupFromNextTimeText                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x28 SkipPopupFromNextTimeText   ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.NotionText                                = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x30 NotionText                  ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.Toggle                                    = GetObject<ToggleButton>(new IntPtr(p + 0x038), ReversePrism.DataModels.ToggleButton.FromPointer); // 0x38 Toggle                      ( ModelClassType ToggleButton ToggleButton ToggleButton Pointer )
            value.AdvInformationField                       = GetObject<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 0x40 AdvInformationField         ( ModelClassType GameObject GameObject GameObject Pointer )
            value.MainHeadline                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x48 MainHeadline                ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.SubHeadline                               = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x050), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x50 SubHeadline                 ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.Summary                                   = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x058), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x58 Summary                     ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.SizeType                                  = (PopupSizeType)GetInt32(new IntPtr(p + 0x060)); // 0x60 SizeType                    ( ModelEnumType PopupSizeType PopupSizeType PopupSizeType Int32 )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x070), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0x70 Parent                      ( ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
