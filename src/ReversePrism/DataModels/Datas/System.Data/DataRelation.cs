using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 DataSet                                  ModelClassType DataSet DataSet DataSet Pointer
    // 018 ExtendedProperties                       ModelClassType PropertyCollection PropertyCollection PropertyCollection Pointer
    // 020 RelationName                             ModelPrimitiveType string string string String
    // 028 ChildKey                                 ModelEnumType DataKey DataKey DataKey Int32
    // 030 ParentKey                                ModelEnumType DataKey DataKey DataKey Int32
    // 038 ParentKeyConstraint                      ModelClassType UniqueConstraint UniqueConstraint UniqueConstraint Pointer
    // 040 ChildKeyConstraint                       ModelClassType ForeignKeyConstraint ForeignKeyConstraint ForeignKeyConstraint Pointer
    // 048 ParentColumnNames                        ModelPrimitiveListType string[] string[] List<string> Pointer
    // 050 ChildColumnNames                         ModelPrimitiveListType string[] string[] List<string> Pointer
    // 058 ParentTableName                          ModelPrimitiveType string string string String
    // 060 ChildTableName                           ModelPrimitiveType string string string String
    // 068 ParentTableNamespace                     ModelPrimitiveType string string string String
    // 070 ChildTableNamespace                      ModelPrimitiveType string string string String
    // 078 Nested                                   ModelPrimitiveType bool bool bool Bool
    // 079 CreateConstraints                        ModelPrimitiveType bool bool bool Bool
    // 07A CheckMultipleNested                      ModelPrimitiveType bool bool bool Bool
    // 000 s_objectTypeCount                        int IL2CPP_TYPE_I4
    // 07C ObjectID                                 ModelPrimitiveType int int int Int32
    // 080 PropertyChanging                         ModelClassType PropertyChangedEventHandler PropertyChangedEventHandler PropertyChangedEventHandler Pointer
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

            value.DataSet                                   = GetObject<DataSet>(new IntPtr(p + 0x010), ReversePrism.DataModels.DataSet.FromPointer); // 0x10 DataSet                     ( ModelClassType DataSet DataSet DataSet Pointer )
            value.ExtendedProperties                        = GetObject<PropertyCollection>(new IntPtr(p + 0x018), ReversePrism.DataModels.PropertyCollection.FromPointer); // 0x18 ExtendedProperties          ( ModelClassType PropertyCollection PropertyCollection PropertyCollection Pointer )
            value.RelationName                              = GetString(new IntPtr(p + 0x020)); // 0x20 RelationName                ( ModelPrimitiveType string string string String )
            value.ChildKey                                  = (DataKey)GetInt32(new IntPtr(p + 0x028)); // 0x28 ChildKey                    ( ModelEnumType DataKey DataKey DataKey Int32 )
            value.ParentKey                                 = (DataKey)GetInt32(new IntPtr(p + 0x030)); // 0x30 ParentKey                   ( ModelEnumType DataKey DataKey DataKey Int32 )
            value.ParentKeyConstraint                       = GetObject<UniqueConstraint>(new IntPtr(p + 0x038), ReversePrism.DataModels.UniqueConstraint.FromPointer); // 0x38 ParentKeyConstraint         ( ModelClassType UniqueConstraint UniqueConstraint UniqueConstraint Pointer )
            value.ChildKeyConstraint                        = GetObject<ForeignKeyConstraint>(new IntPtr(p + 0x040), ReversePrism.DataModels.ForeignKeyConstraint.FromPointer); // 0x40 ChildKeyConstraint          ( ModelClassType ForeignKeyConstraint ForeignKeyConstraint ForeignKeyConstraint Pointer )
            value.ParentColumnNames                         = GetStringList(new IntPtr(p + 0x048)); // 0x48 ParentColumnNames           ( ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.ChildColumnNames                          = GetStringList(new IntPtr(p + 0x050)); // 0x50 ChildColumnNames            ( ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.ParentTableName                           = GetString(new IntPtr(p + 0x058)); // 0x58 ParentTableName             ( ModelPrimitiveType string string string String )
            value.ChildTableName                            = GetString(new IntPtr(p + 0x060)); // 0x60 ChildTableName              ( ModelPrimitiveType string string string String )
            value.ParentTableNamespace                      = GetString(new IntPtr(p + 0x068)); // 0x68 ParentTableNamespace        ( ModelPrimitiveType string string string String )
            value.ChildTableNamespace                       = GetString(new IntPtr(p + 0x070)); // 0x70 ChildTableNamespace         ( ModelPrimitiveType string string string String )
            value.Nested                                    = GetBool(new IntPtr(p + 0x078)); // 0x78 Nested                      ( ModelPrimitiveType bool bool bool Bool )
            value.CreateConstraints                         = GetBool(new IntPtr(p + 0x079)); // 0x79 CreateConstraints           ( ModelPrimitiveType bool bool bool Bool )
            value.CheckMultipleNested                       = GetBool(new IntPtr(p + 0x07A)); // 0x7A CheckMultipleNested         ( ModelPrimitiveType bool bool bool Bool )
            value.ObjectID                                  = GetInt32(new IntPtr(p + 0x07C)); // 0x7C ObjectID                    ( ModelPrimitiveType int int int Int32 )
            value.PropertyChanging                          = GetObject<PropertyChangedEventHandler>(new IntPtr(p + 0x080), ReversePrism.DataModels.PropertyChangedEventHandler.FromPointer); // 0x80 PropertyChanging            ( ModelClassType PropertyChangedEventHandler PropertyChangedEventHandler PropertyChangedEventHandler Pointer )

            return value;
        }
    }
}
