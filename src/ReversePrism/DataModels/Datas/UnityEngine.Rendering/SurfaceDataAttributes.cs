using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 DisplayNames                             ModelPrimitiveListType string[] string[] List<string> Pointer
    // 018 IsDirection                              ModelPrimitiveType bool bool bool Bool
    // 019 SRGBDisplay                              ModelPrimitiveType bool bool bool Bool
    // 01C Precision                                ModelEnumType FieldPrecision FieldPrecision FieldPrecision Int32
    // 020 CheckIsNormalized                        ModelPrimitiveType bool bool bool Bool
    // 028 Preprocessor                             ModelPrimitiveType string string string String
    public partial class SurfaceDataAttributes : DataModel
    {
        public List<string>?                            DisplayNames                            { get; set; }
        public bool                                     IsDirection                             { get; set; }
        public bool                                     SRGBDisplay                             { get; set; }
        public FieldPrecision                           Precision                               { get; set; }
        public bool                                     CheckIsNormalized                       { get; set; }
        public string                                   Preprocessor                            { get; set; }

        public static SurfaceDataAttributes? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SurfaceDataAttributes() { Pointer= p0 };

            value.DisplayNames                              = GetStringList(new IntPtr(p + 0x010)); // 0x10 DisplayNames                ( ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.IsDirection                               = GetBool(new IntPtr(p + 0x018)); // 0x18 IsDirection                 ( ModelPrimitiveType bool bool bool Bool )
            value.SRGBDisplay                               = GetBool(new IntPtr(p + 0x019)); // 0x19 SRGBDisplay                 ( ModelPrimitiveType bool bool bool Bool )
            value.Precision                                 = (FieldPrecision)GetInt32(new IntPtr(p + 0x01C)); // 0x1C Precision                   ( ModelEnumType FieldPrecision FieldPrecision FieldPrecision Int32 )
            value.CheckIsNormalized                         = GetBool(new IntPtr(p + 0x020)); // 0x20 CheckIsNormalized           ( ModelPrimitiveType bool bool bool Bool )
            value.Preprocessor                              = GetString(new IntPtr(p + 0x028)); // 0x28 Preprocessor                ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
