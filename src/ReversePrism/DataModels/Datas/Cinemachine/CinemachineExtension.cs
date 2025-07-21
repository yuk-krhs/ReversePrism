using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Epsilon                                  float IL2CPP_TYPE_R4
    // 020 M_vcamOwner                              ModelClassType CinemachineVirtualCameraBase CinemachineVirtualCameraBase CinemachineVirtualCameraBase Pointer
    // 028 mExtraState                              Dictionary`2<ICinemachineCamera, <object>> IL2CPP_TYPE_GENERICINST
    public partial class CinemachineExtension : DataModel
    {
        public CinemachineVirtualCameraBase?            M_vcamOwner                             { get; set; }

        public static CinemachineExtension? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CinemachineExtension() { Pointer= p0 };

            value.M_vcamOwner                               = GetObject<CinemachineVirtualCameraBase>(new IntPtr(p + 0x020), ReversePrism.DataModels.CinemachineVirtualCameraBase.FromPointer); // 0x20 M_vcamOwner                 ( ModelClassType CinemachineVirtualCameraBase CinemachineVirtualCameraBase CinemachineVirtualCameraBase Pointer )

            return value;
        }
    }
}
