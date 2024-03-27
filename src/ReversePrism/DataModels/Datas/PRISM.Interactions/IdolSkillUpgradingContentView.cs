using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 BtnContentBase                           0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 028 SkillIconView                            0001866BD790 ModelClassType IdolSkillIconView IdolSkillIconView IdolSkillIconView Pointer
    // 030 VoDaViMeMultiView                        000186530920 ModelClassType VoDaViMeMultiView VoDaViMeMultiView VoDaViMeMultiView Pointer
    // 038 TxtSkillName                             0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 GoLock                                   0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 048 TxtLock                                  0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 050 onOpen                                   Subject`1<int> IL2CPP_TYPE_GENERICINST
    public partial class IdolSkillUpgradingContentView
    {
        public UIButton?                                BtnContentBase                          { get; set; }
        public IdolSkillIconView?                       SkillIconView                           { get; set; }
        public VoDaViMeMultiView?                       VoDaViMeMultiView                       { get; set; }
        public UITextMeshProUGUI?                       TxtSkillName                            { get; set; }
        public GameObject?                              GoLock                                  { get; set; }
        public UITextMeshProUGUI?                       TxtLock                                 { get; set; }

        public static IdolSkillUpgradingContentView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IdolSkillUpgradingContentView();

            value.BtnContentBase                            = GetObject<UIButton>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIButton.FromPointer); // 0270DA3460C8 0x20 BtnContentBase              ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.SkillIconView                             = GetObject<IdolSkillIconView>(new IntPtr(p + 0x028), ReversePrism.DataModels.IdolSkillIconView.FromPointer); // 0270DA3460E8 0x28 SkillIconView               ( 0001866BD790 ModelClassType IdolSkillIconView IdolSkillIconView IdolSkillIconView Pointer )
            value.VoDaViMeMultiView                         = GetObject<VoDaViMeMultiView>(new IntPtr(p + 0x030), ReversePrism.DataModels.VoDaViMeMultiView.FromPointer); // 0270DA346108 0x30 VoDaViMeMultiView           ( 000186530920 ModelClassType VoDaViMeMultiView VoDaViMeMultiView VoDaViMeMultiView Pointer )
            value.TxtSkillName                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA346128 0x38 TxtSkillName                ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.GoLock                                    = GetObject<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 0270DA346148 0x40 GoLock                      ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.TxtLock                                   = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA346168 0x48 TxtLock                     ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )

            return value;
        }
    }
}
