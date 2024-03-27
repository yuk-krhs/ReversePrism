using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TxtLv                                    0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 ImgPP                                    000186613190 ModelClassType RawImage RawImage RawImage Pointer
    // 030 TxtPP                                    0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 VoDaViMeMultiView                        000186530920 ModelClassType VoDaViMeMultiView VoDaViMeMultiView VoDaViMeMultiView Pointer
    // 040 TxtDetail                                0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 TmpKeyWordTouchDetector                  000186609CD0 ModelClassType TMPKeyWordTouchDetector TMPKeyWordTouchDetector TMPKeyWordTouchDetector Pointer
    // 050 KeyWordTouchId                           IObservable`1<List`1<string>> IL2CPP_TYPE_GENERICINST
    public partial class IdolSkillDetailListElementView
    {
        public UITextMeshProUGUI?                       TxtLv                                   { get; set; }
        public RawImage?                                ImgPP                                   { get; set; }
        public UITextMeshProUGUI?                       TxtPP                                   { get; set; }
        public VoDaViMeMultiView?                       VoDaViMeMultiView                       { get; set; }
        public UITextMeshProUGUI?                       TxtDetail                               { get; set; }
        public TMPKeyWordTouchDetector?                 TmpKeyWordTouchDetector                 { get; set; }

        public static IdolSkillDetailListElementView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IdolSkillDetailListElementView();

            value.TxtLv                                     = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DB562F20 0x20 TxtLv                       ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ImgPP                                     = GetObject<RawImage>(new IntPtr(p + 0x028), ReversePrism.DataModels.RawImage.FromPointer); // 0270DB562F40 0x28 ImgPP                       ( 000186613190 ModelClassType RawImage RawImage RawImage Pointer )
            value.TxtPP                                     = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DB562F60 0x30 TxtPP                       ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.VoDaViMeMultiView                         = GetObject<VoDaViMeMultiView>(new IntPtr(p + 0x038), ReversePrism.DataModels.VoDaViMeMultiView.FromPointer); // 0270DB562F80 0x38 VoDaViMeMultiView           ( 000186530920 ModelClassType VoDaViMeMultiView VoDaViMeMultiView VoDaViMeMultiView Pointer )
            value.TxtDetail                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DB562FA0 0x40 TxtDetail                   ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TmpKeyWordTouchDetector                   = GetObject<TMPKeyWordTouchDetector>(new IntPtr(p + 0x048), ReversePrism.DataModels.TMPKeyWordTouchDetector.FromPointer); // 0270DB562FC0 0x48 TmpKeyWordTouchDetector     ( 000186609CD0 ModelClassType TMPKeyWordTouchDetector TMPKeyWordTouchDetector TMPKeyWordTouchDetector Pointer )

            return value;
        }
    }
}
