using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Props                                    000186602BC0 ModelEnumType SynchronizationContextProperties SynchronizationContextProperties SynchronizationContextProperties Int32
    // 000 s_cachedPreparedType1                    Type IL2CPP_TYPE_CLASS
    // 008 s_cachedPreparedType2                    Type IL2CPP_TYPE_CLASS
    // 010 S_cachedPreparedType3                    0001866931D0 ModelClassType Type Type Type Pointer
    // 018 S_cachedPreparedType4                    0001866931D0 ModelClassType Type Type Type Pointer
    // 020 S_cachedPreparedType5                    0001866931D0 ModelClassType Type Type Type Pointer
    public partial class SynchronizationContext : DataModel
    {
        public SynchronizationContextProperties         Props                                   { get; set; }
        public Type?                                    S_cachedPreparedType3                   { get; set; }
        public Type?                                    S_cachedPreparedType4                   { get; set; }
        public Type?                                    S_cachedPreparedType5                   { get; set; }

        public static SynchronizationContext? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SynchronizationContext() { Pointer= p0 };

            value.Props                                     = (SynchronizationContextProperties)GetInt32(new IntPtr(p + 0x010)); // 0245A206B548 0x10 Props                       ( 000186602BC0 ModelEnumType SynchronizationContextProperties SynchronizationContextProperties SynchronizationContextProperties Int32 )
            value.S_cachedPreparedType3                     = GetObject<Type>(new IntPtr(p + 0x010), ReversePrism.DataModels.Type.FromPointer); // 0245A206B5A8 0x10 S_cachedPreparedType3       ( 0001866931D0 ModelClassType Type Type Type Pointer )
            value.S_cachedPreparedType4                     = GetObject<Type>(new IntPtr(p + 0x018), ReversePrism.DataModels.Type.FromPointer); // 0245A206B5C8 0x18 S_cachedPreparedType4       ( 0001866931D0 ModelClassType Type Type Type Pointer )
            value.S_cachedPreparedType5                     = GetObject<Type>(new IntPtr(p + 0x020), ReversePrism.DataModels.Type.FromPointer); // 0245A206B5E8 0x20 S_cachedPreparedType5       ( 0001866931D0 ModelClassType Type Type Type Pointer )

            return value;
        }
    }
}
