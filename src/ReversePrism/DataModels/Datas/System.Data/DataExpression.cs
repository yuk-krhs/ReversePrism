using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 OriginalExpression                       000186671BA0 ModelPrimitiveType string string string String
    // 018 Parsed                                   000186594D10 ModelPrimitiveType bool bool bool Bool
    // 019 Bound                                    000186594D10 ModelPrimitiveType bool bool bool Bool
    // 020 Expr                                     00018652D210 ModelClassType ExpressionNode ExpressionNode ExpressionNode Pointer
    // 028 Table                                    0001865B7E00 ModelClassType DataTable DataTable DataTable Pointer
    // 030 StorageType                              00018658F9A0 ModelEnumType StorageType StorageType StorageType Int32
    // 038 DataType                                 0001866936B0 ModelClassType Type Type Type Pointer
    // 040 Dependency                               000185B789A0 ModelClassListType DataColumn[] DataColumn[] List<DataColumn> Pointer
    public partial class DataExpression
    {
        public string                                   OriginalExpression                      { get; set; }
        public bool                                     Parsed                                  { get; set; }
        public bool                                     Bound                                   { get; set; }
        public ExpressionNode?                          Expr                                    { get; set; }
        public DataTable?                               Table                                   { get; set; }
        public StorageType                              StorageType                             { get; set; }
        public Type?                                    DataType                                { get; set; }
        public List<DataColumn>?                        Dependency                              { get; set; }

        public static DataExpression? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DataExpression();

            value.OriginalExpression                        = GetString(new IntPtr(p + 0x010)); // 0270D88A6CC0 0x10 OriginalExpression          ( 000186671BA0 ModelPrimitiveType string string string String )
            value.Parsed                                    = GetBool(new IntPtr(p + 0x018)); // 0270D88A6CE0 0x18 Parsed                      ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Bound                                     = GetBool(new IntPtr(p + 0x019)); // 0270D88A6D00 0x19 Bound                       ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Expr                                      = GetObject<ExpressionNode>(new IntPtr(p + 0x020), ReversePrism.DataModels.ExpressionNode.FromPointer); // 0270D88A6D20 0x20 Expr                        ( 00018652D210 ModelClassType ExpressionNode ExpressionNode ExpressionNode Pointer )
            value.Table                                     = GetObject<DataTable>(new IntPtr(p + 0x028), ReversePrism.DataModels.DataTable.FromPointer); // 0270D88A6D40 0x28 Table                       ( 0001865B7E00 ModelClassType DataTable DataTable DataTable Pointer )
            value.StorageType                               = (StorageType)GetInt32(new IntPtr(p + 0x030)); // 0270D88A6D60 0x30 StorageType                 ( 00018658F9A0 ModelEnumType StorageType StorageType StorageType Int32 )
            value.DataType                                  = GetObject<Type>(new IntPtr(p + 0x038), ReversePrism.DataModels.Type.FromPointer); // 0270D88A6D80 0x38 DataType                    ( 0001866936B0 ModelClassType Type Type Type Pointer )
            value.Dependency                                = GetObjectList<DataColumn>(new IntPtr(p + 0x040), ReversePrism.DataModels.DataColumn.FromPointer); // 0270D88A6DA0 0x40 Dependency                  ( 000185B789A0 ModelClassListType DataColumn[] DataColumn[] List<DataColumn> Pointer )

            return value;
        }
    }
}
