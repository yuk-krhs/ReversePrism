using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_UseProviderTrend                       000186594D10 ModelPrimitiveType bool bool bool Bool
    // 018 M_SumX                                   0001865C2950 ModelPrimitiveType double double double Double
    // 020 M_SumY                                   0001865C2950 ModelPrimitiveType double double double Double
    // 028 M_SumXY                                  0001865C2950 ModelPrimitiveType double double double Double
    // 030 M_SumXX                                  0001865C2950 ModelPrimitiveType double double double Double
    // 000 MeasurementTimeframeSeconds              int IL2CPP_TYPE_I4
    // 000 UpdateFrequency                          int IL2CPP_TYPE_I4
    // 000 SamplesCapacity                          int IL2CPP_TYPE_I4
    // 000 SlopeAtMaxTrend                          double IL2CPP_TYPE_R8
    // 038 M_TimeStamps                             000185B80520 ModelPrimitiveListType float[] float[] List<float> Pointer
    // 040 M_Temperature                            000185B80520 ModelPrimitiveListType float[] float[] List<float> Pointer
    // 048 M_NumValues                              0001865F2AF0 ModelPrimitiveType int int int Int32
    // 04C M_NextValueIndex                         0001865F2AF0 ModelPrimitiveType int int int Int32
    // 050 M_OldestValueIndex                       0001865F2AF0 ModelPrimitiveType int int int Int32
    // 054 ThermalTrend                             0001866656B0 ModelPrimitiveType float float float Single
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

            value.M_UseProviderTrend                        = GetBool(new IntPtr(p + 0x010)); // 02466B6F0598 0x10 M_UseProviderTrend          ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_SumX                                    = GetDouble(new IntPtr(p + 0x018)); // 02466B6F05B8 0x18 M_SumX                      ( 0001865C2950 ModelPrimitiveType double double double Double )
            value.M_SumY                                    = GetDouble(new IntPtr(p + 0x020)); // 02466B6F05D8 0x20 M_SumY                      ( 0001865C2950 ModelPrimitiveType double double double Double )
            value.M_SumXY                                   = GetDouble(new IntPtr(p + 0x028)); // 02466B6F05F8 0x28 M_SumXY                     ( 0001865C2950 ModelPrimitiveType double double double Double )
            value.M_SumXX                                   = GetDouble(new IntPtr(p + 0x030)); // 02466B6F0618 0x30 M_SumXX                     ( 0001865C2950 ModelPrimitiveType double double double Double )
            value.M_TimeStamps                              = GetSingleList(new IntPtr(p + 0x038)); // 02466B6F06B8 0x38 M_TimeStamps                ( 000185B80520 ModelPrimitiveListType float[] float[] List<float> Pointer )
            value.M_Temperature                             = GetSingleList(new IntPtr(p + 0x040)); // 02466B6F06D8 0x40 M_Temperature               ( 000185B80520 ModelPrimitiveListType float[] float[] List<float> Pointer )
            value.M_NumValues                               = GetInt32(new IntPtr(p + 0x048)); // 02466B6F06F8 0x48 M_NumValues                 ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_NextValueIndex                          = GetInt32(new IntPtr(p + 0x04C)); // 02466B6F0718 0x4C M_NextValueIndex            ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_OldestValueIndex                        = GetInt32(new IntPtr(p + 0x050)); // 02466B6F0738 0x50 M_OldestValueIndex          ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ThermalTrend                              = GetSingle(new IntPtr(p + 0x054)); // 02466B6F0758 0x54 ThermalTrend                ( 0001866656B0 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
