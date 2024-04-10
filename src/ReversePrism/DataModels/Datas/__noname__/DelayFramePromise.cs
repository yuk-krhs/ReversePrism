using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 pool                                     TaskPool`1<DelayFramePromise> IL2CPP_TYPE_GENERICINST
    // 010 NextNode                                 0001867173B0 ModelClassType DelayFramePromise DelayFramePromise DelayFramePromise Pointer
    // 018 InitialFrame                             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 01C DelayFrameCount                          0001865F2AF0 ModelPrimitiveType int int int Int32
    // 020 CancellationToken                        00018653CB00 ModelEnumType CancellationToken CancellationToken CancellationToken Int32
    // 028 CurrentFrameCount                        0001865F2AF0 ModelPrimitiveType int int int Int32
    // 030 core                                     UniTaskCompletionSourceCore`1<AsyncUnit> IL2CPP_TYPE_GENERICINST
    public partial class DelayFramePromise : DataModel
    {
        public DelayFramePromise?                       NextNode                                { get; set; }
        public int                                      InitialFrame                            { get; set; }
        public int                                      DelayFrameCount                         { get; set; }
        public CancellationToken                        CancellationToken                       { get; set; }
        public int                                      CurrentFrameCount                       { get; set; }

        public static DelayFramePromise? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DelayFramePromise() { Pointer= p0 };

            value.NextNode                                  = GetObject<DelayFramePromise>(new IntPtr(p + 0x010), ReversePrism.DataModels.DelayFramePromise.FromPointer); // 0245A416E450 0x10 NextNode                    ( 0001867173B0 ModelClassType DelayFramePromise DelayFramePromise DelayFramePromise Pointer )
            value.InitialFrame                              = GetInt32(new IntPtr(p + 0x018)); // 0245A416E470 0x18 InitialFrame                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.DelayFrameCount                           = GetInt32(new IntPtr(p + 0x01C)); // 0245A416E490 0x1C DelayFrameCount             ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.CancellationToken                         = (CancellationToken)GetInt32(new IntPtr(p + 0x020)); // 0245A416E4B0 0x20 CancellationToken           ( 00018653CB00 ModelEnumType CancellationToken CancellationToken CancellationToken Int32 )
            value.CurrentFrameCount                         = GetInt32(new IntPtr(p + 0x028)); // 0245A416E4D0 0x28 CurrentFrameCount           ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
