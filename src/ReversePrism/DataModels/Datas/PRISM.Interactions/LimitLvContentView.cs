using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 RectTransform                            000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 028 DiamondDisplay                           0001866CF8A0 ModelClassType DiamondDisplay DiamondDisplay DiamondDisplay Pointer
    // 030 TxtBeforeLv                              0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 TxtAfterLv                               0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 GoSkillSlot                              0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 048 SkillSlotIconViews                       000185CA40A8 ModelClassListType SkillSlotIconView[] SkillSlotIconView[] List<SkillSlotIconView> Pointer
    // 050 ImgOffBg                                 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 058 ImgOnBg                                  000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 060 Mask                                     0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    public partial class LimitLvContentView : DataModel
    {
        public RectTransform?                           RectTransform                           { get; set; }
        public DiamondDisplay?                          DiamondDisplay                          { get; set; }
        public UITextMeshProUGUI?                       TxtBeforeLv                             { get; set; }
        public UITextMeshProUGUI?                       TxtAfterLv                              { get; set; }
        public GameObject?                              GoSkillSlot                             { get; set; }
        public List<SkillSlotIconView>?                 SkillSlotIconViews                      { get; set; }
        public CanvasGroup?                             ImgOffBg                                { get; set; }
        public CanvasGroup?                             ImgOnBg                                 { get; set; }
        public GameObject?                              Mask                                    { get; set; }

        public static LimitLvContentView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LimitLvContentView() { Pointer= p0 };

            value.RectTransform                             = GetObject<RectTransform>(new IntPtr(p + 0x020), ReversePrism.DataModels.RectTransform.FromPointer); // 02466A2E30B8 0x20 RectTransform               ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.DiamondDisplay                            = GetObject<DiamondDisplay>(new IntPtr(p + 0x028), ReversePrism.DataModels.DiamondDisplay.FromPointer); // 02466A2E30D8 0x28 DiamondDisplay              ( 0001866CF8A0 ModelClassType DiamondDisplay DiamondDisplay DiamondDisplay Pointer )
            value.TxtBeforeLv                               = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466A2E30F8 0x30 TxtBeforeLv                 ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtAfterLv                                = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466A2E3118 0x38 TxtAfterLv                  ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.GoSkillSlot                               = GetObject<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 02466A2E3138 0x40 GoSkillSlot                 ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.SkillSlotIconViews                        = GetObjectList<SkillSlotIconView>(new IntPtr(p + 0x048), ReversePrism.DataModels.SkillSlotIconView.FromPointer); // 02466A2E3158 0x48 SkillSlotIconViews          ( 000185CA40A8 ModelClassListType SkillSlotIconView[] SkillSlotIconView[] List<SkillSlotIconView> Pointer )
            value.ImgOffBg                                  = GetObject<CanvasGroup>(new IntPtr(p + 0x050), ReversePrism.DataModels.CanvasGroup.FromPointer); // 02466A2E3178 0x50 ImgOffBg                    ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.ImgOnBg                                   = GetObject<CanvasGroup>(new IntPtr(p + 0x058), ReversePrism.DataModels.CanvasGroup.FromPointer); // 02466A2E3198 0x58 ImgOnBg                     ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.Mask                                      = GetObject<GameObject>(new IntPtr(p + 0x060), ReversePrism.DataModels.GameObject.FromPointer); // 02466A2E31B8 0x60 Mask                        ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )

            return value;
        }
    }
}
