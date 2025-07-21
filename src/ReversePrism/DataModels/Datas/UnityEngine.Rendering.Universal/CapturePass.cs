using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 0E0 M_CameraColorHandle                      ModelClassType RTHandle RTHandle RTHandle Pointer
    // 000 m_ProfilerTag                            string IL2CPP_TYPE_STRING
    // 000 m_ProfilingSampler                       ProfilingSampler IL2CPP_TYPE_CLASS
    public partial class CapturePass : DataModel
    {
        public RTHandle?                                M_CameraColorHandle                     { get; set; }

        public static CapturePass? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CapturePass() { Pointer= p0 };

            value.M_CameraColorHandle                       = GetObject<RTHandle>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.RTHandle.FromPointer); // 0xE0 M_CameraColorHandle         ( ModelClassType RTHandle RTHandle RTHandle Pointer )

            return value;
        }
    }
}
