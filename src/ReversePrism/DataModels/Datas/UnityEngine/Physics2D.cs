using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 m_LastDisabledRigidbody2D                List`1<Rigidbody2D> IL2CPP_TYPE_GENERICINST
    public partial class Physics2D
    {

        public static Physics2D? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Physics2D();


            return value;
        }
    }
}
