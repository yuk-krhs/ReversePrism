using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 m_Owner                                  InputStateHistory`1<<var>> IL2CPP_TYPE_GENERICINST
    // 000 m_IndexPlusOne                           int IL2CPP_TYPE_I4
    // 000 m_Version                                uint IL2CPP_TYPE_U4
    public partial class Record : DataModel
    {

        public static Record? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Record() { Pointer= p0 };


            return value;
        }
    }
}
