using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Context                                  000186601DB0 ModelClassType SynchronizationContext SynchronizationContext SynchronizationContext Pointer
    // 018 <tag>k__BackingField                     <object> IL2CPP_TYPE_OBJECT
    // 020 Url                                      000186671910 ModelPrimitiveType string string string String
    // 028 Method                                   00018660DFF0 ModelClassType Method Method Method Pointer
    // 030 <requestHeaders>k__BackingField          Dictionary`2<string, List`1<string>> IL2CPP_TYPE_GENERICINST
    // 038 Body                                     000186671910 ModelPrimitiveType string string string String
    // 040 SuccessCallback                          0001866DB690 ModelClassType OnResponseCallback OnResponseCallback OnResponseCallback Pointer
    // 048 FailureCallback                          0001866DB690 ModelClassType OnResponseCallback OnResponseCallback OnResponseCallback Pointer
    // 050 NetworkErrorCallback                     0001866DAD10 ModelClassType OnNetworkErrorCallback OnNetworkErrorCallback OnNetworkErrorCallback Pointer
    public partial class RequestTask
    {
        public SynchronizationContext?                  Context                                 { get; set; }
        public string                                   Url                                     { get; set; }
        public Method?                                  Method                                  { get; set; }
        public string                                   Body                                    { get; set; }
        public OnResponseCallback?                      SuccessCallback                         { get; set; }
        public OnResponseCallback?                      FailureCallback                         { get; set; }
        public OnNetworkErrorCallback?                  NetworkErrorCallback                    { get; set; }

        public static RequestTask? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RequestTask();

            value.Context                                   = GetObject<SynchronizationContext>(new IntPtr(p + 0x010), ReversePrism.DataModels.SynchronizationContext.FromPointer); // 027004C15DD0 0x10 Context                     ( 000186601DB0 ModelClassType SynchronizationContext SynchronizationContext SynchronizationContext Pointer )
            value.Url                                       = GetString(new IntPtr(p + 0x020)); // 027004C15E10 0x20 Url                         ( 000186671910 ModelPrimitiveType string string string String )
            value.Method                                    = GetObject<Method>(new IntPtr(p + 0x028), ReversePrism.DataModels.Method.FromPointer); // 027004C15E30 0x28 Method                      ( 00018660DFF0 ModelClassType Method Method Method Pointer )
            value.Body                                      = GetString(new IntPtr(p + 0x038)); // 027004C15E70 0x38 Body                        ( 000186671910 ModelPrimitiveType string string string String )
            value.SuccessCallback                           = GetObject<OnResponseCallback>(new IntPtr(p + 0x040), ReversePrism.DataModels.OnResponseCallback.FromPointer); // 027004C15E90 0x40 SuccessCallback             ( 0001866DB690 ModelClassType OnResponseCallback OnResponseCallback OnResponseCallback Pointer )
            value.FailureCallback                           = GetObject<OnResponseCallback>(new IntPtr(p + 0x048), ReversePrism.DataModels.OnResponseCallback.FromPointer); // 027004C15EB0 0x48 FailureCallback             ( 0001866DB690 ModelClassType OnResponseCallback OnResponseCallback OnResponseCallback Pointer )
            value.NetworkErrorCallback                      = GetObject<OnNetworkErrorCallback>(new IntPtr(p + 0x050), ReversePrism.DataModels.OnNetworkErrorCallback.FromPointer); // 027004C15ED0 0x50 NetworkErrorCallback        ( 0001866DAD10 ModelClassType OnNetworkErrorCallback OnNetworkErrorCallback OnNetworkErrorCallback Pointer )

            return value;
        }
    }
}
