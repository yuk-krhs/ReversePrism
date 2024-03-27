using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 State                                    00018673B520 ModelEnumType ServicesInitializationState ServicesInitializationState ServicesInitializationState Int32
    // 018 Options                                  0001866F2260 ModelClassType InitializationOptions InitializationOptions InitializationOptions Pointer
    // 020 CanInitialize                            000186595210 ModelPrimitiveType bool bool bool Bool
    // 028 m_Initialization                         TaskCompletionSource`1<<object>> IL2CPP_TYPE_GENERICINST
    // 030 Registry                                 000186625910 ModelClassType CoreRegistry CoreRegistry CoreRegistry Pointer
    // 038 Metrics                                  000186624180 ModelClassType CoreMetrics CoreMetrics CoreMetrics Pointer
    // 040 Diagnostics                              000186623340 ModelClassType CoreDiagnostics CoreDiagnostics CoreDiagnostics Pointer
    public partial class UnityServicesInternal
    {
        public ServicesInitializationState              State                                   { get; set; }
        public InitializationOptions?                   Options                                 { get; set; }
        public bool                                     CanInitialize                           { get; set; }
        public CoreRegistry?                            Registry                                { get; set; }
        public CoreMetrics?                             Metrics                                 { get; set; }
        public CoreDiagnostics?                         Diagnostics                             { get; set; }

        public static UnityServicesInternal? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UnityServicesInternal();

            value.State                                     = (ServicesInitializationState)GetInt32(new IntPtr(p + 0x010)); // 0270D0876840 0x10 State                       ( 00018673B520 ModelEnumType ServicesInitializationState ServicesInitializationState ServicesInitializationState Int32 )
            value.Options                                   = GetObject<InitializationOptions>(new IntPtr(p + 0x018), ReversePrism.DataModels.InitializationOptions.FromPointer); // 0270D0876860 0x18 Options                     ( 0001866F2260 ModelClassType InitializationOptions InitializationOptions InitializationOptions Pointer )
            value.CanInitialize                             = GetBool(new IntPtr(p + 0x020)); // 0270D0876880 0x20 CanInitialize               ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.Registry                                  = GetObject<CoreRegistry>(new IntPtr(p + 0x030), ReversePrism.DataModels.CoreRegistry.FromPointer); // 0270D08768C0 0x30 Registry                    ( 000186625910 ModelClassType CoreRegistry CoreRegistry CoreRegistry Pointer )
            value.Metrics                                   = GetObject<CoreMetrics>(new IntPtr(p + 0x038), ReversePrism.DataModels.CoreMetrics.FromPointer); // 0270D08768E0 0x38 Metrics                     ( 000186624180 ModelClassType CoreMetrics CoreMetrics CoreMetrics Pointer )
            value.Diagnostics                               = GetObject<CoreDiagnostics>(new IntPtr(p + 0x040), ReversePrism.DataModels.CoreDiagnostics.FromPointer); // 0270D0876900 0x40 Diagnostics                 ( 000186623340 ModelClassType CoreDiagnostics CoreDiagnostics CoreDiagnostics Pointer )

            return value;
        }
    }
}
