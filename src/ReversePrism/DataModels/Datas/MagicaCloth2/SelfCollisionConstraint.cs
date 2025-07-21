using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 KindPoint                                uint IL2CPP_TYPE_U4
    // 000 KindEdge                                 uint IL2CPP_TYPE_U4
    // 000 KindTriangle                             uint IL2CPP_TYPE_U4
    // 000 Flag_KindMask                            uint IL2CPP_TYPE_U4
    // 000 Flag_Fix0                                uint IL2CPP_TYPE_U4
    // 000 Flag_Fix1                                uint IL2CPP_TYPE_U4
    // 000 Flag_Fix2                                uint IL2CPP_TYPE_U4
    // 000 Flag_AllFix                              uint IL2CPP_TYPE_U4
    // 000 Flag_Ignore                              uint IL2CPP_TYPE_U4
    // 000 Flag_Enable                              uint IL2CPP_TYPE_U4
    // 010 primitiveArray                           ExNativeArray`1<Primitive> IL2CPP_TYPE_GENERICINST
    // 018 sortAndSweepArray                        ExNativeArray`1<SortData> IL2CPP_TYPE_GENERICINST
    // 020 PointPrimitiveCount                      ModelPrimitiveType int int int Int32
    // 024 EdgePrimitiveCount                       ModelPrimitiveType int int int Int32
    // 028 TrianglePrimitiveCount                   ModelPrimitiveType int int int Int32
    // 030 edgeEdgeContactQueue                     NativeQueue`1<EdgeEdgeContact> IL2CPP_TYPE_GENERICINST
    // 038 edgeEdgeContactList                      NativeList`1<EdgeEdgeContact> IL2CPP_TYPE_GENERICINST
    // 040 pointTriangleContactQueue                NativeQueue`1<PointTriangleContact> IL2CPP_TYPE_GENERICINST
    // 048 pointTriangleContactList                 NativeList`1<PointTriangleContact> IL2CPP_TYPE_GENERICINST
    // 050 intersectFlagArray                       NativeArray`1<sbyte> IL2CPP_TYPE_GENERICINST
    // 060 IntersectCount                           ModelPrimitiveType int int int Int32
    public partial class SelfCollisionConstraint : DataModel
    {
        public int                                      PointPrimitiveCount                     { get; set; }
        public int                                      EdgePrimitiveCount                      { get; set; }
        public int                                      TrianglePrimitiveCount                  { get; set; }
        public int                                      IntersectCount                          { get; set; }

        public static SelfCollisionConstraint? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SelfCollisionConstraint() { Pointer= p0 };

            value.PointPrimitiveCount                       = GetInt32(new IntPtr(p + 0x020)); // 0x20 PointPrimitiveCount         ( ModelPrimitiveType int int int Int32 )
            value.EdgePrimitiveCount                        = GetInt32(new IntPtr(p + 0x024)); // 0x24 EdgePrimitiveCount          ( ModelPrimitiveType int int int Int32 )
            value.TrianglePrimitiveCount                    = GetInt32(new IntPtr(p + 0x028)); // 0x28 TrianglePrimitiveCount      ( ModelPrimitiveType int int int Int32 )
            value.IntersectCount                            = GetInt32(new IntPtr(p + 0x060)); // 0x60 IntersectCount              ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
