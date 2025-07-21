using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 M_Name                                   ModelPrimitiveType string string string String
    // 038 M_RuleIndex                              ModelPrimitiveType int int int Int32
    // 040 M_Text                                   ModelPrimitiveType string string string String
    // 048 M_PickingMode                            ModelEnumType PickingMode PickingMode PickingMode Int32
    // 050 M_Classes                                ModelPrimitiveListType string[] string[] List<string> Pointer
    // 058 M_StylesheetPaths                        ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer
    // 060 M_Stylesheets                            ModelClassListType List`1<StyleSheet> List`1<StyleSheet> List<StyleSheet> Pointer
    // 068 M_SkipClone                              ModelPrimitiveType bool bool bool Bool
    public partial class VisualElementAsset : DataModel
    {
        public string                                   M_Name                                  { get; set; }
        public int                                      M_RuleIndex                             { get; set; }
        public string                                   M_Text                                  { get; set; }
        public PickingMode                              M_PickingMode                           { get; set; }
        public List<string>?                            M_Classes                               { get; set; }
        public List<string>?                            M_StylesheetPaths                       { get; set; }
        public List<StyleSheet>?                        M_Stylesheets                           { get; set; }
        public bool                                     M_SkipClone                             { get; set; }

        public static VisualElementAsset? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new VisualElementAsset() { Pointer= p0 };

            value.M_Name                                    = GetString(new IntPtr(p + 0x030)); // 0x30 M_Name                      ( ModelPrimitiveType string string string String )
            value.M_RuleIndex                               = GetInt32(new IntPtr(p + 0x038)); // 0x38 M_RuleIndex                 ( ModelPrimitiveType int int int Int32 )
            value.M_Text                                    = GetString(new IntPtr(p + 0x040)); // 0x40 M_Text                      ( ModelPrimitiveType string string string String )
            value.M_PickingMode                             = (PickingMode)GetInt32(new IntPtr(p + 0x048)); // 0x48 M_PickingMode               ( ModelEnumType PickingMode PickingMode PickingMode Int32 )
            value.M_Classes                                 = GetStringList(new IntPtr(p + 0x050)); // 0x50 M_Classes                   ( ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.M_StylesheetPaths                         = GetStringList(new IntPtr(p + 0x058)); // 0x58 M_StylesheetPaths           ( ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer )
            value.M_Stylesheets                             = GetObjectList<StyleSheet>(new IntPtr(p + 0x060), ReversePrism.DataModels.StyleSheet.FromPointer); // 0x60 M_Stylesheets               ( ModelClassListType List`1<StyleSheet> List`1<StyleSheet> List<StyleSheet> Pointer )
            value.M_SkipClone                               = GetBool(new IntPtr(p + 0x068)); // 0x68 M_SkipClone                 ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
