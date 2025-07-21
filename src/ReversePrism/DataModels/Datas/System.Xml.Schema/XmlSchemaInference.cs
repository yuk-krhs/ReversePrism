using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 ST_boolean                               XmlQualifiedName IL2CPP_TYPE_CLASS
    // 008 ST_byte                                  XmlQualifiedName IL2CPP_TYPE_CLASS
    // 010 ST_unsignedByte                          ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 018 ST_short                                 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 020 ST_unsignedShort                         ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 028 ST_int                                   ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 030 ST_unsignedInt                           ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 038 ST_long                                  ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 040 ST_unsignedLong                          ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 048 ST_integer                               ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 050 ST_decimal                               ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 058 ST_float                                 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 060 ST_double                                ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 068 ST_duration                              ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 070 ST_dateTime                              ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 078 ST_time                                  ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 080 ST_date                                  ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 088 ST_gYearMonth                            ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 090 ST_string                                ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 098 ST_anySimpleType                         ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 0A0 SimpleTypes                              ModelClassListType XmlQualifiedName[] XmlQualifiedName[] List<XmlQualifiedName> Pointer
    // 010 RootSchema                               ModelClassType XmlSchema XmlSchema XmlSchema Pointer
    // 018 SchemaSet                                ModelClassType XmlSchemaSet XmlSchemaSet XmlSchemaSet Pointer
    // 020 Xtr                                      ModelClassType XmlReader XmlReader XmlReader Pointer
    // 028 Nametable                                ModelClassType NameTable NameTable NameTable Pointer
    // 030 TargetNamespace                          ModelPrimitiveType string string string String
    // 038 NamespaceManager                         ModelClassType XmlNamespaceManager XmlNamespaceManager XmlNamespaceManager Pointer
    // 040 SchemaList                               ModelClassType ArrayList ArrayList ArrayList Pointer
    // 048 Occurrence                               ModelEnumType InferenceOption InferenceOption InferenceOption Int32
    // 04C TypeInference                            ModelEnumType InferenceOption InferenceOption InferenceOption Int32
    public partial class XmlSchemaInference : DataModel
    {
        public XmlQualifiedName?                        ST_unsignedByte                         { get; set; }
        public XmlQualifiedName?                        ST_short                                { get; set; }
        public XmlQualifiedName?                        ST_unsignedShort                        { get; set; }
        public XmlQualifiedName?                        ST_int                                  { get; set; }
        public XmlQualifiedName?                        ST_unsignedInt                          { get; set; }
        public XmlQualifiedName?                        ST_long                                 { get; set; }
        public XmlQualifiedName?                        ST_unsignedLong                         { get; set; }
        public XmlQualifiedName?                        ST_integer                              { get; set; }
        public XmlQualifiedName?                        ST_decimal                              { get; set; }
        public XmlQualifiedName?                        ST_float                                { get; set; }
        public XmlQualifiedName?                        ST_double                               { get; set; }
        public XmlQualifiedName?                        ST_duration                             { get; set; }
        public XmlQualifiedName?                        ST_dateTime                             { get; set; }
        public XmlQualifiedName?                        ST_time                                 { get; set; }
        public XmlQualifiedName?                        ST_date                                 { get; set; }
        public XmlQualifiedName?                        ST_gYearMonth                           { get; set; }
        public XmlQualifiedName?                        ST_string                               { get; set; }
        public XmlQualifiedName?                        ST_anySimpleType                        { get; set; }
        public List<XmlQualifiedName>?                  SimpleTypes                             { get; set; }
        public XmlSchema?                               RootSchema                              { get; set; }
        public XmlSchemaSet?                            SchemaSet                               { get; set; }
        public XmlReader?                               Xtr                                     { get; set; }
        public NameTable?                               Nametable                               { get; set; }
        public string                                   TargetNamespace                         { get; set; }
        public XmlNamespaceManager?                     NamespaceManager                        { get; set; }
        public ArrayList?                               SchemaList                              { get; set; }
        public InferenceOption                          Occurrence                              { get; set; }
        public InferenceOption                          TypeInference                           { get; set; }

        public static XmlSchemaInference? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlSchemaInference() { Pointer= p0 };

            value.ST_unsignedByte                           = GetObject<XmlQualifiedName>(new IntPtr(p + 0x010), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x10 ST_unsignedByte             ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.ST_short                                  = GetObject<XmlQualifiedName>(new IntPtr(p + 0x018), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x18 ST_short                    ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.ST_unsignedShort                          = GetObject<XmlQualifiedName>(new IntPtr(p + 0x020), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x20 ST_unsignedShort            ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.ST_int                                    = GetObject<XmlQualifiedName>(new IntPtr(p + 0x028), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x28 ST_int                      ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.ST_unsignedInt                            = GetObject<XmlQualifiedName>(new IntPtr(p + 0x030), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x30 ST_unsignedInt              ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.ST_long                                   = GetObject<XmlQualifiedName>(new IntPtr(p + 0x038), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x38 ST_long                     ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.ST_unsignedLong                           = GetObject<XmlQualifiedName>(new IntPtr(p + 0x040), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x40 ST_unsignedLong             ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.ST_integer                                = GetObject<XmlQualifiedName>(new IntPtr(p + 0x048), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x48 ST_integer                  ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.ST_decimal                                = GetObject<XmlQualifiedName>(new IntPtr(p + 0x050), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x50 ST_decimal                  ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.ST_float                                  = GetObject<XmlQualifiedName>(new IntPtr(p + 0x058), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x58 ST_float                    ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.ST_double                                 = GetObject<XmlQualifiedName>(new IntPtr(p + 0x060), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x60 ST_double                   ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.ST_duration                               = GetObject<XmlQualifiedName>(new IntPtr(p + 0x068), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x68 ST_duration                 ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.ST_dateTime                               = GetObject<XmlQualifiedName>(new IntPtr(p + 0x070), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x70 ST_dateTime                 ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.ST_time                                   = GetObject<XmlQualifiedName>(new IntPtr(p + 0x078), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x78 ST_time                     ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.ST_date                                   = GetObject<XmlQualifiedName>(new IntPtr(p + 0x080), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x80 ST_date                     ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.ST_gYearMonth                             = GetObject<XmlQualifiedName>(new IntPtr(p + 0x088), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x88 ST_gYearMonth               ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.ST_string                                 = GetObject<XmlQualifiedName>(new IntPtr(p + 0x090), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x90 ST_string                   ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.ST_anySimpleType                          = GetObject<XmlQualifiedName>(new IntPtr(p + 0x098), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x98 ST_anySimpleType            ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.SimpleTypes                               = GetObjectList<XmlQualifiedName>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0xA0 SimpleTypes                 ( ModelClassListType XmlQualifiedName[] XmlQualifiedName[] List<XmlQualifiedName> Pointer )
            value.RootSchema                                = GetObject<XmlSchema>(new IntPtr(p + 0x010), ReversePrism.DataModels.XmlSchema.FromPointer); // 0x10 RootSchema                  ( ModelClassType XmlSchema XmlSchema XmlSchema Pointer )
            value.SchemaSet                                 = GetObject<XmlSchemaSet>(new IntPtr(p + 0x018), ReversePrism.DataModels.XmlSchemaSet.FromPointer); // 0x18 SchemaSet                   ( ModelClassType XmlSchemaSet XmlSchemaSet XmlSchemaSet Pointer )
            value.Xtr                                       = GetObject<XmlReader>(new IntPtr(p + 0x020), ReversePrism.DataModels.XmlReader.FromPointer); // 0x20 Xtr                         ( ModelClassType XmlReader XmlReader XmlReader Pointer )
            value.Nametable                                 = GetObject<NameTable>(new IntPtr(p + 0x028), ReversePrism.DataModels.NameTable.FromPointer); // 0x28 Nametable                   ( ModelClassType NameTable NameTable NameTable Pointer )
            value.TargetNamespace                           = GetString(new IntPtr(p + 0x030)); // 0x30 TargetNamespace             ( ModelPrimitiveType string string string String )
            value.NamespaceManager                          = GetObject<XmlNamespaceManager>(new IntPtr(p + 0x038), ReversePrism.DataModels.XmlNamespaceManager.FromPointer); // 0x38 NamespaceManager            ( ModelClassType XmlNamespaceManager XmlNamespaceManager XmlNamespaceManager Pointer )
            value.SchemaList                                = GetObject<ArrayList>(new IntPtr(p + 0x040), ReversePrism.DataModels.ArrayList.FromPointer); // 0x40 SchemaList                  ( ModelClassType ArrayList ArrayList ArrayList Pointer )
            value.Occurrence                                = (InferenceOption)GetInt32(new IntPtr(p + 0x048)); // 0x48 Occurrence                  ( ModelEnumType InferenceOption InferenceOption InferenceOption Int32 )
            value.TypeInference                             = (InferenceOption)GetInt32(new IntPtr(p + 0x04C)); // 0x4C TypeInference               ( ModelEnumType InferenceOption InferenceOption InferenceOption Int32 )

            return value;
        }
    }
}
