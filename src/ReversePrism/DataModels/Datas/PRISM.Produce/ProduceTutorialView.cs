using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Root                                     0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 028 SkipBtnBase                              000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 030 AllTapBtn                                000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 038 FadeBG                                   000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 040 InfoHand                                 00018658EC60 ModelClassType ProduceTutorialInfoHand ProduceTutorialInfoHand ProduceTutorialInfoHand Pointer
    // 048 Arrow                                    000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 050 AvoidArrow                               000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 058 UnmaskList                               000185CA0448 ModelClassListType RectTransform[] RectTransform[] List<RectTransform> Pointer
    // 060 InfoTextView                             00018658F180 ModelClassType ProduceTutorialInfoTextView ProduceTutorialInfoTextView ProduceTutorialInfoTextView Pointer
    // 068 InputBlock                               0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 070 CommonPopup                              0001865E8C10 ModelClassType CommonPopupWindow CommonPopupWindow CommonPopupWindow Pointer
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

            value.Root                                      = GetObject<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 024665DC1F00 0x20 Root                        ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.SkipBtnBase                               = GetObject<ButtonBase>(new IntPtr(p + 0x028), ReversePrism.DataModels.ButtonBase.FromPointer); // 024665DC1F20 0x28 SkipBtnBase                 ( 000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.AllTapBtn                                 = GetObject<ButtonBase>(new IntPtr(p + 0x030), ReversePrism.DataModels.ButtonBase.FromPointer); // 024665DC1F40 0x30 AllTapBtn                   ( 000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.FadeBG                                    = GetObject<CanvasGroup>(new IntPtr(p + 0x038), ReversePrism.DataModels.CanvasGroup.FromPointer); // 024665DC1F60 0x38 FadeBG                      ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.InfoHand                                  = GetObject<ProduceTutorialInfoHand>(new IntPtr(p + 0x040), ReversePrism.DataModels.ProduceTutorialInfoHand.FromPointer); // 024665DC1F80 0x40 InfoHand                    ( 00018658EC60 ModelClassType ProduceTutorialInfoHand ProduceTutorialInfoHand ProduceTutorialInfoHand Pointer )
            value.Arrow                                     = GetObject<RectTransform>(new IntPtr(p + 0x048), ReversePrism.DataModels.RectTransform.FromPointer); // 024665DC1FA0 0x48 Arrow                       ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.AvoidArrow                                = GetObject<RectTransform>(new IntPtr(p + 0x050), ReversePrism.DataModels.RectTransform.FromPointer); // 024665DC1FC0 0x50 AvoidArrow                  ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.UnmaskList                                = GetObjectList<RectTransform>(new IntPtr(p + 0x058), ReversePrism.DataModels.RectTransform.FromPointer); // 024665DC1FE0 0x58 UnmaskList                  ( 000185CA0448 ModelClassListType RectTransform[] RectTransform[] List<RectTransform> Pointer )
            value.InfoTextView                              = GetObject<ProduceTutorialInfoTextView>(new IntPtr(p + 0x060), ReversePrism.DataModels.ProduceTutorialInfoTextView.FromPointer); // 024665DC2000 0x60 InfoTextView                ( 00018658F180 ModelClassType ProduceTutorialInfoTextView ProduceTutorialInfoTextView ProduceTutorialInfoTextView Pointer )
            value.InputBlock                                = GetObject<GameObject>(new IntPtr(p + 0x068), ReversePrism.DataModels.GameObject.FromPointer); // 024665DC2020 0x68 InputBlock                  ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.CommonPopup                               = GetObject<CommonPopupWindow>(new IntPtr(p + 0x070), ReversePrism.DataModels.CommonPopupWindow.FromPointer); // 024665DC2040 0x70 CommonPopup                 ( 0001865E8C10 ModelClassType CommonPopupWindow CommonPopupWindow CommonPopupWindow Pointer )

            return value;
        }
    }
}
