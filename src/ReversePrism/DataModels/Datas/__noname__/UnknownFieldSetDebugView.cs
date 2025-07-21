using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Set                                      ModelClassType UnknownFieldSet UnknownFieldSet UnknownFieldSet Pointer
    public partial class UnknownFieldSetDebugView : DataModel
    {
        public UnknownFieldSet?                         Set                                     { get; set; }

        public static UnknownFieldSetDebugView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UnknownFieldSetDebugView() { Pointer= p0 };

            value.Set                                       = GetObject<UnknownFieldSet>(new IntPtr(p + 0x010), ReversePrism.DataModels.UnknownFieldSet.FromPointer); // 0x10 Set                         ( ModelClassType UnknownFieldSet UnknownFieldSet UnknownFieldSet Pointer )

            return value;
        }
    }
}
