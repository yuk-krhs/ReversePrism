using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 M_Text                                   ModelClassType Text Text Text Pointer
    // 028 M_Image                                  ModelClassType Image Image Image Pointer
    // 030 M_RectTransform                          ModelClassType RectTransform RectTransform RectTransform Pointer
    // 038 M_Toggle                                 ModelClassType Toggle Toggle Toggle Pointer
    public partial class DropdownItem : DataModel
    {
        public Text?                                    M_Text                                  { get; set; }
        public Image?                                   M_Image                                 { get; set; }
        public RectTransform?                           M_RectTransform                         { get; set; }
        public Toggle?                                  M_Toggle                                { get; set; }

        public static DropdownItem? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DropdownItem() { Pointer= p0 };

            value.M_Text                                    = GetObject<Text>(new IntPtr(p + 0x020), ReversePrism.DataModels.Text.FromPointer); // 0x20 M_Text                      ( ModelClassType Text Text Text Pointer )
            value.M_Image                                   = GetObject<Image>(new IntPtr(p + 0x028), ReversePrism.DataModels.Image.FromPointer); // 0x28 M_Image                     ( ModelClassType Image Image Image Pointer )
            value.M_RectTransform                           = GetObject<RectTransform>(new IntPtr(p + 0x030), ReversePrism.DataModels.RectTransform.FromPointer); // 0x30 M_RectTransform             ( ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.M_Toggle                                  = GetObject<Toggle>(new IntPtr(p + 0x038), ReversePrism.DataModels.Toggle.FromPointer); // 0x38 M_Toggle                    ( ModelClassType Toggle Toggle Toggle Pointer )

            return value;
        }
    }
}
