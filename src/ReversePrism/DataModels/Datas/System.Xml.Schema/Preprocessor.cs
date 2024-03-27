using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 Xmlns                                    000186671910 ModelPrimitiveType string string string String
    // 048 NsXsi                                    000186671910 ModelPrimitiveType string string string String
    // 050 TargetNamespace                          000186671910 ModelPrimitiveType string string string String
    // 058 RootSchema                               0001866BE120 ModelClassType XmlSchema XmlSchema XmlSchema Pointer
    // 060 CurrentSchema                            0001866BE120 ModelClassType XmlSchema XmlSchema XmlSchema Pointer
    // 068 ElementFormDefault                       0001865B66F0 ModelEnumType XmlSchemaForm XmlSchemaForm XmlSchemaForm Int32
    // 06C AttributeFormDefault                     0001865B66F0 ModelEnumType XmlSchemaForm XmlSchemaForm XmlSchemaForm Int32
    // 070 BlockDefault                             0001865B4BE0 ModelEnumType XmlSchemaDerivationMethod XmlSchemaDerivationMethod XmlSchemaDerivationMethod Int32
    // 074 FinalDefault                             0001865B4BE0 ModelEnumType XmlSchemaDerivationMethod XmlSchemaDerivationMethod XmlSchemaDerivationMethod Int32
    // 078 SchemaLocations                          0001865DE360 ModelClassType Hashtable Hashtable Hashtable Pointer
    // 080 ChameleonSchemas                         0001865DE360 ModelClassType Hashtable Hashtable Hashtable Pointer
    // 088 ReferenceNamespaces                      0001865DE360 ModelClassType Hashtable Hashtable Hashtable Pointer
    // 090 ProcessedExternals                       0001865DE360 ModelClassType Hashtable Hashtable Hashtable Pointer
    // 098 LockList                                 000186532E70 ModelClassType SortedList SortedList SortedList Pointer
    // 0A0 ReaderSettings                           0001865AACF0 ModelClassType XmlReaderSettings XmlReaderSettings XmlReaderSettings Pointer
    // 0A8 RootSchemaForRedefine                    0001866BE120 ModelClassType XmlSchema XmlSchema XmlSchema Pointer
    // 0B0 RedefinedList                            00018658A070 ModelClassType ArrayList ArrayList ArrayList Pointer
    // 000 builtInSchemaForXmlNS                    XmlSchema IL2CPP_TYPE_CLASS
    // 0B8 XmlResolver                              0001865ABBE0 ModelClassType XmlResolver XmlResolver XmlResolver Pointer
    public partial class Preprocessor
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
            var value   = new Preprocessor();

            value.Xmlns                                     = GetString(new IntPtr(p + 0x040)); // 0270D752C0C8 0x40 Xmlns                       ( 000186671910 ModelPrimitiveType string string string String )
            value.NsXsi                                     = GetString(new IntPtr(p + 0x048)); // 0270D752C0E8 0x48 NsXsi                       ( 000186671910 ModelPrimitiveType string string string String )
            value.TargetNamespace                           = GetString(new IntPtr(p + 0x050)); // 0270D752C108 0x50 TargetNamespace             ( 000186671910 ModelPrimitiveType string string string String )
            value.RootSchema                                = GetObject<XmlSchema>(new IntPtr(p + 0x058), ReversePrism.DataModels.XmlSchema.FromPointer); // 0270D752C128 0x58 RootSchema                  ( 0001866BE120 ModelClassType XmlSchema XmlSchema XmlSchema Pointer )
            value.CurrentSchema                             = GetObject<XmlSchema>(new IntPtr(p + 0x060), ReversePrism.DataModels.XmlSchema.FromPointer); // 0270D752C148 0x60 CurrentSchema               ( 0001866BE120 ModelClassType XmlSchema XmlSchema XmlSchema Pointer )
            value.ElementFormDefault                        = (XmlSchemaForm)GetInt32(new IntPtr(p + 0x068)); // 0270D752C168 0x68 ElementFormDefault          ( 0001865B66F0 ModelEnumType XmlSchemaForm XmlSchemaForm XmlSchemaForm Int32 )
            value.AttributeFormDefault                      = (XmlSchemaForm)GetInt32(new IntPtr(p + 0x06C)); // 0270D752C188 0x6C AttributeFormDefault        ( 0001865B66F0 ModelEnumType XmlSchemaForm XmlSchemaForm XmlSchemaForm Int32 )
            value.BlockDefault                              = (XmlSchemaDerivationMethod)GetInt32(new IntPtr(p + 0x070)); // 0270D752C1A8 0x70 BlockDefault                ( 0001865B4BE0 ModelEnumType XmlSchemaDerivationMethod XmlSchemaDerivationMethod XmlSchemaDerivationMethod Int32 )
            value.FinalDefault                              = (XmlSchemaDerivationMethod)GetInt32(new IntPtr(p + 0x074)); // 0270D752C1C8 0x74 FinalDefault                ( 0001865B4BE0 ModelEnumType XmlSchemaDerivationMethod XmlSchemaDerivationMethod XmlSchemaDerivationMethod Int32 )
            value.SchemaLocations                           = GetObject<Hashtable>(new IntPtr(p + 0x078), ReversePrism.DataModels.Hashtable.FromPointer); // 0270D752C1E8 0x78 SchemaLocations             ( 0001865DE360 ModelClassType Hashtable Hashtable Hashtable Pointer )
            value.ChameleonSchemas                          = GetObject<Hashtable>(new IntPtr(p + 0x080), ReversePrism.DataModels.Hashtable.FromPointer); // 0270D752C208 0x80 ChameleonSchemas            ( 0001865DE360 ModelClassType Hashtable Hashtable Hashtable Pointer )
            value.ReferenceNamespaces                       = GetObject<Hashtable>(new IntPtr(p + 0x088), ReversePrism.DataModels.Hashtable.FromPointer); // 0270D752C228 0x88 ReferenceNamespaces         ( 0001865DE360 ModelClassType Hashtable Hashtable Hashtable Pointer )
            value.ProcessedExternals                        = GetObject<Hashtable>(new IntPtr(p + 0x090), ReversePrism.DataModels.Hashtable.FromPointer); // 0270D752C248 0x90 ProcessedExternals          ( 0001865DE360 ModelClassType Hashtable Hashtable Hashtable Pointer )
            value.LockList                                  = GetObject<SortedList>(new IntPtr(p + 0x098), ReversePrism.DataModels.SortedList.FromPointer); // 0270D752C268 0x98 LockList                    ( 000186532E70 ModelClassType SortedList SortedList SortedList Pointer )
            value.ReaderSettings                            = GetObject<XmlReaderSettings>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.XmlReaderSettings.FromPointer); // 0270D752C288 0xA0 ReaderSettings              ( 0001865AACF0 ModelClassType XmlReaderSettings XmlReaderSettings XmlReaderSettings Pointer )
            value.RootSchemaForRedefine                     = GetObject<XmlSchema>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.XmlSchema.FromPointer); // 0270D752C2A8 0xA8 RootSchemaForRedefine       ( 0001866BE120 ModelClassType XmlSchema XmlSchema XmlSchema Pointer )
            value.RedefinedList                             = GetObject<ArrayList>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.ArrayList.FromPointer); // 0270D752C2C8 0xB0 RedefinedList               ( 00018658A070 ModelClassType ArrayList ArrayList ArrayList Pointer )
            value.XmlResolver                               = GetObject<XmlResolver>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.XmlResolver.FromPointer); // 0270D752C308 0xB8 XmlResolver                 ( 0001865ABBE0 ModelClassType XmlResolver XmlResolver XmlResolver Pointer )

            return value;
        }
    }
}
