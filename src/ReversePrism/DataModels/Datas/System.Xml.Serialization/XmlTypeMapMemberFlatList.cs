using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 080 ListMap                                  ModelClassType ListMap ListMap ListMap Pointer
    public partial class XmlTypeMapMemberFlatList : DataModel
    {
        public ListMap?                                 ListMap                                 { get; set; }

        public static XmlTypeMapMemberFlatList? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlTypeMapMemberFlatList() { Pointer= p0 };

            value.ListMap                                   = GetObject<ListMap>(new IntPtr(p + 0x080), ReversePrism.DataModels.ListMap.FromPointer); // 0x80 ListMap                     ( ModelClassType ListMap ListMap ListMap Pointer )

            return value;
        }
    }
}
