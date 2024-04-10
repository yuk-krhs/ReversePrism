using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_PropertyBags                           ConcurrentDictionary`2<Type, IPropertyBag> IL2CPP_TYPE_GENERICINST
    // 008 s_RegisteredTypes                        List`1<Type> IL2CPP_TYPE_GENERICINST
    // 010 NewTypeRegistered                        Action`2<Type, IPropertyBag> IL2CPP_TYPE_GENERICINST
    // 018 S_PropertyBagProvider                    000186635B30 ModelClassType ReflectedPropertyBagProvider ReflectedPropertyBagProvider ReflectedPropertyBagProvider Pointer
    public partial class PropertyBagStore : DataModel
    {
        public ReflectedPropertyBagProvider?            S_PropertyBagProvider                   { get; set; }

        public static PropertyBagStore? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PropertyBagStore() { Pointer= p0 };

            value.S_PropertyBagProvider                     = GetObject<ReflectedPropertyBagProvider>(new IntPtr(p + 0x018), ReversePrism.DataModels.ReflectedPropertyBagProvider.FromPointer); // 0245A691A4F0 0x18 S_PropertyBagProvider       ( 000186635B30 ModelClassType ReflectedPropertyBagProvider ReflectedPropertyBagProvider ReflectedPropertyBagProvider Pointer )

            return value;
        }
    }
}
