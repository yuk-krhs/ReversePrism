using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 BtnContentBase                           ModelClassType UIButton UIButton UIButton Pointer
    // 028 SkillIconView                            ModelClassType IdolSkillIconView IdolSkillIconView IdolSkillIconView Pointer
    // 030 VoDaViMeMultiView                        ModelClassType VoDaViMeMultiView VoDaViMeMultiView VoDaViMeMultiView Pointer
    // 038 TxtSkillName                             ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 TxtBeforeCost                            ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 TxtBeforeSkillDetail                     ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 050 TxtAfterCost                             ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 058 TxtAfterSkillDetail                      ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 060 BeforeKeyWordTouchDetector               ModelClassType TMPKeyWordTouchDetector TMPKeyWordTouchDetector TMPKeyWordTouchDetector Pointer
    // 068 AfterKeyWordTouchDetector                ModelClassType TMPKeyWordTouchDetector TMPKeyWordTouchDetector TMPKeyWordTouchDetector Pointer
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

            value.BtnContentBase                            = GetObject<UIButton>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIButton.FromPointer); // 0x20 BtnContentBase              ( ModelClassType UIButton UIButton UIButton Pointer )
            value.SkillIconView                             = GetObject<IdolSkillIconView>(new IntPtr(p + 0x028), ReversePrism.DataModels.IdolSkillIconView.FromPointer); // 0x28 SkillIconView               ( ModelClassType IdolSkillIconView IdolSkillIconView IdolSkillIconView Pointer )
            value.VoDaViMeMultiView                         = GetObject<VoDaViMeMultiView>(new IntPtr(p + 0x030), ReversePrism.DataModels.VoDaViMeMultiView.FromPointer); // 0x30 VoDaViMeMultiView           ( ModelClassType VoDaViMeMultiView VoDaViMeMultiView VoDaViMeMultiView Pointer )
            value.TxtSkillName                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x38 TxtSkillName                ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtBeforeCost                             = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x40 TxtBeforeCost               ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtBeforeSkillDetail                      = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x48 TxtBeforeSkillDetail        ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtAfterCost                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x050), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x50 TxtAfterCost                ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtAfterSkillDetail                       = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x058), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x58 TxtAfterSkillDetail         ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.BeforeKeyWordTouchDetector                = GetObject<TMPKeyWordTouchDetector>(new IntPtr(p + 0x060), ReversePrism.DataModels.TMPKeyWordTouchDetector.FromPointer); // 0x60 BeforeKeyWordTouchDetector  ( ModelClassType TMPKeyWordTouchDetector TMPKeyWordTouchDetector TMPKeyWordTouchDetector Pointer )
            value.AfterKeyWordTouchDetector                 = GetObject<TMPKeyWordTouchDetector>(new IntPtr(p + 0x068), ReversePrism.DataModels.TMPKeyWordTouchDetector.FromPointer); // 0x68 AfterKeyWordTouchDetector   ( ModelClassType TMPKeyWordTouchDetector TMPKeyWordTouchDetector TMPKeyWordTouchDetector Pointer )

            return value;
        }
    }
}
