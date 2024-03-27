using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Count                                    0001865F4260 ModelPrimitiveType int int int Int32
    // 018 Positions                                000186725E70 ModelEnumType ParticleSystemNativeArray3 ParticleSystemNativeArray3 ParticleSystemNativeArray3 Int32
    // 048 Velocities                               000186725E70 ModelEnumType ParticleSystemNativeArray3 ParticleSystemNativeArray3 ParticleSystemNativeArray3 Int32
    // 078 AxisOfRotations                          000186725E70 ModelEnumType ParticleSystemNativeArray3 ParticleSystemNativeArray3 ParticleSystemNativeArray3 Int32
    // 0A8 Rotations                                000186725E70 ModelEnumType ParticleSystemNativeArray3 ParticleSystemNativeArray3 ParticleSystemNativeArray3 Int32
    // 0D8 RotationalSpeeds                         000186725E70 ModelEnumType ParticleSystemNativeArray3 ParticleSystemNativeArray3 ParticleSystemNativeArray3 Int32
    // 108 Sizes                                    000186725E70 ModelEnumType ParticleSystemNativeArray3 ParticleSystemNativeArray3 ParticleSystemNativeArray3 Int32
    // 138 <startColors>k__BackingField             NativeArray`1<Color32> IL2CPP_TYPE_GENERICINST
    // 148 <aliveTimePercent>k__BackingField        NativeArray`1<float> IL2CPP_TYPE_GENERICINST
    // 158 <inverseStartLifetimes>k__BackingField   NativeArray`1<float> IL2CPP_TYPE_GENERICINST
    // 168 <randomSeeds>k__BackingField             NativeArray`1<uint> IL2CPP_TYPE_GENERICINST
    // 178 CustomData1                              000186726350 ModelEnumType ParticleSystemNativeArray4 ParticleSystemNativeArray4 ParticleSystemNativeArray4 Int32
    // 1B8 CustomData2                              000186726350 ModelEnumType ParticleSystemNativeArray4 ParticleSystemNativeArray4 ParticleSystemNativeArray4 Int32
    // 1F8 <meshIndices>k__BackingField             NativeArray`1<int> IL2CPP_TYPE_GENERICINST
    public partial class ParticleSystemJobData
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
            var value   = new ParticleSystemJobData();

            value.Count                                     = GetInt32(new IntPtr(p + 0x010)); // 02700696FAA8 0x10 Count                       ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.Positions                                 = (ParticleSystemNativeArray3)GetInt32(new IntPtr(p + 0x018)); // 02700696FAC8 0x18 Positions                   ( 000186725E70 ModelEnumType ParticleSystemNativeArray3 ParticleSystemNativeArray3 ParticleSystemNativeArray3 Int32 )
            value.Velocities                                = (ParticleSystemNativeArray3)GetInt32(new IntPtr(p + 0x048)); // 02700696FAE8 0x48 Velocities                  ( 000186725E70 ModelEnumType ParticleSystemNativeArray3 ParticleSystemNativeArray3 ParticleSystemNativeArray3 Int32 )
            value.AxisOfRotations                           = (ParticleSystemNativeArray3)GetInt32(new IntPtr(p + 0x078)); // 02700696FB08 0x78 AxisOfRotations             ( 000186725E70 ModelEnumType ParticleSystemNativeArray3 ParticleSystemNativeArray3 ParticleSystemNativeArray3 Int32 )
            value.Rotations                                 = (ParticleSystemNativeArray3)GetInt32(new IntPtr(p + 0x0A8)); // 02700696FB28 0xA8 Rotations                   ( 000186725E70 ModelEnumType ParticleSystemNativeArray3 ParticleSystemNativeArray3 ParticleSystemNativeArray3 Int32 )
            value.RotationalSpeeds                          = (ParticleSystemNativeArray3)GetInt32(new IntPtr(p + 0x0D8)); // 02700696FB48 0xD8 RotationalSpeeds            ( 000186725E70 ModelEnumType ParticleSystemNativeArray3 ParticleSystemNativeArray3 ParticleSystemNativeArray3 Int32 )
            value.Sizes                                     = (ParticleSystemNativeArray3)GetInt32(new IntPtr(p + 0x108)); // 02700696FB68 0x108 Sizes                       ( 000186725E70 ModelEnumType ParticleSystemNativeArray3 ParticleSystemNativeArray3 ParticleSystemNativeArray3 Int32 )
            value.CustomData1                               = (ParticleSystemNativeArray4)GetInt32(new IntPtr(p + 0x178)); // 02700696FC08 0x178 CustomData1                 ( 000186726350 ModelEnumType ParticleSystemNativeArray4 ParticleSystemNativeArray4 ParticleSystemNativeArray4 Int32 )
            value.CustomData2                               = (ParticleSystemNativeArray4)GetInt32(new IntPtr(p + 0x1B8)); // 02700696FC28 0x1B8 CustomData2                 ( 000186726350 ModelEnumType ParticleSystemNativeArray4 ParticleSystemNativeArray4 ParticleSystemNativeArray4 Int32 )

            return value;
        }
    }
}
