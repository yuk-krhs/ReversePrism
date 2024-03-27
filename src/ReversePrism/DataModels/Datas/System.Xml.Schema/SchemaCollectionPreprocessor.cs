using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 Schema                                   0001866BE120 ModelClassType XmlSchema XmlSchema XmlSchema Pointer
    // 048 TargetNamespace                          000186671910 ModelPrimitiveType string string string String
    // 050 BuildinIncluded                          000186594D10 ModelPrimitiveType bool bool bool Bool
    // 054 ElementFormDefault                       0001865B66F0 ModelEnumType XmlSchemaForm XmlSchemaForm XmlSchemaForm Int32
    // 058 AttributeFormDefault                     0001865B66F0 ModelEnumType XmlSchemaForm XmlSchemaForm XmlSchemaForm Int32
    // 05C BlockDefault                             0001865B4BE0 ModelEnumType XmlSchemaDerivationMethod XmlSchemaDerivationMethod XmlSchemaDerivationMethod Int32
    // 060 FinalDefault                             0001865B4BE0 ModelEnumType XmlSchemaDerivationMethod XmlSchemaDerivationMethod XmlSchemaDerivationMethod Int32
    // 068 SchemaLocations                          0001865DE360 ModelClassType Hashtable Hashtable Hashtable Pointer
    // 070 ReferenceNamespaces                      0001865DE360 ModelClassType Hashtable Hashtable Hashtable Pointer
    // 078 Xmlns                                    000186671910 ModelPrimitiveType string string string String
    // 080 XmlResolver                              0001865ABBE0 ModelClassType XmlResolver XmlResolver XmlResolver Pointer
    public partial class SchemaCollectionPreprocessor
    {
        public XmlSchema?                               Schema                                  { get; set; }
        public string                                   TargetNamespace                         { get; set; }
        public bool                                     BuildinIncluded                         { get; set; }
        public XmlSchemaForm                            ElementFormDefault                      { get; set; }
        public XmlSchemaForm                            AttributeFormDefault                    { get; set; }
        public XmlSchemaDerivationMethod                BlockDefault                            { get; set; }
        public XmlSchemaDerivationMethod                FinalDefault                            { get; set; }
        public Hashtable?                               SchemaLocations                         { get; set; }
        public Hashtable?                               ReferenceNamespaces                     { get; set; }
        public string                                   Xmlns                                   { get; set; }
        public XmlResolver?                             XmlResolver                             { get; set; }

        public static SchemaCollectionPreprocessor? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SchemaCollectionPreprocessor();

            value.Schema                                    = GetObject<XmlSchema>(new IntPtr(p + 0x040), ReversePrism.DataModels.XmlSchema.FromPointer); // 0270D7555080 0x40 Schema                      ( 0001866BE120 ModelClassType XmlSchema XmlSchema XmlSchema Pointer )
            value.TargetNamespace                           = GetString(new IntPtr(p + 0x048)); // 0270D75550A0 0x48 TargetNamespace             ( 000186671910 ModelPrimitiveType string string string String )
            value.BuildinIncluded                           = GetBool(new IntPtr(p + 0x050)); // 0270D75550C0 0x50 BuildinIncluded             ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.ElementFormDefault                        = (XmlSchemaForm)GetInt32(new IntPtr(p + 0x054)); // 0270D75550E0 0x54 ElementFormDefault          ( 0001865B66F0 ModelEnumType XmlSchemaForm XmlSchemaForm XmlSchemaForm Int32 )
            value.AttributeFormDefault                      = (XmlSchemaForm)GetInt32(new IntPtr(p + 0x058)); // 0270D7555100 0x58 AttributeFormDefault        ( 0001865B66F0 ModelEnumType XmlSchemaForm XmlSchemaForm XmlSchemaForm Int32 )
            value.BlockDefault                              = (XmlSchemaDerivationMethod)GetInt32(new IntPtr(p + 0x05C)); // 0270D7555120 0x5C BlockDefault                ( 0001865B4BE0 ModelEnumType XmlSchemaDerivationMethod XmlSchemaDerivationMethod XmlSchemaDerivationMethod Int32 )
            value.FinalDefault                              = (XmlSchemaDerivationMethod)GetInt32(new IntPtr(p + 0x060)); // 0270D7555140 0x60 FinalDefault                ( 0001865B4BE0 ModelEnumType XmlSchemaDerivationMethod XmlSchemaDerivationMethod XmlSchemaDerivationMethod Int32 )
            value.SchemaLocations                           = GetObject<Hashtable>(new IntPtr(p + 0x068), ReversePrism.DataModels.Hashtable.FromPointer); // 0270D7555160 0x68 SchemaLocations             ( 0001865DE360 ModelClassType Hashtable Hashtable Hashtable Pointer )
            value.ReferenceNamespaces                       = GetObject<Hashtable>(new IntPtr(p + 0x070), ReversePrism.DataModels.Hashtable.FromPointer); // 0270D7555180 0x70 ReferenceNamespaces         ( 0001865DE360 ModelClassType Hashtable Hashtable Hashtable Pointer )
            value.Xmlns                                     = GetString(new IntPtr(p + 0x078)); // 0270D75551A0 0x78 Xmlns                       ( 000186671910 ModelPrimitiveType string string string String )
            value.XmlResolver                               = GetObject<XmlResolver>(new IntPtr(p + 0x080), ReversePrism.DataModels.XmlResolver.FromPointer); // 0270D75551C0 0x80 XmlResolver                 ( 0001865ABBE0 ModelClassType XmlResolver XmlResolver XmlResolver Pointer )

            return value;
        }
    }
}
