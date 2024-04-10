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
    // 010 ST_unsignedByte                          0001866BD3E0 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 018 ST_short                                 0001866BD3E0 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 020 ST_unsignedShort                         0001866BD3E0 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 028 ST_int                                   0001866BD3E0 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 030 ST_unsignedInt                           0001866BD3E0 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 038 ST_long                                  0001866BD3E0 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 040 ST_unsignedLong                          0001866BD3E0 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 048 ST_integer                               0001866BD3E0 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 050 ST_decimal                               0001866BD3E0 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 058 ST_float                                 0001866BD3E0 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 060 ST_double                                0001866BD3E0 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 068 ST_duration                              0001866BD3E0 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 070 ST_dateTime                              0001866BD3E0 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 078 ST_time                                  0001866BD3E0 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 080 ST_date                                  0001866BD3E0 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 088 ST_gYearMonth                            0001866BD3E0 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 090 ST_string                                0001866BD3E0 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 098 ST_anySimpleType                         0001866BD3E0 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 0A0 SimpleTypes                              000185CB4288 ModelClassListType XmlQualifiedName[] XmlQualifiedName[] List<XmlQualifiedName> Pointer
    // 010 RootSchema                               0001866BE120 ModelClassType XmlSchema XmlSchema XmlSchema Pointer
    // 018 SchemaSet                                0001865BEE30 ModelClassType XmlSchemaSet XmlSchemaSet XmlSchemaSet Pointer
    // 020 Xtr                                      0001865A9BB0 ModelClassType XmlReader XmlReader XmlReader Pointer
    // 028 Nametable                                00018667C500 ModelClassType NameTable NameTable NameTable Pointer
    // 030 TargetNamespace                          000186671910 ModelPrimitiveType string string string String
    // 038 NamespaceManager                         0001866BAB00 ModelClassType XmlNamespaceManager XmlNamespaceManager XmlNamespaceManager Pointer
    // 040 SchemaList                               00018658A070 ModelClassType ArrayList ArrayList ArrayList Pointer
    // 048 Occurrence                               00018673BD70 ModelEnumType InferenceOption InferenceOption InferenceOption Int32
    // 04C TypeInference                            00018673BD70 ModelEnumType InferenceOption InferenceOption InferenceOption Int32
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

            value.ST_unsignedByte                           = GetObject<XmlQualifiedName>(new IntPtr(p + 0x010), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 024667592528 0x10 ST_unsignedByte             ( 0001866BD3E0 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.ST_short                                  = GetObject<XmlQualifiedName>(new IntPtr(p + 0x018), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 024667592548 0x18 ST_short                    ( 0001866BD3E0 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.ST_unsignedShort                          = GetObject<XmlQualifiedName>(new IntPtr(p + 0x020), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 024667592568 0x20 ST_unsignedShort            ( 0001866BD3E0 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.ST_int                                    = GetObject<XmlQualifiedName>(new IntPtr(p + 0x028), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 024667592588 0x28 ST_int                      ( 0001866BD3E0 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.ST_unsignedInt                            = GetObject<XmlQualifiedName>(new IntPtr(p + 0x030), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0246675925A8 0x30 ST_unsignedInt              ( 0001866BD3E0 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.ST_long                                   = GetObject<XmlQualifiedName>(new IntPtr(p + 0x038), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0246675925C8 0x38 ST_long                     ( 0001866BD3E0 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.ST_unsignedLong                           = GetObject<XmlQualifiedName>(new IntPtr(p + 0x040), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0246675925E8 0x40 ST_unsignedLong             ( 0001866BD3E0 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.ST_integer                                = GetObject<XmlQualifiedName>(new IntPtr(p + 0x048), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 024667592608 0x48 ST_integer                  ( 0001866BD3E0 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.ST_decimal                                = GetObject<XmlQualifiedName>(new IntPtr(p + 0x050), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 024667592628 0x50 ST_decimal                  ( 0001866BD3E0 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.ST_float                                  = GetObject<XmlQualifiedName>(new IntPtr(p + 0x058), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 024667592648 0x58 ST_float                    ( 0001866BD3E0 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.ST_double                                 = GetObject<XmlQualifiedName>(new IntPtr(p + 0x060), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 024667592668 0x60 ST_double                   ( 0001866BD3E0 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.ST_duration                               = GetObject<XmlQualifiedName>(new IntPtr(p + 0x068), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 024667592688 0x68 ST_duration                 ( 0001866BD3E0 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.ST_dateTime                               = GetObject<XmlQualifiedName>(new IntPtr(p + 0x070), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0246675926A8 0x70 ST_dateTime                 ( 0001866BD3E0 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.ST_time                                   = GetObject<XmlQualifiedName>(new IntPtr(p + 0x078), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0246675926C8 0x78 ST_time                     ( 0001866BD3E0 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.ST_date                                   = GetObject<XmlQualifiedName>(new IntPtr(p + 0x080), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0246675926E8 0x80 ST_date                     ( 0001866BD3E0 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.ST_gYearMonth                             = GetObject<XmlQualifiedName>(new IntPtr(p + 0x088), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 024667592708 0x88 ST_gYearMonth               ( 0001866BD3E0 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.ST_string                                 = GetObject<XmlQualifiedName>(new IntPtr(p + 0x090), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 024667592728 0x90 ST_string                   ( 0001866BD3E0 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.ST_anySimpleType                          = GetObject<XmlQualifiedName>(new IntPtr(p + 0x098), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 024667592748 0x98 ST_anySimpleType            ( 0001866BD3E0 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.SimpleTypes                               = GetObjectList<XmlQualifiedName>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 024667592768 0xA0 SimpleTypes                 ( 000185CB4288 ModelClassListType XmlQualifiedName[] XmlQualifiedName[] List<XmlQualifiedName> Pointer )
            value.RootSchema                                = GetObject<XmlSchema>(new IntPtr(p + 0x010), ReversePrism.DataModels.XmlSchema.FromPointer); // 024667592788 0x10 RootSchema                  ( 0001866BE120 ModelClassType XmlSchema XmlSchema XmlSchema Pointer )
            value.SchemaSet                                 = GetObject<XmlSchemaSet>(new IntPtr(p + 0x018), ReversePrism.DataModels.XmlSchemaSet.FromPointer); // 0246675927A8 0x18 SchemaSet                   ( 0001865BEE30 ModelClassType XmlSchemaSet XmlSchemaSet XmlSchemaSet Pointer )
            value.Xtr                                       = GetObject<XmlReader>(new IntPtr(p + 0x020), ReversePrism.DataModels.XmlReader.FromPointer); // 0246675927C8 0x20 Xtr                         ( 0001865A9BB0 ModelClassType XmlReader XmlReader XmlReader Pointer )
            value.Nametable                                 = GetObject<NameTable>(new IntPtr(p + 0x028), ReversePrism.DataModels.NameTable.FromPointer); // 0246675927E8 0x28 Nametable                   ( 00018667C500 ModelClassType NameTable NameTable NameTable Pointer )
            value.TargetNamespace                           = GetString(new IntPtr(p + 0x030)); // 024667592808 0x30 TargetNamespace             ( 000186671910 ModelPrimitiveType string string string String )
            value.NamespaceManager                          = GetObject<XmlNamespaceManager>(new IntPtr(p + 0x038), ReversePrism.DataModels.XmlNamespaceManager.FromPointer); // 024667592828 0x38 NamespaceManager            ( 0001866BAB00 ModelClassType XmlNamespaceManager XmlNamespaceManager XmlNamespaceManager Pointer )
            value.SchemaList                                = GetObject<ArrayList>(new IntPtr(p + 0x040), ReversePrism.DataModels.ArrayList.FromPointer); // 024667592848 0x40 SchemaList                  ( 00018658A070 ModelClassType ArrayList ArrayList ArrayList Pointer )
            value.Occurrence                                = (InferenceOption)GetInt32(new IntPtr(p + 0x048)); // 024667592868 0x48 Occurrence                  ( 00018673BD70 ModelEnumType InferenceOption InferenceOption InferenceOption Int32 )
            value.TypeInference                             = (InferenceOption)GetInt32(new IntPtr(p + 0x04C)); // 024667592888 0x4C TypeInference               ( 00018673BD70 ModelEnumType InferenceOption InferenceOption InferenceOption Int32 )

            return value;
        }
    }
}
