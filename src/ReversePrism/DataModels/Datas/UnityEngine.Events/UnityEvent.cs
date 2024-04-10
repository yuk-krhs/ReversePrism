using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 m_InvokeArray                            <object>[] IL2CPP_TYPE_SZARRAY
    public partial class UnityEvent : DataModel
    {

        public static UnityEvent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UnityEvent() { Pointer= p0 };


            return value;
        }
    }
}
