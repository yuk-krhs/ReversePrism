using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 onClickCloseButtonSubject                Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 028 onClickKeyWordSubject                    Subject`1<List`1<int>> IL2CPP_TYPE_GENERICINST
    // 030 Icon                                     00018669EBE0 ModelClassType TrainerSkillIconView TrainerSkillIconView TrainerSkillIconView Pointer
    // 038 VoDaViMeView                             000186530920 ModelClassType VoDaViMeMultiView VoDaViMeMultiView VoDaViMeMultiView Pointer
    // 040 SkillNameText                            0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 DescriptionText                          0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 050 TmpKeyWordTouchDetector                  000186609CD0 ModelClassType TMPKeyWordTouchDetector TMPKeyWordTouchDetector TMPKeyWordTouchDetector Pointer
    // 058 FrameParameter                           000186762FA0 ModelClassType PopupFrameParameter PopupFrameParameter PopupFrameParameter Pointer
    // 060 Parent                                   0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class ProduceEnemySkillDetailPopupView
    {
        public TrainerSkillIconView?                    Icon                                    { get; set; }
        public VoDaViMeMultiView?                       VoDaViMeView                            { get; set; }
        public UITextMeshProUGUI?                       SkillNameText                           { get; set; }
        public UITextMeshProUGUI?                       DescriptionText                         { get; set; }
        public TMPKeyWordTouchDetector?                 TmpKeyWordTouchDetector                 { get; set; }
        public PopupFrameParameter?                     FrameParameter                          { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static ProduceEnemySkillDetailPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceEnemySkillDetailPopupView();

            value.Icon                                      = GetObject<TrainerSkillIconView>(new IntPtr(p + 0x030), ReversePrism.DataModels.TrainerSkillIconView.FromPointer); // 0270DA0E0A88 0x30 Icon                        ( 00018669EBE0 ModelClassType TrainerSkillIconView TrainerSkillIconView TrainerSkillIconView Pointer )
            value.VoDaViMeView                              = GetObject<VoDaViMeMultiView>(new IntPtr(p + 0x038), ReversePrism.DataModels.VoDaViMeMultiView.FromPointer); // 0270DA0E0AA8 0x38 VoDaViMeView                ( 000186530920 ModelClassType VoDaViMeMultiView VoDaViMeMultiView VoDaViMeMultiView Pointer )
            value.SkillNameText                             = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA0E0AC8 0x40 SkillNameText               ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.DescriptionText                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA0E0AE8 0x48 DescriptionText             ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TmpKeyWordTouchDetector                   = GetObject<TMPKeyWordTouchDetector>(new IntPtr(p + 0x050), ReversePrism.DataModels.TMPKeyWordTouchDetector.FromPointer); // 0270DA0E0B08 0x50 TmpKeyWordTouchDetector     ( 000186609CD0 ModelClassType TMPKeyWordTouchDetector TMPKeyWordTouchDetector TMPKeyWordTouchDetector Pointer )
            value.FrameParameter                            = GetObject<PopupFrameParameter>(new IntPtr(p + 0x058), ReversePrism.DataModels.PopupFrameParameter.FromPointer); // 0270DA0E0B28 0x58 FrameParameter              ( 000186762FA0 ModelClassType PopupFrameParameter PopupFrameParameter PopupFrameParameter Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x060), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0270DA0E0B48 0x60 Parent                      ( 0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
