using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 FilterService                            ModelClassType ITypeDescriptorFilterService ITypeDescriptorFilterService ITypeDescriptorFilterService Pointer
    // 018 FilteredMembers                          ModelClassType ICollection ICollection ICollection Pointer
    public partial class FilterCacheItem : DataModel
    {
        public ITypeDescriptorFilterService?            FilterService                           { get; set; }
        public ICollection?                             FilteredMembers                         { get; set; }

        public static FilterCacheItem? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FilterCacheItem() { Pointer= p0 };

            value.FilterService                             = GetObject<ITypeDescriptorFilterService>(new IntPtr(p + 0x010), ReversePrism.DataModels.ITypeDescriptorFilterService.FromPointer); // 0x10 FilterService               ( ModelClassType ITypeDescriptorFilterService ITypeDescriptorFilterService ITypeDescriptorFilterService Pointer )
            value.FilteredMembers                           = GetObject<ICollection>(new IntPtr(p + 0x018), ReversePrism.DataModels.ICollection.FromPointer); // 0x18 FilteredMembers             ( ModelClassType ICollection ICollection ICollection Pointer )

            return value;
        }
    }
}
