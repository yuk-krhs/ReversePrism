using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ImgLiveSkillIcon                         000186613190 ModelClassType RawImage RawImage RawImage Pointer
    // 028 TxtLiveSkillName                         0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 TxtLiveSkillLv                           0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 TxtLiveSkillDetail                       0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 onClick                                  Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 048 Parent                                   0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class LiveSkillDetailPopupView
    {
        public RawImage?                                ImgLiveSkillIcon                        { get; set; }
        public UITextMeshProUGUI?                       TxtLiveSkillName                        { get; set; }
        public UITextMeshProUGUI?                       TxtLiveSkillLv                          { get; set; }
        public UITextMeshProUGUI?                       TxtLiveSkillDetail                      { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static LiveSkillDetailPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveSkillDetailPopupView();

            value.ImgLiveSkillIcon                          = GetObject<RawImage>(new IntPtr(p + 0x020), ReversePrism.DataModels.RawImage.FromPointer); // 0270DA2FF150 0x20 ImgLiveSkillIcon            ( 000186613190 ModelClassType RawImage RawImage RawImage Pointer )
            value.TxtLiveSkillName                          = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA2FF170 0x28 TxtLiveSkillName            ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtLiveSkillLv                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA2FF190 0x30 TxtLiveSkillLv              ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtLiveSkillDetail                        = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA2FF1B0 0x38 TxtLiveSkillDetail          ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x048), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0270DA2FF1F0 0x48 Parent                      ( 0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
