using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 _body                                    <object> IL2CPP_TYPE_OBJECT
    public partial class Scope1
    {

        public static Scope1? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Scope1();


            return value;
        }
    }
}
