using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_UseProviderTrend                       ModelPrimitiveType bool bool bool Bool
    // 018 M_SumX                                   ModelPrimitiveType double double double Double
    // 020 M_SumY                                   ModelPrimitiveType double double double Double
    // 028 M_SumXY                                  ModelPrimitiveType double double double Double
    // 030 M_SumXX                                  ModelPrimitiveType double double double Double
    // 000 MeasurementTimeframeSeconds              int IL2CPP_TYPE_I4
    // 000 UpdateFrequency                          int IL2CPP_TYPE_I4
    // 000 SamplesCapacity                          int IL2CPP_TYPE_I4
    // 000 SlopeAtMaxTrend                          double IL2CPP_TYPE_R8
    // 038 M_TimeStamps                             ModelPrimitiveListType float[] float[] List<float> Pointer
    // 040 M_Temperature                            ModelPrimitiveListType float[] float[] List<float> Pointer
    // 048 M_NumValues                              ModelPrimitiveType int int int Int32
    // 04C M_NextValueIndex                         ModelPrimitiveType int int int Int32
    // 050 M_OldestValueIndex                       ModelPrimitiveType int int int Int32
    // 054 ThermalTrend                             ModelPrimitiveType float float float Single
    public partial class TemperatureTrend : DataModel
    {
        public bool                                     M_UseProviderTrend                      { get; set; }
        public double                                   M_SumX                                  { get; set; }
        public double                                   M_SumY                                  { get; set; }
        public double                                   M_SumXY                                 { get; set; }
        public double                                   M_SumXX                                 { get; set; }
        public List<float>?                             M_TimeStamps                            { get; set; }
        public List<float>?                             M_Temperature                           { get; set; }
        public int                                      M_NumValues                             { get; set; }
        public int                                      M_NextValueIndex                        { get; set; }
        public int                                      M_OldestValueIndex                      { get; set; }
        public float                                    ThermalTrend                            { get; set; }

        public static TemperatureTrend? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TemperatureTrend() { Pointer= p0 };

            value.M_UseProviderTrend                        = GetBool(new IntPtr(p + 0x010)); // 0x10 M_UseProviderTrend          ( ModelPrimitiveType bool bool bool Bool )
            value.M_SumX                                    = GetDouble(new IntPtr(p + 0x018)); // 0x18 M_SumX                      ( ModelPrimitiveType double double double Double )
            value.M_SumY                                    = GetDouble(new IntPtr(p + 0x020)); // 0x20 M_SumY                      ( ModelPrimitiveType double double double Double )
            value.M_SumXY                                   = GetDouble(new IntPtr(p + 0x028)); // 0x28 M_SumXY                     ( ModelPrimitiveType double double double Double )
            value.M_SumXX                                   = GetDouble(new IntPtr(p + 0x030)); // 0x30 M_SumXX                     ( ModelPrimitiveType double double double Double )
            value.M_TimeStamps                              = GetSingleList(new IntPtr(p + 0x038)); // 0x38 M_TimeStamps                ( ModelPrimitiveListType float[] float[] List<float> Pointer )
            value.M_Temperature                             = GetSingleList(new IntPtr(p + 0x040)); // 0x40 M_Temperature               ( ModelPrimitiveListType float[] float[] List<float> Pointer )
            value.M_NumValues                               = GetInt32(new IntPtr(p + 0x048)); // 0x48 M_NumValues                 ( ModelPrimitiveType int int int Int32 )
            value.M_NextValueIndex                          = GetInt32(new IntPtr(p + 0x04C)); // 0x4C M_NextValueIndex            ( ModelPrimitiveType int int int Int32 )
            value.M_OldestValueIndex                        = GetInt32(new IntPtr(p + 0x050)); // 0x50 M_OldestValueIndex          ( ModelPrimitiveType int int int Int32 )
            value.ThermalTrend                              = GetSingle(new IntPtr(p + 0x054)); // 0x54 ThermalTrend                ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
