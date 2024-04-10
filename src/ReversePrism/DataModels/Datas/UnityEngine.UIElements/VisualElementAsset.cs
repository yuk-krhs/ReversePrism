using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 M_Name                                   000186671910 ModelPrimitiveType string string string String
    // 038 M_RuleIndex                              0001865F2AF0 ModelPrimitiveType int int int Int32
    // 040 M_Text                                   000186671910 ModelPrimitiveType string string string String
    // 048 M_PickingMode                            00018673C830 ModelEnumType PickingMode PickingMode PickingMode Int32
    // 050 M_Classes                                000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 058 M_StylesheetPaths                        000185D0D518 ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer
    // 060 M_Stylesheets                            000185D0EC28 ModelClassListType List`1<StyleSheet> List`1<StyleSheet> List<StyleSheet> Pointer
    public partial class VisualElementAsset : DataModel
    {
        public string                                   M_Name                                  { get; set; }
        public int                                      M_RuleIndex                             { get; set; }
        public string                                   M_Text                                  { get; set; }
        public PickingMode                              M_PickingMode                           { get; set; }
        public List<string>?                            M_Classes                               { get; set; }
        public List<string>?                            M_StylesheetPaths                       { get; set; }
        public List<StyleSheet>?                        M_Stylesheets                           { get; set; }

        public static VisualElementAsset? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new VisualElementAsset() { Pointer= p0 };

            value.M_Name                                    = GetString(new IntPtr(p + 0x030)); // 0245A6810870 0x30 M_Name                      ( 000186671910 ModelPrimitiveType string string string String )
            value.M_RuleIndex                               = GetInt32(new IntPtr(p + 0x038)); // 0245A6810890 0x38 M_RuleIndex                 ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_Text                                    = GetString(new IntPtr(p + 0x040)); // 0245A68108B0 0x40 M_Text                      ( 000186671910 ModelPrimitiveType string string string String )
            value.M_PickingMode                             = (PickingMode)GetInt32(new IntPtr(p + 0x048)); // 0245A68108D0 0x48 M_PickingMode               ( 00018673C830 ModelEnumType PickingMode PickingMode PickingMode Int32 )
            value.M_Classes                                 = GetStringList(new IntPtr(p + 0x050)); // 0245A68108F0 0x50 M_Classes                   ( 000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.M_StylesheetPaths                         = GetStringList(new IntPtr(p + 0x058)); // 0245A6810910 0x58 M_StylesheetPaths           ( 000185D0D518 ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer )
            value.M_Stylesheets                             = GetObjectList<StyleSheet>(new IntPtr(p + 0x060), ReversePrism.DataModels.StyleSheet.FromPointer); // 0245A6810930 0x60 M_Stylesheets               ( 000185D0EC28 ModelClassListType List`1<StyleSheet> List`1<StyleSheet> List<StyleSheet> Pointer )

            return value;
        }
    }
}
