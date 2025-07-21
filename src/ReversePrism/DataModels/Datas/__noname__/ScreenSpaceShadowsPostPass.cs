using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 m_ProfilerTag                            string IL2CPP_TYPE_STRING
    // 008 m_ProfilingSampler                       ProfilingSampler IL2CPP_TYPE_CLASS
    // 010 K_CurrentActive                          ModelClassType RTHandle RTHandle RTHandle Pointer
    public partial class ScreenSpaceShadowsPostPass : DataModel
    {
        public RTHandle?                                K_CurrentActive                         { get; set; }

        public static ScreenSpaceShadowsPostPass? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ScreenSpaceShadowsPostPass() { Pointer= p0 };

            value.K_CurrentActive                           = GetObject<RTHandle>(new IntPtr(p + 0x010), ReversePrism.DataModels.RTHandle.FromPointer); // 0x10 K_CurrentActive             ( ModelClassType RTHandle RTHandle RTHandle Pointer )

            return value;
        }
    }
}
