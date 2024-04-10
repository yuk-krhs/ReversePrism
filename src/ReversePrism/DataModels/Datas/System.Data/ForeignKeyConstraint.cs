using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 DeleteRule                               000186694730 ModelEnumType Rule Rule Rule Int32
    // 03C UpdateRule                               000186694730 ModelEnumType Rule Rule Rule Int32
    // 040 AcceptRejectRule                         00018666F910 ModelEnumType AcceptRejectRule AcceptRejectRule AcceptRejectRule Int32
    // 048 ChildKey                                 00018667AF10 ModelEnumType DataKey DataKey DataKey Int32
    // 050 ParentKey                                00018667AF10 ModelEnumType DataKey DataKey DataKey Int32
    // 058 ConstraintName                           000186671BA0 ModelPrimitiveType string string string String
    // 060 ParentColumnNames                        000185B81660 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 068 ChildColumnNames                         000185B81660 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 070 ParentTableName                          000186671BA0 ModelPrimitiveType string string string String
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

            value.DeleteRule                                = (Rule)GetInt32(new IntPtr(p + 0x038)); // 0246689197D8 0x38 DeleteRule                  ( 000186694730 ModelEnumType Rule Rule Rule Int32 )
            value.UpdateRule                                = (Rule)GetInt32(new IntPtr(p + 0x03C)); // 0246689197F8 0x3C UpdateRule                  ( 000186694730 ModelEnumType Rule Rule Rule Int32 )
            value.AcceptRejectRule                          = (AcceptRejectRule)GetInt32(new IntPtr(p + 0x040)); // 024668919818 0x40 AcceptRejectRule            ( 00018666F910 ModelEnumType AcceptRejectRule AcceptRejectRule AcceptRejectRule Int32 )
            value.ChildKey                                  = (DataKey)GetInt32(new IntPtr(p + 0x048)); // 024668919838 0x48 ChildKey                    ( 00018667AF10 ModelEnumType DataKey DataKey DataKey Int32 )
            value.ParentKey                                 = (DataKey)GetInt32(new IntPtr(p + 0x050)); // 024668919858 0x50 ParentKey                   ( 00018667AF10 ModelEnumType DataKey DataKey DataKey Int32 )
            value.ConstraintName                            = GetString(new IntPtr(p + 0x058)); // 024668919878 0x58 ConstraintName              ( 000186671BA0 ModelPrimitiveType string string string String )
            value.ParentColumnNames                         = GetStringList(new IntPtr(p + 0x060)); // 024668919898 0x60 ParentColumnNames           ( 000185B81660 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.ChildColumnNames                          = GetStringList(new IntPtr(p + 0x068)); // 0246689198B8 0x68 ChildColumnNames            ( 000185B81660 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.ParentTableName                           = GetString(new IntPtr(p + 0x070)); // 0246689198D8 0x70 ParentTableName             ( 000186671BA0 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
