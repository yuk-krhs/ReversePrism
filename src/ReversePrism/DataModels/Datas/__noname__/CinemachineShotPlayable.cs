using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 VirtualCamera                            ModelClassType CinemachineVirtualCameraBase CinemachineVirtualCameraBase CinemachineVirtualCameraBase Pointer
    public partial class CinemachineShotPlayable : DataModel
    {
        public CinemachineVirtualCameraBase?            VirtualCamera                           { get; set; }

        public static CinemachineShotPlayable? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CinemachineShotPlayable() { Pointer= p0 };

            value.VirtualCamera                             = GetObject<CinemachineVirtualCameraBase>(new IntPtr(p + 0x010), ReversePrism.DataModels.CinemachineVirtualCameraBase.FromPointer); // 0x10 VirtualCamera               ( ModelClassType CinemachineVirtualCameraBase CinemachineVirtualCameraBase CinemachineVirtualCameraBase Pointer )

            return value;
        }
    }
}
