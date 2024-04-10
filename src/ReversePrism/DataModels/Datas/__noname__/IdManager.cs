using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 m_nextIdToTry                            int IL2CPP_TYPE_I4
    // 000 m_freeIds                                List`1<bool> IL2CPP_TYPE_GENERICINST
    public partial class IdManager : DataModel
    {

        public static IdManager? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IdManager() { Pointer= p0 };


            return value;
        }
    }
}
