using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 080 ListMap                                  000186539E00 ModelClassType ListMap ListMap ListMap Pointer
    public partial class XmlTypeMapMemberFlatList
    {
        public ListMap?                                 ListMap                                 { get; set; }

        public static XmlTypeMapMemberFlatList? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlTypeMapMemberFlatList();

            value.ListMap                                   = GetObject<ListMap>(new IntPtr(p + 0x080), ReversePrism.DataModels.ListMap.FromPointer); // 0270D74D1F60 0x80 ListMap                     ( 000186539E00 ModelClassType ListMap ListMap ListMap Pointer )

            return value;
        }
    }
}
