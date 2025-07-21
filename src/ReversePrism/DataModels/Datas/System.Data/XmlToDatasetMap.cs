using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TableSchemaMap                           ModelClassType XmlNodeIdHashtable XmlNodeIdHashtable XmlNodeIdHashtable Pointer
    // 018 LastTableSchemaInfo                      ModelClassType TableSchemaInfo TableSchemaInfo TableSchemaInfo Pointer
    public partial class XmlToDatasetMap : DataModel
    {
        public XmlNodeIdHashtable?                      TableSchemaMap                          { get; set; }
        public TableSchemaInfo?                         LastTableSchemaInfo                     { get; set; }

        public static XmlToDatasetMap? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlToDatasetMap() { Pointer= p0 };

            value.TableSchemaMap                            = GetObject<XmlNodeIdHashtable>(new IntPtr(p + 0x010), ReversePrism.DataModels.XmlNodeIdHashtable.FromPointer); // 0x10 TableSchemaMap              ( ModelClassType XmlNodeIdHashtable XmlNodeIdHashtable XmlNodeIdHashtable Pointer )
            value.LastTableSchemaInfo                       = GetObject<TableSchemaInfo>(new IntPtr(p + 0x018), ReversePrism.DataModels.TableSchemaInfo.FromPointer); // 0x18 LastTableSchemaInfo         ( ModelClassType TableSchemaInfo TableSchemaInfo TableSchemaInfo Pointer )

            return value;
        }
    }
}
