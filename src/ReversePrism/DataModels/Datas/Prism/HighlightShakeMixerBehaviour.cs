using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 shakeMax                                 float IL2CPP_TYPE_R4
    public partial class HighlightShakeMixerBehaviour : DataModel
    {

        public static HighlightShakeMixerBehaviour? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HighlightShakeMixerBehaviour() { Pointer= p0 };


            return value;
        }
    }
}
