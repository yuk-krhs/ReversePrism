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
    public partial class SimpleType
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
            var value   = new SimpleType();

            value.BaseType                                  = GetString(new IntPtr(p + 0x010)); // 0270D88B6650 0x10 BaseType                    ( 000186671910 ModelPrimitiveType string string string String )
            value.BaseSimpleType                            = GetObject<SimpleType>(new IntPtr(p + 0x018), ReversePrism.DataModels.SimpleType.FromPointer); // 0270D88B6670 0x18 BaseSimpleType              ( 00018650C2B0 ModelClassType SimpleType SimpleType SimpleType Pointer )
            value.XmlBaseType                               = GetObject<XmlQualifiedName>(new IntPtr(p + 0x020), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0270D88B6690 0x20 XmlBaseType                 ( 0001866BC7E0 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.Name                                      = GetString(new IntPtr(p + 0x028)); // 0270D88B66B0 0x28 Name                        ( 000186671910 ModelPrimitiveType string string string String )
            value.Length                                    = GetInt32(new IntPtr(p + 0x030)); // 0270D88B66D0 0x30 Length                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MinLength                                 = GetInt32(new IntPtr(p + 0x034)); // 0270D88B66F0 0x34 MinLength                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MaxLength                                 = GetInt32(new IntPtr(p + 0x038)); // 0270D88B6710 0x38 MaxLength                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Pattern                                   = GetString(new IntPtr(p + 0x040)); // 0270D88B6730 0x40 Pattern                     ( 000186671910 ModelPrimitiveType string string string String )
            value.Ns                                        = GetString(new IntPtr(p + 0x048)); // 0270D88B6750 0x48 Ns                          ( 000186671910 ModelPrimitiveType string string string String )
            value.MaxExclusive                              = GetString(new IntPtr(p + 0x050)); // 0270D88B6770 0x50 MaxExclusive                ( 000186671910 ModelPrimitiveType string string string String )
            value.MaxInclusive                              = GetString(new IntPtr(p + 0x058)); // 0270D88B6790 0x58 MaxInclusive                ( 000186671910 ModelPrimitiveType string string string String )
            value.MinExclusive                              = GetString(new IntPtr(p + 0x060)); // 0270D88B67B0 0x60 MinExclusive                ( 000186671910 ModelPrimitiveType string string string String )
            value.MinInclusive                              = GetString(new IntPtr(p + 0x068)); // 0270D88B67D0 0x68 MinInclusive                ( 000186671910 ModelPrimitiveType string string string String )
            value.Enumeration                               = GetString(new IntPtr(p + 0x070)); // 0270D88B67F0 0x70 Enumeration                 ( 000186671BA0 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
