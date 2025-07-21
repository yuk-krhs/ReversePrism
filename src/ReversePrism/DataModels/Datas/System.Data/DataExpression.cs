using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 OriginalExpression                       ModelPrimitiveType string string string String
    // 018 Parsed                                   ModelPrimitiveType bool bool bool Bool
    // 019 Bound                                    ModelPrimitiveType bool bool bool Bool
    // 020 Expr                                     ModelClassType ExpressionNode ExpressionNode ExpressionNode Pointer
    // 028 Table                                    ModelClassType DataTable DataTable DataTable Pointer
    // 030 StorageType                              ModelEnumType StorageType StorageType StorageType Int32
    // 038 DataType                                 ModelClassType Type Type Type Pointer
    // 040 Dependency                               ModelClassListType DataColumn[] DataColumn[] List<DataColumn> Pointer
    public partial class DataExpression : DataModel
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
            var value   = new DataExpression() { Pointer= p0 };

            value.OriginalExpression                        = GetString(new IntPtr(p + 0x010)); // 0x10 OriginalExpression          ( ModelPrimitiveType string string string String )
            value.Parsed                                    = GetBool(new IntPtr(p + 0x018)); // 0x18 Parsed                      ( ModelPrimitiveType bool bool bool Bool )
            value.Bound                                     = GetBool(new IntPtr(p + 0x019)); // 0x19 Bound                       ( ModelPrimitiveType bool bool bool Bool )
            value.Expr                                      = GetObject<ExpressionNode>(new IntPtr(p + 0x020), ReversePrism.DataModels.ExpressionNode.FromPointer); // 0x20 Expr                        ( ModelClassType ExpressionNode ExpressionNode ExpressionNode Pointer )
            value.Table                                     = GetObject<DataTable>(new IntPtr(p + 0x028), ReversePrism.DataModels.DataTable.FromPointer); // 0x28 Table                       ( ModelClassType DataTable DataTable DataTable Pointer )
            value.StorageType                               = (StorageType)GetInt32(new IntPtr(p + 0x030)); // 0x30 StorageType                 ( ModelEnumType StorageType StorageType StorageType Int32 )
            value.DataType                                  = GetObject<Type>(new IntPtr(p + 0x038), ReversePrism.DataModels.Type.FromPointer); // 0x38 DataType                    ( ModelClassType Type Type Type Pointer )
            value.Dependency                                = GetObjectList<DataColumn>(new IntPtr(p + 0x040), ReversePrism.DataModels.DataColumn.FromPointer); // 0x40 Dependency                  ( ModelClassListType DataColumn[] DataColumn[] List<DataColumn> Pointer )

            return value;
        }
    }
}
