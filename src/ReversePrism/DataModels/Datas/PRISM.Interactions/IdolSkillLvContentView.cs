using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 SkillIconView                            0001866BD790 ModelClassType IdolSkillIconView IdolSkillIconView IdolSkillIconView Pointer
    // 028 VoDaViMeMultiView                        000186530920 ModelClassType VoDaViMeMultiView VoDaViMeMultiView VoDaViMeMultiView Pointer
    // 030 TxtSkillName                             0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 Btn                                      0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 040 TxtSkillLv                               0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 CgLock                                   000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 050 TxtLock                                  0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 058 onDetail                                 Subject`1<int> IL2CPP_TYPE_GENERICINST
    public partial class IdolSkillLvContentView
    {
        public IdolSkillIconView?                       SkillIconView                           { get; set; }
        public VoDaViMeMultiView?                       VoDaViMeMultiView                       { get; set; }
        public UITextMeshProUGUI?                       TxtSkillName                            { get; set; }
        public UIButton?                                Btn                                     { get; set; }
        public UITextMeshProUGUI?                       TxtSkillLv                              { get; set; }
        public CanvasGroup?                             CgLock                                  { get; set; }
        public UITextMeshProUGUI?                       TxtLock                                 { get; set; }

        public static IdolSkillLvContentView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IdolSkillLvContentView();

            value.SkillIconView                             = GetObject<IdolSkillIconView>(new IntPtr(p + 0x020), ReversePrism.DataModels.IdolSkillIconView.FromPointer); // 0270DA2FE698 0x20 SkillIconView               ( 0001866BD790 ModelClassType IdolSkillIconView IdolSkillIconView IdolSkillIconView Pointer )
            value.VoDaViMeMultiView                         = GetObject<VoDaViMeMultiView>(new IntPtr(p + 0x028), ReversePrism.DataModels.VoDaViMeMultiView.FromPointer); // 0270DA2FE6B8 0x28 VoDaViMeMultiView           ( 000186530920 ModelClassType VoDaViMeMultiView VoDaViMeMultiView VoDaViMeMultiView Pointer )
            value.TxtSkillName                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA2FE6D8 0x30 TxtSkillName                ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.Btn                                       = GetObject<UIButton>(new IntPtr(p + 0x038), ReversePrism.DataModels.UIButton.FromPointer); // 0270DA2FE6F8 0x38 Btn                         ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.TxtSkillLv                                = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA2FE718 0x40 TxtSkillLv                  ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.CgLock                                    = GetObject<CanvasGroup>(new IntPtr(p + 0x048), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0270DA2FE738 0x48 CgLock                      ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.TxtLock                                   = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x050), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA2FE758 0x50 TxtLock                     ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )

            return value;
        }
    }
}
