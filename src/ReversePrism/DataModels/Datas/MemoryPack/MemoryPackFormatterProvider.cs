using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 ArrayLikeFormatters                      Dictionary`2<Type, Type> IL2CPP_TYPE_GENERICINST
    // 008 CollectionFormatters                     Dictionary`2<Type, Type> IL2CPP_TYPE_GENERICINST
    // 010 InterfaceCollectionFormatters            Dictionary`2<Type, Type> IL2CPP_TYPE_GENERICINST
    // 018 formatters                               ConcurrentDictionary`2<Type, IMemoryPackFormatter> IL2CPP_TYPE_GENERICINST
    // 020 genericFormatterFactory                  ConcurrentDictionary`2<Type, Type> IL2CPP_TYPE_GENERICINST
    // 028 genericCollectionFormatterFactory        ConcurrentDictionary`2<Type, Type> IL2CPP_TYPE_GENERICINST
    // 030 KnownGenericTypeFormatters               Dictionary`2<Type, Type> IL2CPP_TYPE_GENERICINST
    public partial class MemoryPackFormatterProvider : DataModel
    {

        public static MemoryPackFormatterProvider? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MemoryPackFormatterProvider() { Pointer= p0 };


            return value;
        }
    }
}
