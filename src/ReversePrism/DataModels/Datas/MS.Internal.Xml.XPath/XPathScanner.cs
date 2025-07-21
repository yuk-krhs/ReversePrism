using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 XpathExpr                                ModelPrimitiveType string string string String
    // 018 XpathExprIndex                           ModelPrimitiveType int int int Int32
    // 01C Kind                                     ModelEnumType LexKind LexKind LexKind Int32
    // 020 _currentChar                             char IL2CPP_TYPE_CHAR
    // 028 Name                                     ModelPrimitiveType string string string String
    // 030 Prefix                                   ModelPrimitiveType string string string String
    // 038 StringValue                              ModelPrimitiveType string string string String
    // 040 NumberValue                              ModelPrimitiveType double double double Double
    // 048 CanBeFunction                            ModelPrimitiveType bool bool bool Bool
    // 050 XmlCharType                              ModelEnumType XmlCharType XmlCharType XmlCharType Int32
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

            value.XpathExpr                                 = GetString(new IntPtr(p + 0x010)); // 0x10 XpathExpr                   ( ModelPrimitiveType string string string String )
            value.XpathExprIndex                            = GetInt32(new IntPtr(p + 0x018)); // 0x18 XpathExprIndex              ( ModelPrimitiveType int int int Int32 )
            value.Kind                                      = (LexKind)GetInt32(new IntPtr(p + 0x01C)); // 0x1C Kind                        ( ModelEnumType LexKind LexKind LexKind Int32 )
            value.Name                                      = GetString(new IntPtr(p + 0x028)); // 0x28 Name                        ( ModelPrimitiveType string string string String )
            value.Prefix                                    = GetString(new IntPtr(p + 0x030)); // 0x30 Prefix                      ( ModelPrimitiveType string string string String )
            value.StringValue                               = GetString(new IntPtr(p + 0x038)); // 0x38 StringValue                 ( ModelPrimitiveType string string string String )
            value.NumberValue                               = GetDouble(new IntPtr(p + 0x040)); // 0x40 NumberValue                 ( ModelPrimitiveType double double double Double )
            value.CanBeFunction                             = GetBool(new IntPtr(p + 0x048)); // 0x48 CanBeFunction               ( ModelPrimitiveType bool bool bool Bool )
            value.XmlCharType                               = (XmlCharType)GetInt32(new IntPtr(p + 0x050)); // 0x50 XmlCharType                 ( ModelEnumType XmlCharType XmlCharType XmlCharType Int32 )

            return value;
        }
    }
}
