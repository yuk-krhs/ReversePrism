using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 roundPower10Single                       float[] IL2CPP_TYPE_SZARRAY
    // 008 singleRoundLimit                         float IL2CPP_TYPE_R4
    public partial class MathF : DataModel
    {

        public static MathF? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MathF() { Pointer= p0 };


            return value;
        }
    }
}
