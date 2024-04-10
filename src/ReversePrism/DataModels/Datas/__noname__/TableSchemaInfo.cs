using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TableSchema                              0001865B82E0 ModelClassType DataTable DataTable DataTable Pointer
    // 018 ColumnsSchemaMap                         000186748FC0 ModelClassType XmlNodeIdHashtable XmlNodeIdHashtable XmlNodeIdHashtable Pointer
    public partial class TableSchemaInfo : DataModel
    {
        public DataTable?                               TableSchema                             { get; set; }
        public XmlNodeIdHashtable?                      ColumnsSchemaMap                        { get; set; }

        public static TableSchemaInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TableSchemaInfo() { Pointer= p0 };

            value.TableSchema                               = GetObject<DataTable>(new IntPtr(p + 0x010), ReversePrism.DataModels.DataTable.FromPointer); // 0246689E42E8 0x10 TableSchema                 ( 0001865B82E0 ModelClassType DataTable DataTable DataTable Pointer )
            value.ColumnsSchemaMap                          = GetObject<XmlNodeIdHashtable>(new IntPtr(p + 0x018), ReversePrism.DataModels.XmlNodeIdHashtable.FromPointer); // 0246689E4308 0x18 ColumnsSchemaMap            ( 000186748FC0 ModelClassType XmlNodeIdHashtable XmlNodeIdHashtable XmlNodeIdHashtable Pointer )

            return value;
        }
    }
}
