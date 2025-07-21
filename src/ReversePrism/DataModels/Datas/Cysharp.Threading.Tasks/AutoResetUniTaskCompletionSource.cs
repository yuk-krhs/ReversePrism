using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 pool                                     TaskPool`1<AutoResetUniTaskCompletionSource> IL2CPP_TYPE_GENERICINST
    // 010 NextNode                                 ModelClassType AutoResetUniTaskCompletionSource AutoResetUniTaskCompletionSource AutoResetUniTaskCompletionSource Pointer
    // 018 core                                     UniTaskCompletionSourceCore`1<AsyncUnit> IL2CPP_TYPE_GENERICINST
    // 040 Version                                  ModelPrimitiveType short short short Int16
    public partial class AutoResetUniTaskCompletionSource : DataModel
    {
        public AutoResetUniTaskCompletionSource?        NextNode                                { get; set; }
        public short                                    Version                                 { get; set; }

        public static AutoResetUniTaskCompletionSource? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AutoResetUniTaskCompletionSource() { Pointer= p0 };

            value.NextNode                                  = GetObject<AutoResetUniTaskCompletionSource>(new IntPtr(p + 0x010), ReversePrism.DataModels.AutoResetUniTaskCompletionSource.FromPointer); // 0x10 NextNode                    ( ModelClassType AutoResetUniTaskCompletionSource AutoResetUniTaskCompletionSource AutoResetUniTaskCompletionSource Pointer )
            value.Version                                   = GetInt16(new IntPtr(p + 0x040)); // 0x40 Version                     ( ModelPrimitiveType short short short Int16 )

            return value;
        }
    }
}
