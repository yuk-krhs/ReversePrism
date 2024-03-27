using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ImgBase                                  0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer
    // 028 TxtSkillType                             0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    public partial class VoDaViMeLabel
    {
        public UIImage?                                 ImgBase                                 { get; set; }
        public UITextMeshProUGUI?                       TxtSkillType                            { get; set; }

        public static VoDaViMeLabel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new VoDaViMeLabel();

            value.ImgBase                                   = GetObject<UIImage>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIImage.FromPointer); // 0270D4EF0148 0x20 ImgBase                     ( 0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer )
            value.TxtSkillType                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D4EF0168 0x28 TxtSkillType                ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )

            return value;
        }
    }
}
