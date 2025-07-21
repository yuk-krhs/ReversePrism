using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MemberTypes                              ModelEnumType DynamicallyAccessedMemberTypes DynamicallyAccessedMemberTypes DynamicallyAccessedMemberTypes Int32
    public partial class DynamicallyAccessedMembersAttribute : DataModel
    {
        public DynamicallyAccessedMemberTypes           MemberTypes                             { get; set; }

        public static DynamicallyAccessedMembersAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DynamicallyAccessedMembersAttribute() { Pointer= p0 };

            value.MemberTypes                               = (DynamicallyAccessedMemberTypes)GetInt32(new IntPtr(p + 0x010)); // 0x10 MemberTypes                 ( ModelEnumType DynamicallyAccessedMemberTypes DynamicallyAccessedMemberTypes DynamicallyAccessedMemberTypes Int32 )

            return value;
        }
    }
}
