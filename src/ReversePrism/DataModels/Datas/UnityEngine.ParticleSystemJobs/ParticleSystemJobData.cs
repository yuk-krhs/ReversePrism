using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Count                                    ModelPrimitiveType int int int Int32
    // 018 Positions                                ModelEnumType ParticleSystemNativeArray3 ParticleSystemNativeArray3 ParticleSystemNativeArray3 Int32
    // 048 Velocities                               ModelEnumType ParticleSystemNativeArray3 ParticleSystemNativeArray3 ParticleSystemNativeArray3 Int32
    // 078 AxisOfRotations                          ModelEnumType ParticleSystemNativeArray3 ParticleSystemNativeArray3 ParticleSystemNativeArray3 Int32
    // 0A8 Rotations                                ModelEnumType ParticleSystemNativeArray3 ParticleSystemNativeArray3 ParticleSystemNativeArray3 Int32
    // 0D8 RotationalSpeeds                         ModelEnumType ParticleSystemNativeArray3 ParticleSystemNativeArray3 ParticleSystemNativeArray3 Int32
    // 108 Sizes                                    ModelEnumType ParticleSystemNativeArray3 ParticleSystemNativeArray3 ParticleSystemNativeArray3 Int32
    // 138 <startColors>k__BackingField             NativeArray`1<Color32> IL2CPP_TYPE_GENERICINST
    // 148 <aliveTimePercent>k__BackingField        NativeArray`1<float> IL2CPP_TYPE_GENERICINST
    // 158 <inverseStartLifetimes>k__BackingField   NativeArray`1<float> IL2CPP_TYPE_GENERICINST
    // 168 <randomSeeds>k__BackingField             NativeArray`1<uint> IL2CPP_TYPE_GENERICINST
    // 178 CustomData1                              ModelEnumType ParticleSystemNativeArray4 ParticleSystemNativeArray4 ParticleSystemNativeArray4 Int32
    // 1B8 CustomData2                              ModelEnumType ParticleSystemNativeArray4 ParticleSystemNativeArray4 ParticleSystemNativeArray4 Int32
    // 1F8 <meshIndices>k__BackingField             NativeArray`1<int> IL2CPP_TYPE_GENERICINST
    public partial class ParticleSystemJobData : DataModel
    {
        public int                                      Count                                   { get; set; }
        public ParticleSystemNativeArray3               Positions                               { get; set; }
        public ParticleSystemNativeArray3               Velocities                              { get; set; }
        public ParticleSystemNativeArray3               AxisOfRotations                         { get; set; }
        public ParticleSystemNativeArray3               Rotations                               { get; set; }
        public ParticleSystemNativeArray3               RotationalSpeeds                        { get; set; }
        public ParticleSystemNativeArray3               Sizes                                   { get; set; }
        public ParticleSystemNativeArray4               CustomData1                             { get; set; }
        public ParticleSystemNativeArray4               CustomData2                             { get; set; }

        public static ParticleSystemJobData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ParticleSystemJobData() { Pointer= p0 };

            value.Count                                     = GetInt32(new IntPtr(p + 0x010)); // 0x10 Count                       ( ModelPrimitiveType int int int Int32 )
            value.Positions                                 = (ParticleSystemNativeArray3)GetInt32(new IntPtr(p + 0x018)); // 0x18 Positions                   ( ModelEnumType ParticleSystemNativeArray3 ParticleSystemNativeArray3 ParticleSystemNativeArray3 Int32 )
            value.Velocities                                = (ParticleSystemNativeArray3)GetInt32(new IntPtr(p + 0x048)); // 0x48 Velocities                  ( ModelEnumType ParticleSystemNativeArray3 ParticleSystemNativeArray3 ParticleSystemNativeArray3 Int32 )
            value.AxisOfRotations                           = (ParticleSystemNativeArray3)GetInt32(new IntPtr(p + 0x078)); // 0x78 AxisOfRotations             ( ModelEnumType ParticleSystemNativeArray3 ParticleSystemNativeArray3 ParticleSystemNativeArray3 Int32 )
            value.Rotations                                 = (ParticleSystemNativeArray3)GetInt32(new IntPtr(p + 0x0A8)); // 0xA8 Rotations                   ( ModelEnumType ParticleSystemNativeArray3 ParticleSystemNativeArray3 ParticleSystemNativeArray3 Int32 )
            value.RotationalSpeeds                          = (ParticleSystemNativeArray3)GetInt32(new IntPtr(p + 0x0D8)); // 0xD8 RotationalSpeeds            ( ModelEnumType ParticleSystemNativeArray3 ParticleSystemNativeArray3 ParticleSystemNativeArray3 Int32 )
            value.Sizes                                     = (ParticleSystemNativeArray3)GetInt32(new IntPtr(p + 0x108)); // 0x108 Sizes                       ( ModelEnumType ParticleSystemNativeArray3 ParticleSystemNativeArray3 ParticleSystemNativeArray3 Int32 )
            value.CustomData1                               = (ParticleSystemNativeArray4)GetInt32(new IntPtr(p + 0x178)); // 0x178 CustomData1                 ( ModelEnumType ParticleSystemNativeArray4 ParticleSystemNativeArray4 ParticleSystemNativeArray4 Int32 )
            value.CustomData2                               = (ParticleSystemNativeArray4)GetInt32(new IntPtr(p + 0x1B8)); // 0x1B8 CustomData2                 ( ModelEnumType ParticleSystemNativeArray4 ParticleSystemNativeArray4 ParticleSystemNativeArray4 Int32 )

            return value;
        }
    }
}
