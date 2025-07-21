using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 M_Weight0                                ModelPrimitiveType float float float Single
    // 024 M_Weight1                                ModelPrimitiveType float float float Single
    // 028 M_Weight2                                ModelPrimitiveType float float float Single
    // 02C M_Weight3                                ModelPrimitiveType float float float Single
    // 030 M_Weight4                                ModelPrimitiveType float float float Single
    // 034 M_Weight5                                ModelPrimitiveType float float float Single
    // 038 M_Weight6                                ModelPrimitiveType float float float Single
    // 03C M_Weight7                                ModelPrimitiveType float float float Single
    // 040 M_group                                  ModelClassType CinemachineTargetGroup CinemachineTargetGroup CinemachineTargetGroup Pointer
    public partial class GroupWeightManipulator : DataModel
    {
        public float                                    M_Weight0                               { get; set; }
        public float                                    M_Weight1                               { get; set; }
        public float                                    M_Weight2                               { get; set; }
        public float                                    M_Weight3                               { get; set; }
        public float                                    M_Weight4                               { get; set; }
        public float                                    M_Weight5                               { get; set; }
        public float                                    M_Weight6                               { get; set; }
        public float                                    M_Weight7                               { get; set; }
        public CinemachineTargetGroup?                  M_group                                 { get; set; }

        public static GroupWeightManipulator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GroupWeightManipulator() { Pointer= p0 };

            value.M_Weight0                                 = GetSingle(new IntPtr(p + 0x020)); // 0x20 M_Weight0                   ( ModelPrimitiveType float float float Single )
            value.M_Weight1                                 = GetSingle(new IntPtr(p + 0x024)); // 0x24 M_Weight1                   ( ModelPrimitiveType float float float Single )
            value.M_Weight2                                 = GetSingle(new IntPtr(p + 0x028)); // 0x28 M_Weight2                   ( ModelPrimitiveType float float float Single )
            value.M_Weight3                                 = GetSingle(new IntPtr(p + 0x02C)); // 0x2C M_Weight3                   ( ModelPrimitiveType float float float Single )
            value.M_Weight4                                 = GetSingle(new IntPtr(p + 0x030)); // 0x30 M_Weight4                   ( ModelPrimitiveType float float float Single )
            value.M_Weight5                                 = GetSingle(new IntPtr(p + 0x034)); // 0x34 M_Weight5                   ( ModelPrimitiveType float float float Single )
            value.M_Weight6                                 = GetSingle(new IntPtr(p + 0x038)); // 0x38 M_Weight6                   ( ModelPrimitiveType float float float Single )
            value.M_Weight7                                 = GetSingle(new IntPtr(p + 0x03C)); // 0x3C M_Weight7                   ( ModelPrimitiveType float float float Single )
            value.M_group                                   = GetObject<CinemachineTargetGroup>(new IntPtr(p + 0x040), ReversePrism.DataModels.CinemachineTargetGroup.FromPointer); // 0x40 M_group                     ( ModelClassType CinemachineTargetGroup CinemachineTargetGroup CinemachineTargetGroup Pointer )

            return value;
        }
    }
}
