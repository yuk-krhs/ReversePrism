using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 fields                                   IDictionary`2<int, UnknownField> IL2CPP_TYPE_GENERICINST
    // 018 lastFieldNumber                          int IL2CPP_TYPE_I4
    // 020 LastField                                000186731440 ModelClassType UnknownField UnknownField UnknownField Pointer
    public partial class UnknownFieldSet : DataModel
    {
        public UnknownField?                            LastField                               { get; set; }

        public static UnknownFieldSet? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UnknownFieldSet() { Pointer= p0 };

            value.LastField                                 = GetObject<UnknownField>(new IntPtr(p + 0x020), ReversePrism.DataModels.UnknownField.FromPointer); // 0246639950E0 0x20 LastField                   ( 000186731440 ModelClassType UnknownField UnknownField UnknownField Pointer )

            return value;
        }
    }
}
