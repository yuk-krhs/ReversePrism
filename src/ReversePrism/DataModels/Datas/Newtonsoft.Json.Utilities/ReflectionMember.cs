using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MemberType                               ModelClassType Type Type Type Pointer
    // 018 <Getter>k__BackingField                  Func`2<<object>, <object>> IL2CPP_TYPE_GENERICINST
    // 020 <Setter>k__BackingField                  Action`2<<object>, <object>> IL2CPP_TYPE_GENERICINST
    public partial class ReflectionMember : DataModel
    {
        public Type?                                    MemberType                              { get; set; }

        public static ReflectionMember? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ReflectionMember() { Pointer= p0 };

            value.MemberType                                = GetObject<Type>(new IntPtr(p + 0x010), ReversePrism.DataModels.Type.FromPointer); // 0x10 MemberType                  ( ModelClassType Type Type Type Pointer )

            return value;
        }
    }
}
