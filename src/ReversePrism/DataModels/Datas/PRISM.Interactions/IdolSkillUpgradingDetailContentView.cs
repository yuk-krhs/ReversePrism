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
    // 040 TxtBeforeCost                            0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 TxtBeforeSkillDetail                     0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 050 TxtAfterCost                             0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 058 TxtAfterSkillDetail                      0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 060 BeforeKeyWordTouchDetector               000186609CD0 ModelClassType TMPKeyWordTouchDetector TMPKeyWordTouchDetector TMPKeyWordTouchDetector Pointer
    // 068 AfterKeyWordTouchDetector                000186609CD0 ModelClassType TMPKeyWordTouchDetector TMPKeyWordTouchDetector TMPKeyWordTouchDetector Pointer
    // 070 onClose                                  Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 078 onTouchSkillId                           Subject`1<List`1<string>> IL2CPP_TYPE_GENERICINST
    public partial class IdolSkillUpgradingDetailContentView : DataModel
    {
        public UIButton?                                BtnContentBase                          { get; set; }
        public IdolSkillIconView?                       SkillIconView                           { get; set; }
        public VoDaViMeMultiView?                       VoDaViMeMultiView                       { get; set; }
        public UITextMeshProUGUI?                       TxtSkillName                            { get; set; }
        public UITextMeshProUGUI?                       TxtBeforeCost                           { get; set; }
        public UITextMeshProUGUI?                       TxtBeforeSkillDetail                    { get; set; }
        public UITextMeshProUGUI?                       TxtAfterCost                            { get; set; }
        public UITextMeshProUGUI?                       TxtAfterSkillDetail                     { get; set; }
        public TMPKeyWordTouchDetector?                 BeforeKeyWordTouchDetector              { get; set; }
        public TMPKeyWordTouchDetector?                 AfterKeyWordTouchDetector               { get; set; }

        public static IdolSkillUpgradingDetailContentView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IdolSkillUpgradingDetailContentView() { Pointer= p0 };

            value.BtnContentBase                            = GetObject<UIButton>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIButton.FromPointer); // 02466A3B94A8 0x20 BtnContentBase              ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.SkillIconView                             = GetObject<IdolSkillIconView>(new IntPtr(p + 0x028), ReversePrism.DataModels.IdolSkillIconView.FromPointer); // 02466A3B94C8 0x28 SkillIconView               ( 0001866BD790 ModelClassType IdolSkillIconView IdolSkillIconView IdolSkillIconView Pointer )
            value.VoDaViMeMultiView                         = GetObject<VoDaViMeMultiView>(new IntPtr(p + 0x030), ReversePrism.DataModels.VoDaViMeMultiView.FromPointer); // 02466A3B94E8 0x30 VoDaViMeMultiView           ( 000186530920 ModelClassType VoDaViMeMultiView VoDaViMeMultiView VoDaViMeMultiView Pointer )
            value.TxtSkillName                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466A3B9508 0x38 TxtSkillName                ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtBeforeCost                             = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466A3B9528 0x40 TxtBeforeCost               ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtBeforeSkillDetail                      = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466A3B9548 0x48 TxtBeforeSkillDetail        ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtAfterCost                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x050), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466A3B9568 0x50 TxtAfterCost                ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtAfterSkillDetail                       = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x058), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466A3B9588 0x58 TxtAfterSkillDetail         ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.BeforeKeyWordTouchDetector                = GetObject<TMPKeyWordTouchDetector>(new IntPtr(p + 0x060), ReversePrism.DataModels.TMPKeyWordTouchDetector.FromPointer); // 02466A3B95A8 0x60 BeforeKeyWordTouchDetector  ( 000186609CD0 ModelClassType TMPKeyWordTouchDetector TMPKeyWordTouchDetector TMPKeyWordTouchDetector Pointer )
            value.AfterKeyWordTouchDetector                 = GetObject<TMPKeyWordTouchDetector>(new IntPtr(p + 0x068), ReversePrism.DataModels.TMPKeyWordTouchDetector.FromPointer); // 02466A3B95C8 0x68 AfterKeyWordTouchDetector   ( 000186609CD0 ModelClassType TMPKeyWordTouchDetector TMPKeyWordTouchDetector TMPKeyWordTouchDetector Pointer )

            return value;
        }
    }
}
