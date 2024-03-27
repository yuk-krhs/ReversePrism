using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 InnerBinder                              00018664D460 ModelClassType GetMemberBinder GetMemberBinder GetMemberBinder Pointer
    public partial class NoThrowGetBinderMember
    {
        public GetMemberBinder?                         InnerBinder                             { get; set; }

        public static NoThrowGetBinderMember? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NoThrowGetBinderMember();

            value.InnerBinder                               = GetObject<GetMemberBinder>(new IntPtr(p + 0x028), ReversePrism.DataModels.GetMemberBinder.FromPointer); // 0270D872F4D0 0x28 InnerBinder                 ( 00018664D460 ModelClassType GetMemberBinder GetMemberBinder GetMemberBinder Pointer )

            return value;
        }
    }
}
