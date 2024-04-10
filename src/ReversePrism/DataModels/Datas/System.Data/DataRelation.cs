using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 DataSet                                  000186680790 ModelClassType DataSet DataSet DataSet Pointer
    // 018 ExtendedProperties                       0001865D2A60 ModelClassType PropertyCollection PropertyCollection PropertyCollection Pointer
    // 020 RelationName                             000186671BA0 ModelPrimitiveType string string string String
    // 028 ChildKey                                 00018667AF10 ModelEnumType DataKey DataKey DataKey Int32
    // 030 ParentKey                                00018667AF10 ModelEnumType DataKey DataKey DataKey Int32
    // 038 ParentKeyConstraint                      00018670A720 ModelClassType UniqueConstraint UniqueConstraint UniqueConstraint Pointer
    // 040 ChildKeyConstraint                       0001865B56E0 ModelClassType ForeignKeyConstraint ForeignKeyConstraint ForeignKeyConstraint Pointer
    // 048 ParentColumnNames                        000185B81660 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 050 ChildColumnNames                         000185B81660 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 058 ParentTableName                          000186671BA0 ModelPrimitiveType string string string String
    // 060 ChildTableName                           000186671BA0 ModelPrimitiveType string string string String
    // 068 ParentTableNamespace                     000186671BA0 ModelPrimitiveType string string string String
    // 070 ChildTableNamespace                      000186671BA0 ModelPrimitiveType string string string String
    // 078 Nested                                   000186595210 ModelPrimitiveType bool bool bool Bool
    // 079 CreateConstraints                        000186595210 ModelPrimitiveType bool bool bool Bool
    // 07A CheckMultipleNested                      000186594D10 ModelPrimitiveType bool bool bool Bool
    // 000 s_objectTypeCount                        int IL2CPP_TYPE_I4
    // 07C ObjectID                                 0001865F4260 ModelPrimitiveType int int int Int32
    // 080 PropertyChanging                         0001865D1C20 ModelClassType PropertyChangedEventHandler PropertyChangedEventHandler PropertyChangedEventHandler Pointer
    public partial class DataRelation : DataModel
    {
        public DataSet?                                 DataSet                                 { get; set; }
        public PropertyCollection?                      ExtendedProperties                      { get; set; }
        public string                                   RelationName                            { get; set; }
        public DataKey                                  ChildKey                                { get; set; }
        public DataKey                                  ParentKey                               { get; set; }
        public UniqueConstraint?                        ParentKeyConstraint                     { get; set; }
        public ForeignKeyConstraint?                    ChildKeyConstraint                      { get; set; }
        public List<string>?                            ParentColumnNames                       { get; set; }
        public List<string>?                            ChildColumnNames                        { get; set; }
        public string                                   ParentTableName                         { get; set; }
        public string                                   ChildTableName                          { get; set; }
        public string                                   ParentTableNamespace                    { get; set; }
        public string                                   ChildTableNamespace                     { get; set; }
        public bool                                     Nested                                  { get; set; }
        public bool                                     CreateConstraints                       { get; set; }
        public bool                                     CheckMultipleNested                     { get; set; }
        public int                                      ObjectID                                { get; set; }
        public PropertyChangedEventHandler?             PropertyChanging                        { get; set; }

        public static DataRelation? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DataRelation() { Pointer= p0 };

            value.DataSet                                   = GetObject<DataSet>(new IntPtr(p + 0x010), ReversePrism.DataModels.DataSet.FromPointer); // 024668933888 0x10 DataSet                     ( 000186680790 ModelClassType DataSet DataSet DataSet Pointer )
            value.ExtendedProperties                        = GetObject<PropertyCollection>(new IntPtr(p + 0x018), ReversePrism.DataModels.PropertyCollection.FromPointer); // 0246689338A8 0x18 ExtendedProperties          ( 0001865D2A60 ModelClassType PropertyCollection PropertyCollection PropertyCollection Pointer )
            value.RelationName                              = GetString(new IntPtr(p + 0x020)); // 0246689338C8 0x20 RelationName                ( 000186671BA0 ModelPrimitiveType string string string String )
            value.ChildKey                                  = (DataKey)GetInt32(new IntPtr(p + 0x028)); // 0246689338E8 0x28 ChildKey                    ( 00018667AF10 ModelEnumType DataKey DataKey DataKey Int32 )
            value.ParentKey                                 = (DataKey)GetInt32(new IntPtr(p + 0x030)); // 024668933908 0x30 ParentKey                   ( 00018667AF10 ModelEnumType DataKey DataKey DataKey Int32 )
            value.ParentKeyConstraint                       = GetObject<UniqueConstraint>(new IntPtr(p + 0x038), ReversePrism.DataModels.UniqueConstraint.FromPointer); // 024668933928 0x38 ParentKeyConstraint         ( 00018670A720 ModelClassType UniqueConstraint UniqueConstraint UniqueConstraint Pointer )
            value.ChildKeyConstraint                        = GetObject<ForeignKeyConstraint>(new IntPtr(p + 0x040), ReversePrism.DataModels.ForeignKeyConstraint.FromPointer); // 024668933948 0x40 ChildKeyConstraint          ( 0001865B56E0 ModelClassType ForeignKeyConstraint ForeignKeyConstraint ForeignKeyConstraint Pointer )
            value.ParentColumnNames                         = GetStringList(new IntPtr(p + 0x048)); // 024668933968 0x48 ParentColumnNames           ( 000185B81660 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.ChildColumnNames                          = GetStringList(new IntPtr(p + 0x050)); // 024668933988 0x50 ChildColumnNames            ( 000185B81660 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.ParentTableName                           = GetString(new IntPtr(p + 0x058)); // 0246689339A8 0x58 ParentTableName             ( 000186671BA0 ModelPrimitiveType string string string String )
            value.ChildTableName                            = GetString(new IntPtr(p + 0x060)); // 0246689339C8 0x60 ChildTableName              ( 000186671BA0 ModelPrimitiveType string string string String )
            value.ParentTableNamespace                      = GetString(new IntPtr(p + 0x068)); // 0246689339E8 0x68 ParentTableNamespace        ( 000186671BA0 ModelPrimitiveType string string string String )
            value.ChildTableNamespace                       = GetString(new IntPtr(p + 0x070)); // 024668933A08 0x70 ChildTableNamespace         ( 000186671BA0 ModelPrimitiveType string string string String )
            value.Nested                                    = GetBool(new IntPtr(p + 0x078)); // 024668933A28 0x78 Nested                      ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.CreateConstraints                         = GetBool(new IntPtr(p + 0x079)); // 024668933A48 0x79 CreateConstraints           ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.CheckMultipleNested                       = GetBool(new IntPtr(p + 0x07A)); // 024668933A68 0x7A CheckMultipleNested         ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.ObjectID                                  = GetInt32(new IntPtr(p + 0x07C)); // 024668933AA8 0x7C ObjectID                    ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.PropertyChanging                          = GetObject<PropertyChangedEventHandler>(new IntPtr(p + 0x080), ReversePrism.DataModels.PropertyChangedEventHandler.FromPointer); // 024668933AC8 0x80 PropertyChanging            ( 0001865D1C20 ModelClassType PropertyChangedEventHandler PropertyChangedEventHandler PropertyChangedEventHandler Pointer )

            return value;
        }
    }
}
