using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MappedType                               000186692850 ModelClassType Type Type Type Pointer
    // 018 TableName                                000186671910 ModelPrimitiveType string string string String
    // 020 WithoutRowId                             000186594D10 ModelPrimitiveType bool bool bool Bool
    // 028 Columns                                  000185CC40E8 ModelClassListType Column[] Column[] List<Column> Pointer
    // 030 PK                                       0001865EA300 ModelClassType Column Column Column Pointer
    // 038 GetByPrimaryKeySql                       000186671910 ModelPrimitiveType string string string String
    // 040 CreateFlags                              00018663B260 ModelEnumType CreateFlags CreateFlags CreateFlags Int32
    // 044 Method                                   0001865EAC80 ModelEnumType MapMethod MapMethod MapMethod Int32
    // 048 AutoPk                                   0001865EA7C0 ModelClassType Column Column Column Pointer
    // 050 InsertColumns                            000185CC4248 ModelClassListType Column[] Column[] List<Column> Pointer
    // 058 InsertOrReplaceColumns                   000185CC4248 ModelClassListType Column[] Column[] List<Column> Pointer
    // 060 HasAutoIncPK                             000186594D10 ModelPrimitiveType bool bool bool Bool
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

            value.MappedType                                = GetObject<Type>(new IntPtr(p + 0x010), ReversePrism.DataModels.Type.FromPointer); // 0245A3D2F910 0x10 MappedType                  ( 000186692850 ModelClassType Type Type Type Pointer )
            value.TableName                                 = GetString(new IntPtr(p + 0x018)); // 0245A3D2F930 0x18 TableName                   ( 000186671910 ModelPrimitiveType string string string String )
            value.WithoutRowId                              = GetBool(new IntPtr(p + 0x020)); // 0245A3D2F950 0x20 WithoutRowId                ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Columns                                   = GetObjectList<Column>(new IntPtr(p + 0x028), ReversePrism.DataModels.Column.FromPointer); // 0245A3D2F970 0x28 Columns                     ( 000185CC40E8 ModelClassListType Column[] Column[] List<Column> Pointer )
            value.PK                                        = GetObject<Column>(new IntPtr(p + 0x030), ReversePrism.DataModels.Column.FromPointer); // 0245A3D2F990 0x30 PK                          ( 0001865EA300 ModelClassType Column Column Column Pointer )
            value.GetByPrimaryKeySql                        = GetString(new IntPtr(p + 0x038)); // 0245A3D2F9B0 0x38 GetByPrimaryKeySql          ( 000186671910 ModelPrimitiveType string string string String )
            value.CreateFlags                               = (CreateFlags)GetInt32(new IntPtr(p + 0x040)); // 0245A3D2F9D0 0x40 CreateFlags                 ( 00018663B260 ModelEnumType CreateFlags CreateFlags CreateFlags Int32 )
            value.Method                                    = (MapMethod)GetInt32(new IntPtr(p + 0x044)); // 0245A3D2F9F0 0x44 Method                      ( 0001865EAC80 ModelEnumType MapMethod MapMethod MapMethod Int32 )
            value.AutoPk                                    = GetObject<Column>(new IntPtr(p + 0x048), ReversePrism.DataModels.Column.FromPointer); // 0245A3D2FA10 0x48 AutoPk                      ( 0001865EA7C0 ModelClassType Column Column Column Pointer )
            value.InsertColumns                             = GetObjectList<Column>(new IntPtr(p + 0x050), ReversePrism.DataModels.Column.FromPointer); // 0245A3D2FA30 0x50 InsertColumns               ( 000185CC4248 ModelClassListType Column[] Column[] List<Column> Pointer )
            value.InsertOrReplaceColumns                    = GetObjectList<Column>(new IntPtr(p + 0x058), ReversePrism.DataModels.Column.FromPointer); // 0245A3D2FA50 0x58 InsertOrReplaceColumns      ( 000185CC4248 ModelClassListType Column[] Column[] List<Column> Pointer )
            value.HasAutoIncPK                              = GetBool(new IntPtr(p + 0x060)); // 0245A3D2FA70 0x60 HasAutoIncPK                ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
