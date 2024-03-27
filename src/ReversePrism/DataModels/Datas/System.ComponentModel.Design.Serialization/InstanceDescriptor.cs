using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Arguments                                0001867319F0 ModelClassType ICollection ICollection ICollection Pointer
    // 018 IsComplete                               0001865965D0 ModelPrimitiveType bool bool bool Bool
    // 020 MemberInfo                               0001865F2430 ModelClassType MemberInfo MemberInfo MemberInfo Pointer
    public partial class InstanceDescriptor
    {
        public ICollection?                             Arguments                               { get; set; }
        public bool                                     IsComplete                              { get; set; }
        public MemberInfo?                              MemberInfo                              { get; set; }

        public static InstanceDescriptor? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InstanceDescriptor();

            value.Arguments                                 = GetObject<ICollection>(new IntPtr(p + 0x010), ReversePrism.DataModels.ICollection.FromPointer); // 0270D7B3F108 0x10 Arguments                   ( 0001867319F0 ModelClassType ICollection ICollection ICollection Pointer )
            value.IsComplete                                = GetBool(new IntPtr(p + 0x018)); // 0270D7B3F128 0x18 IsComplete                  ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )
            value.MemberInfo                                = GetObject<MemberInfo>(new IntPtr(p + 0x020), ReversePrism.DataModels.MemberInfo.FromPointer); // 0270D7B3F148 0x20 MemberInfo                  ( 0001865F2430 ModelClassType MemberInfo MemberInfo MemberInfo Pointer )

            return value;
        }
    }
}
