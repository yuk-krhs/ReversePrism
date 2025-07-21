using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 k_PackageVersion                         string IL2CPP_TYPE_STRING
    // 018 K_Version                                ModelPrimitiveType string string string String
    // 020 M_NativeStoreProvider                    ModelClassType INativeStoreProvider INativeStoreProvider INativeStoreProvider Pointer
    // 028 M_RuntimePlatform                        ModelEnumType RuntimePlatform RuntimePlatform RuntimePlatform Int32
    // 000 ModuleInstance                           StandardPurchasingModule IL2CPP_TYPE_CLASS
    // 030 Util                                     ModelClassType IUtil IUtil IUtil Pointer
    // 038 Logger                                   ModelClassType ILogger ILogger ILogger Pointer
    // 040 StoreInstance                            ModelClassType StoreInstance StoreInstance StoreInstance Pointer
    // 048 TelemetryMetricsInstanceWrapper          ModelClassType ITelemetryMetricsInstanceWrapper ITelemetryMetricsInstanceWrapper ITelemetryMetricsInstanceWrapper Pointer
    // 050 TelemetryDiagnosticsInstanceWrapper      ModelClassType ITelemetryDiagnosticsInstanceWrapper ITelemetryDiagnosticsInstanceWrapper ITelemetryDiagnosticsInstanceWrapper Pointer
    // 008 AndroidStoreNameMap                      Dictionary`2<AppStore, string> IL2CPP_TYPE_GENERICINST
    // 058 AppStore                                 ModelEnumType AppStore AppStore AppStore Int32
    // 05C UsingMockMicrosoft                       ModelPrimitiveType bool bool bool Bool
    // 060 UseFakeStoreUIMode                       ModelEnumType FakeStoreUIMode FakeStoreUIMode FakeStoreUIMode Int32
    // 064 UseFakeStoreAlways                       ModelPrimitiveType bool bool bool Bool
    // 068 WindowsStore                             ModelClassType WinRTStore WinRTStore WinRTStore Pointer
    public partial class StandardPurchasingModule : DataModel
    {
        public string                                   K_Version                               { get; set; }
        public INativeStoreProvider?                    M_NativeStoreProvider                   { get; set; }
        public RuntimePlatform                          M_RuntimePlatform                       { get; set; }
        public IUtil?                                   Util                                    { get; set; }
        public ILogger?                                 Logger                                  { get; set; }
        public StoreInstance?                           StoreInstance                           { get; set; }
        public ITelemetryMetricsInstanceWrapper?        TelemetryMetricsInstanceWrapper         { get; set; }
        public ITelemetryDiagnosticsInstanceWrapper?    TelemetryDiagnosticsInstanceWrapper     { get; set; }
        public AppStore                                 AppStore                                { get; set; }
        public bool                                     UsingMockMicrosoft                      { get; set; }
        public FakeStoreUIMode                          UseFakeStoreUIMode                      { get; set; }
        public bool                                     UseFakeStoreAlways                      { get; set; }
        public WinRTStore?                              WindowsStore                            { get; set; }

        public static StandardPurchasingModule? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StandardPurchasingModule() { Pointer= p0 };

            value.K_Version                                 = GetString(new IntPtr(p + 0x018)); // 0x18 K_Version                   ( ModelPrimitiveType string string string String )
            value.M_NativeStoreProvider                     = GetObject<INativeStoreProvider>(new IntPtr(p + 0x020), ReversePrism.DataModels.INativeStoreProvider.FromPointer); // 0x20 M_NativeStoreProvider       ( ModelClassType INativeStoreProvider INativeStoreProvider INativeStoreProvider Pointer )
            value.M_RuntimePlatform                         = (RuntimePlatform)GetInt32(new IntPtr(p + 0x028)); // 0x28 M_RuntimePlatform           ( ModelEnumType RuntimePlatform RuntimePlatform RuntimePlatform Int32 )
            value.Util                                      = GetObject<IUtil>(new IntPtr(p + 0x030), ReversePrism.DataModels.IUtil.FromPointer); // 0x30 Util                        ( ModelClassType IUtil IUtil IUtil Pointer )
            value.Logger                                    = GetObject<ILogger>(new IntPtr(p + 0x038), ReversePrism.DataModels.ILogger.FromPointer); // 0x38 Logger                      ( ModelClassType ILogger ILogger ILogger Pointer )
            value.StoreInstance                             = GetObject<StoreInstance>(new IntPtr(p + 0x040), ReversePrism.DataModels.StoreInstance.FromPointer); // 0x40 StoreInstance               ( ModelClassType StoreInstance StoreInstance StoreInstance Pointer )
            value.TelemetryMetricsInstanceWrapper           = GetObject<ITelemetryMetricsInstanceWrapper>(new IntPtr(p + 0x048), ReversePrism.DataModels.ITelemetryMetricsInstanceWrapper.FromPointer); // 0x48 TelemetryMetricsInstanceWrapper ( ModelClassType ITelemetryMetricsInstanceWrapper ITelemetryMetricsInstanceWrapper ITelemetryMetricsInstanceWrapper Pointer )
            value.TelemetryDiagnosticsInstanceWrapper       = GetObject<ITelemetryDiagnosticsInstanceWrapper>(new IntPtr(p + 0x050), ReversePrism.DataModels.ITelemetryDiagnosticsInstanceWrapper.FromPointer); // 0x50 TelemetryDiagnosticsInstanceWrapper ( ModelClassType ITelemetryDiagnosticsInstanceWrapper ITelemetryDiagnosticsInstanceWrapper ITelemetryDiagnosticsInstanceWrapper Pointer )
            value.AppStore                                  = (AppStore)GetInt32(new IntPtr(p + 0x058)); // 0x58 AppStore                    ( ModelEnumType AppStore AppStore AppStore Int32 )
            value.UsingMockMicrosoft                        = GetBool(new IntPtr(p + 0x05C)); // 0x5C UsingMockMicrosoft          ( ModelPrimitiveType bool bool bool Bool )
            value.UseFakeStoreUIMode                        = (FakeStoreUIMode)GetInt32(new IntPtr(p + 0x060)); // 0x60 UseFakeStoreUIMode          ( ModelEnumType FakeStoreUIMode FakeStoreUIMode FakeStoreUIMode Int32 )
            value.UseFakeStoreAlways                        = GetBool(new IntPtr(p + 0x064)); // 0x64 UseFakeStoreAlways          ( ModelPrimitiveType bool bool bool Bool )
            value.WindowsStore                              = GetObject<WinRTStore>(new IntPtr(p + 0x068), ReversePrism.DataModels.WinRTStore.FromPointer); // 0x68 WindowsStore                ( ModelClassType WinRTStore WinRTStore WinRTStore Pointer )

            return value;
        }
    }
}
