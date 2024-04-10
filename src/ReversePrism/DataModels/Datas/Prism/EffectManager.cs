using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 _pool                                    Dictionary`2<GameObject, List`1<GameObject>> IL2CPP_TYPE_GENERICINST
    public partial class EffectManager : DataModel
    {

        public static EffectManager? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EffectManager() { Pointer= p0 };


            return value;
        }
    }
}
