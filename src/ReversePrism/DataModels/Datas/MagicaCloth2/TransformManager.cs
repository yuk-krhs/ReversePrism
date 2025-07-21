using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Flag_Read                                sbyte IL2CPP_TYPE_U1
    // 000 Flag_WorldRotWrite                       sbyte IL2CPP_TYPE_U1
    // 000 Flag_LocalPosRotWrite                    sbyte IL2CPP_TYPE_U1
    // 000 Flag_Restore                             sbyte IL2CPP_TYPE_U1
    // 000 Flag_Enable                              sbyte IL2CPP_TYPE_U1
    // 010 flagArray                                ExNativeArray`1<ExBitFlag8> IL2CPP_TYPE_GENERICINST
    // 018 initLocalPositionArray                   ExNativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 020 initLocalRotationArray                   ExNativeArray`1<quaternion> IL2CPP_TYPE_GENERICINST
    // 028 positionArray                            ExNativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 030 rotationArray                            ExNativeArray`1<quaternion> IL2CPP_TYPE_GENERICINST
    // 038 inverseRotationArray                     ExNativeArray`1<quaternion> IL2CPP_TYPE_GENERICINST
    // 040 scaleArray                               ExNativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 048 localPositionArray                       ExNativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 050 localRotationArray                       ExNativeArray`1<quaternion> IL2CPP_TYPE_GENERICINST
    // 058 teamIdArray                              ExNativeArray`1<short> IL2CPP_TYPE_GENERICINST
    // 060 TransformAccessArray                     ModelEnumType TransformAccessArray TransformAccessArray TransformAccessArray Int32
    // 068 IsValid                                  ModelPrimitiveType bool bool bool Bool
    public partial class TransformManager : DataModel
    {
        public TransformAccessArray                     TransformAccessArray                    { get; set; }
        public bool                                     IsValid                                 { get; set; }

        public static TransformManager? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TransformManager() { Pointer= p0 };

            value.TransformAccessArray                      = (TransformAccessArray)GetInt32(new IntPtr(p + 0x060)); // 0x60 TransformAccessArray        ( ModelEnumType TransformAccessArray TransformAccessArray TransformAccessArray Int32 )
            value.IsValid                                   = GetBool(new IntPtr(p + 0x068)); // 0x68 IsValid                     ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
