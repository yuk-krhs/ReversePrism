using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 m_ProfilingScope                         ProfilingSampler IL2CPP_TYPE_CLASS
    // 0E0 M_Source                                 ModelClassType RTHandle RTHandle RTHandle Pointer
    // 0E8 M_UpscaleHandle                          ModelClassType RTHandle RTHandle RTHandle Pointer
    // 008 m_BlitMaterial                           Material IL2CPP_TYPE_CLASS
    public partial class UpscalePass : DataModel
    {
        public RTHandle?                                M_Source                                { get; set; }
        public RTHandle?                                M_UpscaleHandle                         { get; set; }

        public static UpscalePass? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UpscalePass() { Pointer= p0 };

            value.M_Source                                  = GetObject<RTHandle>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.RTHandle.FromPointer); // 0xE0 M_Source                    ( ModelClassType RTHandle RTHandle RTHandle Pointer )
            value.M_UpscaleHandle                           = GetObject<RTHandle>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.RTHandle.FromPointer); // 0xE8 M_UpscaleHandle             ( ModelClassType RTHandle RTHandle RTHandle Pointer )

            return value;
        }
    }
}
