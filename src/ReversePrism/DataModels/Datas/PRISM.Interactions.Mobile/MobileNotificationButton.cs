using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 MobileCallBtnTwesta                      ModelPrimitiveType string string string String
    // 028 MobileCallBtnChain                       ModelPrimitiveType string string string String
    // 030 MobileCallBtnPhone                       ModelPrimitiveType string string string String
    // 038 Button                                   ModelClassType UIButton UIButton UIButton Pointer
    // 040 Animator                                 ModelClassType Animator Animator Animator Pointer
    // 048 TitleText                                ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 050 SubText                                  ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 058 IconImage                                ModelClassType UIImage UIImage UIImage Pointer
    // 060 NotificationImage                        ModelClassType UIImage UIImage UIImage Pointer
    public partial class MobileNotificationButton : DataModel
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
            var value   = new MobileNotificationButton() { Pointer= p0 };

            value.MobileCallBtnTwesta                       = GetString(new IntPtr(p + 0x020)); // 0x20 MobileCallBtnTwesta         ( ModelPrimitiveType string string string String )
            value.MobileCallBtnChain                        = GetString(new IntPtr(p + 0x028)); // 0x28 MobileCallBtnChain          ( ModelPrimitiveType string string string String )
            value.MobileCallBtnPhone                        = GetString(new IntPtr(p + 0x030)); // 0x30 MobileCallBtnPhone          ( ModelPrimitiveType string string string String )
            value.Button                                    = GetObject<UIButton>(new IntPtr(p + 0x038), ReversePrism.DataModels.UIButton.FromPointer); // 0x38 Button                      ( ModelClassType UIButton UIButton UIButton Pointer )
            value.Animator                                  = GetObject<Animator>(new IntPtr(p + 0x040), ReversePrism.DataModels.Animator.FromPointer); // 0x40 Animator                    ( ModelClassType Animator Animator Animator Pointer )
            value.TitleText                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x48 TitleText                   ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.SubText                                   = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x050), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x50 SubText                     ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.IconImage                                 = GetObject<UIImage>(new IntPtr(p + 0x058), ReversePrism.DataModels.UIImage.FromPointer); // 0x58 IconImage                   ( ModelClassType UIImage UIImage UIImage Pointer )
            value.NotificationImage                         = GetObject<UIImage>(new IntPtr(p + 0x060), ReversePrism.DataModels.UIImage.FromPointer); // 0x60 NotificationImage           ( ModelClassType UIImage UIImage UIImage Pointer )

            return value;
        }
    }
}
