using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Filter                                   ModelClassListType Attribute[] Attribute[] List<Attribute> Pointer
    // 018 FilteredMembers                          ModelClassType ICollection ICollection ICollection Pointer
    public partial class AttributeFilterCacheItem : DataModel
    {
        public List<Attribute>?                         Filter                                  { get; set; }
        public ICollection?                             FilteredMembers                         { get; set; }

        public static AttributeFilterCacheItem? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AttributeFilterCacheItem() { Pointer= p0 };

            value.Filter                                    = GetObjectList<Attribute>(new IntPtr(p + 0x010), ReversePrism.DataModels.Attribute.FromPointer); // 0x10 Filter                      ( ModelClassListType Attribute[] Attribute[] List<Attribute> Pointer )
            value.FilteredMembers                           = GetObject<ICollection>(new IntPtr(p + 0x018), ReversePrism.DataModels.ICollection.FromPointer); // 0x18 FilteredMembers             ( ModelClassType ICollection ICollection ICollection Pointer )

            return value;
        }
    }
}
