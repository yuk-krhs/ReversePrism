using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 Type                                     ModelEnumType AggregateType AggregateType AggregateType Int32
    // 01C Aggregate                                ModelEnumType Aggregate Aggregate Aggregate Int32
    // 020 Local                                    ModelPrimitiveType bool bool bool Bool
    // 028 RelationName                             ModelPrimitiveType string string string String
    // 030 ColumnName                               ModelPrimitiveType string string string String
    // 038 ChildTable                               ModelClassType DataTable DataTable DataTable Pointer
    // 040 Column                                   ModelClassType DataColumn DataColumn DataColumn Pointer
    // 048 Relation                                 ModelClassType DataRelation DataRelation DataRelation Pointer
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

            value.Type                                      = (AggregateType)GetInt32(new IntPtr(p + 0x018)); // 0x18 Type                        ( ModelEnumType AggregateType AggregateType AggregateType Int32 )
            value.Aggregate                                 = (Aggregate)GetInt32(new IntPtr(p + 0x01C)); // 0x1C Aggregate                   ( ModelEnumType Aggregate Aggregate Aggregate Int32 )
            value.Local                                     = GetBool(new IntPtr(p + 0x020)); // 0x20 Local                       ( ModelPrimitiveType bool bool bool Bool )
            value.RelationName                              = GetString(new IntPtr(p + 0x028)); // 0x28 RelationName                ( ModelPrimitiveType string string string String )
            value.ColumnName                                = GetString(new IntPtr(p + 0x030)); // 0x30 ColumnName                  ( ModelPrimitiveType string string string String )
            value.ChildTable                                = GetObject<DataTable>(new IntPtr(p + 0x038), ReversePrism.DataModels.DataTable.FromPointer); // 0x38 ChildTable                  ( ModelClassType DataTable DataTable DataTable Pointer )
            value.Column                                    = GetObject<DataColumn>(new IntPtr(p + 0x040), ReversePrism.DataModels.DataColumn.FromPointer); // 0x40 Column                      ( ModelClassType DataColumn DataColumn DataColumn Pointer )
            value.Relation                                  = GetObject<DataRelation>(new IntPtr(p + 0x048), ReversePrism.DataModels.DataRelation.FromPointer); // 0x48 Relation                    ( ModelClassType DataRelation DataRelation DataRelation Pointer )

            return value;
        }
    }
}
