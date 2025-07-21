using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 BaseText                                 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 TextCamera                               ModelClassType Camera Camera Camera Pointer
    // 030 MaterialModifiers                        ModelClassListType ColorToUVChannelForTextMeshProUGUI[] ColorToUVChannelForTextMeshProUGUI[] List<ColorToUVChannelForTextMeshProUGUI> Pointer
    public partial class TextureTemplate : DataModel
    {
        public UITextMeshProUGUI?                       BaseText                                { get; set; }
        public Camera?                                  TextCamera                              { get; set; }
        public List<ColorToUVChannelForTextMeshProUGUI>? MaterialModifiers                       { get; set; }

        public static TextureTemplate? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TextureTemplate() { Pointer= p0 };

            value.BaseText                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x20 BaseText                    ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TextCamera                                = GetObject<Camera>(new IntPtr(p + 0x028), ReversePrism.DataModels.Camera.FromPointer); // 0x28 TextCamera                  ( ModelClassType Camera Camera Camera Pointer )
            value.MaterialModifiers                         = GetObjectList<ColorToUVChannelForTextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.ColorToUVChannelForTextMeshProUGUI.FromPointer); // 0x30 MaterialModifiers           ( ModelClassListType ColorToUVChannelForTextMeshProUGUI[] ColorToUVChannelForTextMeshProUGUI[] List<ColorToUVChannelForTextMeshProUGUI> Pointer )

            return value;
        }
    }
}
