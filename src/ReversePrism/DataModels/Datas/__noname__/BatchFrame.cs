using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Parent                                   ModelClassType BatchFrameObservable BatchFrameObservable BatchFrameObservable Pointer
    // 028 gate                                     <object> IL2CPP_TYPE_OBJECT
    // 030 CancellationToken                        ModelClassType BooleanDisposable BooleanDisposable BooleanDisposable Pointer
    // 038 Timer                                    ModelClassType IEnumerator IEnumerator IEnumerator Pointer
    // 040 IsRunning                                ModelPrimitiveType bool bool bool Bool
    // 041 IsCompleted                              ModelPrimitiveType bool bool bool Bool
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

            value.Parent                                    = GetObject<BatchFrameObservable>(new IntPtr(p + 0x020), ReversePrism.DataModels.BatchFrameObservable.FromPointer); // 0x20 Parent                      ( ModelClassType BatchFrameObservable BatchFrameObservable BatchFrameObservable Pointer )
            value.CancellationToken                         = GetObject<BooleanDisposable>(new IntPtr(p + 0x030), ReversePrism.DataModels.BooleanDisposable.FromPointer); // 0x30 CancellationToken           ( ModelClassType BooleanDisposable BooleanDisposable BooleanDisposable Pointer )
            value.Timer                                     = GetObject<IEnumerator>(new IntPtr(p + 0x038), ReversePrism.DataModels.IEnumerator.FromPointer); // 0x38 Timer                       ( ModelClassType IEnumerator IEnumerator IEnumerator Pointer )
            value.IsRunning                                 = GetBool(new IntPtr(p + 0x040)); // 0x40 IsRunning                   ( ModelPrimitiveType bool bool bool Bool )
            value.IsCompleted                               = GetBool(new IntPtr(p + 0x041)); // 0x41 IsCompleted                 ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
