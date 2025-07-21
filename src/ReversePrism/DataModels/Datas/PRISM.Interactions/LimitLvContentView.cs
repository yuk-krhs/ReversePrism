using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 RectTransform                            ModelClassType RectTransform RectTransform RectTransform Pointer
    // 028 DiamondDisplay                           ModelClassType DiamondDisplay DiamondDisplay DiamondDisplay Pointer
    // 030 TxtBeforeLv                              ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 TxtAfterLv                               ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 GoSkillSlot                              ModelClassType GameObject GameObject GameObject Pointer
    // 048 SkillSlotIconViews                       ModelClassListType SkillSlotIconView[] SkillSlotIconView[] List<SkillSlotIconView> Pointer
    // 050 ImgOffBg                                 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 058 ImgOnBg                                  ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 060 Mask                                     ModelClassType GameObject GameObject GameObject Pointer
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

            value.RectTransform                             = GetObject<RectTransform>(new IntPtr(p + 0x020), ReversePrism.DataModels.RectTransform.FromPointer); // 0x20 RectTransform               ( ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.DiamondDisplay                            = GetObject<DiamondDisplay>(new IntPtr(p + 0x028), ReversePrism.DataModels.DiamondDisplay.FromPointer); // 0x28 DiamondDisplay              ( ModelClassType DiamondDisplay DiamondDisplay DiamondDisplay Pointer )
            value.TxtBeforeLv                               = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x30 TxtBeforeLv                 ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtAfterLv                                = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x38 TxtAfterLv                  ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.GoSkillSlot                               = GetObject<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 0x40 GoSkillSlot                 ( ModelClassType GameObject GameObject GameObject Pointer )
            value.SkillSlotIconViews                        = GetObjectList<SkillSlotIconView>(new IntPtr(p + 0x048), ReversePrism.DataModels.SkillSlotIconView.FromPointer); // 0x48 SkillSlotIconViews          ( ModelClassListType SkillSlotIconView[] SkillSlotIconView[] List<SkillSlotIconView> Pointer )
            value.ImgOffBg                                  = GetObject<CanvasGroup>(new IntPtr(p + 0x050), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0x50 ImgOffBg                    ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.ImgOnBg                                   = GetObject<CanvasGroup>(new IntPtr(p + 0x058), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0x58 ImgOnBg                     ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.Mask                                      = GetObject<GameObject>(new IntPtr(p + 0x060), ReversePrism.DataModels.GameObject.FromPointer); // 0x60 Mask                        ( ModelClassType GameObject GameObject GameObject Pointer )

            return value;
        }
    }
}
