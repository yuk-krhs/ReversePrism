using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 <OnEffectBufferFunc>k__BackingField      Func`1<RenderTexture> IL2CPP_TYPE_GENERICINST
    public partial class EffectBufferBridge : DataModel
    {

        public static EffectBufferBridge? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EffectBufferBridge() { Pointer= p0 };


            return value;
        }
    }
}
