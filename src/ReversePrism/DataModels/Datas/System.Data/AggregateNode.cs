using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 Type                                     00018669B3D0 ModelEnumType AggregateType AggregateType AggregateType Int32
    // 01C Aggregate                                000186699E10 ModelEnumType Aggregate Aggregate Aggregate Int32
    // 020 Local                                    0001865965D0 ModelPrimitiveType bool bool bool Bool
    // 028 RelationName                             000186672F10 ModelPrimitiveType string string string String
    // 030 ColumnName                               000186672F10 ModelPrimitiveType string string string String
    // 038 ChildTable                               0001865B7E00 ModelClassType DataTable DataTable DataTable Pointer
    // 040 Column                                   0001866759E0 ModelClassType DataColumn DataColumn DataColumn Pointer
    // 048 Relation                                 00018667C0E0 ModelClassType DataRelation DataRelation DataRelation Pointer
    public partial class AggregateNode : DataModel
    {
        public AggregateType                            Type                                    { get; set; }
        public Aggregate                                Aggregate                               { get; set; }
        public bool                                     Local                                   { get; set; }
        public string                                   RelationName                            { get; set; }
        public string                                   ColumnName                              { get; set; }
        public DataTable?                               ChildTable                              { get; set; }
        public DataColumn?                              Column                                  { get; set; }
        public DataRelation?                            Relation                                { get; set; }

        public static AggregateNode? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AggregateNode() { Pointer= p0 };

            value.Type                                      = (AggregateType)GetInt32(new IntPtr(p + 0x018)); // 024668992AE8 0x18 Type                        ( 00018669B3D0 ModelEnumType AggregateType AggregateType AggregateType Int32 )
            value.Aggregate                                 = (Aggregate)GetInt32(new IntPtr(p + 0x01C)); // 024668992B08 0x1C Aggregate                   ( 000186699E10 ModelEnumType Aggregate Aggregate Aggregate Int32 )
            value.Local                                     = GetBool(new IntPtr(p + 0x020)); // 024668992B28 0x20 Local                       ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )
            value.RelationName                              = GetString(new IntPtr(p + 0x028)); // 024668992B48 0x28 RelationName                ( 000186672F10 ModelPrimitiveType string string string String )
            value.ColumnName                                = GetString(new IntPtr(p + 0x030)); // 024668992B68 0x30 ColumnName                  ( 000186672F10 ModelPrimitiveType string string string String )
            value.ChildTable                                = GetObject<DataTable>(new IntPtr(p + 0x038), ReversePrism.DataModels.DataTable.FromPointer); // 024668992B88 0x38 ChildTable                  ( 0001865B7E00 ModelClassType DataTable DataTable DataTable Pointer )
            value.Column                                    = GetObject<DataColumn>(new IntPtr(p + 0x040), ReversePrism.DataModels.DataColumn.FromPointer); // 024668992BA8 0x40 Column                      ( 0001866759E0 ModelClassType DataColumn DataColumn DataColumn Pointer )
            value.Relation                                  = GetObject<DataRelation>(new IntPtr(p + 0x048), ReversePrism.DataModels.DataRelation.FromPointer); // 024668992BC8 0x48 Relation                    ( 00018667C0E0 ModelClassType DataRelation DataRelation DataRelation Pointer )

            return value;
        }
    }
}
