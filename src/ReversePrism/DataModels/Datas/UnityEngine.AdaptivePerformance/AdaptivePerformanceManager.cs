using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ThermalEvent                             ModelClassType ThermalEventHandler ThermalEventHandler ThermalEventHandler Pointer
    // 028 PerformanceBottleneckChangeEvent         ModelClassType PerformanceBottleneckChangeHandler PerformanceBottleneckChangeHandler PerformanceBottleneckChangeHandler Pointer
    // 030 PerformanceLevelChangeEvent              ModelClassType PerformanceLevelChangeHandler PerformanceLevelChangeHandler PerformanceLevelChangeHandler Pointer
    // 038 PerformanceBoostChangeEvent              ModelClassType PerformanceBoostChangeHandler PerformanceBoostChangeHandler PerformanceBoostChangeHandler Pointer
    // 040 PerformanceModeEvent                     ModelClassType PerformanceModeEventHandler PerformanceModeEventHandler PerformanceModeEventHandler Pointer
    // 048 M_JustResumed                            ModelPrimitiveType bool bool bool Bool
    // 04C M_RequestedCpuLevel                      ModelPrimitiveType int int int Int32
    // 050 M_RequestedGpuLevel                      ModelPrimitiveType int int int Int32
    // 054 M_NewUserPerformanceLevelRequest         ModelPrimitiveType bool bool bool Bool
    // 055 M_RequestedCpuBoost                      ModelPrimitiveType bool bool bool Bool
    // 056 M_RequestedGpuBoost                      ModelPrimitiveType bool bool bool Bool
    // 057 M_NewUserCpuPerformanceBoostRequest      ModelPrimitiveType bool bool bool Bool
    // 058 M_NewUserGpuPerformanceBoostRequest      ModelPrimitiveType bool bool bool Bool
    // 05C M_ThermalMetrics                         ModelEnumType ThermalMetrics ThermalMetrics ThermalMetrics Int32
    // 068 M_PerformanceMetrics                     ModelEnumType PerformanceMetrics PerformanceMetrics PerformanceMetrics Int32
    // 084 M_FrameTiming                            ModelEnumType FrameTiming FrameTiming FrameTiming Int32
    // 09C M_PerformanceMode                        ModelEnumType PerformanceMode PerformanceMode PerformanceMode Int32
    // 0A0 LoggingFrequencyInFrames                 ModelPrimitiveType int int int Int32
    // 0A4 M_AutomaticPerformanceControl            ModelPrimitiveType bool bool bool Bool
    // 0A5 M_AutomaticPerformanceControlChanged     ModelPrimitiveType bool bool bool Bool
    // 0A8 Indexer                                  ModelClassType AdaptivePerformanceIndexer AdaptivePerformanceIndexer AdaptivePerformanceIndexer Pointer
    // 0B0 M_Settings                               ModelClassType IAdaptivePerformanceSettings IAdaptivePerformanceSettings IAdaptivePerformanceSettings Pointer
    // 0B8 M_Subsystem                              ModelClassType AdaptivePerformanceSubsystem AdaptivePerformanceSubsystem AdaptivePerformanceSubsystem Pointer
    // 0C0 M_DevicePerfControl                      ModelClassType DevicePerformanceControlImpl DevicePerformanceControlImpl DevicePerformanceControlImpl Pointer
    // 0C8 M_AutoPerformanceLevelController         ModelClassType AutoPerformanceLevelController AutoPerformanceLevelController AutoPerformanceLevelController Pointer
    // 0D0 M_CpuFrameTimeProvider                   ModelClassType CpuTimeProvider CpuTimeProvider CpuTimeProvider Pointer
    // 0D8 M_GpuFrameTimeProvider                   ModelClassType GpuTimeProvider GpuTimeProvider GpuTimeProvider Pointer
    // 0E0 M_AppLifecycle                           ModelClassType IApplicationLifecycle IApplicationLifecycle IApplicationLifecycle Pointer
    // 0E8 M_TemperatureTrend                       ModelClassType TemperatureTrend TemperatureTrend TemperatureTrend Pointer
    // 0F0 M_UseProviderOverallFrameTime            ModelPrimitiveType bool bool bool Bool
    // 0F8 M_WaitForEndOfFrame                      ModelClassType WaitForEndOfFrame WaitForEndOfFrame WaitForEndOfFrame Pointer
    // 100 M_FrameCount                             ModelPrimitiveType int int int Int32
    // 108 M_OverallFrameTime                       ModelClassType RunningAverage RunningAverage RunningAverage Pointer
    // 110 M_OverallFrameTimeAccu                   ModelPrimitiveType float float float Single
    // 118 M_GpuFrameTime                           ModelClassType RunningAverage RunningAverage RunningAverage Pointer
    // 120 M_CpuFrameTime                           ModelClassType RunningAverage RunningAverage RunningAverage Pointer
    public partial class AdaptivePerformanceManager : DataModel
    {
        public ThermalEventHandler?                     ThermalEvent                            { get; set; }
        public PerformanceBottleneckChangeHandler?      PerformanceBottleneckChangeEvent        { get; set; }
        public PerformanceLevelChangeHandler?           PerformanceLevelChangeEvent             { get; set; }
        public PerformanceBoostChangeHandler?           PerformanceBoostChangeEvent             { get; set; }
        public PerformanceModeEventHandler?             PerformanceModeEvent                    { get; set; }
        public bool                                     M_JustResumed                           { get; set; }
        public int                                      M_RequestedCpuLevel                     { get; set; }
        public int                                      M_RequestedGpuLevel                     { get; set; }
        public bool                                     M_NewUserPerformanceLevelRequest        { get; set; }
        public bool                                     M_RequestedCpuBoost                     { get; set; }
        public bool                                     M_RequestedGpuBoost                     { get; set; }
        public bool                                     M_NewUserCpuPerformanceBoostRequest     { get; set; }
        public bool                                     M_NewUserGpuPerformanceBoostRequest     { get; set; }
        public ThermalMetrics                           M_ThermalMetrics                        { get; set; }
        public PerformanceMetrics                       M_PerformanceMetrics                    { get; set; }
        public FrameTiming                              M_FrameTiming                           { get; set; }
        public PerformanceMode                          M_PerformanceMode                       { get; set; }
        public int                                      LoggingFrequencyInFrames                { get; set; }
        public bool                                     M_AutomaticPerformanceControl           { get; set; }
        public bool                                     M_AutomaticPerformanceControlChanged    { get; set; }
        public AdaptivePerformanceIndexer?              Indexer                                 { get; set; }
        public IAdaptivePerformanceSettings?            M_Settings                              { get; set; }
        public AdaptivePerformanceSubsystem?            M_Subsystem                             { get; set; }
        public DevicePerformanceControlImpl?            M_DevicePerfControl                     { get; set; }
        public AutoPerformanceLevelController?          M_AutoPerformanceLevelController        { get; set; }
        public CpuTimeProvider?                         M_CpuFrameTimeProvider                  { get; set; }
        public GpuTimeProvider?                         M_GpuFrameTimeProvider                  { get; set; }
        public IApplicationLifecycle?                   M_AppLifecycle                          { get; set; }
        public TemperatureTrend?                        M_TemperatureTrend                      { get; set; }
        public bool                                     M_UseProviderOverallFrameTime           { get; set; }
        public WaitForEndOfFrame?                       M_WaitForEndOfFrame                     { get; set; }
        public int                                      M_FrameCount                            { get; set; }
        public RunningAverage?                          M_OverallFrameTime                      { get; set; }
        public float                                    M_OverallFrameTimeAccu                  { get; set; }
        public RunningAverage?                          M_GpuFrameTime                          { get; set; }
        public RunningAverage?                          M_CpuFrameTime                          { get; set; }

        public static AdaptivePerformanceManager? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AdaptivePerformanceManager() { Pointer= p0 };

            value.ThermalEvent                              = GetObject<ThermalEventHandler>(new IntPtr(p + 0x020), ReversePrism.DataModels.ThermalEventHandler.FromPointer); // 0x20 ThermalEvent                ( ModelClassType ThermalEventHandler ThermalEventHandler ThermalEventHandler Pointer )
            value.PerformanceBottleneckChangeEvent          = GetObject<PerformanceBottleneckChangeHandler>(new IntPtr(p + 0x028), ReversePrism.DataModels.PerformanceBottleneckChangeHandler.FromPointer); // 0x28 PerformanceBottleneckChangeEvent ( ModelClassType PerformanceBottleneckChangeHandler PerformanceBottleneckChangeHandler PerformanceBottleneckChangeHandler Pointer )
            value.PerformanceLevelChangeEvent               = GetObject<PerformanceLevelChangeHandler>(new IntPtr(p + 0x030), ReversePrism.DataModels.PerformanceLevelChangeHandler.FromPointer); // 0x30 PerformanceLevelChangeEvent ( ModelClassType PerformanceLevelChangeHandler PerformanceLevelChangeHandler PerformanceLevelChangeHandler Pointer )
            value.PerformanceBoostChangeEvent               = GetObject<PerformanceBoostChangeHandler>(new IntPtr(p + 0x038), ReversePrism.DataModels.PerformanceBoostChangeHandler.FromPointer); // 0x38 PerformanceBoostChangeEvent ( ModelClassType PerformanceBoostChangeHandler PerformanceBoostChangeHandler PerformanceBoostChangeHandler Pointer )
            value.PerformanceModeEvent                      = GetObject<PerformanceModeEventHandler>(new IntPtr(p + 0x040), ReversePrism.DataModels.PerformanceModeEventHandler.FromPointer); // 0x40 PerformanceModeEvent        ( ModelClassType PerformanceModeEventHandler PerformanceModeEventHandler PerformanceModeEventHandler Pointer )
            value.M_JustResumed                             = GetBool(new IntPtr(p + 0x048)); // 0x48 M_JustResumed               ( ModelPrimitiveType bool bool bool Bool )
            value.M_RequestedCpuLevel                       = GetInt32(new IntPtr(p + 0x04C)); // 0x4C M_RequestedCpuLevel         ( ModelPrimitiveType int int int Int32 )
            value.M_RequestedGpuLevel                       = GetInt32(new IntPtr(p + 0x050)); // 0x50 M_RequestedGpuLevel         ( ModelPrimitiveType int int int Int32 )
            value.M_NewUserPerformanceLevelRequest          = GetBool(new IntPtr(p + 0x054)); // 0x54 M_NewUserPerformanceLevelRequest ( ModelPrimitiveType bool bool bool Bool )
            value.M_RequestedCpuBoost                       = GetBool(new IntPtr(p + 0x055)); // 0x55 M_RequestedCpuBoost         ( ModelPrimitiveType bool bool bool Bool )
            value.M_RequestedGpuBoost                       = GetBool(new IntPtr(p + 0x056)); // 0x56 M_RequestedGpuBoost         ( ModelPrimitiveType bool bool bool Bool )
            value.M_NewUserCpuPerformanceBoostRequest       = GetBool(new IntPtr(p + 0x057)); // 0x57 M_NewUserCpuPerformanceBoostRequest ( ModelPrimitiveType bool bool bool Bool )
            value.M_NewUserGpuPerformanceBoostRequest       = GetBool(new IntPtr(p + 0x058)); // 0x58 M_NewUserGpuPerformanceBoostRequest ( ModelPrimitiveType bool bool bool Bool )
            value.M_ThermalMetrics                          = (ThermalMetrics)GetInt32(new IntPtr(p + 0x05C)); // 0x5C M_ThermalMetrics            ( ModelEnumType ThermalMetrics ThermalMetrics ThermalMetrics Int32 )
            value.M_PerformanceMetrics                      = (PerformanceMetrics)GetInt32(new IntPtr(p + 0x068)); // 0x68 M_PerformanceMetrics        ( ModelEnumType PerformanceMetrics PerformanceMetrics PerformanceMetrics Int32 )
            value.M_FrameTiming                             = (FrameTiming)GetInt32(new IntPtr(p + 0x084)); // 0x84 M_FrameTiming               ( ModelEnumType FrameTiming FrameTiming FrameTiming Int32 )
            value.M_PerformanceMode                         = (PerformanceMode)GetInt32(new IntPtr(p + 0x09C)); // 0x9C M_PerformanceMode           ( ModelEnumType PerformanceMode PerformanceMode PerformanceMode Int32 )
            value.LoggingFrequencyInFrames                  = GetInt32(new IntPtr(p + 0x0A0)); // 0xA0 LoggingFrequencyInFrames    ( ModelPrimitiveType int int int Int32 )
            value.M_AutomaticPerformanceControl             = GetBool(new IntPtr(p + 0x0A4)); // 0xA4 M_AutomaticPerformanceControl ( ModelPrimitiveType bool bool bool Bool )
            value.M_AutomaticPerformanceControlChanged      = GetBool(new IntPtr(p + 0x0A5)); // 0xA5 M_AutomaticPerformanceControlChanged ( ModelPrimitiveType bool bool bool Bool )
            value.Indexer                                   = GetObject<AdaptivePerformanceIndexer>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.AdaptivePerformanceIndexer.FromPointer); // 0xA8 Indexer                     ( ModelClassType AdaptivePerformanceIndexer AdaptivePerformanceIndexer AdaptivePerformanceIndexer Pointer )
            value.M_Settings                                = GetObject<IAdaptivePerformanceSettings>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.IAdaptivePerformanceSettings.FromPointer); // 0xB0 M_Settings                  ( ModelClassType IAdaptivePerformanceSettings IAdaptivePerformanceSettings IAdaptivePerformanceSettings Pointer )
            value.M_Subsystem                               = GetObject<AdaptivePerformanceSubsystem>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.AdaptivePerformanceSubsystem.FromPointer); // 0xB8 M_Subsystem                 ( ModelClassType AdaptivePerformanceSubsystem AdaptivePerformanceSubsystem AdaptivePerformanceSubsystem Pointer )
            value.M_DevicePerfControl                       = GetObject<DevicePerformanceControlImpl>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.DevicePerformanceControlImpl.FromPointer); // 0xC0 M_DevicePerfControl         ( ModelClassType DevicePerformanceControlImpl DevicePerformanceControlImpl DevicePerformanceControlImpl Pointer )
            value.M_AutoPerformanceLevelController          = GetObject<AutoPerformanceLevelController>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.AutoPerformanceLevelController.FromPointer); // 0xC8 M_AutoPerformanceLevelController ( ModelClassType AutoPerformanceLevelController AutoPerformanceLevelController AutoPerformanceLevelController Pointer )
            value.M_CpuFrameTimeProvider                    = GetObject<CpuTimeProvider>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.CpuTimeProvider.FromPointer); // 0xD0 M_CpuFrameTimeProvider      ( ModelClassType CpuTimeProvider CpuTimeProvider CpuTimeProvider Pointer )
            value.M_GpuFrameTimeProvider                    = GetObject<GpuTimeProvider>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.GpuTimeProvider.FromPointer); // 0xD8 M_GpuFrameTimeProvider      ( ModelClassType GpuTimeProvider GpuTimeProvider GpuTimeProvider Pointer )
            value.M_AppLifecycle                            = GetObject<IApplicationLifecycle>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.IApplicationLifecycle.FromPointer); // 0xE0 M_AppLifecycle              ( ModelClassType IApplicationLifecycle IApplicationLifecycle IApplicationLifecycle Pointer )
            value.M_TemperatureTrend                        = GetObject<TemperatureTrend>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.TemperatureTrend.FromPointer); // 0xE8 M_TemperatureTrend          ( ModelClassType TemperatureTrend TemperatureTrend TemperatureTrend Pointer )
            value.M_UseProviderOverallFrameTime             = GetBool(new IntPtr(p + 0x0F0)); // 0xF0 M_UseProviderOverallFrameTime ( ModelPrimitiveType bool bool bool Bool )
            value.M_WaitForEndOfFrame                       = GetObject<WaitForEndOfFrame>(new IntPtr(p + 0x0F8), ReversePrism.DataModels.WaitForEndOfFrame.FromPointer); // 0xF8 M_WaitForEndOfFrame         ( ModelClassType WaitForEndOfFrame WaitForEndOfFrame WaitForEndOfFrame Pointer )
            value.M_FrameCount                              = GetInt32(new IntPtr(p + 0x100)); // 0x100 M_FrameCount                ( ModelPrimitiveType int int int Int32 )
            value.M_OverallFrameTime                        = GetObject<RunningAverage>(new IntPtr(p + 0x108), ReversePrism.DataModels.RunningAverage.FromPointer); // 0x108 M_OverallFrameTime          ( ModelClassType RunningAverage RunningAverage RunningAverage Pointer )
            value.M_OverallFrameTimeAccu                    = GetSingle(new IntPtr(p + 0x110)); // 0x110 M_OverallFrameTimeAccu      ( ModelPrimitiveType float float float Single )
            value.M_GpuFrameTime                            = GetObject<RunningAverage>(new IntPtr(p + 0x118), ReversePrism.DataModels.RunningAverage.FromPointer); // 0x118 M_GpuFrameTime              ( ModelClassType RunningAverage RunningAverage RunningAverage Pointer )
            value.M_CpuFrameTime                            = GetObject<RunningAverage>(new IntPtr(p + 0x120), ReversePrism.DataModels.RunningAverage.FromPointer); // 0x120 M_CpuFrameTime              ( ModelClassType RunningAverage RunningAverage RunningAverage Pointer )

            return value;
        }
    }
}
