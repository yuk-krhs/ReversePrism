using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Logger                                   ILogger IL2CPP_TYPE_CLASS
    // 000 RTLD_LAZY                                int IL2CPP_TYPE_I4
    // 000 RTLD_GLOBAL                              int IL2CPP_TYPE_I4
    // 010 LibraryPath                              000186672F10 ModelPrimitiveType string string string String
    // 018 handle                                   <int> IL2CPP_TYPE_I
    public partial class UnmanagedLibrary : DataModel
    {
        public string                                   LibraryPath                             { get; set; }

        public static UnmanagedLibrary? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UnmanagedLibrary() { Pointer= p0 };

            value.LibraryPath                               = GetString(new IntPtr(p + 0x010)); // 024660E3B6F0 0x10 LibraryPath                 ( 000186672F10 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
