using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Entries                                  ModelEnumListType List`1<XmlSchemaObjectEntry> List`1<XmlSchemaObjectEntry> List<XmlSchemaObjectEntry> Pointer
    // 018 Size                                     ModelPrimitiveType int int int Int32
    public partial class ValuesCollection : DataModel
    {
        public List<XmlSchemaObjectEntry>?              Entries                                 { get; set; }
        public int                                      Size                                    { get; set; }

        public static ValuesCollection? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ValuesCollection() { Pointer= p0 };

            value.Entries                                   = GetEnumList<XmlSchemaObjectEntry>(new IntPtr(p + 0x010)); // 0x10 Entries                     ( ModelEnumListType List`1<XmlSchemaObjectEntry> List`1<XmlSchemaObjectEntry> List<XmlSchemaObjectEntry> Pointer )
            value.Size                                      = GetInt32(new IntPtr(p + 0x018)); // 0x18 Size                        ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
