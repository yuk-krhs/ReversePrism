using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SimulationDeltaTime                      ModelPrimitiveType float float float Single
    // 018 teamDataArray                            NativeArray`1<TeamData> IL2CPP_TYPE_GENERICINST
    // 028 centerDataArray                          NativeArray`1<CenterData> IL2CPP_TYPE_GENERICINST
    // 038 teamWindArray                            NativeArray`1<TeamWindData> IL2CPP_TYPE_GENERICINST
    // 048 parameterArray                           NativeArray`1<ClothParameters> IL2CPP_TYPE_GENERICINST
    // 058 positions                                NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 068 rotations                                NativeArray`1<quaternion> IL2CPP_TYPE_GENERICINST
    // 078 vertexBindPoseRotations                  NativeArray`1<quaternion> IL2CPP_TYPE_GENERICINST
    // 088 fixedArray                               NativeArray`1<ushort> IL2CPP_TYPE_GENERICINST
    // 098 transformPositionArray                   NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 0A8 transformRotationArray                   NativeArray`1<quaternion> IL2CPP_TYPE_GENERICINST
    // 0B8 transformScaleArray                      NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 0C8 WindZoneCount                            ModelPrimitiveType int int int Int32
    // 0D0 windDataArray                            NativeArray`1<WindData> IL2CPP_TYPE_GENERICINST
    public partial class CalcCenterAndInertiaAndWindJob : DataModel
    {
        public float                                    SimulationDeltaTime                     { get; set; }
        public int                                      WindZoneCount                           { get; set; }

        public static CalcCenterAndInertiaAndWindJob? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CalcCenterAndInertiaAndWindJob() { Pointer= p0 };

            value.SimulationDeltaTime                       = GetSingle(new IntPtr(p + 0x010)); // 0x10 SimulationDeltaTime         ( ModelPrimitiveType float float float Single )
            value.WindZoneCount                             = GetInt32(new IntPtr(p + 0x0C8)); // 0xC8 WindZoneCount               ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
