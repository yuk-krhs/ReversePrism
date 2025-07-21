using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 IndexName                                ModelPrimitiveType string string string String
    // 018 TableName                                ModelPrimitiveType string string string String
    // 020 Unique                                   ModelPrimitiveType bool bool bool Bool
    // 028 Columns                                  ModelEnumListType List`1<IndexedColumn> List`1<IndexedColumn> List<IndexedColumn> Pointer
    public partial class IndexInfo : DataModel
    {
        public string                                   IndexName                               { get; set; }
        public string                                   TableName                               { get; set; }
        public bool                                     Unique                                  { get; set; }
        public List<IndexedColumn>?                     Columns                                 { get; set; }

        public static IndexInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IndexInfo() { Pointer= p0 };

            value.IndexName                                 = GetString(new IntPtr(p + 0x010)); // 0x10 IndexName                   ( ModelPrimitiveType string string string String )
            value.TableName                                 = GetString(new IntPtr(p + 0x018)); // 0x18 TableName                   ( ModelPrimitiveType string string string String )
            value.Unique                                    = GetBool(new IntPtr(p + 0x020)); // 0x20 Unique                      ( ModelPrimitiveType bool bool bool Bool )
            value.Columns                                   = GetEnumList<IndexedColumn>(new IntPtr(p + 0x028)); // 0x28 Columns                     ( ModelEnumListType List`1<IndexedColumn> List`1<IndexedColumn> List<IndexedColumn> Pointer )

            return value;
        }
    }
}
