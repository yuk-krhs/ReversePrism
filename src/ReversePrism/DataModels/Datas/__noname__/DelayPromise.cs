using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 pool                                     TaskPool`1<DelayPromise> IL2CPP_TYPE_GENERICINST
    // 010 NextNode                                 ModelClassType DelayPromise DelayPromise DelayPromise Pointer
    // 018 InitialFrame                             ModelPrimitiveType int int int Int32
    // 01C DelayTimeSpan                            ModelPrimitiveType float float float Single
    // 020 Elapsed                                  ModelPrimitiveType float float float Single
    // 028 CancellationToken                        ModelEnumType CancellationToken CancellationToken CancellationToken Int32
    // 030 CancellationTokenRegistration            ModelEnumType CancellationTokenRegistration CancellationTokenRegistration CancellationTokenRegistration Int32
    // 048 core                                     UniTaskCompletionSourceCore`1<<object>> IL2CPP_TYPE_GENERICINST
    public partial class DelayPromise : DataModel
    {
        public DelayPromise?                            NextNode                                { get; set; }
        public int                                      InitialFrame                            { get; set; }
        public float                                    DelayTimeSpan                           { get; set; }
        public float                                    Elapsed                                 { get; set; }
        public CancellationToken                        CancellationToken                       { get; set; }
        public CancellationTokenRegistration            CancellationTokenRegistration           { get; set; }

        public static DelayPromise? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DelayPromise() { Pointer= p0 };

            value.NextNode                                  = GetObject<DelayPromise>(new IntPtr(p + 0x010), ReversePrism.DataModels.DelayPromise.FromPointer); // 0x10 NextNode                    ( ModelClassType DelayPromise DelayPromise DelayPromise Pointer )
            value.InitialFrame                              = GetInt32(new IntPtr(p + 0x018)); // 0x18 InitialFrame                ( ModelPrimitiveType int int int Int32 )
            value.DelayTimeSpan                             = GetSingle(new IntPtr(p + 0x01C)); // 0x1C DelayTimeSpan               ( ModelPrimitiveType float float float Single )
            value.Elapsed                                   = GetSingle(new IntPtr(p + 0x020)); // 0x20 Elapsed                     ( ModelPrimitiveType float float float Single )
            value.CancellationToken                         = (CancellationToken)GetInt32(new IntPtr(p + 0x028)); // 0x28 CancellationToken           ( ModelEnumType CancellationToken CancellationToken CancellationToken Int32 )
            value.CancellationTokenRegistration             = (CancellationTokenRegistration)GetInt32(new IntPtr(p + 0x030)); // 0x30 CancellationTokenRegistration ( ModelEnumType CancellationTokenRegistration CancellationTokenRegistration CancellationTokenRegistration Int32 )

            return value;
        }
    }
}
