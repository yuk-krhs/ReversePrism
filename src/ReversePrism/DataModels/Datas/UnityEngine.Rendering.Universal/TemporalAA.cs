using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 taaFilterOffsets                         Vector2[] IL2CPP_TYPE_SZARRAY
    // 008 taaFilterWeights                         float[] IL2CPP_TYPE_SZARRAY
    public partial class TemporalAA : DataModel
    {

        public static TemporalAA? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TemporalAA() { Pointer= p0 };


            return value;
        }
    }
}
