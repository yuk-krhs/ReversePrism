using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Color                                    ModelEnumListType Color[] Color[] List<Color> Pointer
    // 028 Image                                    ModelClassType UIImage UIImage UIImage Pointer
    // 030 Label                                    ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    public partial class StoryTypeLabel : DataModel
    {
        public List<Color>?                             Color                                   { get; set; }
        public UIImage?                                 Image                                   { get; set; }
        public UITextMeshProUGUI?                       Label                                   { get; set; }

        public static StoryTypeLabel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StoryTypeLabel() { Pointer= p0 };

            value.Color                                     = GetEnumList<Color>(new IntPtr(p + 0x020)); // 0x20 Color                       ( ModelEnumListType Color[] Color[] List<Color> Pointer )
            value.Image                                     = GetObject<UIImage>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIImage.FromPointer); // 0x28 Image                       ( ModelClassType UIImage UIImage UIImage Pointer )
            value.Label                                     = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x30 Label                       ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )

            return value;
        }
    }
}
