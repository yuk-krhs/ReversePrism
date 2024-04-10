using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TargetUrl                                000186672F10 ModelPrimitiveType string string string String
    // 018 M_RetryPolicy                            0001865283F0 ModelClassType ExponentialBackOffRetryPolicy ExponentialBackOffRetryPolicy ExponentialBackOffRetryPolicy Pointer
    // 020 M_Scheduler                              0001866ECE00 ModelClassType IActionScheduler IActionScheduler IActionScheduler Pointer
    // 028 M_RequestSender                          00018668BC90 ModelClassType IUnityWebRequestSender IUnityWebRequestSender IUnityWebRequestSender Pointer
    // 030 Serializer                               00018658BD20 ModelClassType IJsonSerializer IJsonSerializer IJsonSerializer Pointer
    public partial class TelemetrySender : DataModel
    {
        public string                                   TargetUrl                               { get; set; }
        public ExponentialBackOffRetryPolicy?           M_RetryPolicy                           { get; set; }
        public IActionScheduler?                        M_Scheduler                             { get; set; }
        public IUnityWebRequestSender?                  M_RequestSender                         { get; set; }
        public IJsonSerializer?                         Serializer                              { get; set; }

        public static TelemetrySender? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TelemetrySender() { Pointer= p0 };

            value.TargetUrl                                 = GetString(new IntPtr(p + 0x010)); // 0245A663E738 0x10 TargetUrl                   ( 000186672F10 ModelPrimitiveType string string string String )
            value.M_RetryPolicy                             = GetObject<ExponentialBackOffRetryPolicy>(new IntPtr(p + 0x018), ReversePrism.DataModels.ExponentialBackOffRetryPolicy.FromPointer); // 0245A663E758 0x18 M_RetryPolicy               ( 0001865283F0 ModelClassType ExponentialBackOffRetryPolicy ExponentialBackOffRetryPolicy ExponentialBackOffRetryPolicy Pointer )
            value.M_Scheduler                               = GetObject<IActionScheduler>(new IntPtr(p + 0x020), ReversePrism.DataModels.IActionScheduler.FromPointer); // 0245A663E778 0x20 M_Scheduler                 ( 0001866ECE00 ModelClassType IActionScheduler IActionScheduler IActionScheduler Pointer )
            value.M_RequestSender                           = GetObject<IUnityWebRequestSender>(new IntPtr(p + 0x028), ReversePrism.DataModels.IUnityWebRequestSender.FromPointer); // 0245A663E798 0x28 M_RequestSender             ( 00018668BC90 ModelClassType IUnityWebRequestSender IUnityWebRequestSender IUnityWebRequestSender Pointer )
            value.Serializer                                = GetObject<IJsonSerializer>(new IntPtr(p + 0x030), ReversePrism.DataModels.IJsonSerializer.FromPointer); // 0245A663E7B8 0x30 Serializer                  ( 00018658BD20 ModelClassType IJsonSerializer IJsonSerializer IJsonSerializer Pointer )

            return value;
        }
    }
}
