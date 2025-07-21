using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TransformList                            ModelClassListType List`1<Transform> List`1<Transform> List<Transform> Pointer
    // 018 flagArray                                ExSimpleNativeArray`1<ExBitFlag8> IL2CPP_TYPE_GENERICINST
    // 020 initLocalPositionArray                   ExSimpleNativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 028 initLocalRotationArray                   ExSimpleNativeArray`1<quaternion> IL2CPP_TYPE_GENERICINST
    // 030 positionArray                            ExSimpleNativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 038 rotationArray                            ExSimpleNativeArray`1<quaternion> IL2CPP_TYPE_GENERICINST
    // 040 inverseRotationArray                     ExSimpleNativeArray`1<quaternion> IL2CPP_TYPE_GENERICINST
    // 048 scaleArray                               ExSimpleNativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 050 localPositionArray                       ExSimpleNativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 058 localRotationArray                       ExSimpleNativeArray`1<quaternion> IL2CPP_TYPE_GENERICINST
    // 060 idArray                                  ExSimpleNativeArray`1<int> IL2CPP_TYPE_GENERICINST
    // 068 parentIdArray                            ExSimpleNativeArray`1<int> IL2CPP_TYPE_GENERICINST
    // 070 RootIdList                               ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer
    // 078 IsDirty                                  ModelPrimitiveType bool bool bool Bool
    // 080 TransformAccessArray                     ModelEnumType TransformAccessArray TransformAccessArray TransformAccessArray Int32
    // 088 emptyStack                               Queue`1<int> IL2CPP_TYPE_GENERICINST
    public partial class TransformData : DataModel
    {
        public List<Transform>?                         TransformList                           { get; set; }
        public List<int>?                               RootIdList                              { get; set; }
        public bool                                     IsDirty                                 { get; set; }
        public TransformAccessArray                     TransformAccessArray                    { get; set; }

        public static TransformData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TransformData() { Pointer= p0 };

            value.TransformList                             = GetObjectList<Transform>(new IntPtr(p + 0x010), ReversePrism.DataModels.Transform.FromPointer); // 0x10 TransformList               ( ModelClassListType List`1<Transform> List`1<Transform> List<Transform> Pointer )
            value.RootIdList                                = GetInt32List(new IntPtr(p + 0x070)); // 0x70 RootIdList                  ( ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer )
            value.IsDirty                                   = GetBool(new IntPtr(p + 0x078)); // 0x78 IsDirty                     ( ModelPrimitiveType bool bool bool Bool )
            value.TransformAccessArray                      = (TransformAccessArray)GetInt32(new IntPtr(p + 0x080)); // 0x80 TransformAccessArray        ( ModelEnumType TransformAccessArray TransformAccessArray TransformAccessArray Int32 )

            return value;
        }
    }
}
