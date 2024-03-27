using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 DefaultCoreMask                          ContextPropagationFlags IL2CPP_TYPE_VALUETYPE
    // 000 DefaultMask                              ContextPropagationFlags IL2CPP_TYPE_VALUETYPE
    // 010 ParentCall                               00018652DD30 ModelClassType CallSafeHandle CallSafeHandle CallSafeHandle Pointer
    // 018 Deadline                                 0001865BA1C0 ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 020 CancellationToken                        00018653D5A0 ModelEnumType CancellationToken CancellationToken CancellationToken Int32
    // 028 Options                                  000186616430 ModelClassType ContextPropagationOptions ContextPropagationOptions ContextPropagationOptions Pointer
    public partial class ContextPropagationTokenImpl
    {
        public CallSafeHandle?                          ParentCall                              { get; set; }
        public DateTime                                 Deadline                                { get; set; }
        public CancellationToken                        CancellationToken                       { get; set; }
        public ContextPropagationOptions?               Options                                 { get; set; }

        public static ContextPropagationTokenImpl? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ContextPropagationTokenImpl();

            value.ParentCall                                = GetObject<CallSafeHandle>(new IntPtr(p + 0x010), ReversePrism.DataModels.CallSafeHandle.FromPointer); // 0270D303C5B0 0x10 ParentCall                  ( 00018652DD30 ModelClassType CallSafeHandle CallSafeHandle CallSafeHandle Pointer )
            value.Deadline                                  = GetDateTime(new IntPtr(p + 0x018)); // 0270D303C5D0 0x18 Deadline                    ( 0001865BA1C0 ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.CancellationToken                         = (CancellationToken)GetInt32(new IntPtr(p + 0x020)); // 0270D303C5F0 0x20 CancellationToken           ( 00018653D5A0 ModelEnumType CancellationToken CancellationToken CancellationToken Int32 )
            value.Options                                   = GetObject<ContextPropagationOptions>(new IntPtr(p + 0x028), ReversePrism.DataModels.ContextPropagationOptions.FromPointer); // 0270D303C610 0x28 Options                     ( 000186616430 ModelClassType ContextPropagationOptions ContextPropagationOptions ContextPropagationOptions Pointer )

            return value;
        }
    }
}
