using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MemberInfo                               0001865F2430 ModelClassType MemberInfo MemberInfo MemberInfo Pointer
    public partial class ReflectionValueProvider : DataModel
    {
        public MemberInfo?                              MemberInfo                              { get; set; }

        public static ReflectionValueProvider? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ReflectionValueProvider() { Pointer= p0 };

            value.MemberInfo                                = GetObject<MemberInfo>(new IntPtr(p + 0x010), ReversePrism.DataModels.MemberInfo.FromPointer); // 0245A606B120 0x10 MemberInfo                  ( 0001865F2430 ModelClassType MemberInfo MemberInfo MemberInfo Pointer )

            return value;
        }
    }
}
