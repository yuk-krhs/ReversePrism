using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 XpathExpr                                000186671910 ModelPrimitiveType string string string String
    // 018 XpathExprIndex                           0001865F2AF0 ModelPrimitiveType int int int Int32
    // 01C Kind                                     000186723D90 ModelEnumType LexKind LexKind LexKind Int32
    // 020 _currentChar                             char IL2CPP_TYPE_CHAR
    // 028 Name                                     000186671910 ModelPrimitiveType string string string String
    // 030 Prefix                                   000186671910 ModelPrimitiveType string string string String
    // 038 StringValue                              000186671910 ModelPrimitiveType string string string String
    // 040 NumberValue                              0001865C2950 ModelPrimitiveType double double double Double
    // 048 CanBeFunction                            000186594D10 ModelPrimitiveType bool bool bool Bool
    // 050 XmlCharType                              00018658F4B0 ModelEnumType XmlCharType XmlCharType XmlCharType Int32
    public partial class XPathScanner : DataModel
    {
        public string                                   XpathExpr                               { get; set; }
        public int                                      XpathExprIndex                          { get; set; }
        public LexKind                                  Kind                                    { get; set; }
        public string                                   Name                                    { get; set; }
        public string                                   Prefix                                  { get; set; }
        public string                                   StringValue                             { get; set; }
        public double                                   NumberValue                             { get; set; }
        public bool                                     CanBeFunction                           { get; set; }
        public XmlCharType                              XmlCharType                             { get; set; }

        public static XPathScanner? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XPathScanner() { Pointer= p0 };

            value.XpathExpr                                 = GetString(new IntPtr(p + 0x010)); // 024667693EB8 0x10 XpathExpr                   ( 000186671910 ModelPrimitiveType string string string String )
            value.XpathExprIndex                            = GetInt32(new IntPtr(p + 0x018)); // 024667693ED8 0x18 XpathExprIndex              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Kind                                      = (LexKind)GetInt32(new IntPtr(p + 0x01C)); // 024667693EF8 0x1C Kind                        ( 000186723D90 ModelEnumType LexKind LexKind LexKind Int32 )
            value.Name                                      = GetString(new IntPtr(p + 0x028)); // 024667693F38 0x28 Name                        ( 000186671910 ModelPrimitiveType string string string String )
            value.Prefix                                    = GetString(new IntPtr(p + 0x030)); // 024667693F58 0x30 Prefix                      ( 000186671910 ModelPrimitiveType string string string String )
            value.StringValue                               = GetString(new IntPtr(p + 0x038)); // 024667693F78 0x38 StringValue                 ( 000186671910 ModelPrimitiveType string string string String )
            value.NumberValue                               = GetDouble(new IntPtr(p + 0x040)); // 024667693F98 0x40 NumberValue                 ( 0001865C2950 ModelPrimitiveType double double double Double )
            value.CanBeFunction                             = GetBool(new IntPtr(p + 0x048)); // 024667693FB8 0x48 CanBeFunction               ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.XmlCharType                               = (XmlCharType)GetInt32(new IntPtr(p + 0x050)); // 024667693FD8 0x50 XmlCharType                 ( 00018658F4B0 ModelEnumType XmlCharType XmlCharType XmlCharType Int32 )

            return value;
        }
    }
}
