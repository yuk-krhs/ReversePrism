using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 3D8 M_Toggle                                 000186682E60 ModelClassType Toggle Toggle Toggle Pointer
    // 3E0 M_Container                              0001866B2D70 ModelClassType VisualElement VisualElement VisualElement Pointer
    // 3E8 M_Value                                  000186594D10 ModelPrimitiveType bool bool bool Bool
    // 000 ussClassName                             string IL2CPP_TYPE_STRING
    // 008 toggleUssClassName                       string IL2CPP_TYPE_STRING
    // 010 ContentUssClassName                      000186674040 ModelPrimitiveType string string string String
    // 018 InputUssClassName                        000186674040 ModelPrimitiveType string string string String
    // 020 CheckmarkUssClassName                    000186674040 ModelPrimitiveType string string string String
    // 028 TextUssClassName                         000186674040 ModelPrimitiveType string string string String
    // 030 ToggleInspectorUssClassName              000186673B80 ModelPrimitiveType string string string String
    // 038 UssFoldoutDepthClassName                 000186673B80 ModelPrimitiveType string string string String
    // 040 UssFoldoutMaxDepth                       0001865F4E00 ModelPrimitiveType int int int Int32
    public partial class Foldout : DataModel
    {
        public Toggle?                                  M_Toggle                                { get; set; }
        public VisualElement?                           M_Container                             { get; set; }
        public bool                                     M_Value                                 { get; set; }
        public string                                   ContentUssClassName                     { get; set; }
        public string                                   InputUssClassName                       { get; set; }
        public string                                   CheckmarkUssClassName                   { get; set; }
        public string                                   TextUssClassName                        { get; set; }
        public string                                   ToggleInspectorUssClassName             { get; set; }
        public string                                   UssFoldoutDepthClassName                { get; set; }
        public int                                      UssFoldoutMaxDepth                      { get; set; }

        public static Foldout? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Foldout() { Pointer= p0 };

            value.M_Toggle                                  = GetObject<Toggle>(new IntPtr(p + 0x3D8), ReversePrism.DataModels.Toggle.FromPointer); // 0245A66D20F0 0x3D8 M_Toggle                    ( 000186682E60 ModelClassType Toggle Toggle Toggle Pointer )
            value.M_Container                               = GetObject<VisualElement>(new IntPtr(p + 0x3E0), ReversePrism.DataModels.VisualElement.FromPointer); // 0245A66D2110 0x3E0 M_Container                 ( 0001866B2D70 ModelClassType VisualElement VisualElement VisualElement Pointer )
            value.M_Value                                   = GetBool(new IntPtr(p + 0x3E8)); // 0245A66D2130 0x3E8 M_Value                     ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.ContentUssClassName                       = GetString(new IntPtr(p + 0x010)); // 0245A66D2190 0x10 ContentUssClassName         ( 000186674040 ModelPrimitiveType string string string String )
            value.InputUssClassName                         = GetString(new IntPtr(p + 0x018)); // 0245A66D21B0 0x18 InputUssClassName           ( 000186674040 ModelPrimitiveType string string string String )
            value.CheckmarkUssClassName                     = GetString(new IntPtr(p + 0x020)); // 0245A66D21D0 0x20 CheckmarkUssClassName       ( 000186674040 ModelPrimitiveType string string string String )
            value.TextUssClassName                          = GetString(new IntPtr(p + 0x028)); // 0245A66D21F0 0x28 TextUssClassName            ( 000186674040 ModelPrimitiveType string string string String )
            value.ToggleInspectorUssClassName               = GetString(new IntPtr(p + 0x030)); // 0245A66D2210 0x30 ToggleInspectorUssClassName ( 000186673B80 ModelPrimitiveType string string string String )
            value.UssFoldoutDepthClassName                  = GetString(new IntPtr(p + 0x038)); // 0245A66D2230 0x38 UssFoldoutDepthClassName    ( 000186673B80 ModelPrimitiveType string string string String )
            value.UssFoldoutMaxDepth                        = GetInt32(new IntPtr(p + 0x040)); // 0245A66D2250 0x40 UssFoldoutMaxDepth          ( 0001865F4E00 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
