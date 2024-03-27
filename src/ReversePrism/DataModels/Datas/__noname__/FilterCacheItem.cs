using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 FilterService                            000186686340 ModelClassType ITypeDescriptorFilterService ITypeDescriptorFilterService ITypeDescriptorFilterService Pointer
    // 018 FilteredMembers                          0001867317B0 ModelClassType ICollection ICollection ICollection Pointer
    public partial class FilterCacheItem
    {
        public ITypeDescriptorFilterService?            FilterService                           { get; set; }
        public ICollection?                             FilteredMembers                         { get; set; }

        public static FilterCacheItem? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FilterCacheItem();

            value.FilterService                             = GetObject<ITypeDescriptorFilterService>(new IntPtr(p + 0x010), ReversePrism.DataModels.ITypeDescriptorFilterService.FromPointer); // 0270D7B3C4F0 0x10 FilterService               ( 000186686340 ModelClassType ITypeDescriptorFilterService ITypeDescriptorFilterService ITypeDescriptorFilterService Pointer )
            value.FilteredMembers                           = GetObject<ICollection>(new IntPtr(p + 0x018), ReversePrism.DataModels.ICollection.FromPointer); // 0270D7B3C510 0x18 FilteredMembers             ( 0001867317B0 ModelClassType ICollection ICollection ICollection Pointer )

            return value;
        }
    }
}
