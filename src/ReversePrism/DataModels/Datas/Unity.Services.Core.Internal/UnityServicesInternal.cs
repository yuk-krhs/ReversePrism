using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 State                                    ModelEnumType ServicesInitializationState ServicesInitializationState ServicesInitializationState Int32
    // 014 CanInitialize                            ModelPrimitiveType bool bool bool Bool
    // 018 m_Initialization                         TaskCompletionSource`1<<object>> IL2CPP_TYPE_GENERICINST
    // 020 Registry                                 ModelClassType CoreRegistry CoreRegistry CoreRegistry Pointer
    // 028 Metrics                                  ModelClassType CoreMetrics CoreMetrics CoreMetrics Pointer
    // 030 Diagnostics                              ModelClassType CoreDiagnostics CoreDiagnostics CoreDiagnostics Pointer
    public partial class UnityServicesInternal : DataModel
    {
        public ServicesInitializationState              State                                   { get; set; }
        public bool                                     CanInitialize                           { get; set; }
        public CoreRegistry?                            Registry                                { get; set; }
        public CoreMetrics?                             Metrics                                 { get; set; }
        public CoreDiagnostics?                         Diagnostics                             { get; set; }

        public static UnityServicesInternal? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UnityServicesInternal() { Pointer= p0 };

            value.State                                     = (ServicesInitializationState)GetInt32(new IntPtr(p + 0x010)); // 0x10 State                       ( ModelEnumType ServicesInitializationState ServicesInitializationState ServicesInitializationState Int32 )
            value.CanInitialize                             = GetBool(new IntPtr(p + 0x014)); // 0x14 CanInitialize               ( ModelPrimitiveType bool bool bool Bool )
            value.Registry                                  = GetObject<CoreRegistry>(new IntPtr(p + 0x020), ReversePrism.DataModels.CoreRegistry.FromPointer); // 0x20 Registry                    ( ModelClassType CoreRegistry CoreRegistry CoreRegistry Pointer )
            value.Metrics                                   = GetObject<CoreMetrics>(new IntPtr(p + 0x028), ReversePrism.DataModels.CoreMetrics.FromPointer); // 0x28 Metrics                     ( ModelClassType CoreMetrics CoreMetrics CoreMetrics Pointer )
            value.Diagnostics                               = GetObject<CoreDiagnostics>(new IntPtr(p + 0x030), ReversePrism.DataModels.CoreDiagnostics.FromPointer); // 0x30 Diagnostics                 ( ModelClassType CoreDiagnostics CoreDiagnostics CoreDiagnostics Pointer )

            return value;
        }
    }
}
