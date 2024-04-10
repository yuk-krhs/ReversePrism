using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ConeInsideAngle                          000186666050 ModelPrimitiveType float float float Single
    // 014 ConeOutsideAngle                         000186666050 ModelPrimitiveType float float float Single
    // 018 MinAttenuationDistance                   000186666050 ModelPrimitiveType float float float Single
    // 01C MaxAttenuationDistance                   000186666050 ModelPrimitiveType float float float Single
    // 020 SourceRadius                             000186666050 ModelPrimitiveType float float float Single
    // 024 InteriorDistance                         000186666050 ModelPrimitiveType float float float Single
    // 028 DopplerFactor                            000186666050 ModelPrimitiveType float float float Single
    // 030 RandomPos                                0001866D6820 ModelEnumType Randomize3dConfig Randomize3dConfig Randomize3dConfig Int32
    // 040 DistanceAisacControl                     0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 044 ListenerBaseAngleAisacControl            0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 048 SourceBaseAngleAisacControl              0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 04C ListenerBaseElevationAisacControl        0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 050 SourceBaseElevationAisacControl          0001866992B0 ModelPrimitiveType uint uint uint UInt32
    public partial class CuePos3dInfo : DataModel
    {
        public float                                    ConeInsideAngle                         { get; set; }
        public float                                    ConeOutsideAngle                        { get; set; }
        public float                                    MinAttenuationDistance                  { get; set; }
        public float                                    MaxAttenuationDistance                  { get; set; }
        public float                                    SourceRadius                            { get; set; }
        public float                                    InteriorDistance                        { get; set; }
        public float                                    DopplerFactor                           { get; set; }
        public Randomize3dConfig                        RandomPos                               { get; set; }
        public uint                                     DistanceAisacControl                    { get; set; }
        public uint                                     ListenerBaseAngleAisacControl           { get; set; }
        public uint                                     SourceBaseAngleAisacControl             { get; set; }
        public uint                                     ListenerBaseElevationAisacControl       { get; set; }
        public uint                                     SourceBaseElevationAisacControl         { get; set; }

        public static CuePos3dInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CuePos3dInfo() { Pointer= p0 };

            value.ConeInsideAngle                           = GetSingle(new IntPtr(p + 0x010)); // 0245A729F898 0x10 ConeInsideAngle             ( 000186666050 ModelPrimitiveType float float float Single )
            value.ConeOutsideAngle                          = GetSingle(new IntPtr(p + 0x014)); // 0245A729F8B8 0x14 ConeOutsideAngle            ( 000186666050 ModelPrimitiveType float float float Single )
            value.MinAttenuationDistance                    = GetSingle(new IntPtr(p + 0x018)); // 0245A729F8D8 0x18 MinAttenuationDistance      ( 000186666050 ModelPrimitiveType float float float Single )
            value.MaxAttenuationDistance                    = GetSingle(new IntPtr(p + 0x01C)); // 0245A729F8F8 0x1C MaxAttenuationDistance      ( 000186666050 ModelPrimitiveType float float float Single )
            value.SourceRadius                              = GetSingle(new IntPtr(p + 0x020)); // 0245A729F918 0x20 SourceRadius                ( 000186666050 ModelPrimitiveType float float float Single )
            value.InteriorDistance                          = GetSingle(new IntPtr(p + 0x024)); // 0245A729F938 0x24 InteriorDistance            ( 000186666050 ModelPrimitiveType float float float Single )
            value.DopplerFactor                             = GetSingle(new IntPtr(p + 0x028)); // 0245A729F958 0x28 DopplerFactor               ( 000186666050 ModelPrimitiveType float float float Single )
            value.RandomPos                                 = (Randomize3dConfig)GetInt32(new IntPtr(p + 0x030)); // 0245A729F978 0x30 RandomPos                   ( 0001866D6820 ModelEnumType Randomize3dConfig Randomize3dConfig Randomize3dConfig Int32 )
            value.DistanceAisacControl                      = GetUInt32(new IntPtr(p + 0x040)); // 0245A729F998 0x40 DistanceAisacControl        ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.ListenerBaseAngleAisacControl             = GetUInt32(new IntPtr(p + 0x044)); // 0245A729F9B8 0x44 ListenerBaseAngleAisacControl ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.SourceBaseAngleAisacControl               = GetUInt32(new IntPtr(p + 0x048)); // 0245A729F9D8 0x48 SourceBaseAngleAisacControl ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.ListenerBaseElevationAisacControl         = GetUInt32(new IntPtr(p + 0x04C)); // 0245A729F9F8 0x4C ListenerBaseElevationAisacControl ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.SourceBaseElevationAisacControl           = GetUInt32(new IntPtr(p + 0x050)); // 0245A729FA18 0x50 SourceBaseElevationAisacControl ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )

            return value;
        }
    }
}
