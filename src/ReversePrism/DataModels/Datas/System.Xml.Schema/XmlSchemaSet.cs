using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 NameTable                                0001865A0930 ModelClassType XmlNameTable XmlNameTable XmlNameTable Pointer
    // 018 SchemaNames                              0001866EA5B0 ModelClassType SchemaNames SchemaNames SchemaNames Pointer
    // 020 Schemas                                  000186532E70 ModelClassType SortedList SortedList SortedList Pointer
    // 028 InternalEventHandler                     000186765AD0 ModelClassType ValidationEventHandler ValidationEventHandler ValidationEventHandler Pointer
    // 030 EventHandler                             000186765AD0 ModelClassType ValidationEventHandler ValidationEventHandler ValidationEventHandler Pointer
    // 038 IsCompiled                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 040 SchemaLocations                          0001865DE360 ModelClassType Hashtable Hashtable Hashtable Pointer
    // 048 ChameleonSchemas                         0001865DE360 ModelClassType Hashtable Hashtable Hashtable Pointer
    // 050 TargetNamespaces                         0001865DE360 ModelClassType Hashtable Hashtable Hashtable Pointer
    // 058 CompileAll                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 060 CachedCompiledInfo                       0001866E9EB0 ModelClassType SchemaInfo SchemaInfo SchemaInfo Pointer
    // 068 ReaderSettings                           0001865AACF0 ModelClassType XmlReaderSettings XmlReaderSettings XmlReaderSettings Pointer
    // 070 SchemaForSchema                          0001866BE120 ModelClassType XmlSchema XmlSchema XmlSchema Pointer
    // 078 CompilationSettings                      0001865B0220 ModelClassType XmlSchemaCompilationSettings XmlSchemaCompilationSettings XmlSchemaCompilationSettings Pointer
    // 080 Elements                                 0001865BCFD0 ModelClassType XmlSchemaObjectTable XmlSchemaObjectTable XmlSchemaObjectTable Pointer
    // 088 Attributes                               0001865BCFD0 ModelClassType XmlSchemaObjectTable XmlSchemaObjectTable XmlSchemaObjectTable Pointer
    // 090 SchemaTypes                              0001865BCFD0 ModelClassType XmlSchemaObjectTable XmlSchemaObjectTable XmlSchemaObjectTable Pointer
    // 098 SubstitutionGroups                       0001865BCFD0 ModelClassType XmlSchemaObjectTable XmlSchemaObjectTable XmlSchemaObjectTable Pointer
    // 0A0 TypeExtensions                           0001865BCD20 ModelClassType XmlSchemaObjectTable XmlSchemaObjectTable XmlSchemaObjectTable Pointer
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

            value.NameTable                                 = GetObject<XmlNameTable>(new IntPtr(p + 0x010), ReversePrism.DataModels.XmlNameTable.FromPointer); // 024667421238 0x10 NameTable                   ( 0001865A0930 ModelClassType XmlNameTable XmlNameTable XmlNameTable Pointer )
            value.SchemaNames                               = GetObject<SchemaNames>(new IntPtr(p + 0x018), ReversePrism.DataModels.SchemaNames.FromPointer); // 024667421258 0x18 SchemaNames                 ( 0001866EA5B0 ModelClassType SchemaNames SchemaNames SchemaNames Pointer )
            value.Schemas                                   = GetObject<SortedList>(new IntPtr(p + 0x020), ReversePrism.DataModels.SortedList.FromPointer); // 024667421278 0x20 Schemas                     ( 000186532E70 ModelClassType SortedList SortedList SortedList Pointer )
            value.InternalEventHandler                      = GetObject<ValidationEventHandler>(new IntPtr(p + 0x028), ReversePrism.DataModels.ValidationEventHandler.FromPointer); // 024667421298 0x28 InternalEventHandler        ( 000186765AD0 ModelClassType ValidationEventHandler ValidationEventHandler ValidationEventHandler Pointer )
            value.EventHandler                              = GetObject<ValidationEventHandler>(new IntPtr(p + 0x030), ReversePrism.DataModels.ValidationEventHandler.FromPointer); // 0246674212B8 0x30 EventHandler                ( 000186765AD0 ModelClassType ValidationEventHandler ValidationEventHandler ValidationEventHandler Pointer )
            value.IsCompiled                                = GetBool(new IntPtr(p + 0x038)); // 0246674212D8 0x38 IsCompiled                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.SchemaLocations                           = GetObject<Hashtable>(new IntPtr(p + 0x040), ReversePrism.DataModels.Hashtable.FromPointer); // 0246674212F8 0x40 SchemaLocations             ( 0001865DE360 ModelClassType Hashtable Hashtable Hashtable Pointer )
            value.ChameleonSchemas                          = GetObject<Hashtable>(new IntPtr(p + 0x048), ReversePrism.DataModels.Hashtable.FromPointer); // 024667421318 0x48 ChameleonSchemas            ( 0001865DE360 ModelClassType Hashtable Hashtable Hashtable Pointer )
            value.TargetNamespaces                          = GetObject<Hashtable>(new IntPtr(p + 0x050), ReversePrism.DataModels.Hashtable.FromPointer); // 024667421338 0x50 TargetNamespaces            ( 0001865DE360 ModelClassType Hashtable Hashtable Hashtable Pointer )
            value.CompileAll                                = GetBool(new IntPtr(p + 0x058)); // 024667421358 0x58 CompileAll                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.CachedCompiledInfo                        = GetObject<SchemaInfo>(new IntPtr(p + 0x060), ReversePrism.DataModels.SchemaInfo.FromPointer); // 024667421378 0x60 CachedCompiledInfo          ( 0001866E9EB0 ModelClassType SchemaInfo SchemaInfo SchemaInfo Pointer )
            value.ReaderSettings                            = GetObject<XmlReaderSettings>(new IntPtr(p + 0x068), ReversePrism.DataModels.XmlReaderSettings.FromPointer); // 024667421398 0x68 ReaderSettings              ( 0001865AACF0 ModelClassType XmlReaderSettings XmlReaderSettings XmlReaderSettings Pointer )
            value.SchemaForSchema                           = GetObject<XmlSchema>(new IntPtr(p + 0x070), ReversePrism.DataModels.XmlSchema.FromPointer); // 0246674213B8 0x70 SchemaForSchema             ( 0001866BE120 ModelClassType XmlSchema XmlSchema XmlSchema Pointer )
            value.CompilationSettings                       = GetObject<XmlSchemaCompilationSettings>(new IntPtr(p + 0x078), ReversePrism.DataModels.XmlSchemaCompilationSettings.FromPointer); // 0246674213D8 0x78 CompilationSettings         ( 0001865B0220 ModelClassType XmlSchemaCompilationSettings XmlSchemaCompilationSettings XmlSchemaCompilationSettings Pointer )
            value.Elements                                  = GetObject<XmlSchemaObjectTable>(new IntPtr(p + 0x080), ReversePrism.DataModels.XmlSchemaObjectTable.FromPointer); // 0246674213F8 0x80 Elements                    ( 0001865BCFD0 ModelClassType XmlSchemaObjectTable XmlSchemaObjectTable XmlSchemaObjectTable Pointer )
            value.Attributes                                = GetObject<XmlSchemaObjectTable>(new IntPtr(p + 0x088), ReversePrism.DataModels.XmlSchemaObjectTable.FromPointer); // 024667421418 0x88 Attributes                  ( 0001865BCFD0 ModelClassType XmlSchemaObjectTable XmlSchemaObjectTable XmlSchemaObjectTable Pointer )
            value.SchemaTypes                               = GetObject<XmlSchemaObjectTable>(new IntPtr(p + 0x090), ReversePrism.DataModels.XmlSchemaObjectTable.FromPointer); // 024667421438 0x90 SchemaTypes                 ( 0001865BCFD0 ModelClassType XmlSchemaObjectTable XmlSchemaObjectTable XmlSchemaObjectTable Pointer )
            value.SubstitutionGroups                        = GetObject<XmlSchemaObjectTable>(new IntPtr(p + 0x098), ReversePrism.DataModels.XmlSchemaObjectTable.FromPointer); // 024667421458 0x98 SubstitutionGroups          ( 0001865BCFD0 ModelClassType XmlSchemaObjectTable XmlSchemaObjectTable XmlSchemaObjectTable Pointer )
            value.TypeExtensions                            = GetObject<XmlSchemaObjectTable>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.XmlSchemaObjectTable.FromPointer); // 024667421478 0xA0 TypeExtensions              ( 0001865BCD20 ModelClassType XmlSchemaObjectTable XmlSchemaObjectTable XmlSchemaObjectTable Pointer )

            return value;
        }
    }
}
