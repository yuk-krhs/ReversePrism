using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 3D8 M_Toggle                                 ModelClassType Toggle Toggle Toggle Pointer
    // 3E0 M_Container                              ModelClassType VisualElement VisualElement VisualElement Pointer
    // 3E8 M_Value                                  ModelPrimitiveType bool bool bool Bool
    // 000 ussClassName                             string IL2CPP_TYPE_STRING
    // 008 toggleUssClassName                       string IL2CPP_TYPE_STRING
    // 010 ContentUssClassName                      ModelPrimitiveType string string string String
    // 018 InputUssClassName                        ModelPrimitiveType string string string String
    // 020 CheckmarkUssClassName                    ModelPrimitiveType string string string String
    // 028 TextUssClassName                         ModelPrimitiveType string string string String
    // 030 ToggleInspectorUssClassName              ModelPrimitiveType string string string String
    // 038 UssFoldoutDepthClassName                 ModelPrimitiveType string string string String
    // 040 UssFoldoutMaxDepth                       ModelPrimitiveType int int int Int32
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

            value.M_Toggle                                  = GetObject<Toggle>(new IntPtr(p + 0x3D8), ReversePrism.DataModels.Toggle.FromPointer); // 0x3D8 M_Toggle                    ( ModelClassType Toggle Toggle Toggle Pointer )
            value.M_Container                               = GetObject<VisualElement>(new IntPtr(p + 0x3E0), ReversePrism.DataModels.VisualElement.FromPointer); // 0x3E0 M_Container                 ( ModelClassType VisualElement VisualElement VisualElement Pointer )
            value.M_Value                                   = GetBool(new IntPtr(p + 0x3E8)); // 0x3E8 M_Value                     ( ModelPrimitiveType bool bool bool Bool )
            value.ContentUssClassName                       = GetString(new IntPtr(p + 0x010)); // 0x10 ContentUssClassName         ( ModelPrimitiveType string string string String )
            value.InputUssClassName                         = GetString(new IntPtr(p + 0x018)); // 0x18 InputUssClassName           ( ModelPrimitiveType string string string String )
            value.CheckmarkUssClassName                     = GetString(new IntPtr(p + 0x020)); // 0x20 CheckmarkUssClassName       ( ModelPrimitiveType string string string String )
            value.TextUssClassName                          = GetString(new IntPtr(p + 0x028)); // 0x28 TextUssClassName            ( ModelPrimitiveType string string string String )
            value.ToggleInspectorUssClassName               = GetString(new IntPtr(p + 0x030)); // 0x30 ToggleInspectorUssClassName ( ModelPrimitiveType string string string String )
            value.UssFoldoutDepthClassName                  = GetString(new IntPtr(p + 0x038)); // 0x38 UssFoldoutDepthClassName    ( ModelPrimitiveType string string string String )
            value.UssFoldoutMaxDepth                        = GetInt32(new IntPtr(p + 0x040)); // 0x40 UssFoldoutMaxDepth          ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
