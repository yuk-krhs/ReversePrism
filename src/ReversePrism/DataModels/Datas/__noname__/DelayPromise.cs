using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 pool                                     TaskPool`1<DelayPromise> IL2CPP_TYPE_GENERICINST
    // 010 NextNode                                 000186718280 ModelClassType DelayPromise DelayPromise DelayPromise Pointer
    // 018 InitialFrame                             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 01C DelayTimeSpan                            0001866656B0 ModelPrimitiveType float float float Single
    // 020 Elapsed                                  0001866656B0 ModelPrimitiveType float float float Single
    // 028 CancellationToken                        00018653CB00 ModelEnumType CancellationToken CancellationToken CancellationToken Int32
    // 030 core                                     UniTaskCompletionSourceCore`1<<object>> IL2CPP_TYPE_GENERICINST
    public partial class DelayPromise
    {
        public DelayPromise?                            NextNode                                { get; set; }
        public int                                      InitialFrame                            { get; set; }
        public float                                    DelayTimeSpan                           { get; set; }
        public float                                    Elapsed                                 { get; set; }
        public CancellationToken                        CancellationToken                       { get; set; }

        public static DelayPromise? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DelayPromise();

            value.NextNode                                  = GetObject<DelayPromise>(new IntPtr(p + 0x010), ReversePrism.DataModels.DelayPromise.FromPointer); // 0270D8BEAFA8 0x10 NextNode                    ( 000186718280 ModelClassType DelayPromise DelayPromise DelayPromise Pointer )
            value.InitialFrame                              = GetInt32(new IntPtr(p + 0x018)); // 0270D8BEAFC8 0x18 InitialFrame                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.DelayTimeSpan                             = GetSingle(new IntPtr(p + 0x01C)); // 0270D8BEAFE8 0x1C DelayTimeSpan               ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.Elapsed                                   = GetSingle(new IntPtr(p + 0x020)); // 0270D8BEB008 0x20 Elapsed                     ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.CancellationToken                         = (CancellationToken)GetInt32(new IntPtr(p + 0x028)); // 0270D8BEB028 0x28 CancellationToken           ( 00018653CB00 ModelEnumType CancellationToken CancellationToken CancellationToken Int32 )

            return value;
        }
    }
}
