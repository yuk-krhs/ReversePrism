using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 NameTable                                ModelClassType XmlNameTable XmlNameTable XmlNameTable Pointer
    // 018 SchemaNames                              ModelClassType SchemaNames SchemaNames SchemaNames Pointer
    // 020 Schemas                                  ModelClassType SortedList SortedList SortedList Pointer
    // 028 InternalEventHandler                     ModelClassType ValidationEventHandler ValidationEventHandler ValidationEventHandler Pointer
    // 030 EventHandler                             ModelClassType ValidationEventHandler ValidationEventHandler ValidationEventHandler Pointer
    // 038 IsCompiled                               ModelPrimitiveType bool bool bool Bool
    // 040 SchemaLocations                          ModelClassType Hashtable Hashtable Hashtable Pointer
    // 048 ChameleonSchemas                         ModelClassType Hashtable Hashtable Hashtable Pointer
    // 050 TargetNamespaces                         ModelClassType Hashtable Hashtable Hashtable Pointer
    // 058 CompileAll                               ModelPrimitiveType bool bool bool Bool
    // 060 CachedCompiledInfo                       ModelClassType SchemaInfo SchemaInfo SchemaInfo Pointer
    // 068 ReaderSettings                           ModelClassType XmlReaderSettings XmlReaderSettings XmlReaderSettings Pointer
    // 070 SchemaForSchema                          ModelClassType XmlSchema XmlSchema XmlSchema Pointer
    // 078 CompilationSettings                      ModelClassType XmlSchemaCompilationSettings XmlSchemaCompilationSettings XmlSchemaCompilationSettings Pointer
    // 080 Elements                                 ModelClassType XmlSchemaObjectTable XmlSchemaObjectTable XmlSchemaObjectTable Pointer
    // 088 Attributes                               ModelClassType XmlSchemaObjectTable XmlSchemaObjectTable XmlSchemaObjectTable Pointer
    // 090 SchemaTypes                              ModelClassType XmlSchemaObjectTable XmlSchemaObjectTable XmlSchemaObjectTable Pointer
    // 098 SubstitutionGroups                       ModelClassType XmlSchemaObjectTable XmlSchemaObjectTable XmlSchemaObjectTable Pointer
    // 0A0 TypeExtensions                           ModelClassType XmlSchemaObjectTable XmlSchemaObjectTable XmlSchemaObjectTable Pointer
    // 0A8 internalSyncObject                       <object> IL2CPP_TYPE_OBJECT
    public partial class XmlSchemaSet : DataModel
    {
        public XmlNameTable?                            NameTable                               { get; set; }
        public SchemaNames?                             SchemaNames                             { get; set; }
        public SortedList?                              Schemas                                 { get; set; }
        public ValidationEventHandler?                  InternalEventHandler                    { get; set; }
        public ValidationEventHandler?                  EventHandler                            { get; set; }
        public bool                                     IsCompiled                              { get; set; }
        public Hashtable?                               SchemaLocations                         { get; set; }
        public Hashtable?                               ChameleonSchemas                        { get; set; }
        public Hashtable?                               TargetNamespaces                        { get; set; }
        public bool                                     CompileAll                              { get; set; }
        public SchemaInfo?                              CachedCompiledInfo                      { get; set; }
        public XmlReaderSettings?                       ReaderSettings                          { get; set; }
        public XmlSchema?                               SchemaForSchema                         { get; set; }
        public XmlSchemaCompilationSettings?            CompilationSettings                     { get; set; }
        public XmlSchemaObjectTable?                    Elements                                { get; set; }
        public XmlSchemaObjectTable?                    Attributes                              { get; set; }
        public XmlSchemaObjectTable?                    SchemaTypes                             { get; set; }
        public XmlSchemaObjectTable?                    SubstitutionGroups                      { get; set; }
        public XmlSchemaObjectTable?                    TypeExtensions                          { get; set; }

        public static XmlSchemaSet? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlSchemaSet() { Pointer= p0 };

            value.NameTable                                 = GetObject<XmlNameTable>(new IntPtr(p + 0x010), ReversePrism.DataModels.XmlNameTable.FromPointer); // 0x10 NameTable                   ( ModelClassType XmlNameTable XmlNameTable XmlNameTable Pointer )
            value.SchemaNames                               = GetObject<SchemaNames>(new IntPtr(p + 0x018), ReversePrism.DataModels.SchemaNames.FromPointer); // 0x18 SchemaNames                 ( ModelClassType SchemaNames SchemaNames SchemaNames Pointer )
            value.Schemas                                   = GetObject<SortedList>(new IntPtr(p + 0x020), ReversePrism.DataModels.SortedList.FromPointer); // 0x20 Schemas                     ( ModelClassType SortedList SortedList SortedList Pointer )
            value.InternalEventHandler                      = GetObject<ValidationEventHandler>(new IntPtr(p + 0x028), ReversePrism.DataModels.ValidationEventHandler.FromPointer); // 0x28 InternalEventHandler        ( ModelClassType ValidationEventHandler ValidationEventHandler ValidationEventHandler Pointer )
            value.EventHandler                              = GetObject<ValidationEventHandler>(new IntPtr(p + 0x030), ReversePrism.DataModels.ValidationEventHandler.FromPointer); // 0x30 EventHandler                ( ModelClassType ValidationEventHandler ValidationEventHandler ValidationEventHandler Pointer )
            value.IsCompiled                                = GetBool(new IntPtr(p + 0x038)); // 0x38 IsCompiled                  ( ModelPrimitiveType bool bool bool Bool )
            value.SchemaLocations                           = GetObject<Hashtable>(new IntPtr(p + 0x040), ReversePrism.DataModels.Hashtable.FromPointer); // 0x40 SchemaLocations             ( ModelClassType Hashtable Hashtable Hashtable Pointer )
            value.ChameleonSchemas                          = GetObject<Hashtable>(new IntPtr(p + 0x048), ReversePrism.DataModels.Hashtable.FromPointer); // 0x48 ChameleonSchemas            ( ModelClassType Hashtable Hashtable Hashtable Pointer )
            value.TargetNamespaces                          = GetObject<Hashtable>(new IntPtr(p + 0x050), ReversePrism.DataModels.Hashtable.FromPointer); // 0x50 TargetNamespaces            ( ModelClassType Hashtable Hashtable Hashtable Pointer )
            value.CompileAll                                = GetBool(new IntPtr(p + 0x058)); // 0x58 CompileAll                  ( ModelPrimitiveType bool bool bool Bool )
            value.CachedCompiledInfo                        = GetObject<SchemaInfo>(new IntPtr(p + 0x060), ReversePrism.DataModels.SchemaInfo.FromPointer); // 0x60 CachedCompiledInfo          ( ModelClassType SchemaInfo SchemaInfo SchemaInfo Pointer )
            value.ReaderSettings                            = GetObject<XmlReaderSettings>(new IntPtr(p + 0x068), ReversePrism.DataModels.XmlReaderSettings.FromPointer); // 0x68 ReaderSettings              ( ModelClassType XmlReaderSettings XmlReaderSettings XmlReaderSettings Pointer )
            value.SchemaForSchema                           = GetObject<XmlSchema>(new IntPtr(p + 0x070), ReversePrism.DataModels.XmlSchema.FromPointer); // 0x70 SchemaForSchema             ( ModelClassType XmlSchema XmlSchema XmlSchema Pointer )
            value.CompilationSettings                       = GetObject<XmlSchemaCompilationSettings>(new IntPtr(p + 0x078), ReversePrism.DataModels.XmlSchemaCompilationSettings.FromPointer); // 0x78 CompilationSettings         ( ModelClassType XmlSchemaCompilationSettings XmlSchemaCompilationSettings XmlSchemaCompilationSettings Pointer )
            value.Elements                                  = GetObject<XmlSchemaObjectTable>(new IntPtr(p + 0x080), ReversePrism.DataModels.XmlSchemaObjectTable.FromPointer); // 0x80 Elements                    ( ModelClassType XmlSchemaObjectTable XmlSchemaObjectTable XmlSchemaObjectTable Pointer )
            value.Attributes                                = GetObject<XmlSchemaObjectTable>(new IntPtr(p + 0x088), ReversePrism.DataModels.XmlSchemaObjectTable.FromPointer); // 0x88 Attributes                  ( ModelClassType XmlSchemaObjectTable XmlSchemaObjectTable XmlSchemaObjectTable Pointer )
            value.SchemaTypes                               = GetObject<XmlSchemaObjectTable>(new IntPtr(p + 0x090), ReversePrism.DataModels.XmlSchemaObjectTable.FromPointer); // 0x90 SchemaTypes                 ( ModelClassType XmlSchemaObjectTable XmlSchemaObjectTable XmlSchemaObjectTable Pointer )
            value.SubstitutionGroups                        = GetObject<XmlSchemaObjectTable>(new IntPtr(p + 0x098), ReversePrism.DataModels.XmlSchemaObjectTable.FromPointer); // 0x98 SubstitutionGroups          ( ModelClassType XmlSchemaObjectTable XmlSchemaObjectTable XmlSchemaObjectTable Pointer )
            value.TypeExtensions                            = GetObject<XmlSchemaObjectTable>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.XmlSchemaObjectTable.FromPointer); // 0xA0 TypeExtensions              ( ModelClassType XmlSchemaObjectTable XmlSchemaObjectTable XmlSchemaObjectTable Pointer )

            return value;
        }
    }
}
