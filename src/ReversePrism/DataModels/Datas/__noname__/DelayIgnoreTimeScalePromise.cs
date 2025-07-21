using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 pool                                     TaskPool`1<DelayIgnoreTimeScalePromise> IL2CPP_TYPE_GENERICINST
    // 010 NextNode                                 ModelClassType DelayIgnoreTimeScalePromise DelayIgnoreTimeScalePromise DelayIgnoreTimeScalePromise Pointer
    // 018 DelayFrameTimeSpan                       ModelPrimitiveType float float float Single
    // 01C Elapsed                                  ModelPrimitiveType float float float Single
    // 020 InitialFrame                             ModelPrimitiveType int int int Int32
    // 028 CancellationToken                        ModelEnumType CancellationToken CancellationToken CancellationToken Int32
    // 030 CancellationTokenRegistration            ModelEnumType CancellationTokenRegistration CancellationTokenRegistration CancellationTokenRegistration Int32
    // 048 core                                     UniTaskCompletionSourceCore`1<<object>> IL2CPP_TYPE_GENERICINST
    public partial class DelayIgnoreTimeScalePromise : DataModel
    {
        public DelayIgnoreTimeScalePromise?             NextNode                                { get; set; }
        public float                                    DelayFrameTimeSpan                      { get; set; }
        public float                                    Elapsed                                 { get; set; }
        public int                                      InitialFrame                            { get; set; }
        public CancellationToken                        CancellationToken                       { get; set; }
        public CancellationTokenRegistration            CancellationTokenRegistration           { get; set; }

        public static DelayIgnoreTimeScalePromise? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DelayIgnoreTimeScalePromise() { Pointer= p0 };

            value.NextNode                                  = GetObject<DelayIgnoreTimeScalePromise>(new IntPtr(p + 0x010), ReversePrism.DataModels.DelayIgnoreTimeScalePromise.FromPointer); // 0x10 NextNode                    ( ModelClassType DelayIgnoreTimeScalePromise DelayIgnoreTimeScalePromise DelayIgnoreTimeScalePromise Pointer )
            value.DelayFrameTimeSpan                        = GetSingle(new IntPtr(p + 0x018)); // 0x18 DelayFrameTimeSpan          ( ModelPrimitiveType float float float Single )
            value.Elapsed                                   = GetSingle(new IntPtr(p + 0x01C)); // 0x1C Elapsed                     ( ModelPrimitiveType float float float Single )
            value.InitialFrame                              = GetInt32(new IntPtr(p + 0x020)); // 0x20 InitialFrame                ( ModelPrimitiveType int int int Int32 )
            value.CancellationToken                         = (CancellationToken)GetInt32(new IntPtr(p + 0x028)); // 0x28 CancellationToken           ( ModelEnumType CancellationToken CancellationToken CancellationToken Int32 )
            value.CancellationTokenRegistration             = (CancellationTokenRegistration)GetInt32(new IntPtr(p + 0x030)); // 0x30 CancellationTokenRegistration ( ModelEnumType CancellationTokenRegistration CancellationTokenRegistration CancellationTokenRegistration Int32 )

            return value;
        }
    }
}
