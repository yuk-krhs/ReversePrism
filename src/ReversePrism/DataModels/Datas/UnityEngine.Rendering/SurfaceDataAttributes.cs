using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 DisplayNames                             000185B81990 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 018 IsDirection                              000186595960 ModelPrimitiveType bool bool bool Bool
    // 019 SRGBDisplay                              000186595960 ModelPrimitiveType bool bool bool Bool
    // 01C Precision                                000186576970 ModelEnumType FieldPrecision FieldPrecision FieldPrecision Int32
    // 020 CheckIsNormalized                        000186595960 ModelPrimitiveType bool bool bool Bool
    // 028 Preprocessor                             0001866722E0 ModelPrimitiveType string string string String
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

            value.DisplayNames                              = GetStringList(new IntPtr(p + 0x010)); // 0246692BDD08 0x10 DisplayNames                ( 000185B81990 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.IsDirection                               = GetBool(new IntPtr(p + 0x018)); // 0246692BDD28 0x18 IsDirection                 ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.SRGBDisplay                               = GetBool(new IntPtr(p + 0x019)); // 0246692BDD48 0x19 SRGBDisplay                 ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.Precision                                 = (FieldPrecision)GetInt32(new IntPtr(p + 0x01C)); // 0246692BDD68 0x1C Precision                   ( 000186576970 ModelEnumType FieldPrecision FieldPrecision FieldPrecision Int32 )
            value.CheckIsNormalized                         = GetBool(new IntPtr(p + 0x020)); // 0246692BDD88 0x20 CheckIsNormalized           ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.Preprocessor                              = GetString(new IntPtr(p + 0x028)); // 0246692BDDA8 0x28 Preprocessor                ( 0001866722E0 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
