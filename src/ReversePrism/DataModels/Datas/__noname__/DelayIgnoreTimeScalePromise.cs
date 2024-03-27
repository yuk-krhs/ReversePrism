using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 pool                                     TaskPool`1<DelayIgnoreTimeScalePromise> IL2CPP_TYPE_GENERICINST
    // 010 NextNode                                 000186717B40 ModelClassType DelayIgnoreTimeScalePromise DelayIgnoreTimeScalePromise DelayIgnoreTimeScalePromise Pointer
    // 018 DelayFrameTimeSpan                       0001866656B0 ModelPrimitiveType float float float Single
    // 01C Elapsed                                  0001866656B0 ModelPrimitiveType float float float Single
    // 020 InitialFrame                             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 028 CancellationToken                        00018653CB00 ModelEnumType CancellationToken CancellationToken CancellationToken Int32
    // 030 core                                     UniTaskCompletionSourceCore`1<<object>> IL2CPP_TYPE_GENERICINST
    public partial class DelayIgnoreTimeScalePromise
    {
        public DelayIgnoreTimeScalePromise?             NextNode                                { get; set; }
        public float                                    DelayFrameTimeSpan                      { get; set; }
        public float                                    Elapsed                                 { get; set; }
        public int                                      InitialFrame                            { get; set; }
        public CancellationToken                        CancellationToken                       { get; set; }

        public static DelayIgnoreTimeScalePromise? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DelayIgnoreTimeScalePromise();

            value.NextNode                                  = GetObject<DelayIgnoreTimeScalePromise>(new IntPtr(p + 0x010), ReversePrism.DataModels.DelayIgnoreTimeScalePromise.FromPointer); // 0270D8BEBA90 0x10 NextNode                    ( 000186717B40 ModelClassType DelayIgnoreTimeScalePromise DelayIgnoreTimeScalePromise DelayIgnoreTimeScalePromise Pointer )
            value.DelayFrameTimeSpan                        = GetSingle(new IntPtr(p + 0x018)); // 0270D8BEBAB0 0x18 DelayFrameTimeSpan          ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.Elapsed                                   = GetSingle(new IntPtr(p + 0x01C)); // 0270D8BEBAD0 0x1C Elapsed                     ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.InitialFrame                              = GetInt32(new IntPtr(p + 0x020)); // 0270D8BEBAF0 0x20 InitialFrame                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.CancellationToken                         = (CancellationToken)GetInt32(new IntPtr(p + 0x028)); // 0270D8BEBB10 0x28 CancellationToken           ( 00018653CB00 ModelEnumType CancellationToken CancellationToken CancellationToken Int32 )

            return value;
        }
    }
}
