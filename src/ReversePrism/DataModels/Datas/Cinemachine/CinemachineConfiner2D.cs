using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 M_BoundingShape2D                        ModelClassType Collider2D Collider2D Collider2D Pointer
    // 038 M_Damping                                ModelPrimitiveType float float float Single
    // 03C M_MaxWindowSize                          ModelPrimitiveType float float float Single
    // 040 M_MaxComputationTimePerFrameInSeconds    ModelPrimitiveType float float float Single
    // 000 k_cornerAngleTreshold                    float IL2CPP_TYPE_R4
    // 048 M_shapeCache                             ModelEnumType ShapeCache ShapeCache ShapeCache Int32
    public partial class CinemachineConfiner2D : DataModel
    {
        public Collider2D?                              M_BoundingShape2D                       { get; set; }
        public float                                    M_Damping                               { get; set; }
        public float                                    M_MaxWindowSize                         { get; set; }
        public float                                    M_MaxComputationTimePerFrameInSeconds   { get; set; }
        public ShapeCache                               M_shapeCache                            { get; set; }

        public static CinemachineConfiner2D? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CinemachineConfiner2D() { Pointer= p0 };

            value.M_BoundingShape2D                         = GetObject<Collider2D>(new IntPtr(p + 0x030), ReversePrism.DataModels.Collider2D.FromPointer); // 0x30 M_BoundingShape2D           ( ModelClassType Collider2D Collider2D Collider2D Pointer )
            value.M_Damping                                 = GetSingle(new IntPtr(p + 0x038)); // 0x38 M_Damping                   ( ModelPrimitiveType float float float Single )
            value.M_MaxWindowSize                           = GetSingle(new IntPtr(p + 0x03C)); // 0x3C M_MaxWindowSize             ( ModelPrimitiveType float float float Single )
            value.M_MaxComputationTimePerFrameInSeconds     = GetSingle(new IntPtr(p + 0x040)); // 0x40 M_MaxComputationTimePerFrameInSeconds ( ModelPrimitiveType float float float Single )
            value.M_shapeCache                              = (ShapeCache)GetInt32(new IntPtr(p + 0x048)); // 0x48 M_shapeCache                ( ModelEnumType ShapeCache ShapeCache ShapeCache Int32 )

            return value;
        }
    }
}
