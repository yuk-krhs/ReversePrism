using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 3D8 TemplateId                               000186671910 ModelPrimitiveType string string string String
    // 3E0 M_ContentContainer                       0001866B2D70 ModelClassType VisualElement VisualElement VisualElement Pointer
    // 3E8 M_TemplateSource                         00018652C200 ModelClassType VisualTreeAsset VisualTreeAsset VisualTreeAsset Pointer
    public partial class TemplateContainer
    {
        public string                                   TemplateId                              { get; set; }
        public VisualElement?                           M_ContentContainer                      { get; set; }
        public VisualTreeAsset?                         M_TemplateSource                        { get; set; }

        public static TemplateContainer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TemplateContainer();

            value.TemplateId                                = GetString(new IntPtr(p + 0x3D8)); // 027006844718 0x3D8 TemplateId                  ( 000186671910 ModelPrimitiveType string string string String )
            value.M_ContentContainer                        = GetObject<VisualElement>(new IntPtr(p + 0x3E0), ReversePrism.DataModels.VisualElement.FromPointer); // 027006844738 0x3E0 M_ContentContainer          ( 0001866B2D70 ModelClassType VisualElement VisualElement VisualElement Pointer )
            value.M_TemplateSource                          = GetObject<VisualTreeAsset>(new IntPtr(p + 0x3E8), ReversePrism.DataModels.VisualTreeAsset.FromPointer); // 027006844758 0x3E8 M_TemplateSource            ( 00018652C200 ModelClassType VisualTreeAsset VisualTreeAsset VisualTreeAsset Pointer )

            return value;
        }
    }
}
