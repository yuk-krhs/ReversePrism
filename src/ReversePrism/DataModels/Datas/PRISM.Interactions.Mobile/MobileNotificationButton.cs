using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 MobileCallBtnTwesta                      000186672F10 ModelPrimitiveType string string string String
    // 028 MobileCallBtnChain                       000186672F10 ModelPrimitiveType string string string String
    // 030 MobileCallBtnPhone                       000186672F10 ModelPrimitiveType string string string String
    // 038 Button                                   0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 040 Animator                                 0001866B8DE0 ModelClassType Animator Animator Animator Pointer
    // 048 TitleText                                0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 050 SubText                                  0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 058 IconImage                                0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer
    // 060 NotificationImage                        0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer
    public partial class MobileNotificationButton
    {
        public string                                   MobileCallBtnTwesta                     { get; set; }
        public string                                   MobileCallBtnChain                      { get; set; }
        public string                                   MobileCallBtnPhone                      { get; set; }
        public UIButton?                                Button                                  { get; set; }
        public Animator?                                Animator                                { get; set; }
        public UITextMeshProUGUI?                       TitleText                               { get; set; }
        public UITextMeshProUGUI?                       SubText                                 { get; set; }
        public UIImage?                                 IconImage                               { get; set; }
        public UIImage?                                 NotificationImage                       { get; set; }

        public static MobileNotificationButton? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MobileNotificationButton();

            value.MobileCallBtnTwesta                       = GetString(new IntPtr(p + 0x020)); // 027004F74AD8 0x20 MobileCallBtnTwesta         ( 000186672F10 ModelPrimitiveType string string string String )
            value.MobileCallBtnChain                        = GetString(new IntPtr(p + 0x028)); // 027004F74AF8 0x28 MobileCallBtnChain          ( 000186672F10 ModelPrimitiveType string string string String )
            value.MobileCallBtnPhone                        = GetString(new IntPtr(p + 0x030)); // 027004F74B18 0x30 MobileCallBtnPhone          ( 000186672F10 ModelPrimitiveType string string string String )
            value.Button                                    = GetObject<UIButton>(new IntPtr(p + 0x038), ReversePrism.DataModels.UIButton.FromPointer); // 027004F74B38 0x38 Button                      ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.Animator                                  = GetObject<Animator>(new IntPtr(p + 0x040), ReversePrism.DataModels.Animator.FromPointer); // 027004F74B58 0x40 Animator                    ( 0001866B8DE0 ModelClassType Animator Animator Animator Pointer )
            value.TitleText                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 027004F74B78 0x48 TitleText                   ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.SubText                                   = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x050), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 027004F74B98 0x50 SubText                     ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.IconImage                                 = GetObject<UIImage>(new IntPtr(p + 0x058), ReversePrism.DataModels.UIImage.FromPointer); // 027004F74BB8 0x58 IconImage                   ( 0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer )
            value.NotificationImage                         = GetObject<UIImage>(new IntPtr(p + 0x060), ReversePrism.DataModels.UIImage.FromPointer); // 027004F74BD8 0x60 NotificationImage           ( 0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer )

            return value;
        }
    }
}
