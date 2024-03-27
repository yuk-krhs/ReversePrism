using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 ussClassName                             string IL2CPP_TYPE_STRING
    // 008 containerUssClassName                    string IL2CPP_TYPE_STRING
    // 010 TitleUssClassName                        000186674040 ModelPrimitiveType string string string String
    // 018 TitleContainerUssClassName               000186674040 ModelPrimitiveType string string string String
    // 020 ProgressUssClassName                     000186674040 ModelPrimitiveType string string string String
    // 028 BackgroundUssClassName                   000186674040 ModelPrimitiveType string string string String
    // 3D8 M_Background                             0001866B34A0 ModelClassType VisualElement VisualElement VisualElement Pointer
    // 3E0 M_Progress                               0001866B34A0 ModelClassType VisualElement VisualElement VisualElement Pointer
    // 3E8 M_Title                                  000186775260 ModelClassType Label Label Label Pointer
    // 3F0 M_LowValue                               0001866656B0 ModelPrimitiveType float float float Single
    // 3F4 M_HighValue                              0001866656B0 ModelPrimitiveType float float float Single
    // 3F8 M_Value                                  0001866656B0 ModelPrimitiveType float float float Single
    public partial class AbstractProgressBar
    {
        public string                                   TitleUssClassName                       { get; set; }
        public string                                   TitleContainerUssClassName              { get; set; }
        public string                                   ProgressUssClassName                    { get; set; }
        public string                                   BackgroundUssClassName                  { get; set; }
        public VisualElement?                           M_Background                            { get; set; }
        public VisualElement?                           M_Progress                              { get; set; }
        public Label?                                   M_Title                                 { get; set; }
        public float                                    M_LowValue                              { get; set; }
        public float                                    M_HighValue                             { get; set; }
        public float                                    M_Value                                 { get; set; }

        public static AbstractProgressBar? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AbstractProgressBar();

            value.TitleUssClassName                         = GetString(new IntPtr(p + 0x010)); // 0270050E2D80 0x10 TitleUssClassName           ( 000186674040 ModelPrimitiveType string string string String )
            value.TitleContainerUssClassName                = GetString(new IntPtr(p + 0x018)); // 0270050E2DA0 0x18 TitleContainerUssClassName  ( 000186674040 ModelPrimitiveType string string string String )
            value.ProgressUssClassName                      = GetString(new IntPtr(p + 0x020)); // 0270050E2DC0 0x20 ProgressUssClassName        ( 000186674040 ModelPrimitiveType string string string String )
            value.BackgroundUssClassName                    = GetString(new IntPtr(p + 0x028)); // 0270050E2DE0 0x28 BackgroundUssClassName      ( 000186674040 ModelPrimitiveType string string string String )
            value.M_Background                              = GetObject<VisualElement>(new IntPtr(p + 0x3D8), ReversePrism.DataModels.VisualElement.FromPointer); // 0270050E2E00 0x3D8 M_Background                ( 0001866B34A0 ModelClassType VisualElement VisualElement VisualElement Pointer )
            value.M_Progress                                = GetObject<VisualElement>(new IntPtr(p + 0x3E0), ReversePrism.DataModels.VisualElement.FromPointer); // 0270050E2E20 0x3E0 M_Progress                  ( 0001866B34A0 ModelClassType VisualElement VisualElement VisualElement Pointer )
            value.M_Title                                   = GetObject<Label>(new IntPtr(p + 0x3E8), ReversePrism.DataModels.Label.FromPointer); // 0270050E2E40 0x3E8 M_Title                     ( 000186775260 ModelClassType Label Label Label Pointer )
            value.M_LowValue                                = GetSingle(new IntPtr(p + 0x3F0)); // 0270050E2E60 0x3F0 M_LowValue                  ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_HighValue                               = GetSingle(new IntPtr(p + 0x3F4)); // 0270050E2E80 0x3F4 M_HighValue                 ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_Value                                   = GetSingle(new IntPtr(p + 0x3F8)); // 0270050E2EA0 0x3F8 M_Value                     ( 0001866656B0 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
