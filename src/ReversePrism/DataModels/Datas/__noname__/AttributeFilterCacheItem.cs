using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Filter                                   000185B70E90 ModelClassListType Attribute[] Attribute[] List<Attribute> Pointer
    // 018 FilteredMembers                          0001867317B0 ModelClassType ICollection ICollection ICollection Pointer
    public partial class AttributeFilterCacheItem
    {
        public List<Attribute>?                         Filter                                  { get; set; }
        public ICollection?                             FilteredMembers                         { get; set; }

        public static AttributeFilterCacheItem? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AttributeFilterCacheItem();

            value.Filter                                    = GetObjectList<Attribute>(new IntPtr(p + 0x010), ReversePrism.DataModels.Attribute.FromPointer); // 0270D7B3C3D8 0x10 Filter                      ( 000185B70E90 ModelClassListType Attribute[] Attribute[] List<Attribute> Pointer )
            value.FilteredMembers                           = GetObject<ICollection>(new IntPtr(p + 0x018), ReversePrism.DataModels.ICollection.FromPointer); // 0270D7B3C3F8 0x18 FilteredMembers             ( 0001867317B0 ModelClassType ICollection ICollection ICollection Pointer )

            return value;
        }
    }
}
