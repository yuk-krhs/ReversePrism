using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Parent                                   00018674B990 ModelClassType BatchFrameObservable BatchFrameObservable BatchFrameObservable Pointer
    // 028 gate                                     <object> IL2CPP_TYPE_OBJECT
    // 030 CancellationToken                        00018676B4A0 ModelClassType BooleanDisposable BooleanDisposable BooleanDisposable Pointer
    // 038 Timer                                    00018675FFB0 ModelClassType IEnumerator IEnumerator IEnumerator Pointer
    // 040 IsRunning                                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 041 IsCompleted                              000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class BatchFrame : DataModel
    {
        public BatchFrameObservable?                    Parent                                  { get; set; }
        public BooleanDisposable?                       CancellationToken                       { get; set; }
        public IEnumerator?                             Timer                                   { get; set; }
        public bool                                     IsRunning                               { get; set; }
        public bool                                     IsCompleted                             { get; set; }

        public static BatchFrame? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BatchFrame() { Pointer= p0 };

            value.Parent                                    = GetObject<BatchFrameObservable>(new IntPtr(p + 0x020), ReversePrism.DataModels.BatchFrameObservable.FromPointer); // 024669891248 0x20 Parent                      ( 00018674B990 ModelClassType BatchFrameObservable BatchFrameObservable BatchFrameObservable Pointer )
            value.CancellationToken                         = GetObject<BooleanDisposable>(new IntPtr(p + 0x030), ReversePrism.DataModels.BooleanDisposable.FromPointer); // 024669891288 0x30 CancellationToken           ( 00018676B4A0 ModelClassType BooleanDisposable BooleanDisposable BooleanDisposable Pointer )
            value.Timer                                     = GetObject<IEnumerator>(new IntPtr(p + 0x038), ReversePrism.DataModels.IEnumerator.FromPointer); // 0246698912A8 0x38 Timer                       ( 00018675FFB0 ModelClassType IEnumerator IEnumerator IEnumerator Pointer )
            value.IsRunning                                 = GetBool(new IntPtr(p + 0x040)); // 0246698912C8 0x40 IsRunning                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsCompleted                               = GetBool(new IntPtr(p + 0x041)); // 0246698912E8 0x41 IsCompleted                 ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
