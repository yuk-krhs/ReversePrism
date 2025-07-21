using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ImgBase                                  ModelClassType UIImage UIImage UIImage Pointer
    // 028 TxtSkillType                             ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    public partial class VoDaViMeLabel : DataModel
    {
        public UIImage?                                 ImgBase                                 { get; set; }
        public UITextMeshProUGUI?                       TxtSkillType                            { get; set; }

        public static VoDaViMeLabel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new VoDaViMeLabel() { Pointer= p0 };

            value.ImgBase                                   = GetObject<UIImage>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIImage.FromPointer); // 0x20 ImgBase                     ( ModelClassType UIImage UIImage UIImage Pointer )
            value.TxtSkillType                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x28 TxtSkillType                ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )

            return value;
        }
    }
}
