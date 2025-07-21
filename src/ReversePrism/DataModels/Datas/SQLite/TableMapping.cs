using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MappedType                               ModelClassType Type Type Type Pointer
    // 018 TableName                                ModelPrimitiveType string string string String
    // 020 WithoutRowId                             ModelPrimitiveType bool bool bool Bool
    // 028 Columns                                  ModelClassListType Column[] Column[] List<Column> Pointer
    // 030 PK                                       ModelClassType Column Column Column Pointer
    // 038 GetByPrimaryKeySql                       ModelPrimitiveType string string string String
    // 040 CreateFlags                              ModelEnumType CreateFlags CreateFlags CreateFlags Int32
    // 044 Method                                   ModelEnumType MapMethod MapMethod MapMethod Int32
    // 048 AutoPk                                   ModelClassType Column Column Column Pointer
    // 050 InsertColumns                            ModelClassListType Column[] Column[] List<Column> Pointer
    // 058 InsertOrReplaceColumns                   ModelClassListType Column[] Column[] List<Column> Pointer
    // 060 HasAutoIncPK                             ModelPrimitiveType bool bool bool Bool
    public partial class TableMapping : DataModel
    {
        public Type?                                    MappedType                              { get; set; }
        public string                                   TableName                               { get; set; }
        public bool                                     WithoutRowId                            { get; set; }
        public List<Column>?                            Columns                                 { get; set; }
        public Column?                                  PK                                      { get; set; }
        public string                                   GetByPrimaryKeySql                      { get; set; }
        public CreateFlags                              CreateFlags                             { get; set; }
        public MapMethod                                Method                                  { get; set; }
        public Column?                                  AutoPk                                  { get; set; }
        public List<Column>?                            InsertColumns                           { get; set; }
        public List<Column>?                            InsertOrReplaceColumns                  { get; set; }
        public bool                                     HasAutoIncPK                            { get; set; }

        public static TableMapping? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TableMapping() { Pointer= p0 };

            value.MappedType                                = GetObject<Type>(new IntPtr(p + 0x010), ReversePrism.DataModels.Type.FromPointer); // 0x10 MappedType                  ( ModelClassType Type Type Type Pointer )
            value.TableName                                 = GetString(new IntPtr(p + 0x018)); // 0x18 TableName                   ( ModelPrimitiveType string string string String )
            value.WithoutRowId                              = GetBool(new IntPtr(p + 0x020)); // 0x20 WithoutRowId                ( ModelPrimitiveType bool bool bool Bool )
            value.Columns                                   = GetObjectList<Column>(new IntPtr(p + 0x028), ReversePrism.DataModels.Column.FromPointer); // 0x28 Columns                     ( ModelClassListType Column[] Column[] List<Column> Pointer )
            value.PK                                        = GetObject<Column>(new IntPtr(p + 0x030), ReversePrism.DataModels.Column.FromPointer); // 0x30 PK                          ( ModelClassType Column Column Column Pointer )
            value.GetByPrimaryKeySql                        = GetString(new IntPtr(p + 0x038)); // 0x38 GetByPrimaryKeySql          ( ModelPrimitiveType string string string String )
            value.CreateFlags                               = (CreateFlags)GetInt32(new IntPtr(p + 0x040)); // 0x40 CreateFlags                 ( ModelEnumType CreateFlags CreateFlags CreateFlags Int32 )
            value.Method                                    = (MapMethod)GetInt32(new IntPtr(p + 0x044)); // 0x44 Method                      ( ModelEnumType MapMethod MapMethod MapMethod Int32 )
            value.AutoPk                                    = GetObject<Column>(new IntPtr(p + 0x048), ReversePrism.DataModels.Column.FromPointer); // 0x48 AutoPk                      ( ModelClassType Column Column Column Pointer )
            value.InsertColumns                             = GetObjectList<Column>(new IntPtr(p + 0x050), ReversePrism.DataModels.Column.FromPointer); // 0x50 InsertColumns               ( ModelClassListType Column[] Column[] List<Column> Pointer )
            value.InsertOrReplaceColumns                    = GetObjectList<Column>(new IntPtr(p + 0x058), ReversePrism.DataModels.Column.FromPointer); // 0x58 InsertOrReplaceColumns      ( ModelClassListType Column[] Column[] List<Column> Pointer )
            value.HasAutoIncPK                              = GetBool(new IntPtr(p + 0x060)); // 0x60 HasAutoIncPK                ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
