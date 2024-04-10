using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 pool                                     TaskPool`1<NextFramePromise> IL2CPP_TYPE_GENERICINST
    // 010 NextNode                                 000186719150 ModelClassType NextFramePromise NextFramePromise NextFramePromise Pointer
    // 018 FrameCount                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 020 CancellationToken                        00018653CB00 ModelEnumType CancellationToken CancellationToken CancellationToken Int32
    // 028 core                                     UniTaskCompletionSourceCore`1<AsyncUnit> IL2CPP_TYPE_GENERICINST
    public partial class NextFramePromise : DataModel
    {
        public NextFramePromise?                        NextNode                                { get; set; }
        public int                                      FrameCount                              { get; set; }
        public CancellationToken                        CancellationToken                       { get; set; }

        public static NextFramePromise? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NextFramePromise() { Pointer= p0 };

            value.NextNode                                  = GetObject<NextFramePromise>(new IntPtr(p + 0x010), ReversePrism.DataModels.NextFramePromise.FromPointer); // 024668C3C638 0x10 NextNode                    ( 000186719150 ModelClassType NextFramePromise NextFramePromise NextFramePromise Pointer )
            value.FrameCount                                = GetInt32(new IntPtr(p + 0x018)); // 024668C3C658 0x18 FrameCount                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.CancellationToken                         = (CancellationToken)GetInt32(new IntPtr(p + 0x020)); // 024668C3C678 0x20 CancellationToken           ( 00018653CB00 ModelEnumType CancellationToken CancellationToken CancellationToken Int32 )

            return value;
        }
    }
}
