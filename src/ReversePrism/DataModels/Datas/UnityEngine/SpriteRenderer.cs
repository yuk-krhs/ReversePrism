using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 m_SpriteChangeEvent                      UnityEvent`1<SpriteRenderer> IL2CPP_TYPE_GENERICINST
    public partial class SpriteRenderer : DataModel
    {

        public static SpriteRenderer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SpriteRenderer() { Pointer= p0 };


            return value;
        }
    }
}
