using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 pool                                     TaskPool`1<WaitForEndOfFramePromise> IL2CPP_TYPE_GENERICINST
    // 010 NextNode                                 ModelClassType WaitForEndOfFramePromise WaitForEndOfFramePromise WaitForEndOfFramePromise Pointer
    // 018 core                                     UniTaskCompletionSourceCore`1<<object>> IL2CPP_TYPE_GENERICINST
    // 040 CancellationToken                        ModelEnumType CancellationToken CancellationToken CancellationToken Int32
    // 048 CancellationTokenRegistration            ModelEnumType CancellationTokenRegistration CancellationTokenRegistration CancellationTokenRegistration Int32
    // 010 WaitForEndOfFrameYieldInstruction        ModelClassType WaitForEndOfFrame WaitForEndOfFrame WaitForEndOfFrame Pointer
    // 060 IsFirst                                  ModelPrimitiveType bool bool bool Bool
    public partial class WaitForEndOfFramePromise : DataModel
    {
        public WaitForEndOfFramePromise?                NextNode                                { get; set; }
        public CancellationToken                        CancellationToken                       { get; set; }
        public CancellationTokenRegistration            CancellationTokenRegistration           { get; set; }
        public WaitForEndOfFrame?                       WaitForEndOfFrameYieldInstruction       { get; set; }
        public bool                                     IsFirst                                 { get; set; }

        public static WaitForEndOfFramePromise? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new WaitForEndOfFramePromise() { Pointer= p0 };

            value.NextNode                                  = GetObject<WaitForEndOfFramePromise>(new IntPtr(p + 0x010), ReversePrism.DataModels.WaitForEndOfFramePromise.FromPointer); // 0x10 NextNode                    ( ModelClassType WaitForEndOfFramePromise WaitForEndOfFramePromise WaitForEndOfFramePromise Pointer )
            value.CancellationToken                         = (CancellationToken)GetInt32(new IntPtr(p + 0x040)); // 0x40 CancellationToken           ( ModelEnumType CancellationToken CancellationToken CancellationToken Int32 )
            value.CancellationTokenRegistration             = (CancellationTokenRegistration)GetInt32(new IntPtr(p + 0x048)); // 0x48 CancellationTokenRegistration ( ModelEnumType CancellationTokenRegistration CancellationTokenRegistration CancellationTokenRegistration Int32 )
            value.WaitForEndOfFrameYieldInstruction         = GetObject<WaitForEndOfFrame>(new IntPtr(p + 0x010), ReversePrism.DataModels.WaitForEndOfFrame.FromPointer); // 0x10 WaitForEndOfFrameYieldInstruction ( ModelClassType WaitForEndOfFrame WaitForEndOfFrame WaitForEndOfFrame Pointer )
            value.IsFirst                                   = GetBool(new IntPtr(p + 0x060)); // 0x60 IsFirst                     ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
