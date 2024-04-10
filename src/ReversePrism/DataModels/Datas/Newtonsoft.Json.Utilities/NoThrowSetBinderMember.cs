using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 InnerBinder                              000186743890 ModelClassType SetMemberBinder SetMemberBinder SetMemberBinder Pointer
    public partial class NoThrowSetBinderMember : DataModel
    {
        public SetMemberBinder?                         InnerBinder                             { get; set; }

        public static NoThrowSetBinderMember? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NoThrowSetBinderMember() { Pointer= p0 };

            value.InnerBinder                               = GetObject<SetMemberBinder>(new IntPtr(p + 0x028), ReversePrism.DataModels.SetMemberBinder.FromPointer); // 02466879F5C8 0x28 InnerBinder                 ( 000186743890 ModelClassType SetMemberBinder SetMemberBinder SetMemberBinder Pointer )

            return value;
        }
    }
}
