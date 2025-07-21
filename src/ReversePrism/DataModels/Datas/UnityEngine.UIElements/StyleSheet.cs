using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 M_ImportedWithErrors                     ModelPrimitiveType bool bool bool Bool
    // 019 M_ImportedWithWarnings                   ModelPrimitiveType bool bool bool Bool
    // 020 M_Rules                                  ModelClassListType StyleRule[] StyleRule[] List<StyleRule> Pointer
    // 028 M_ComplexSelectors                       ModelClassListType StyleComplexSelector[] StyleComplexSelector[] List<StyleComplexSelector> Pointer
    // 030 Floats                                   ModelPrimitiveListType float[] float[] List<float> Pointer
    // 038 Dimensions                               ModelEnumListType Dimension[] Dimension[] List<Dimension> Pointer
    // 040 Colors                                   ModelEnumListType Color[] Color[] List<Color> Pointer
    // 048 Strings                                  ModelPrimitiveListType string[] string[] List<string> Pointer
    // 050 Assets                                   ModelClassListType Object[] Object[] List<Object> Pointer
    // 058 Imports                                  ModelEnumListType ImportStruct[] ImportStruct[] List<ImportStruct> Pointer
    // 060 M_FlattenedImportedStyleSheets           ModelClassListType List`1<StyleSheet> List`1<StyleSheet> List<StyleSheet> Pointer
    // 068 M_ContentHash                            ModelPrimitiveType int int int Int32
    // 070 ScalableImages                           ModelEnumListType ScalableImage[] ScalableImage[] List<ScalableImage> Pointer
    // 078 orderedNameSelectors                     Dictionary`2<string, StyleComplexSelector> IL2CPP_TYPE_GENERICINST
    // 080 orderedTypeSelectors                     Dictionary`2<string, StyleComplexSelector> IL2CPP_TYPE_GENERICINST
    // 088 orderedClassSelectors                    Dictionary`2<string, StyleComplexSelector> IL2CPP_TYPE_GENERICINST
    // 090 M_IsDefaultStyleSheet                    ModelPrimitiveType bool bool bool Bool
    // 000 kCustomPropertyMarker                    string IL2CPP_TYPE_STRING
    public partial class StyleSheet : DataModel
    {
        public bool                                     M_ImportedWithErrors                    { get; set; }
        public bool                                     M_ImportedWithWarnings                  { get; set; }
        public List<StyleRule>?                         M_Rules                                 { get; set; }
        public List<StyleComplexSelector>?              M_ComplexSelectors                      { get; set; }
        public List<float>?                             Floats                                  { get; set; }
        public List<Dimension>?                         Dimensions                              { get; set; }
        public List<Color>?                             Colors                                  { get; set; }
        public List<string>?                            Strings                                 { get; set; }
        public List<Object>?                            Assets                                  { get; set; }
        public List<ImportStruct>?                      Imports                                 { get; set; }
        public List<StyleSheet>?                        M_FlattenedImportedStyleSheets          { get; set; }
        public int                                      M_ContentHash                           { get; set; }
        public List<ScalableImage>?                     ScalableImages                          { get; set; }
        public bool                                     M_IsDefaultStyleSheet                   { get; set; }

        public static StyleSheet? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StyleSheet() { Pointer= p0 };

            value.M_ImportedWithErrors                      = GetBool(new IntPtr(p + 0x018)); // 0x18 M_ImportedWithErrors        ( ModelPrimitiveType bool bool bool Bool )
            value.M_ImportedWithWarnings                    = GetBool(new IntPtr(p + 0x019)); // 0x19 M_ImportedWithWarnings      ( ModelPrimitiveType bool bool bool Bool )
            value.M_Rules                                   = GetObjectList<StyleRule>(new IntPtr(p + 0x020), ReversePrism.DataModels.StyleRule.FromPointer); // 0x20 M_Rules                     ( ModelClassListType StyleRule[] StyleRule[] List<StyleRule> Pointer )
            value.M_ComplexSelectors                        = GetObjectList<StyleComplexSelector>(new IntPtr(p + 0x028), ReversePrism.DataModels.StyleComplexSelector.FromPointer); // 0x28 M_ComplexSelectors          ( ModelClassListType StyleComplexSelector[] StyleComplexSelector[] List<StyleComplexSelector> Pointer )
            value.Floats                                    = GetSingleList(new IntPtr(p + 0x030)); // 0x30 Floats                      ( ModelPrimitiveListType float[] float[] List<float> Pointer )
            value.Dimensions                                = GetEnumList<Dimension>(new IntPtr(p + 0x038)); // 0x38 Dimensions                  ( ModelEnumListType Dimension[] Dimension[] List<Dimension> Pointer )
            value.Colors                                    = GetEnumList<Color>(new IntPtr(p + 0x040)); // 0x40 Colors                      ( ModelEnumListType Color[] Color[] List<Color> Pointer )
            value.Strings                                   = GetStringList(new IntPtr(p + 0x048)); // 0x48 Strings                     ( ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.Assets                                    = GetObjectList<Object>(new IntPtr(p + 0x050), ReversePrism.DataModels.Object.FromPointer); // 0x50 Assets                      ( ModelClassListType Object[] Object[] List<Object> Pointer )
            value.Imports                                   = GetEnumList<ImportStruct>(new IntPtr(p + 0x058)); // 0x58 Imports                     ( ModelEnumListType ImportStruct[] ImportStruct[] List<ImportStruct> Pointer )
            value.M_FlattenedImportedStyleSheets            = GetObjectList<StyleSheet>(new IntPtr(p + 0x060), ReversePrism.DataModels.StyleSheet.FromPointer); // 0x60 M_FlattenedImportedStyleSheets ( ModelClassListType List`1<StyleSheet> List`1<StyleSheet> List<StyleSheet> Pointer )
            value.M_ContentHash                             = GetInt32(new IntPtr(p + 0x068)); // 0x68 M_ContentHash               ( ModelPrimitiveType int int int Int32 )
            value.ScalableImages                            = GetEnumList<ScalableImage>(new IntPtr(p + 0x070)); // 0x70 ScalableImages              ( ModelEnumListType ScalableImage[] ScalableImage[] List<ScalableImage> Pointer )
            value.M_IsDefaultStyleSheet                     = GetBool(new IntPtr(p + 0x090)); // 0x90 M_IsDefaultStyleSheet       ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
