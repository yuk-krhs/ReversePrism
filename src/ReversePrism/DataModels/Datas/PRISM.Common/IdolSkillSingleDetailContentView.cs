using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ImgSkillIcon                             000186613190 ModelClassType RawImage RawImage RawImage Pointer
    // 028 TxtPp                                    0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 VoDaViMeView                             000186530920 ModelClassType VoDaViMeMultiView VoDaViMeMultiView VoDaViMeMultiView Pointer
    // 038 TxtSKillName                             0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 TxtLv                                    0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 TxtDetail                                0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    public partial class IdolSkillSingleDetailContentView
    {
        public RawImage?                                ImgSkillIcon                            { get; set; }
        public UITextMeshProUGUI?                       TxtPp                                   { get; set; }
        public VoDaViMeMultiView?                       VoDaViMeView                            { get; set; }
        public UITextMeshProUGUI?                       TxtSKillName                            { get; set; }
        public UITextMeshProUGUI?                       TxtLv                                   { get; set; }
        public UITextMeshProUGUI?                       TxtDetail                               { get; set; }

        public static IdolSkillSingleDetailContentView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IdolSkillSingleDetailContentView();

            value.ImgSkillIcon                              = GetObject<RawImage>(new IntPtr(p + 0x020), ReversePrism.DataModels.RawImage.FromPointer); // 0270D5976460 0x20 ImgSkillIcon                ( 000186613190 ModelClassType RawImage RawImage RawImage Pointer )
            value.TxtPp                                     = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D5976480 0x28 TxtPp                       ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.VoDaViMeView                              = GetObject<VoDaViMeMultiView>(new IntPtr(p + 0x030), ReversePrism.DataModels.VoDaViMeMultiView.FromPointer); // 0270D59764A0 0x30 VoDaViMeView                ( 000186530920 ModelClassType VoDaViMeMultiView VoDaViMeMultiView VoDaViMeMultiView Pointer )
            value.TxtSKillName                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D59764C0 0x38 TxtSKillName                ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtLv                                     = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D59764E0 0x40 TxtLv                       ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtDetail                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D5976500 0x48 TxtDetail                   ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )

            return value;
        }
    }
}
