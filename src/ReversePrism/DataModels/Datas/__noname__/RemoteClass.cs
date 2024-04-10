using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 default_vtable                           <int> IL2CPP_TYPE_I
    // 018 xdomain_vtable                           <int> IL2CPP_TYPE_I
    // 020 proxy_class                              IntPtr IL2CPP_TYPE_PTR
    // 028 proxy_class_name                         <int> IL2CPP_TYPE_I
    // 030 Interface_count                          000186698DF0 ModelPrimitiveType uint uint uint UInt32
    public partial class RemoteClass : DataModel
    {
        public uint                                     Interface_count                         { get; set; }

        public static RemoteClass? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RemoteClass() { Pointer= p0 };

            value.Interface_count                           = GetUInt32(new IntPtr(p + 0x030)); // 0246669A71F8 0x30 Interface_count             ( 000186698DF0 ModelPrimitiveType uint uint uint UInt32 )

            return value;
        }
    }
}
