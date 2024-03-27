using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 GrayoutController                        0001866EA450 ModelClassType UIGrayOutController UIGrayOutController UIGrayOutController Pointer
    // 038 TxtVoice                                 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 BtnStop                                  0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 048 BtnPlay                                  0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    public partial class VoiceGridElementCellView
    {
        public UIGrayOutController?                     GrayoutController                       { get; set; }
        public UITextMeshProUGUI?                       TxtVoice                                { get; set; }
        public UIButton?                                BtnStop                                 { get; set; }
        public UIButton?                                BtnPlay                                 { get; set; }

        public static VoiceGridElementCellView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new VoiceGridElementCellView();

            value.GrayoutController                         = GetObject<UIGrayOutController>(new IntPtr(p + 0x030), ReversePrism.DataModels.UIGrayOutController.FromPointer); // 0270DA3440A0 0x30 GrayoutController           ( 0001866EA450 ModelClassType UIGrayOutController UIGrayOutController UIGrayOutController Pointer )
            value.TxtVoice                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA3440C0 0x38 TxtVoice                    ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.BtnStop                                   = GetObject<UIButton>(new IntPtr(p + 0x040), ReversePrism.DataModels.UIButton.FromPointer); // 0270DA3440E0 0x40 BtnStop                     ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.BtnPlay                                   = GetObject<UIButton>(new IntPtr(p + 0x048), ReversePrism.DataModels.UIButton.FromPointer); // 0270DA344100 0x48 BtnPlay                     ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )

            return value;
        }
    }
}
