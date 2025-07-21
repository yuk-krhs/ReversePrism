using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_FullHash                               ModelPrimitiveType int int int Int32
    // 018 M_VirtualCamera                          ModelClassType CinemachineVirtualCameraBase CinemachineVirtualCameraBase CinemachineVirtualCameraBase Pointer
    // 020 M_ActivateAfter                          ModelPrimitiveType float float float Single
    // 024 M_MinDuration                            ModelPrimitiveType float float float Single
    public partial class Instruction : DataModel
    {
        public int                                      M_FullHash                              { get; set; }
        public CinemachineVirtualCameraBase?            M_VirtualCamera                         { get; set; }
        public float                                    M_ActivateAfter                         { get; set; }
        public float                                    M_MinDuration                           { get; set; }

        public static Instruction? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Instruction() { Pointer= p0 };

            value.M_FullHash                                = GetInt32(new IntPtr(p + 0x010)); // 0x10 M_FullHash                  ( ModelPrimitiveType int int int Int32 )
            value.M_VirtualCamera                           = GetObject<CinemachineVirtualCameraBase>(new IntPtr(p + 0x018), ReversePrism.DataModels.CinemachineVirtualCameraBase.FromPointer); // 0x18 M_VirtualCamera             ( ModelClassType CinemachineVirtualCameraBase CinemachineVirtualCameraBase CinemachineVirtualCameraBase Pointer )
            value.M_ActivateAfter                           = GetSingle(new IntPtr(p + 0x020)); // 0x20 M_ActivateAfter             ( ModelPrimitiveType float float float Single )
            value.M_MinDuration                             = GetSingle(new IntPtr(p + 0x024)); // 0x24 M_MinDuration               ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
