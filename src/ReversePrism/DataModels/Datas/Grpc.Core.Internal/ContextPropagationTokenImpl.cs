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
    // 010 ParentCall                               ModelClassType CallSafeHandle CallSafeHandle CallSafeHandle Pointer
    // 018 Deadline                                 ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 020 CancellationToken                        ModelEnumType CancellationToken CancellationToken CancellationToken Int32
    // 028 Options                                  ModelClassType ContextPropagationOptions ContextPropagationOptions ContextPropagationOptions Pointer
    public partial class ContextPropagationTokenImpl : DataModel
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
            var value   = new ContextPropagationTokenImpl() { Pointer= p0 };

            value.ParentCall                                = GetObject<CallSafeHandle>(new IntPtr(p + 0x010), ReversePrism.DataModels.CallSafeHandle.FromPointer); // 0x10 ParentCall                  ( ModelClassType CallSafeHandle CallSafeHandle CallSafeHandle Pointer )
            value.Deadline                                  = GetDateTime(new IntPtr(p + 0x018)); // 0x18 Deadline                    ( ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.CancellationToken                         = (CancellationToken)GetInt32(new IntPtr(p + 0x020)); // 0x20 CancellationToken           ( ModelEnumType CancellationToken CancellationToken CancellationToken Int32 )
            value.Options                                   = GetObject<ContextPropagationOptions>(new IntPtr(p + 0x028), ReversePrism.DataModels.ContextPropagationOptions.FromPointer); // 0x28 Options                     ( ModelClassType ContextPropagationOptions ContextPropagationOptions ContextPropagationOptions Pointer )

            return value;
        }
    }
}
