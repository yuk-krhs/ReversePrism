using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Order                                    0001865F36C0 ModelPrimitiveType int int int Int32
    // 018 ColumnName                               0001866722E0 ModelPrimitiveType string string string String
    public partial class IndexedColumn : DataModel
    {
        public int                                      Order                                   { get; set; }
        public string                                   ColumnName                              { get; set; }

        public static IndexedColumn? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IndexedColumn() { Pointer= p0 };

            value.Order                                     = GetInt32(new IntPtr(p + 0x010)); // 0245A3D5EF08 0x10 Order                       ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.ColumnName                                = GetString(new IntPtr(p + 0x018)); // 0245A3D5EF28 0x18 ColumnName                  ( 0001866722E0 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
