using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 M_Width                                  ModelPrimitiveType float float float Single
    // 034 M_Damping                                ModelPrimitiveType float float float Single
    // 038 M_MinFOV                                 ModelPrimitiveType float float float Single
    // 03C M_MaxFOV                                 ModelPrimitiveType float float float Single
    public partial class CinemachineFollowZoom : DataModel
    {
        public float                                    M_Width                                 { get; set; }
        public float                                    M_Damping                               { get; set; }
        public float                                    M_MinFOV                                { get; set; }
        public float                                    M_MaxFOV                                { get; set; }

        public static CinemachineFollowZoom? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CinemachineFollowZoom() { Pointer= p0 };

            value.M_Width                                   = GetSingle(new IntPtr(p + 0x030)); // 0x30 M_Width                     ( ModelPrimitiveType float float float Single )
            value.M_Damping                                 = GetSingle(new IntPtr(p + 0x034)); // 0x34 M_Damping                   ( ModelPrimitiveType float float float Single )
            value.M_MinFOV                                  = GetSingle(new IntPtr(p + 0x038)); // 0x38 M_MinFOV                    ( ModelPrimitiveType float float float Single )
            value.M_MaxFOV                                  = GetSingle(new IntPtr(p + 0x03C)); // 0x3C M_MaxFOV                    ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
