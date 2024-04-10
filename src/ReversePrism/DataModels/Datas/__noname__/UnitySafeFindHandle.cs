using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 m_Handle                                 <int> IL2CPP_TYPE_I
    public partial class UnitySafeFindHandle : DataModel
    {

        public static UnitySafeFindHandle? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UnitySafeFindHandle() { Pointer= p0 };


            return value;
        }
    }
}
