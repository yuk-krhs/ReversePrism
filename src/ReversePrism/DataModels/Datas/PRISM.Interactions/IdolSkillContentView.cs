using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 IconView                                 0001866BD790 ModelClassType IdolSkillIconView IdolSkillIconView IdolSkillIconView Pointer
    // 028 TxtSkillName                             0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 VoDaViMeMultiView                        000186530920 ModelClassType VoDaViMeMultiView VoDaViMeMultiView VoDaViMeMultiView Pointer
    // 038 Btn                                      0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 040 CgLock                                   000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 048 TxtLock                                  0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 050 onTap                                    Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 058 onLongTap                                Subject`1<int> IL2CPP_TYPE_GENERICINST
    public partial class IdolSkillContentView
    {
        public IdolSkillIconView?                       IconView                                { get; set; }
        public UITextMeshProUGUI?                       TxtSkillName                            { get; set; }
        public VoDaViMeMultiView?                       VoDaViMeMultiView                       { get; set; }
        public UIButton?                                Btn                                     { get; set; }
        public CanvasGroup?                             CgLock                                  { get; set; }
        public UITextMeshProUGUI?                       TxtLock                                 { get; set; }

        public static IdolSkillContentView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IdolSkillContentView();

            value.IconView                                  = GetObject<IdolSkillIconView>(new IntPtr(p + 0x020), ReversePrism.DataModels.IdolSkillIconView.FromPointer); // 0270DA2917E8 0x20 IconView                    ( 0001866BD790 ModelClassType IdolSkillIconView IdolSkillIconView IdolSkillIconView Pointer )
            value.TxtSkillName                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA291808 0x28 TxtSkillName                ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.VoDaViMeMultiView                         = GetObject<VoDaViMeMultiView>(new IntPtr(p + 0x030), ReversePrism.DataModels.VoDaViMeMultiView.FromPointer); // 0270DA291828 0x30 VoDaViMeMultiView           ( 000186530920 ModelClassType VoDaViMeMultiView VoDaViMeMultiView VoDaViMeMultiView Pointer )
            value.Btn                                       = GetObject<UIButton>(new IntPtr(p + 0x038), ReversePrism.DataModels.UIButton.FromPointer); // 0270DA291848 0x38 Btn                         ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.CgLock                                    = GetObject<CanvasGroup>(new IntPtr(p + 0x040), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0270DA291868 0x40 CgLock                      ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.TxtLock                                   = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA291888 0x48 TxtLock                     ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )

            return value;
        }
    }
}
