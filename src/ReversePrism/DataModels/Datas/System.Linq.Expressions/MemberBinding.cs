using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 BindingType                              0001865F09E0 ModelEnumType MemberBindingType MemberBindingType MemberBindingType Int32
    // 018 Member                                   0001865F2430 ModelClassType MemberInfo MemberInfo MemberInfo Pointer
    public partial class MemberBinding
    {
        public MemberBindingType                        BindingType                             { get; set; }
        public MemberInfo?                              Member                                  { get; set; }

        public static MemberBinding? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MemberBinding();

            value.BindingType                               = (MemberBindingType)GetInt32(new IntPtr(p + 0x010)); // 0270D9F66EE8 0x10 BindingType                 ( 0001865F09E0 ModelEnumType MemberBindingType MemberBindingType MemberBindingType Int32 )
            value.Member                                    = GetObject<MemberInfo>(new IntPtr(p + 0x018), ReversePrism.DataModels.MemberInfo.FromPointer); // 0270D9F66F08 0x18 Member                      ( 0001865F2430 ModelClassType MemberInfo MemberInfo MemberInfo Pointer )

            return value;
        }
    }
}
