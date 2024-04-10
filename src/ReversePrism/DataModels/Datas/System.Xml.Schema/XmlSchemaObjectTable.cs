using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 table                                    Dictionary`2<XmlQualifiedName, XmlSchemaObject> IL2CPP_TYPE_GENERICINST
    // 018 Entries                                  000185D318A8 ModelEnumListType List`1<XmlSchemaObjectEntry> List`1<XmlSchemaObjectEntry> List<XmlSchemaObjectEntry> Pointer
    public partial class XmlSchemaObjectTable : DataModel
    {
        public List<XmlSchemaObjectEntry>?              Entries                                 { get; set; }

        public static XmlSchemaObjectTable? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlSchemaObjectTable() { Pointer= p0 };

            value.Entries                                   = GetEnumList<XmlSchemaObjectEntry>(new IntPtr(p + 0x018)); // 0246675584D0 0x18 Entries                     ( 000185D318A8 ModelEnumListType List`1<XmlSchemaObjectEntry> List`1<XmlSchemaObjectEntry> List<XmlSchemaObjectEntry> Pointer )

            return value;
        }
    }
}
