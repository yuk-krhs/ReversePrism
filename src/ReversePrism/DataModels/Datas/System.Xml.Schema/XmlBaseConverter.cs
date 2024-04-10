using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SchemaType                               0001866BFF90 ModelClassType XmlSchemaType XmlSchemaType XmlSchemaType Pointer
    // 018 TypeCode                                 0001865CF010 ModelEnumType XmlTypeCode XmlTypeCode XmlTypeCode Int32
    // 020 ClrTypeDefault                           000186692850 ModelClassType Type Type Type Pointer
    // 000 ICollectionType                          Type IL2CPP_TYPE_CLASS
    // 008 IEnumerableType                          Type IL2CPP_TYPE_CLASS
    // 010 IListType                                000186694310 ModelClassType Type Type Type Pointer
    // 018 ObjectArrayType                          000186694310 ModelClassType Type Type Type Pointer
    // 020 StringArrayType                          000186694310 ModelClassType Type Type Type Pointer
    // 028 XmlAtomicValueArrayType                  000186694310 ModelClassType Type Type Type Pointer
    // 030 DecimalType                              000186694310 ModelClassType Type Type Type Pointer
    // 038 Int32Type                                000186694310 ModelClassType Type Type Type Pointer
    // 040 Int64Type                                000186694310 ModelClassType Type Type Type Pointer
    // 048 StringType                               000186694310 ModelClassType Type Type Type Pointer
    // 050 XmlAtomicValueType                       000186694310 ModelClassType Type Type Type Pointer
    // 058 ObjectType                               000186694310 ModelClassType Type Type Type Pointer
    // 060 ByteType                                 000186694310 ModelClassType Type Type Type Pointer
    // 068 Int16Type                                000186694310 ModelClassType Type Type Type Pointer
    // 070 SByteType                                000186694310 ModelClassType Type Type Type Pointer
    // 078 UInt16Type                               000186694310 ModelClassType Type Type Type Pointer
    // 080 UInt32Type                               000186694310 ModelClassType Type Type Type Pointer
    // 088 UInt64Type                               000186694310 ModelClassType Type Type Type Pointer
    // 090 XPathItemType                            000186694310 ModelClassType Type Type Type Pointer
    // 098 DoubleType                               000186694310 ModelClassType Type Type Type Pointer
    // 0A0 SingleType                               000186694310 ModelClassType Type Type Type Pointer
    // 0A8 DateTimeType                             000186694310 ModelClassType Type Type Type Pointer
    // 0B0 DateTimeOffsetType                       000186694310 ModelClassType Type Type Type Pointer
    // 0B8 BooleanType                              000186694310 ModelClassType Type Type Type Pointer
    // 0C0 ByteArrayType                            000186694310 ModelClassType Type Type Type Pointer
    // 0C8 XmlQualifiedNameType                     000186694310 ModelClassType Type Type Type Pointer
    // 0D0 UriType                                  000186694310 ModelClassType Type Type Type Pointer
    // 0D8 TimeSpanType                             000186694310 ModelClassType Type Type Type Pointer
    // 0E0 XPathNavigatorType                       000186694310 ModelClassType Type Type Type Pointer
    public partial class XmlBaseConverter : DataModel
    {
        public XmlSchemaType?                           SchemaType                              { get; set; }
        public XmlTypeCode                              TypeCode                                { get; set; }
        public Type?                                    ClrTypeDefault                          { get; set; }
        public Type?                                    IListType                               { get; set; }
        public Type?                                    ObjectArrayType                         { get; set; }
        public Type?                                    StringArrayType                         { get; set; }
        public Type?                                    XmlAtomicValueArrayType                 { get; set; }
        public Type?                                    DecimalType                             { get; set; }
        public Type?                                    Int32Type                               { get; set; }
        public Type?                                    Int64Type                               { get; set; }
        public Type?                                    StringType                              { get; set; }
        public Type?                                    XmlAtomicValueType                      { get; set; }
        public Type?                                    ObjectType                              { get; set; }
        public Type?                                    ByteType                                { get; set; }
        public Type?                                    Int16Type                               { get; set; }
        public Type?                                    SByteType                               { get; set; }
        public Type?                                    UInt16Type                              { get; set; }
        public Type?                                    UInt32Type                              { get; set; }
        public Type?                                    UInt64Type                              { get; set; }
        public Type?                                    XPathItemType                           { get; set; }
        public Type?                                    DoubleType                              { get; set; }
        public Type?                                    SingleType                              { get; set; }
        public Type?                                    DateTimeType                            { get; set; }
        public Type?                                    DateTimeOffsetType                      { get; set; }
        public Type?                                    BooleanType                             { get; set; }
        public Type?                                    ByteArrayType                           { get; set; }
        public Type?                                    XmlQualifiedNameType                    { get; set; }
        public Type?                                    UriType                                 { get; set; }
        public Type?                                    TimeSpanType                            { get; set; }
        public Type?                                    XPathNavigatorType                      { get; set; }

        public static XmlBaseConverter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlBaseConverter() { Pointer= p0 };

            value.SchemaType                                = GetObject<XmlSchemaType>(new IntPtr(p + 0x010), ReversePrism.DataModels.XmlSchemaType.FromPointer); // 02466762CC48 0x10 SchemaType                  ( 0001866BFF90 ModelClassType XmlSchemaType XmlSchemaType XmlSchemaType Pointer )
            value.TypeCode                                  = (XmlTypeCode)GetInt32(new IntPtr(p + 0x018)); // 02466762CC68 0x18 TypeCode                    ( 0001865CF010 ModelEnumType XmlTypeCode XmlTypeCode XmlTypeCode Int32 )
            value.ClrTypeDefault                            = GetObject<Type>(new IntPtr(p + 0x020), ReversePrism.DataModels.Type.FromPointer); // 02466762CC88 0x20 ClrTypeDefault              ( 000186692850 ModelClassType Type Type Type Pointer )
            value.IListType                                 = GetObject<Type>(new IntPtr(p + 0x010), ReversePrism.DataModels.Type.FromPointer); // 02466762CCE8 0x10 IListType                   ( 000186694310 ModelClassType Type Type Type Pointer )
            value.ObjectArrayType                           = GetObject<Type>(new IntPtr(p + 0x018), ReversePrism.DataModels.Type.FromPointer); // 02466762CD08 0x18 ObjectArrayType             ( 000186694310 ModelClassType Type Type Type Pointer )
            value.StringArrayType                           = GetObject<Type>(new IntPtr(p + 0x020), ReversePrism.DataModels.Type.FromPointer); // 02466762CD28 0x20 StringArrayType             ( 000186694310 ModelClassType Type Type Type Pointer )
            value.XmlAtomicValueArrayType                   = GetObject<Type>(new IntPtr(p + 0x028), ReversePrism.DataModels.Type.FromPointer); // 02466762CD48 0x28 XmlAtomicValueArrayType     ( 000186694310 ModelClassType Type Type Type Pointer )
            value.DecimalType                               = GetObject<Type>(new IntPtr(p + 0x030), ReversePrism.DataModels.Type.FromPointer); // 02466762CD68 0x30 DecimalType                 ( 000186694310 ModelClassType Type Type Type Pointer )
            value.Int32Type                                 = GetObject<Type>(new IntPtr(p + 0x038), ReversePrism.DataModels.Type.FromPointer); // 02466762CD88 0x38 Int32Type                   ( 000186694310 ModelClassType Type Type Type Pointer )
            value.Int64Type                                 = GetObject<Type>(new IntPtr(p + 0x040), ReversePrism.DataModels.Type.FromPointer); // 02466762CDA8 0x40 Int64Type                   ( 000186694310 ModelClassType Type Type Type Pointer )
            value.StringType                                = GetObject<Type>(new IntPtr(p + 0x048), ReversePrism.DataModels.Type.FromPointer); // 02466762CDC8 0x48 StringType                  ( 000186694310 ModelClassType Type Type Type Pointer )
            value.XmlAtomicValueType                        = GetObject<Type>(new IntPtr(p + 0x050), ReversePrism.DataModels.Type.FromPointer); // 02466762CDE8 0x50 XmlAtomicValueType          ( 000186694310 ModelClassType Type Type Type Pointer )
            value.ObjectType                                = GetObject<Type>(new IntPtr(p + 0x058), ReversePrism.DataModels.Type.FromPointer); // 02466762CE08 0x58 ObjectType                  ( 000186694310 ModelClassType Type Type Type Pointer )
            value.ByteType                                  = GetObject<Type>(new IntPtr(p + 0x060), ReversePrism.DataModels.Type.FromPointer); // 02466762CE28 0x60 ByteType                    ( 000186694310 ModelClassType Type Type Type Pointer )
            value.Int16Type                                 = GetObject<Type>(new IntPtr(p + 0x068), ReversePrism.DataModels.Type.FromPointer); // 02466762CE48 0x68 Int16Type                   ( 000186694310 ModelClassType Type Type Type Pointer )
            value.SByteType                                 = GetObject<Type>(new IntPtr(p + 0x070), ReversePrism.DataModels.Type.FromPointer); // 02466762CE68 0x70 SByteType                   ( 000186694310 ModelClassType Type Type Type Pointer )
            value.UInt16Type                                = GetObject<Type>(new IntPtr(p + 0x078), ReversePrism.DataModels.Type.FromPointer); // 02466762CE88 0x78 UInt16Type                  ( 000186694310 ModelClassType Type Type Type Pointer )
            value.UInt32Type                                = GetObject<Type>(new IntPtr(p + 0x080), ReversePrism.DataModels.Type.FromPointer); // 02466762CEA8 0x80 UInt32Type                  ( 000186694310 ModelClassType Type Type Type Pointer )
            value.UInt64Type                                = GetObject<Type>(new IntPtr(p + 0x088), ReversePrism.DataModels.Type.FromPointer); // 02466762CEC8 0x88 UInt64Type                  ( 000186694310 ModelClassType Type Type Type Pointer )
            value.XPathItemType                             = GetObject<Type>(new IntPtr(p + 0x090), ReversePrism.DataModels.Type.FromPointer); // 02466762CEE8 0x90 XPathItemType               ( 000186694310 ModelClassType Type Type Type Pointer )
            value.DoubleType                                = GetObject<Type>(new IntPtr(p + 0x098), ReversePrism.DataModels.Type.FromPointer); // 02466762CF08 0x98 DoubleType                  ( 000186694310 ModelClassType Type Type Type Pointer )
            value.SingleType                                = GetObject<Type>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.Type.FromPointer); // 02466762CF28 0xA0 SingleType                  ( 000186694310 ModelClassType Type Type Type Pointer )
            value.DateTimeType                              = GetObject<Type>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.Type.FromPointer); // 02466762CF48 0xA8 DateTimeType                ( 000186694310 ModelClassType Type Type Type Pointer )
            value.DateTimeOffsetType                        = GetObject<Type>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.Type.FromPointer); // 02466762CF68 0xB0 DateTimeOffsetType          ( 000186694310 ModelClassType Type Type Type Pointer )
            value.BooleanType                               = GetObject<Type>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.Type.FromPointer); // 02466762CF88 0xB8 BooleanType                 ( 000186694310 ModelClassType Type Type Type Pointer )
            value.ByteArrayType                             = GetObject<Type>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.Type.FromPointer); // 02466762CFA8 0xC0 ByteArrayType               ( 000186694310 ModelClassType Type Type Type Pointer )
            value.XmlQualifiedNameType                      = GetObject<Type>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.Type.FromPointer); // 02466762CFC8 0xC8 XmlQualifiedNameType        ( 000186694310 ModelClassType Type Type Type Pointer )
            value.UriType                                   = GetObject<Type>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.Type.FromPointer); // 02466762CFE8 0xD0 UriType                     ( 000186694310 ModelClassType Type Type Type Pointer )
            value.TimeSpanType                              = GetObject<Type>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.Type.FromPointer); // 02466762D008 0xD8 TimeSpanType                ( 000186694310 ModelClassType Type Type Type Pointer )
            value.XPathNavigatorType                        = GetObject<Type>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.Type.FromPointer); // 02466762D028 0xE0 XPathNavigatorType          ( 000186694310 ModelClassType Type Type Type Pointer )

            return value;
        }
    }
}
