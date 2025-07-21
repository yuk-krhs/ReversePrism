using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Root                                     ModelClassType GameObject GameObject GameObject Pointer
    // 028 SkipBtnBase                              ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 030 AllTapBtn                                ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 038 FadeBG                                   ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 040 InfoHand                                 ModelClassType ProduceTutorialInfoHand ProduceTutorialInfoHand ProduceTutorialInfoHand Pointer
    // 048 Arrow                                    ModelClassType RectTransform RectTransform RectTransform Pointer
    // 050 AvoidArrow                               ModelClassType RectTransform RectTransform RectTransform Pointer
    // 058 UnmaskList                               ModelClassListType RectTransform[] RectTransform[] List<RectTransform> Pointer
    // 060 InfoTextView                             ModelClassType ProduceTutorialInfoTextView ProduceTutorialInfoTextView ProduceTutorialInfoTextView Pointer
    // 068 InputBlock                               ModelClassType GameObject GameObject GameObject Pointer
    // 070 CommonPopup                              ModelClassType CommonPopupWindow CommonPopupWindow CommonPopupWindow Pointer
    public partial class ProduceTutorialView : DataModel
    {
        public GameObject?                              Root                                    { get; set; }
        public ButtonBase?                              SkipBtnBase                             { get; set; }
        public ButtonBase?                              AllTapBtn                               { get; set; }
        public CanvasGroup?                             FadeBG                                  { get; set; }
        public ProduceTutorialInfoHand?                 InfoHand                                { get; set; }
        public RectTransform?                           Arrow                                   { get; set; }
        public RectTransform?                           AvoidArrow                              { get; set; }
        public List<RectTransform>?                     UnmaskList                              { get; set; }
        public ProduceTutorialInfoTextView?             InfoTextView                            { get; set; }
        public GameObject?                              InputBlock                              { get; set; }
        public CommonPopupWindow?                       CommonPopup                             { get; set; }

        public static ProduceTutorialView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceTutorialView() { Pointer= p0 };

            value.Root                                      = GetObject<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 0x20 Root                        ( ModelClassType GameObject GameObject GameObject Pointer )
            value.SkipBtnBase                               = GetObject<ButtonBase>(new IntPtr(p + 0x028), ReversePrism.DataModels.ButtonBase.FromPointer); // 0x28 SkipBtnBase                 ( ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.AllTapBtn                                 = GetObject<ButtonBase>(new IntPtr(p + 0x030), ReversePrism.DataModels.ButtonBase.FromPointer); // 0x30 AllTapBtn                   ( ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.FadeBG                                    = GetObject<CanvasGroup>(new IntPtr(p + 0x038), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0x38 FadeBG                      ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.InfoHand                                  = GetObject<ProduceTutorialInfoHand>(new IntPtr(p + 0x040), ReversePrism.DataModels.ProduceTutorialInfoHand.FromPointer); // 0x40 InfoHand                    ( ModelClassType ProduceTutorialInfoHand ProduceTutorialInfoHand ProduceTutorialInfoHand Pointer )
            value.Arrow                                     = GetObject<RectTransform>(new IntPtr(p + 0x048), ReversePrism.DataModels.RectTransform.FromPointer); // 0x48 Arrow                       ( ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.AvoidArrow                                = GetObject<RectTransform>(new IntPtr(p + 0x050), ReversePrism.DataModels.RectTransform.FromPointer); // 0x50 AvoidArrow                  ( ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.UnmaskList                                = GetObjectList<RectTransform>(new IntPtr(p + 0x058), ReversePrism.DataModels.RectTransform.FromPointer); // 0x58 UnmaskList                  ( ModelClassListType RectTransform[] RectTransform[] List<RectTransform> Pointer )
            value.InfoTextView                              = GetObject<ProduceTutorialInfoTextView>(new IntPtr(p + 0x060), ReversePrism.DataModels.ProduceTutorialInfoTextView.FromPointer); // 0x60 InfoTextView                ( ModelClassType ProduceTutorialInfoTextView ProduceTutorialInfoTextView ProduceTutorialInfoTextView Pointer )
            value.InputBlock                                = GetObject<GameObject>(new IntPtr(p + 0x068), ReversePrism.DataModels.GameObject.FromPointer); // 0x68 InputBlock                  ( ModelClassType GameObject GameObject GameObject Pointer )
            value.CommonPopup                               = GetObject<CommonPopupWindow>(new IntPtr(p + 0x070), ReversePrism.DataModels.CommonPopupWindow.FromPointer); // 0x70 CommonPopup                 ( ModelClassType CommonPopupWindow CommonPopupWindow CommonPopupWindow Pointer )

            return value;
        }
    }
}
