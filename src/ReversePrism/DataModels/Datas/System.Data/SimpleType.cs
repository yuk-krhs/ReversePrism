using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 BaseType                                 000186671910 ModelPrimitiveType string string string String
    // 018 BaseSimpleType                           00018650C2B0 ModelClassType SimpleType SimpleType SimpleType Pointer
    // 020 XmlBaseType                              0001866BC7E0 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 028 Name                                     000186671910 ModelPrimitiveType string string string String
    // 030 Length                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    // 034 MinLength                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 038 MaxLength                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 040 Pattern                                  000186671910 ModelPrimitiveType string string string String
    // 048 Ns                                       000186671910 ModelPrimitiveType string string string String
    // 050 MaxExclusive                             000186671910 ModelPrimitiveType string string string String
    // 058 MaxInclusive                             000186671910 ModelPrimitiveType string string string String
    // 060 MinExclusive                             000186671910 ModelPrimitiveType string string string String
    // 068 MinInclusive                             000186671910 ModelPrimitiveType string string string String
    // 070 Enumeration                              000186671BA0 ModelPrimitiveType string string string String
    public partial class SimpleType : DataModel
    {
        public string                                   BaseType                                { get; set; }
        public SimpleType?                              BaseSimpleType                          { get; set; }
        public XmlQualifiedName?                        XmlBaseType                             { get; set; }
        public string                                   Name                                    { get; set; }
        public int                                      Length                                  { get; set; }
        public int                                      MinLength                               { get; set; }
        public int                                      MaxLength                               { get; set; }
        public string                                   Pattern                                 { get; set; }
        public string                                   Ns                                      { get; set; }
        public string                                   MaxExclusive                            { get; set; }
        public string                                   MaxInclusive                            { get; set; }
        public string                                   MinExclusive                            { get; set; }
        public string                                   MinInclusive                            { get; set; }
        public string                                   Enumeration                             { get; set; }

        public static SimpleType? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SimpleType() { Pointer= p0 };

            value.BaseType                                  = GetString(new IntPtr(p + 0x010)); // 024668922770 0x10 BaseType                    ( 000186671910 ModelPrimitiveType string string string String )
            value.BaseSimpleType                            = GetObject<SimpleType>(new IntPtr(p + 0x018), ReversePrism.DataModels.SimpleType.FromPointer); // 024668922790 0x18 BaseSimpleType              ( 00018650C2B0 ModelClassType SimpleType SimpleType SimpleType Pointer )
            value.XmlBaseType                               = GetObject<XmlQualifiedName>(new IntPtr(p + 0x020), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0246689227B0 0x20 XmlBaseType                 ( 0001866BC7E0 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.Name                                      = GetString(new IntPtr(p + 0x028)); // 0246689227D0 0x28 Name                        ( 000186671910 ModelPrimitiveType string string string String )
            value.Length                                    = GetInt32(new IntPtr(p + 0x030)); // 0246689227F0 0x30 Length                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MinLength                                 = GetInt32(new IntPtr(p + 0x034)); // 024668922810 0x34 MinLength                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MaxLength                                 = GetInt32(new IntPtr(p + 0x038)); // 024668922830 0x38 MaxLength                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Pattern                                   = GetString(new IntPtr(p + 0x040)); // 024668922850 0x40 Pattern                     ( 000186671910 ModelPrimitiveType string string string String )
            value.Ns                                        = GetString(new IntPtr(p + 0x048)); // 024668922870 0x48 Ns                          ( 000186671910 ModelPrimitiveType string string string String )
            value.MaxExclusive                              = GetString(new IntPtr(p + 0x050)); // 024668922890 0x50 MaxExclusive                ( 000186671910 ModelPrimitiveType string string string String )
            value.MaxInclusive                              = GetString(new IntPtr(p + 0x058)); // 0246689228B0 0x58 MaxInclusive                ( 000186671910 ModelPrimitiveType string string string String )
            value.MinExclusive                              = GetString(new IntPtr(p + 0x060)); // 0246689228D0 0x60 MinExclusive                ( 000186671910 ModelPrimitiveType string string string String )
            value.MinInclusive                              = GetString(new IntPtr(p + 0x068)); // 0246689228F0 0x68 MinInclusive                ( 000186671910 ModelPrimitiveType string string string String )
            value.Enumeration                               = GetString(new IntPtr(p + 0x070)); // 024668922910 0x70 Enumeration                 ( 000186671BA0 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
