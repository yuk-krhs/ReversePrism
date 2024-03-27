using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 BaseText                                 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 TextCamera                               0001865A1C90 ModelClassType Camera Camera Camera Pointer
    // 030 MaterialModifiers                        000185B75F90 ModelClassListType ColorToUVChannelForTextMeshProUGUI[] ColorToUVChannelForTextMeshProUGUI[] List<ColorToUVChannelForTextMeshProUGUI> Pointer
    public partial class TextureTemplate
    {
        public UITextMeshProUGUI?                       BaseText                                { get; set; }
        public Camera?                                  TextCamera                              { get; set; }
        public List<ColorToUVChannelForTextMeshProUGUI>? MaterialModifiers                       { get; set; }

        public static TextureTemplate? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TextureTemplate();

            value.BaseText                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270069A54F8 0x20 BaseText                    ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TextCamera                                = GetObject<Camera>(new IntPtr(p + 0x028), ReversePrism.DataModels.Camera.FromPointer); // 0270069A5518 0x28 TextCamera                  ( 0001865A1C90 ModelClassType Camera Camera Camera Pointer )
            value.MaterialModifiers                         = GetObjectList<ColorToUVChannelForTextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.ColorToUVChannelForTextMeshProUGUI.FromPointer); // 0270069A5538 0x30 MaterialModifiers           ( 000185B75F90 ModelClassListType ColorToUVChannelForTextMeshProUGUI[] ColorToUVChannelForTextMeshProUGUI[] List<ColorToUVChannelForTextMeshProUGUI> Pointer )

            return value;
        }
    }
}
