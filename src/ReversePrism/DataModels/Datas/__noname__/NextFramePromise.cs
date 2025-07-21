using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 pool                                     TaskPool`1<NextFramePromise> IL2CPP_TYPE_GENERICINST
    // 010 NextNode                                 ModelClassType NextFramePromise NextFramePromise NextFramePromise Pointer
    // 018 FrameCount                               ModelPrimitiveType int int int Int32
    // 020 core                                     UniTaskCompletionSourceCore`1<AsyncUnit> IL2CPP_TYPE_GENERICINST
    // 048 CancellationToken                        ModelEnumType CancellationToken CancellationToken CancellationToken Int32
    // 050 CancellationTokenRegistration            ModelEnumType CancellationTokenRegistration CancellationTokenRegistration CancellationTokenRegistration Int32
    public partial class NextFramePromise : DataModel
    {
        public NextFramePromise?                        NextNode                                { get; set; }
        public int                                      FrameCount                              { get; set; }
        public CancellationToken                        CancellationToken                       { get; set; }
        public CancellationTokenRegistration            CancellationTokenRegistration           { get; set; }

        public static NextFramePromise? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NextFramePromise() { Pointer= p0 };

            value.NextNode                                  = GetObject<NextFramePromise>(new IntPtr(p + 0x010), ReversePrism.DataModels.NextFramePromise.FromPointer); // 0x10 NextNode                    ( ModelClassType NextFramePromise NextFramePromise NextFramePromise Pointer )
            value.FrameCount                                = GetInt32(new IntPtr(p + 0x018)); // 0x18 FrameCount                  ( ModelPrimitiveType int int int Int32 )
            value.CancellationToken                         = (CancellationToken)GetInt32(new IntPtr(p + 0x048)); // 0x48 CancellationToken           ( ModelEnumType CancellationToken CancellationToken CancellationToken Int32 )
            value.CancellationTokenRegistration             = (CancellationTokenRegistration)GetInt32(new IntPtr(p + 0x050)); // 0x50 CancellationTokenRegistration ( ModelEnumType CancellationTokenRegistration CancellationTokenRegistration CancellationTokenRegistration Int32 )

            return value;
        }
    }
}
