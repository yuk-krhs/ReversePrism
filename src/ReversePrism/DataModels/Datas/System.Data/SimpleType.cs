using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 BaseType                                 ModelPrimitiveType string string string String
    // 018 BaseSimpleType                           ModelClassType SimpleType SimpleType SimpleType Pointer
    // 020 XmlBaseType                              ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 028 Name                                     ModelPrimitiveType string string string String
    // 030 Length                                   ModelPrimitiveType int int int Int32
    // 034 MinLength                                ModelPrimitiveType int int int Int32
    // 038 MaxLength                                ModelPrimitiveType int int int Int32
    // 040 Pattern                                  ModelPrimitiveType string string string String
    // 048 Ns                                       ModelPrimitiveType string string string String
    // 050 MaxExclusive                             ModelPrimitiveType string string string String
    // 058 MaxInclusive                             ModelPrimitiveType string string string String
    // 060 MinExclusive                             ModelPrimitiveType string string string String
    // 068 MinInclusive                             ModelPrimitiveType string string string String
    // 070 Enumeration                              ModelPrimitiveType string string string String
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

            value.BaseType                                  = GetString(new IntPtr(p + 0x010)); // 0x10 BaseType                    ( ModelPrimitiveType string string string String )
            value.BaseSimpleType                            = GetObject<SimpleType>(new IntPtr(p + 0x018), ReversePrism.DataModels.SimpleType.FromPointer); // 0x18 BaseSimpleType              ( ModelClassType SimpleType SimpleType SimpleType Pointer )
            value.XmlBaseType                               = GetObject<XmlQualifiedName>(new IntPtr(p + 0x020), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x20 XmlBaseType                 ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.Name                                      = GetString(new IntPtr(p + 0x028)); // 0x28 Name                        ( ModelPrimitiveType string string string String )
            value.Length                                    = GetInt32(new IntPtr(p + 0x030)); // 0x30 Length                      ( ModelPrimitiveType int int int Int32 )
            value.MinLength                                 = GetInt32(new IntPtr(p + 0x034)); // 0x34 MinLength                   ( ModelPrimitiveType int int int Int32 )
            value.MaxLength                                 = GetInt32(new IntPtr(p + 0x038)); // 0x38 MaxLength                   ( ModelPrimitiveType int int int Int32 )
            value.Pattern                                   = GetString(new IntPtr(p + 0x040)); // 0x40 Pattern                     ( ModelPrimitiveType string string string String )
            value.Ns                                        = GetString(new IntPtr(p + 0x048)); // 0x48 Ns                          ( ModelPrimitiveType string string string String )
            value.MaxExclusive                              = GetString(new IntPtr(p + 0x050)); // 0x50 MaxExclusive                ( ModelPrimitiveType string string string String )
            value.MaxInclusive                              = GetString(new IntPtr(p + 0x058)); // 0x58 MaxInclusive                ( ModelPrimitiveType string string string String )
            value.MinExclusive                              = GetString(new IntPtr(p + 0x060)); // 0x60 MinExclusive                ( ModelPrimitiveType string string string String )
            value.MinInclusive                              = GetString(new IntPtr(p + 0x068)); // 0x68 MinInclusive                ( ModelPrimitiveType string string string String )
            value.Enumeration                               = GetString(new IntPtr(p + 0x070)); // 0x70 Enumeration                 ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
