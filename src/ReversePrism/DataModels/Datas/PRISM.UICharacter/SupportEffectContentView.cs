using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TxtSkillName                             ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 TxtDetail                                ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 ImgOffBg                                 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 038 ImgOnBg                                  ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 040 CgLock                                   ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 048 TxtReleaseLv                             ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    public partial class SupportEffectContentView : DataModel
    {
        public UITextMeshProUGUI?                       TxtSkillName                            { get; set; }
        public UITextMeshProUGUI?                       TxtDetail                               { get; set; }
        public CanvasGroup?                             ImgOffBg                                { get; set; }
        public CanvasGroup?                             ImgOnBg                                 { get; set; }
        public CanvasGroup?                             CgLock                                  { get; set; }
        public UITextMeshProUGUI?                       TxtReleaseLv                            { get; set; }

        public static SupportEffectContentView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SupportEffectContentView() { Pointer= p0 };

            value.TxtSkillName                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x20 TxtSkillName                ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtDetail                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x28 TxtDetail                   ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ImgOffBg                                  = GetObject<CanvasGroup>(new IntPtr(p + 0x030), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0x30 ImgOffBg                    ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.ImgOnBg                                   = GetObject<CanvasGroup>(new IntPtr(p + 0x038), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0x38 ImgOnBg                     ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.CgLock                                    = GetObject<CanvasGroup>(new IntPtr(p + 0x040), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0x40 CgLock                      ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.TxtReleaseLv                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x48 TxtReleaseLv                ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )

            return value;
        }
    }
}
