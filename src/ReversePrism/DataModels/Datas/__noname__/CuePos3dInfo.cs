using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ConeInsideAngle                          ModelPrimitiveType float float float Single
    // 014 ConeOutsideAngle                         ModelPrimitiveType float float float Single
    // 018 MinAttenuationDistance                   ModelPrimitiveType float float float Single
    // 01C MaxAttenuationDistance                   ModelPrimitiveType float float float Single
    // 020 SourceRadius                             ModelPrimitiveType float float float Single
    // 024 InteriorDistance                         ModelPrimitiveType float float float Single
    // 028 DopplerFactor                            ModelPrimitiveType float float float Single
    // 030 RandomPos                                ModelEnumType Randomize3dConfig Randomize3dConfig Randomize3dConfig Int32
    // 040 DistanceAisacControl                     ModelPrimitiveType uint uint uint UInt32
    // 044 ListenerBaseAngleAisacControl            ModelPrimitiveType uint uint uint UInt32
    // 048 SourceBaseAngleAisacControl              ModelPrimitiveType uint uint uint UInt32
    // 04C ListenerBaseElevationAisacControl        ModelPrimitiveType uint uint uint UInt32
    // 050 SourceBaseElevationAisacControl          ModelPrimitiveType uint uint uint UInt32
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

            value.ConeInsideAngle                           = GetSingle(new IntPtr(p + 0x010)); // 0x10 ConeInsideAngle             ( ModelPrimitiveType float float float Single )
            value.ConeOutsideAngle                          = GetSingle(new IntPtr(p + 0x014)); // 0x14 ConeOutsideAngle            ( ModelPrimitiveType float float float Single )
            value.MinAttenuationDistance                    = GetSingle(new IntPtr(p + 0x018)); // 0x18 MinAttenuationDistance      ( ModelPrimitiveType float float float Single )
            value.MaxAttenuationDistance                    = GetSingle(new IntPtr(p + 0x01C)); // 0x1C MaxAttenuationDistance      ( ModelPrimitiveType float float float Single )
            value.SourceRadius                              = GetSingle(new IntPtr(p + 0x020)); // 0x20 SourceRadius                ( ModelPrimitiveType float float float Single )
            value.InteriorDistance                          = GetSingle(new IntPtr(p + 0x024)); // 0x24 InteriorDistance            ( ModelPrimitiveType float float float Single )
            value.DopplerFactor                             = GetSingle(new IntPtr(p + 0x028)); // 0x28 DopplerFactor               ( ModelPrimitiveType float float float Single )
            value.RandomPos                                 = (Randomize3dConfig)GetInt32(new IntPtr(p + 0x030)); // 0x30 RandomPos                   ( ModelEnumType Randomize3dConfig Randomize3dConfig Randomize3dConfig Int32 )
            value.DistanceAisacControl                      = GetUInt32(new IntPtr(p + 0x040)); // 0x40 DistanceAisacControl        ( ModelPrimitiveType uint uint uint UInt32 )
            value.ListenerBaseAngleAisacControl             = GetUInt32(new IntPtr(p + 0x044)); // 0x44 ListenerBaseAngleAisacControl ( ModelPrimitiveType uint uint uint UInt32 )
            value.SourceBaseAngleAisacControl               = GetUInt32(new IntPtr(p + 0x048)); // 0x48 SourceBaseAngleAisacControl ( ModelPrimitiveType uint uint uint UInt32 )
            value.ListenerBaseElevationAisacControl         = GetUInt32(new IntPtr(p + 0x04C)); // 0x4C ListenerBaseElevationAisacControl ( ModelPrimitiveType uint uint uint UInt32 )
            value.SourceBaseElevationAisacControl           = GetUInt32(new IntPtr(p + 0x050)); // 0x50 SourceBaseElevationAisacControl ( ModelPrimitiveType uint uint uint UInt32 )

            return value;
        }
    }
}
