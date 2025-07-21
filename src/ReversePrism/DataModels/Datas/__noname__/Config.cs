using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MaxInputSamplingRate                     ModelPrimitiveType int int int Int32
    // 014 MorphTargetType                          ModelEnumType MorphTargetType MorphTargetType MorphTargetType Int32
    // 018 DataReadoutMode                          ModelEnumType DataReadoutMode DataReadoutMode DataReadoutMode Int32
    // 01C BehaviourParamsPreset                    ModelEnumType BehaviourParamsPreset BehaviourParamsPreset BehaviourParamsPreset Int32
    public partial class Config : DataModel
    {
        public int                                      MaxInputSamplingRate                    { get; set; }
        public MorphTargetType                          MorphTargetType                         { get; set; }
        public DataReadoutMode                          DataReadoutMode                         { get; set; }
        public BehaviourParamsPreset                    BehaviourParamsPreset                   { get; set; }

        public static Config? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Config() { Pointer= p0 };

            value.MaxInputSamplingRate                      = GetInt32(new IntPtr(p + 0x010)); // 0x10 MaxInputSamplingRate        ( ModelPrimitiveType int int int Int32 )
            value.MorphTargetType                           = (MorphTargetType)GetInt32(new IntPtr(p + 0x014)); // 0x14 MorphTargetType             ( ModelEnumType MorphTargetType MorphTargetType MorphTargetType Int32 )
            value.DataReadoutMode                           = (DataReadoutMode)GetInt32(new IntPtr(p + 0x018)); // 0x18 DataReadoutMode             ( ModelEnumType DataReadoutMode DataReadoutMode DataReadoutMode Int32 )
            value.BehaviourParamsPreset                     = (BehaviourParamsPreset)GetInt32(new IntPtr(p + 0x01C)); // 0x1C BehaviourParamsPreset       ( ModelEnumType BehaviourParamsPreset BehaviourParamsPreset BehaviourParamsPreset Int32 )

            return value;
        }
    }
}
