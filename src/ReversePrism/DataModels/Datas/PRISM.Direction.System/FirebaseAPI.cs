using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 initialized                              ReactiveProperty`1<bool> IL2CPP_TYPE_GENERICINST
    public partial class FirebaseAPI
    {

        public static FirebaseAPI? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FirebaseAPI();


            return value;
        }
    }
}
