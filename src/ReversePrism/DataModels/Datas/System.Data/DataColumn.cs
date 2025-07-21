using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 AllowNull                                ModelPrimitiveType bool bool bool Bool
    // 028 Caption                                  ModelPrimitiveType string string string String
    // 030 ColumnName                               ModelPrimitiveType string string string String
    // 038 DataType                                 ModelClassType Type Type Type Pointer
    // 040 StorageType                              ModelEnumType StorageType StorageType StorageType Int32
    // 048 _defaultValue                            <object> IL2CPP_TYPE_OBJECT
    // 050 DateTimeMode                             ModelEnumType DataSetDateTime DataSetDateTime DataSetDateTime Int32
    // 058 Expression                               ModelClassType DataExpression DataExpression DataExpression Pointer
    // 060 MaxLength                                ModelPrimitiveType int int int Int32
    // 064 Ordinal                                  ModelPrimitiveType int int int Int32
    // 068 ReadOnly                                 ModelPrimitiveType bool bool bool Bool
    // 070 SortIndex                                ModelClassType Index Index Index Pointer
    // 078 Table                                    ModelClassType DataTable DataTable DataTable Pointer
    // 080 Unique                                   ModelPrimitiveType bool bool bool Bool
    // 084 ColumnMapping                            ModelEnumType MappingType MappingType MappingType Int32
    // 088 HashCode                                 ModelPrimitiveType int int int Int32
    // 08C Errors                                   ModelPrimitiveType int int int Int32
    // 090 IsSqlType                                ModelPrimitiveType bool bool bool Bool
    // 091 ImplementsINullable                      ModelPrimitiveType bool bool bool Bool
    // 092 ImplementsIChangeTracking                ModelPrimitiveType bool bool bool Bool
    // 093 ImplementsIRevertibleChangeTracking      ModelPrimitiveType bool bool bool Bool
    // 094 ImplementsIXMLSerializable               ModelPrimitiveType bool bool bool Bool
    // 095 DefaultValueIsNull                       ModelPrimitiveType bool bool bool Bool
    // 098 DependentColumns                         ModelClassListType List`1<DataColumn> List`1<DataColumn> List<DataColumn> Pointer
    // 0A0 ExtendedProperties                       ModelClassType PropertyCollection PropertyCollection PropertyCollection Pointer
    // 0A8 Storage                                  ModelClassType DataStorage DataStorage DataStorage Pointer
    // 0B0 AutoInc                                  ModelClassType AutoIncrementValue AutoIncrementValue AutoIncrementValue Pointer
    // 0B8 ColumnUri                                ModelPrimitiveType string string string String
    // 0C0 ColumnPrefix                             ModelPrimitiveType string string string String
    // 0C8 EncodedColumnName                        ModelPrimitiveType string string string String
    // 0D0 SimpleType                               ModelClassType SimpleType SimpleType SimpleType Pointer
    // 000 s_objectTypeCount                        int IL2CPP_TYPE_I4
    // 0D8 ObjectID                                 ModelPrimitiveType int int int Int32
    // 0E0 XmlDataType                              ModelPrimitiveType string string string String
    // 0E8 PropertyChanging                         ModelClassType PropertyChangedEventHandler PropertyChangedEventHandler PropertyChangedEventHandler Pointer
    public partial class DataColumn : DataModel
    {
        public bool                                     AllowNull                               { get; set; }
        public string                                   Caption                                 { get; set; }
        public string                                   ColumnName                              { get; set; }
        public Type?                                    DataType                                { get; set; }
        public StorageType                              StorageType                             { get; set; }
        public DataSetDateTime                          DateTimeMode                            { get; set; }
        public DataExpression?                          Expression                              { get; set; }
        public int                                      MaxLength                               { get; set; }
        public int                                      Ordinal                                 { get; set; }
        public bool                                     ReadOnly                                { get; set; }
        public Index?                                   SortIndex                               { get; set; }
        public DataTable?                               Table                                   { get; set; }
        public bool                                     Unique                                  { get; set; }
        public MappingType                              ColumnMapping                           { get; set; }
        public int                                      HashCode                                { get; set; }
        public int                                      Errors                                  { get; set; }
        public bool                                     IsSqlType                               { get; set; }
        public bool                                     ImplementsINullable                     { get; set; }
        public bool                                     ImplementsIChangeTracking               { get; set; }
        public bool                                     ImplementsIRevertibleChangeTracking     { get; set; }
        public bool                                     ImplementsIXMLSerializable              { get; set; }
        public bool                                     DefaultValueIsNull                      { get; set; }
        public List<DataColumn>?                        DependentColumns                        { get; set; }
        public PropertyCollection?                      ExtendedProperties                      { get; set; }
        public DataStorage?                             Storage                                 { get; set; }
        public AutoIncrementValue?                      AutoInc                                 { get; set; }
        public string                                   ColumnUri                               { get; set; }
        public string                                   ColumnPrefix                            { get; set; }
        public string                                   EncodedColumnName                       { get; set; }
        public SimpleType?                              SimpleType                              { get; set; }
        public int                                      ObjectID                                { get; set; }
        public string                                   XmlDataType                             { get; set; }
        public PropertyChangedEventHandler?             PropertyChanging                        { get; set; }

        public static DataColumn? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DataColumn() { Pointer= p0 };

            value.AllowNull                                 = GetBool(new IntPtr(p + 0x020)); // 0x20 AllowNull                   ( ModelPrimitiveType bool bool bool Bool )
            value.Caption                                   = GetString(new IntPtr(p + 0x028)); // 0x28 Caption                     ( ModelPrimitiveType string string string String )
            value.ColumnName                                = GetString(new IntPtr(p + 0x030)); // 0x30 ColumnName                  ( ModelPrimitiveType string string string String )
            value.DataType                                  = GetObject<Type>(new IntPtr(p + 0x038), ReversePrism.DataModels.Type.FromPointer); // 0x38 DataType                    ( ModelClassType Type Type Type Pointer )
            value.StorageType                               = (StorageType)GetInt32(new IntPtr(p + 0x040)); // 0x40 StorageType                 ( ModelEnumType StorageType StorageType StorageType Int32 )
            value.DateTimeMode                              = (DataSetDateTime)GetInt32(new IntPtr(p + 0x050)); // 0x50 DateTimeMode                ( ModelEnumType DataSetDateTime DataSetDateTime DataSetDateTime Int32 )
            value.Expression                                = GetObject<DataExpression>(new IntPtr(p + 0x058), ReversePrism.DataModels.DataExpression.FromPointer); // 0x58 Expression                  ( ModelClassType DataExpression DataExpression DataExpression Pointer )
            value.MaxLength                                 = GetInt32(new IntPtr(p + 0x060)); // 0x60 MaxLength                   ( ModelPrimitiveType int int int Int32 )
            value.Ordinal                                   = GetInt32(new IntPtr(p + 0x064)); // 0x64 Ordinal                     ( ModelPrimitiveType int int int Int32 )
            value.ReadOnly                                  = GetBool(new IntPtr(p + 0x068)); // 0x68 ReadOnly                    ( ModelPrimitiveType bool bool bool Bool )
            value.SortIndex                                 = GetObject<Index>(new IntPtr(p + 0x070), ReversePrism.DataModels.Index.FromPointer); // 0x70 SortIndex                   ( ModelClassType Index Index Index Pointer )
            value.Table                                     = GetObject<DataTable>(new IntPtr(p + 0x078), ReversePrism.DataModels.DataTable.FromPointer); // 0x78 Table                       ( ModelClassType DataTable DataTable DataTable Pointer )
            value.Unique                                    = GetBool(new IntPtr(p + 0x080)); // 0x80 Unique                      ( ModelPrimitiveType bool bool bool Bool )
            value.ColumnMapping                             = (MappingType)GetInt32(new IntPtr(p + 0x084)); // 0x84 ColumnMapping               ( ModelEnumType MappingType MappingType MappingType Int32 )
            value.HashCode                                  = GetInt32(new IntPtr(p + 0x088)); // 0x88 HashCode                    ( ModelPrimitiveType int int int Int32 )
            value.Errors                                    = GetInt32(new IntPtr(p + 0x08C)); // 0x8C Errors                      ( ModelPrimitiveType int int int Int32 )
            value.IsSqlType                                 = GetBool(new IntPtr(p + 0x090)); // 0x90 IsSqlType                   ( ModelPrimitiveType bool bool bool Bool )
            value.ImplementsINullable                       = GetBool(new IntPtr(p + 0x091)); // 0x91 ImplementsINullable         ( ModelPrimitiveType bool bool bool Bool )
            value.ImplementsIChangeTracking                 = GetBool(new IntPtr(p + 0x092)); // 0x92 ImplementsIChangeTracking   ( ModelPrimitiveType bool bool bool Bool )
            value.ImplementsIRevertibleChangeTracking       = GetBool(new IntPtr(p + 0x093)); // 0x93 ImplementsIRevertibleChangeTracking ( ModelPrimitiveType bool bool bool Bool )
            value.ImplementsIXMLSerializable                = GetBool(new IntPtr(p + 0x094)); // 0x94 ImplementsIXMLSerializable  ( ModelPrimitiveType bool bool bool Bool )
            value.DefaultValueIsNull                        = GetBool(new IntPtr(p + 0x095)); // 0x95 DefaultValueIsNull          ( ModelPrimitiveType bool bool bool Bool )
            value.DependentColumns                          = GetObjectList<DataColumn>(new IntPtr(p + 0x098), ReversePrism.DataModels.DataColumn.FromPointer); // 0x98 DependentColumns            ( ModelClassListType List`1<DataColumn> List`1<DataColumn> List<DataColumn> Pointer )
            value.ExtendedProperties                        = GetObject<PropertyCollection>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.PropertyCollection.FromPointer); // 0xA0 ExtendedProperties          ( ModelClassType PropertyCollection PropertyCollection PropertyCollection Pointer )
            value.Storage                                   = GetObject<DataStorage>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.DataStorage.FromPointer); // 0xA8 Storage                     ( ModelClassType DataStorage DataStorage DataStorage Pointer )
            value.AutoInc                                   = GetObject<AutoIncrementValue>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.AutoIncrementValue.FromPointer); // 0xB0 AutoInc                     ( ModelClassType AutoIncrementValue AutoIncrementValue AutoIncrementValue Pointer )
            value.ColumnUri                                 = GetString(new IntPtr(p + 0x0B8)); // 0xB8 ColumnUri                   ( ModelPrimitiveType string string string String )
            value.ColumnPrefix                              = GetString(new IntPtr(p + 0x0C0)); // 0xC0 ColumnPrefix                ( ModelPrimitiveType string string string String )
            value.EncodedColumnName                         = GetString(new IntPtr(p + 0x0C8)); // 0xC8 EncodedColumnName           ( ModelPrimitiveType string string string String )
            value.SimpleType                                = GetObject<SimpleType>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.SimpleType.FromPointer); // 0xD0 SimpleType                  ( ModelClassType SimpleType SimpleType SimpleType Pointer )
            value.ObjectID                                  = GetInt32(new IntPtr(p + 0x0D8)); // 0xD8 ObjectID                    ( ModelPrimitiveType int int int Int32 )
            value.XmlDataType                               = GetString(new IntPtr(p + 0x0E0)); // 0xE0 XmlDataType                 ( ModelPrimitiveType string string string String )
            value.PropertyChanging                          = GetObject<PropertyChangedEventHandler>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.PropertyChangedEventHandler.FromPointer); // 0xE8 PropertyChanging            ( ModelClassType PropertyChangedEventHandler PropertyChangedEventHandler PropertyChangedEventHandler Pointer )

            return value;
        }
    }
}
