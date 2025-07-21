using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 Xmlns                                    ModelPrimitiveType string string string String
    // 048 NsXsi                                    ModelPrimitiveType string string string String
    // 050 TargetNamespace                          ModelPrimitiveType string string string String
    // 058 RootSchema                               ModelClassType XmlSchema XmlSchema XmlSchema Pointer
    // 060 CurrentSchema                            ModelClassType XmlSchema XmlSchema XmlSchema Pointer
    // 068 ElementFormDefault                       ModelEnumType XmlSchemaForm XmlSchemaForm XmlSchemaForm Int32
    // 06C AttributeFormDefault                     ModelEnumType XmlSchemaForm XmlSchemaForm XmlSchemaForm Int32
    // 070 BlockDefault                             ModelEnumType XmlSchemaDerivationMethod XmlSchemaDerivationMethod XmlSchemaDerivationMethod Int32
    // 074 FinalDefault                             ModelEnumType XmlSchemaDerivationMethod XmlSchemaDerivationMethod XmlSchemaDerivationMethod Int32
    // 078 SchemaLocations                          ModelClassType Hashtable Hashtable Hashtable Pointer
    // 080 ChameleonSchemas                         ModelClassType Hashtable Hashtable Hashtable Pointer
    // 088 ReferenceNamespaces                      ModelClassType Hashtable Hashtable Hashtable Pointer
    // 090 ProcessedExternals                       ModelClassType Hashtable Hashtable Hashtable Pointer
    // 098 LockList                                 ModelClassType SortedList SortedList SortedList Pointer
    // 0A0 ReaderSettings                           ModelClassType XmlReaderSettings XmlReaderSettings XmlReaderSettings Pointer
    // 0A8 RootSchemaForRedefine                    ModelClassType XmlSchema XmlSchema XmlSchema Pointer
    // 0B0 RedefinedList                            ModelClassType ArrayList ArrayList ArrayList Pointer
    // 000 builtInSchemaForXmlNS                    XmlSchema IL2CPP_TYPE_CLASS
    // 0B8 XmlResolver                              ModelClassType XmlResolver XmlResolver XmlResolver Pointer
    public partial class Preprocessor : DataModel
    {
        public string                                   Xmlns                                   { get; set; }
        public string                                   NsXsi                                   { get; set; }
        public string                                   TargetNamespace                         { get; set; }
        public XmlSchema?                               RootSchema                              { get; set; }
        public XmlSchema?                               CurrentSchema                           { get; set; }
        public XmlSchemaForm                            ElementFormDefault                      { get; set; }
        public XmlSchemaForm                            AttributeFormDefault                    { get; set; }
        public XmlSchemaDerivationMethod                BlockDefault                            { get; set; }
        public XmlSchemaDerivationMethod                FinalDefault                            { get; set; }
        public Hashtable?                               SchemaLocations                         { get; set; }
        public Hashtable?                               ChameleonSchemas                        { get; set; }
        public Hashtable?                               ReferenceNamespaces                     { get; set; }
        public Hashtable?                               ProcessedExternals                      { get; set; }
        public SortedList?                              LockList                                { get; set; }
        public XmlReaderSettings?                       ReaderSettings                          { get; set; }
        public XmlSchema?                               RootSchemaForRedefine                   { get; set; }
        public ArrayList?                               RedefinedList                           { get; set; }
        public XmlResolver?                             XmlResolver                             { get; set; }

        public static Preprocessor? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Preprocessor() { Pointer= p0 };

            value.Xmlns                                     = GetString(new IntPtr(p + 0x040)); // 0x40 Xmlns                       ( ModelPrimitiveType string string string String )
            value.NsXsi                                     = GetString(new IntPtr(p + 0x048)); // 0x48 NsXsi                       ( ModelPrimitiveType string string string String )
            value.TargetNamespace                           = GetString(new IntPtr(p + 0x050)); // 0x50 TargetNamespace             ( ModelPrimitiveType string string string String )
            value.RootSchema                                = GetObject<XmlSchema>(new IntPtr(p + 0x058), ReversePrism.DataModels.XmlSchema.FromPointer); // 0x58 RootSchema                  ( ModelClassType XmlSchema XmlSchema XmlSchema Pointer )
            value.CurrentSchema                             = GetObject<XmlSchema>(new IntPtr(p + 0x060), ReversePrism.DataModels.XmlSchema.FromPointer); // 0x60 CurrentSchema               ( ModelClassType XmlSchema XmlSchema XmlSchema Pointer )
            value.ElementFormDefault                        = (XmlSchemaForm)GetInt32(new IntPtr(p + 0x068)); // 0x68 ElementFormDefault          ( ModelEnumType XmlSchemaForm XmlSchemaForm XmlSchemaForm Int32 )
            value.AttributeFormDefault                      = (XmlSchemaForm)GetInt32(new IntPtr(p + 0x06C)); // 0x6C AttributeFormDefault        ( ModelEnumType XmlSchemaForm XmlSchemaForm XmlSchemaForm Int32 )
            value.BlockDefault                              = (XmlSchemaDerivationMethod)GetInt32(new IntPtr(p + 0x070)); // 0x70 BlockDefault                ( ModelEnumType XmlSchemaDerivationMethod XmlSchemaDerivationMethod XmlSchemaDerivationMethod Int32 )
            value.FinalDefault                              = (XmlSchemaDerivationMethod)GetInt32(new IntPtr(p + 0x074)); // 0x74 FinalDefault                ( ModelEnumType XmlSchemaDerivationMethod XmlSchemaDerivationMethod XmlSchemaDerivationMethod Int32 )
            value.SchemaLocations                           = GetObject<Hashtable>(new IntPtr(p + 0x078), ReversePrism.DataModels.Hashtable.FromPointer); // 0x78 SchemaLocations             ( ModelClassType Hashtable Hashtable Hashtable Pointer )
            value.ChameleonSchemas                          = GetObject<Hashtable>(new IntPtr(p + 0x080), ReversePrism.DataModels.Hashtable.FromPointer); // 0x80 ChameleonSchemas            ( ModelClassType Hashtable Hashtable Hashtable Pointer )
            value.ReferenceNamespaces                       = GetObject<Hashtable>(new IntPtr(p + 0x088), ReversePrism.DataModels.Hashtable.FromPointer); // 0x88 ReferenceNamespaces         ( ModelClassType Hashtable Hashtable Hashtable Pointer )
            value.ProcessedExternals                        = GetObject<Hashtable>(new IntPtr(p + 0x090), ReversePrism.DataModels.Hashtable.FromPointer); // 0x90 ProcessedExternals          ( ModelClassType Hashtable Hashtable Hashtable Pointer )
            value.LockList                                  = GetObject<SortedList>(new IntPtr(p + 0x098), ReversePrism.DataModels.SortedList.FromPointer); // 0x98 LockList                    ( ModelClassType SortedList SortedList SortedList Pointer )
            value.ReaderSettings                            = GetObject<XmlReaderSettings>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.XmlReaderSettings.FromPointer); // 0xA0 ReaderSettings              ( ModelClassType XmlReaderSettings XmlReaderSettings XmlReaderSettings Pointer )
            value.RootSchemaForRedefine                     = GetObject<XmlSchema>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.XmlSchema.FromPointer); // 0xA8 RootSchemaForRedefine       ( ModelClassType XmlSchema XmlSchema XmlSchema Pointer )
            value.RedefinedList                             = GetObject<ArrayList>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.ArrayList.FromPointer); // 0xB0 RedefinedList               ( ModelClassType ArrayList ArrayList ArrayList Pointer )
            value.XmlResolver                               = GetObject<XmlResolver>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.XmlResolver.FromPointer); // 0xB8 XmlResolver                 ( ModelClassType XmlResolver XmlResolver XmlResolver Pointer )

            return value;
        }
    }
}
