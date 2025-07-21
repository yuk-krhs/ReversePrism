using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 DeleteRule                               ModelEnumType Rule Rule Rule Int32
    // 03C UpdateRule                               ModelEnumType Rule Rule Rule Int32
    // 040 AcceptRejectRule                         ModelEnumType AcceptRejectRule AcceptRejectRule AcceptRejectRule Int32
    // 048 ChildKey                                 ModelEnumType DataKey DataKey DataKey Int32
    // 050 ParentKey                                ModelEnumType DataKey DataKey DataKey Int32
    // 058 ConstraintName                           ModelPrimitiveType string string string String
    // 060 ParentColumnNames                        ModelPrimitiveListType string[] string[] List<string> Pointer
    // 068 ChildColumnNames                         ModelPrimitiveListType string[] string[] List<string> Pointer
    // 070 ParentTableName                          ModelPrimitiveType string string string String
    public partial class ForeignKeyConstraint : DataModel
    {
        public Rule                                     DeleteRule                              { get; set; }
        public Rule                                     UpdateRule                              { get; set; }
        public AcceptRejectRule                         AcceptRejectRule                        { get; set; }
        public DataKey                                  ChildKey                                { get; set; }
        public DataKey                                  ParentKey                               { get; set; }
        public string                                   ConstraintName                          { get; set; }
        public List<string>?                            ParentColumnNames                       { get; set; }
        public List<string>?                            ChildColumnNames                        { get; set; }
        public string                                   ParentTableName                         { get; set; }

        public static ForeignKeyConstraint? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ForeignKeyConstraint() { Pointer= p0 };

            value.DeleteRule                                = (Rule)GetInt32(new IntPtr(p + 0x038)); // 0x38 DeleteRule                  ( ModelEnumType Rule Rule Rule Int32 )
            value.UpdateRule                                = (Rule)GetInt32(new IntPtr(p + 0x03C)); // 0x3C UpdateRule                  ( ModelEnumType Rule Rule Rule Int32 )
            value.AcceptRejectRule                          = (AcceptRejectRule)GetInt32(new IntPtr(p + 0x040)); // 0x40 AcceptRejectRule            ( ModelEnumType AcceptRejectRule AcceptRejectRule AcceptRejectRule Int32 )
            value.ChildKey                                  = (DataKey)GetInt32(new IntPtr(p + 0x048)); // 0x48 ChildKey                    ( ModelEnumType DataKey DataKey DataKey Int32 )
            value.ParentKey                                 = (DataKey)GetInt32(new IntPtr(p + 0x050)); // 0x50 ParentKey                   ( ModelEnumType DataKey DataKey DataKey Int32 )
            value.ConstraintName                            = GetString(new IntPtr(p + 0x058)); // 0x58 ConstraintName              ( ModelPrimitiveType string string string String )
            value.ParentColumnNames                         = GetStringList(new IntPtr(p + 0x060)); // 0x60 ParentColumnNames           ( ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.ChildColumnNames                          = GetStringList(new IntPtr(p + 0x068)); // 0x68 ChildColumnNames            ( ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.ParentTableName                           = GetString(new IntPtr(p + 0x070)); // 0x70 ParentTableName             ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
