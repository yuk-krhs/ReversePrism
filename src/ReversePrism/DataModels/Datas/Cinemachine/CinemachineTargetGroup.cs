using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 M_PositionMode                           ModelEnumType PositionMode PositionMode PositionMode Int32
    // 024 M_RotationMode                           ModelEnumType RotationMode RotationMode RotationMode Int32
    // 028 M_UpdateMethod                           ModelEnumType UpdateMethod UpdateMethod UpdateMethod Int32
    // 030 M_Targets                                ModelEnumListType Target[] Target[] List<Target> Pointer
    // 038 M_MaxWeight                              ModelPrimitiveType float float float Single
    // 03C M_AveragePos                             ModelEnumType Vector3 Vector3 Vector3 Int32
    // 048 M_BoundingBox                            ModelEnumType Bounds Bounds Bounds Int32
    // 060 M_BoundingSphere                         ModelEnumType BoundingSphere BoundingSphere BoundingSphere Int32
    // 070 M_LastUpdateFrame                        ModelPrimitiveType int int int Int32
    // 078 M_ValidMembers                           ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer
    // 080 M_MemberValidity                         ModelPrimitiveListType List`1<bool> List`1<bool> List<bool> Pointer
    public partial class CinemachineTargetGroup : DataModel
    {
        public PositionMode                             M_PositionMode                          { get; set; }
        public RotationMode                             M_RotationMode                          { get; set; }
        public UpdateMethod                             M_UpdateMethod                          { get; set; }
        public List<Target>?                            M_Targets                               { get; set; }
        public float                                    M_MaxWeight                             { get; set; }
        public Vector3                                  M_AveragePos                            { get; set; }
        public Bounds                                   M_BoundingBox                           { get; set; }
        public BoundingSphere                           M_BoundingSphere                        { get; set; }
        public int                                      M_LastUpdateFrame                       { get; set; }
        public List<int>?                               M_ValidMembers                          { get; set; }
        public List<bool>?                              M_MemberValidity                        { get; set; }

        public static CinemachineTargetGroup? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CinemachineTargetGroup() { Pointer= p0 };

            value.M_PositionMode                            = (PositionMode)GetInt32(new IntPtr(p + 0x020)); // 0x20 M_PositionMode              ( ModelEnumType PositionMode PositionMode PositionMode Int32 )
            value.M_RotationMode                            = (RotationMode)GetInt32(new IntPtr(p + 0x024)); // 0x24 M_RotationMode              ( ModelEnumType RotationMode RotationMode RotationMode Int32 )
            value.M_UpdateMethod                            = (UpdateMethod)GetInt32(new IntPtr(p + 0x028)); // 0x28 M_UpdateMethod              ( ModelEnumType UpdateMethod UpdateMethod UpdateMethod Int32 )
            value.M_Targets                                 = GetEnumList<Target>(new IntPtr(p + 0x030)); // 0x30 M_Targets                   ( ModelEnumListType Target[] Target[] List<Target> Pointer )
            value.M_MaxWeight                               = GetSingle(new IntPtr(p + 0x038)); // 0x38 M_MaxWeight                 ( ModelPrimitiveType float float float Single )
            value.M_AveragePos                              = (Vector3)GetInt32(new IntPtr(p + 0x03C)); // 0x3C M_AveragePos                ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.M_BoundingBox                             = (Bounds)GetInt32(new IntPtr(p + 0x048)); // 0x48 M_BoundingBox               ( ModelEnumType Bounds Bounds Bounds Int32 )
            value.M_BoundingSphere                          = (BoundingSphere)GetInt32(new IntPtr(p + 0x060)); // 0x60 M_BoundingSphere            ( ModelEnumType BoundingSphere BoundingSphere BoundingSphere Int32 )
            value.M_LastUpdateFrame                         = GetInt32(new IntPtr(p + 0x070)); // 0x70 M_LastUpdateFrame           ( ModelPrimitiveType int int int Int32 )
            value.M_ValidMembers                            = GetInt32List(new IntPtr(p + 0x078)); // 0x78 M_ValidMembers              ( ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer )
            value.M_MemberValidity                          = GetBoolList(new IntPtr(p + 0x080)); // 0x80 M_MemberValidity            ( ModelPrimitiveListType List`1<bool> List`1<bool> List<bool> Pointer )

            return value;
        }
    }
}
