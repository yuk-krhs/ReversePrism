using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 continuation                             Action`1<<object>> IL2CPP_TYPE_GENERICINST
    // 010 taskFactory                              Func`1<UniTask> IL2CPP_TYPE_GENERICINST
    // 018 CompletionSource                         ModelClassType UniTaskCompletionSource UniTaskCompletionSource UniTaskCompletionSource Pointer
    // 020 Awaiter                                  ModelEnumType Awaiter Awaiter Awaiter Int32
    // 030 syncLock                                 <object> IL2CPP_TYPE_OBJECT
    // 038 Initialized                              ModelPrimitiveType bool bool bool Bool
    public partial class AsyncLazy : DataModel
    {
        public UniTaskCompletionSource?                 CompletionSource                        { get; set; }
        public Awaiter                                  Awaiter                                 { get; set; }
        public bool                                     Initialized                             { get; set; }

        public static AsyncLazy? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AsyncLazy() { Pointer= p0 };

            value.CompletionSource                          = GetObject<UniTaskCompletionSource>(new IntPtr(p + 0x018), ReversePrism.DataModels.UniTaskCompletionSource.FromPointer); // 0x18 CompletionSource            ( ModelClassType UniTaskCompletionSource UniTaskCompletionSource UniTaskCompletionSource Pointer )
            value.Awaiter                                   = (Awaiter)GetInt32(new IntPtr(p + 0x020)); // 0x20 Awaiter                     ( ModelEnumType Awaiter Awaiter Awaiter Int32 )
            value.Initialized                               = GetBool(new IntPtr(p + 0x038)); // 0x38 Initialized                 ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
