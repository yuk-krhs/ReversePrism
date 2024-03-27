using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 <Bindings>k__BackingField                ReadOnlyCollection`1<MemberBinding> IL2CPP_TYPE_GENERICINST
    public partial class MemberMemberBinding
    {

        public static MemberMemberBinding? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MemberMemberBinding();


            return value;
        }
    }
}
