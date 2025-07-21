using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Schemas                                  ModelClassType XmlSchemaSet XmlSchemaSet XmlSchemaSet Pointer
    // 018 XmlDoc                                   ModelClassType XmlDocument XmlDocument XmlDocument Pointer
    // 020 DataContractSet                          ModelClassType DataContractSet DataContractSet DataContractSet Pointer
    // 000 anytypeQualifiedName                     XmlQualifiedName IL2CPP_TYPE_CLASS
    // 008 stringQualifiedName                      XmlQualifiedName IL2CPP_TYPE_CLASS
    // 010 DefaultEnumBaseTypeName                  ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 018 EnumerationValueAnnotationName           ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 020 SurrogateDataAnnotationName              ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 028 DefaultValueAnnotation                   ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 030 ActualTypeAnnotationName                 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 038 IsDictionaryAnnotationName               ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 040 IsValueTypeName                          ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    public partial class SchemaExporter : DataModel
    {
        public XmlSchemaSet?                            Schemas                                 { get; set; }
        public XmlDocument?                             XmlDoc                                  { get; set; }
        public DataContractSet?                         DataContractSet                         { get; set; }
        public XmlQualifiedName?                        DefaultEnumBaseTypeName                 { get; set; }
        public XmlQualifiedName?                        EnumerationValueAnnotationName          { get; set; }
        public XmlQualifiedName?                        SurrogateDataAnnotationName             { get; set; }
        public XmlQualifiedName?                        DefaultValueAnnotation                  { get; set; }
        public XmlQualifiedName?                        ActualTypeAnnotationName                { get; set; }
        public XmlQualifiedName?                        IsDictionaryAnnotationName              { get; set; }
        public XmlQualifiedName?                        IsValueTypeName                         { get; set; }

        public static SchemaExporter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SchemaExporter() { Pointer= p0 };

            value.Schemas                                   = GetObject<XmlSchemaSet>(new IntPtr(p + 0x010), ReversePrism.DataModels.XmlSchemaSet.FromPointer); // 0x10 Schemas                     ( ModelClassType XmlSchemaSet XmlSchemaSet XmlSchemaSet Pointer )
            value.XmlDoc                                    = GetObject<XmlDocument>(new IntPtr(p + 0x018), ReversePrism.DataModels.XmlDocument.FromPointer); // 0x18 XmlDoc                      ( ModelClassType XmlDocument XmlDocument XmlDocument Pointer )
            value.DataContractSet                           = GetObject<DataContractSet>(new IntPtr(p + 0x020), ReversePrism.DataModels.DataContractSet.FromPointer); // 0x20 DataContractSet             ( ModelClassType DataContractSet DataContractSet DataContractSet Pointer )
            value.DefaultEnumBaseTypeName                   = GetObject<XmlQualifiedName>(new IntPtr(p + 0x010), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x10 DefaultEnumBaseTypeName     ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.EnumerationValueAnnotationName            = GetObject<XmlQualifiedName>(new IntPtr(p + 0x018), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x18 EnumerationValueAnnotationName ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.SurrogateDataAnnotationName               = GetObject<XmlQualifiedName>(new IntPtr(p + 0x020), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x20 SurrogateDataAnnotationName ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.DefaultValueAnnotation                    = GetObject<XmlQualifiedName>(new IntPtr(p + 0x028), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x28 DefaultValueAnnotation      ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.ActualTypeAnnotationName                  = GetObject<XmlQualifiedName>(new IntPtr(p + 0x030), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x30 ActualTypeAnnotationName    ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.IsDictionaryAnnotationName                = GetObject<XmlQualifiedName>(new IntPtr(p + 0x038), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x38 IsDictionaryAnnotationName  ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.IsValueTypeName                           = GetObject<XmlQualifiedName>(new IntPtr(p + 0x040), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x40 IsValueTypeName             ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )

            return value;
        }
    }
}
