using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 AllowNull                                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 028 Caption                                  000186671910 ModelPrimitiveType string string string String
    // 030 ColumnName                               000186671910 ModelPrimitiveType string string string String
    // 038 DataType                                 000186692850 ModelClassType Type Type Type Pointer
    // 040 StorageType                              00018658F750 ModelEnumType StorageType StorageType StorageType Int32
    // 048 _defaultValue                            <object> IL2CPP_TYPE_OBJECT
    // 050 DateTimeMode                             0001866818A0 ModelEnumType DataSetDateTime DataSetDateTime DataSetDateTime Int32
    // 058 Expression                               00018667A280 ModelClassType DataExpression DataExpression DataExpression Pointer
    // 060 MaxLength                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 064 Ordinal                                  0001865F2AF0 ModelPrimitiveType int int int Int32
    // 068 ReadOnly                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 070 SortIndex                                0001866E00D0 ModelClassType Index Index Index Pointer
    // 078 Table                                    0001865B8050 ModelClassType DataTable DataTable DataTable Pointer
    // 080 Unique                                   000186594D10 ModelPrimitiveType bool bool bool Bool
    // 084 ColumnMapping                            0001865D05E0 ModelEnumType MappingType MappingType MappingType Int32
    // 088 HashCode                                 0001865F2F90 ModelPrimitiveType int int int Int32
    // 08C Errors                                   0001865F2F90 ModelPrimitiveType int int int Int32
    // 090 IsSqlType                                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 091 ImplementsINullable                      000186594D10 ModelPrimitiveType bool bool bool Bool
    // 092 ImplementsIChangeTracking                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 093 ImplementsIRevertibleChangeTracking      000186594D10 ModelPrimitiveType bool bool bool Bool
    // 094 ImplementsIXMLSerializable               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 095 DefaultValueIsNull                       000186594D10 ModelPrimitiveType bool bool bool Bool
    // 098 DependentColumns                         000185CD5CF8 ModelClassListType List`1<DataColumn> List`1<DataColumn> List<DataColumn> Pointer
    // 0A0 ExtendedProperties                       0001865D2A60 ModelClassType PropertyCollection PropertyCollection PropertyCollection Pointer
    // 0A8 Storage                                  000186682000 ModelClassType DataStorage DataStorage DataStorage Pointer
    // 0B0 AutoInc                                  0001867255D0 ModelClassType AutoIncrementValue AutoIncrementValue AutoIncrementValue Pointer
    // 0B8 ColumnUri                                000186671BA0 ModelPrimitiveType string string string String
    // 0C0 ColumnPrefix                             000186671910 ModelPrimitiveType string string string String
    // 0C8 EncodedColumnName                        000186671BA0 ModelPrimitiveType string string string String
    // 0D0 SimpleType                               00018650C5B0 ModelClassType SimpleType SimpleType SimpleType Pointer
    // 000 s_objectTypeCount                        int IL2CPP_TYPE_I4
    // 0D8 ObjectID                                 0001865F4260 ModelPrimitiveType int int int Int32
    // 0E0 XmlDataType                              000186671910 ModelPrimitiveType string string string String
    // 0E8 PropertyChanging                         0001865D1C20 ModelClassType PropertyChangedEventHandler PropertyChangedEventHandler PropertyChangedEventHandler Pointer
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

            value.AllowNull                                 = GetBool(new IntPtr(p + 0x020)); // 0246688FBAF0 0x20 AllowNull                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Caption                                   = GetString(new IntPtr(p + 0x028)); // 0246688FBB10 0x28 Caption                     ( 000186671910 ModelPrimitiveType string string string String )
            value.ColumnName                                = GetString(new IntPtr(p + 0x030)); // 0246688FBB30 0x30 ColumnName                  ( 000186671910 ModelPrimitiveType string string string String )
            value.DataType                                  = GetObject<Type>(new IntPtr(p + 0x038), ReversePrism.DataModels.Type.FromPointer); // 0246688FBB50 0x38 DataType                    ( 000186692850 ModelClassType Type Type Type Pointer )
            value.StorageType                               = (StorageType)GetInt32(new IntPtr(p + 0x040)); // 0246688FBB70 0x40 StorageType                 ( 00018658F750 ModelEnumType StorageType StorageType StorageType Int32 )
            value.DateTimeMode                              = (DataSetDateTime)GetInt32(new IntPtr(p + 0x050)); // 0246688FBBB0 0x50 DateTimeMode                ( 0001866818A0 ModelEnumType DataSetDateTime DataSetDateTime DataSetDateTime Int32 )
            value.Expression                                = GetObject<DataExpression>(new IntPtr(p + 0x058), ReversePrism.DataModels.DataExpression.FromPointer); // 0246688FBBD0 0x58 Expression                  ( 00018667A280 ModelClassType DataExpression DataExpression DataExpression Pointer )
            value.MaxLength                                 = GetInt32(new IntPtr(p + 0x060)); // 0246688FBBF0 0x60 MaxLength                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Ordinal                                   = GetInt32(new IntPtr(p + 0x064)); // 0246688FBC10 0x64 Ordinal                     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ReadOnly                                  = GetBool(new IntPtr(p + 0x068)); // 0246688FBC30 0x68 ReadOnly                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.SortIndex                                 = GetObject<Index>(new IntPtr(p + 0x070), ReversePrism.DataModels.Index.FromPointer); // 0246688FBC50 0x70 SortIndex                   ( 0001866E00D0 ModelClassType Index Index Index Pointer )
            value.Table                                     = GetObject<DataTable>(new IntPtr(p + 0x078), ReversePrism.DataModels.DataTable.FromPointer); // 0246688FBC70 0x78 Table                       ( 0001865B8050 ModelClassType DataTable DataTable DataTable Pointer )
            value.Unique                                    = GetBool(new IntPtr(p + 0x080)); // 0246688FBC90 0x80 Unique                      ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.ColumnMapping                             = (MappingType)GetInt32(new IntPtr(p + 0x084)); // 0246688FBCB0 0x84 ColumnMapping               ( 0001865D05E0 ModelEnumType MappingType MappingType MappingType Int32 )
            value.HashCode                                  = GetInt32(new IntPtr(p + 0x088)); // 0246688FBCD0 0x88 HashCode                    ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.Errors                                    = GetInt32(new IntPtr(p + 0x08C)); // 0246688FBCF0 0x8C Errors                      ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.IsSqlType                                 = GetBool(new IntPtr(p + 0x090)); // 0246688FBD10 0x90 IsSqlType                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.ImplementsINullable                       = GetBool(new IntPtr(p + 0x091)); // 0246688FBD30 0x91 ImplementsINullable         ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.ImplementsIChangeTracking                 = GetBool(new IntPtr(p + 0x092)); // 0246688FBD50 0x92 ImplementsIChangeTracking   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.ImplementsIRevertibleChangeTracking       = GetBool(new IntPtr(p + 0x093)); // 0246688FBD70 0x93 ImplementsIRevertibleChangeTracking ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.ImplementsIXMLSerializable                = GetBool(new IntPtr(p + 0x094)); // 0246688FBD90 0x94 ImplementsIXMLSerializable  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.DefaultValueIsNull                        = GetBool(new IntPtr(p + 0x095)); // 0246688FBDB0 0x95 DefaultValueIsNull          ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.DependentColumns                          = GetObjectList<DataColumn>(new IntPtr(p + 0x098), ReversePrism.DataModels.DataColumn.FromPointer); // 0246688FBDD0 0x98 DependentColumns            ( 000185CD5CF8 ModelClassListType List`1<DataColumn> List`1<DataColumn> List<DataColumn> Pointer )
            value.ExtendedProperties                        = GetObject<PropertyCollection>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.PropertyCollection.FromPointer); // 0246688FBDF0 0xA0 ExtendedProperties          ( 0001865D2A60 ModelClassType PropertyCollection PropertyCollection PropertyCollection Pointer )
            value.Storage                                   = GetObject<DataStorage>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.DataStorage.FromPointer); // 0246688FBE10 0xA8 Storage                     ( 000186682000 ModelClassType DataStorage DataStorage DataStorage Pointer )
            value.AutoInc                                   = GetObject<AutoIncrementValue>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.AutoIncrementValue.FromPointer); // 0246688FBE30 0xB0 AutoInc                     ( 0001867255D0 ModelClassType AutoIncrementValue AutoIncrementValue AutoIncrementValue Pointer )
            value.ColumnUri                                 = GetString(new IntPtr(p + 0x0B8)); // 0246688FBE50 0xB8 ColumnUri                   ( 000186671BA0 ModelPrimitiveType string string string String )
            value.ColumnPrefix                              = GetString(new IntPtr(p + 0x0C0)); // 0246688FBE70 0xC0 ColumnPrefix                ( 000186671910 ModelPrimitiveType string string string String )
            value.EncodedColumnName                         = GetString(new IntPtr(p + 0x0C8)); // 0246688FBE90 0xC8 EncodedColumnName           ( 000186671BA0 ModelPrimitiveType string string string String )
            value.SimpleType                                = GetObject<SimpleType>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.SimpleType.FromPointer); // 0246688FBEB0 0xD0 SimpleType                  ( 00018650C5B0 ModelClassType SimpleType SimpleType SimpleType Pointer )
            value.ObjectID                                  = GetInt32(new IntPtr(p + 0x0D8)); // 0246688FBEF0 0xD8 ObjectID                    ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.XmlDataType                               = GetString(new IntPtr(p + 0x0E0)); // 0246688FBF10 0xE0 XmlDataType                 ( 000186671910 ModelPrimitiveType string string string String )
            value.PropertyChanging                          = GetObject<PropertyChangedEventHandler>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.PropertyChangedEventHandler.FromPointer); // 0246688FBF30 0xE8 PropertyChanging            ( 0001865D1C20 ModelClassType PropertyChangedEventHandler PropertyChangedEventHandler PropertyChangedEventHandler Pointer )

            return value;
        }
    }
}
