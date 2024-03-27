using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CanvasGroup                              000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 028 ImgLiveSkillIcon                         000186613190 ModelClassType RawImage RawImage RawImage Pointer
    // 030 BtnLiveSkillIcon                         0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 038 TxtLiveSkillName                         0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 TxtLiveSkillLv                           0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 TxtLiveSkillDetail                       0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 050 IdolSkillIconView                        0001866BD790 ModelClassType IdolSkillIconView IdolSkillIconView IdolSkillIconView Pointer
    // 058 TxtPp                                    0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 060 TxtIdolSkillName                         0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 068 VoDaViMeMultiView                        000186530920 ModelClassType VoDaViMeMultiView VoDaViMeMultiView VoDaViMeMultiView Pointer
    // 070 TxtIdolSkillLv                           0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 078 TxtIdolSkillDetail                       0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 080 TmpKeyWordTouchDetector                  000186609CD0 ModelClassType TMPKeyWordTouchDetector TMPKeyWordTouchDetector TMPKeyWordTouchDetector Pointer
    // 088 keywordTouchId                           Subject`1<List`1<int>> IL2CPP_TYPE_GENERICINST
    // 090 onLiveSkillDetail                        Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    public partial class FIdolDetailSkillView
    {
        public CanvasGroup?                             CanvasGroup                             { get; set; }
        public RawImage?                                ImgLiveSkillIcon                        { get; set; }
        public UIButton?                                BtnLiveSkillIcon                        { get; set; }
        public UITextMeshProUGUI?                       TxtLiveSkillName                        { get; set; }
        public UITextMeshProUGUI?                       TxtLiveSkillLv                          { get; set; }
        public UITextMeshProUGUI?                       TxtLiveSkillDetail                      { get; set; }
        public IdolSkillIconView?                       IdolSkillIconView                       { get; set; }
        public UITextMeshProUGUI?                       TxtPp                                   { get; set; }
        public UITextMeshProUGUI?                       TxtIdolSkillName                        { get; set; }
        public VoDaViMeMultiView?                       VoDaViMeMultiView                       { get; set; }
        public UITextMeshProUGUI?                       TxtIdolSkillLv                          { get; set; }
        public UITextMeshProUGUI?                       TxtIdolSkillDetail                      { get; set; }
        public TMPKeyWordTouchDetector?                 TmpKeyWordTouchDetector                 { get; set; }

        public static FIdolDetailSkillView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FIdolDetailSkillView();

            value.CanvasGroup                               = GetObject<CanvasGroup>(new IntPtr(p + 0x020), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0270DA2ADE28 0x20 CanvasGroup                 ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.ImgLiveSkillIcon                          = GetObject<RawImage>(new IntPtr(p + 0x028), ReversePrism.DataModels.RawImage.FromPointer); // 0270DA2ADE48 0x28 ImgLiveSkillIcon            ( 000186613190 ModelClassType RawImage RawImage RawImage Pointer )
            value.BtnLiveSkillIcon                          = GetObject<UIButton>(new IntPtr(p + 0x030), ReversePrism.DataModels.UIButton.FromPointer); // 0270DA2ADE68 0x30 BtnLiveSkillIcon            ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.TxtLiveSkillName                          = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA2ADE88 0x38 TxtLiveSkillName            ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtLiveSkillLv                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA2ADEA8 0x40 TxtLiveSkillLv              ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtLiveSkillDetail                        = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA2ADEC8 0x48 TxtLiveSkillDetail          ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.IdolSkillIconView                         = GetObject<IdolSkillIconView>(new IntPtr(p + 0x050), ReversePrism.DataModels.IdolSkillIconView.FromPointer); // 0270DA2ADEE8 0x50 IdolSkillIconView           ( 0001866BD790 ModelClassType IdolSkillIconView IdolSkillIconView IdolSkillIconView Pointer )
            value.TxtPp                                     = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x058), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA2ADF08 0x58 TxtPp                       ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtIdolSkillName                          = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x060), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA2ADF28 0x60 TxtIdolSkillName            ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.VoDaViMeMultiView                         = GetObject<VoDaViMeMultiView>(new IntPtr(p + 0x068), ReversePrism.DataModels.VoDaViMeMultiView.FromPointer); // 0270DA2ADF48 0x68 VoDaViMeMultiView           ( 000186530920 ModelClassType VoDaViMeMultiView VoDaViMeMultiView VoDaViMeMultiView Pointer )
            value.TxtIdolSkillLv                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x070), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA2ADF68 0x70 TxtIdolSkillLv              ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtIdolSkillDetail                        = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x078), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA2ADF88 0x78 TxtIdolSkillDetail          ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TmpKeyWordTouchDetector                   = GetObject<TMPKeyWordTouchDetector>(new IntPtr(p + 0x080), ReversePrism.DataModels.TMPKeyWordTouchDetector.FromPointer); // 0270DA2ADFA8 0x80 TmpKeyWordTouchDetector     ( 000186609CD0 ModelClassType TMPKeyWordTouchDetector TMPKeyWordTouchDetector TMPKeyWordTouchDetector Pointer )

            return value;
        }
    }
}
