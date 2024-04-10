using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 RelationName                             000186672F10 ModelPrimitiveType string string string String
    // 020 ColumnName                               000186672F10 ModelPrimitiveType string string string String
    // 028 Column                                   0001866759E0 ModelClassType DataColumn DataColumn DataColumn Pointer
    // 030 Relation                                 00018667C0E0 ModelClassType DataRelation DataRelation DataRelation Pointer
    public partial class LookupNode : DataModel
    {
        public string                                   RelationName                            { get; set; }
        public string                                   ColumnName                              { get; set; }
        public DataColumn?                              Column                                  { get; set; }
        public DataRelation?                            Relation                                { get; set; }

        public static LookupNode? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LookupNode() { Pointer= p0 };

            value.RelationName                              = GetString(new IntPtr(p + 0x018)); // 024668997C28 0x18 RelationName                ( 000186672F10 ModelPrimitiveType string string string String )
            value.ColumnName                                = GetString(new IntPtr(p + 0x020)); // 024668997C48 0x20 ColumnName                  ( 000186672F10 ModelPrimitiveType string string string String )
            value.Column                                    = GetObject<DataColumn>(new IntPtr(p + 0x028), ReversePrism.DataModels.DataColumn.FromPointer); // 024668997C68 0x28 Column                      ( 0001866759E0 ModelClassType DataColumn DataColumn DataColumn Pointer )
            value.Relation                                  = GetObject<DataRelation>(new IntPtr(p + 0x030), ReversePrism.DataModels.DataRelation.FromPointer); // 024668997C88 0x30 Relation                    ( 00018667C0E0 ModelClassType DataRelation DataRelation DataRelation Pointer )

            return value;
        }
    }
}
