using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 Schema                                   ModelClassType XmlSchema XmlSchema XmlSchema Pointer
    // 048 TargetNamespace                          ModelPrimitiveType string string string String
    // 050 BuildinIncluded                          ModelPrimitiveType bool bool bool Bool
    // 054 ElementFormDefault                       ModelEnumType XmlSchemaForm XmlSchemaForm XmlSchemaForm Int32
    // 058 AttributeFormDefault                     ModelEnumType XmlSchemaForm XmlSchemaForm XmlSchemaForm Int32
    // 05C BlockDefault                             ModelEnumType XmlSchemaDerivationMethod XmlSchemaDerivationMethod XmlSchemaDerivationMethod Int32
    // 060 FinalDefault                             ModelEnumType XmlSchemaDerivationMethod XmlSchemaDerivationMethod XmlSchemaDerivationMethod Int32
    // 068 SchemaLocations                          ModelClassType Hashtable Hashtable Hashtable Pointer
    // 070 ReferenceNamespaces                      ModelClassType Hashtable Hashtable Hashtable Pointer
    // 078 Xmlns                                    ModelPrimitiveType string string string String
    // 080 XmlResolver                              ModelClassType XmlResolver XmlResolver XmlResolver Pointer
    public partial class SchemaCollectionPreprocessor : DataModel
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
            var value   = new SchemaCollectionPreprocessor() { Pointer= p0 };

            value.Schema                                    = GetObject<XmlSchema>(new IntPtr(p + 0x040), ReversePrism.DataModels.XmlSchema.FromPointer); // 0x40 Schema                      ( ModelClassType XmlSchema XmlSchema XmlSchema Pointer )
            value.TargetNamespace                           = GetString(new IntPtr(p + 0x048)); // 0x48 TargetNamespace             ( ModelPrimitiveType string string string String )
            value.BuildinIncluded                           = GetBool(new IntPtr(p + 0x050)); // 0x50 BuildinIncluded             ( ModelPrimitiveType bool bool bool Bool )
            value.ElementFormDefault                        = (XmlSchemaForm)GetInt32(new IntPtr(p + 0x054)); // 0x54 ElementFormDefault          ( ModelEnumType XmlSchemaForm XmlSchemaForm XmlSchemaForm Int32 )
            value.AttributeFormDefault                      = (XmlSchemaForm)GetInt32(new IntPtr(p + 0x058)); // 0x58 AttributeFormDefault        ( ModelEnumType XmlSchemaForm XmlSchemaForm XmlSchemaForm Int32 )
            value.BlockDefault                              = (XmlSchemaDerivationMethod)GetInt32(new IntPtr(p + 0x05C)); // 0x5C BlockDefault                ( ModelEnumType XmlSchemaDerivationMethod XmlSchemaDerivationMethod XmlSchemaDerivationMethod Int32 )
            value.FinalDefault                              = (XmlSchemaDerivationMethod)GetInt32(new IntPtr(p + 0x060)); // 0x60 FinalDefault                ( ModelEnumType XmlSchemaDerivationMethod XmlSchemaDerivationMethod XmlSchemaDerivationMethod Int32 )
            value.SchemaLocations                           = GetObject<Hashtable>(new IntPtr(p + 0x068), ReversePrism.DataModels.Hashtable.FromPointer); // 0x68 SchemaLocations             ( ModelClassType Hashtable Hashtable Hashtable Pointer )
            value.ReferenceNamespaces                       = GetObject<Hashtable>(new IntPtr(p + 0x070), ReversePrism.DataModels.Hashtable.FromPointer); // 0x70 ReferenceNamespaces         ( ModelClassType Hashtable Hashtable Hashtable Pointer )
            value.Xmlns                                     = GetString(new IntPtr(p + 0x078)); // 0x78 Xmlns                       ( ModelPrimitiveType string string string String )
            value.XmlResolver                               = GetObject<XmlResolver>(new IntPtr(p + 0x080), ReversePrism.DataModels.XmlResolver.FromPointer); // 0x80 XmlResolver                 ( ModelClassType XmlResolver XmlResolver XmlResolver Pointer )

            return value;
        }
    }
}
