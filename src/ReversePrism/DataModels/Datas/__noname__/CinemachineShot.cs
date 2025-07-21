using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 DisplayName                              ModelPrimitiveType string string string String
    // 020 VirtualCamera                            ExposedReference`1<CinemachineVirtualCameraBase> IL2CPP_TYPE_GENERICINST
    public partial class CinemachineShot : DataModel
    {
        public string                                   DisplayName                             { get; set; }

        public static CinemachineShot? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CinemachineShot() { Pointer= p0 };

            value.DisplayName                               = GetString(new IntPtr(p + 0x018)); // 0x18 DisplayName                 ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
