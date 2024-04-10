using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 _info                                    IntPtr IL2CPP_TYPE_PTR
    // 018 <Directory>k__BackingField               ReadOnlySpan`1<char> IL2CPP_TYPE_GENERICINST
    // 028 <RootDirectory>k__BackingField           ReadOnlySpan`1<char> IL2CPP_TYPE_GENERICINST
    // 038 <OriginalRootDirectory>k__BackingField   ReadOnlySpan`1<char> IL2CPP_TYPE_GENERICINST
    public partial class FileSystemEntry : DataModel
    {

        public static FileSystemEntry? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FileSystemEntry() { Pointer= p0 };


            return value;
        }
    }
}
