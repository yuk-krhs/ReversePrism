using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Context                                  ModelClassType SynchronizationContext SynchronizationContext SynchronizationContext Pointer
    // 018 <tag>k__BackingField                     <object> IL2CPP_TYPE_OBJECT
    // 020 Url                                      ModelPrimitiveType string string string String
    // 028 Method                                   ModelClassType Method Method Method Pointer
    // 030 <requestHeaders>k__BackingField          Dictionary`2<string, List`1<string>> IL2CPP_TYPE_GENERICINST
    // 038 Body                                     ModelPrimitiveType string string string String
    // 040 SuccessCallback                          ModelClassType OnResponseCallback OnResponseCallback OnResponseCallback Pointer
    // 048 FailureCallback                          ModelClassType OnResponseCallback OnResponseCallback OnResponseCallback Pointer
    // 050 NetworkErrorCallback                     ModelClassType OnNetworkErrorCallback OnNetworkErrorCallback OnNetworkErrorCallback Pointer
    public partial class RequestTask : DataModel
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
            var value   = new RequestTask() { Pointer= p0 };

            value.Context                                   = GetObject<SynchronizationContext>(new IntPtr(p + 0x010), ReversePrism.DataModels.SynchronizationContext.FromPointer); // 0x10 Context                     ( ModelClassType SynchronizationContext SynchronizationContext SynchronizationContext Pointer )
            value.Url                                       = GetString(new IntPtr(p + 0x020)); // 0x20 Url                         ( ModelPrimitiveType string string string String )
            value.Method                                    = GetObject<Method>(new IntPtr(p + 0x028), ReversePrism.DataModels.Method.FromPointer); // 0x28 Method                      ( ModelClassType Method Method Method Pointer )
            value.Body                                      = GetString(new IntPtr(p + 0x038)); // 0x38 Body                        ( ModelPrimitiveType string string string String )
            value.SuccessCallback                           = GetObject<OnResponseCallback>(new IntPtr(p + 0x040), ReversePrism.DataModels.OnResponseCallback.FromPointer); // 0x40 SuccessCallback             ( ModelClassType OnResponseCallback OnResponseCallback OnResponseCallback Pointer )
            value.FailureCallback                           = GetObject<OnResponseCallback>(new IntPtr(p + 0x048), ReversePrism.DataModels.OnResponseCallback.FromPointer); // 0x48 FailureCallback             ( ModelClassType OnResponseCallback OnResponseCallback OnResponseCallback Pointer )
            value.NetworkErrorCallback                      = GetObject<OnNetworkErrorCallback>(new IntPtr(p + 0x050), ReversePrism.DataModels.OnNetworkErrorCallback.FromPointer); // 0x50 NetworkErrorCallback        ( ModelClassType OnNetworkErrorCallback OnNetworkErrorCallback OnNetworkErrorCallback Pointer )

            return value;
        }
    }
}
