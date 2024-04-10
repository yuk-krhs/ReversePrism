using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 transitionTable                          int[][] IL2CPP_TYPE_SZARRAY
    // 020 Symbols                                  0001866005F0 ModelClassType SymbolsDictionary SymbolsDictionary SymbolsDictionary Pointer
    public partial class DfaContentValidator : DataModel
    {
        public SymbolsDictionary?                       Symbols                                 { get; set; }

        public static DfaContentValidator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DfaContentValidator() { Pointer= p0 };

            value.Symbols                                   = GetObject<SymbolsDictionary>(new IntPtr(p + 0x020), ReversePrism.DataModels.SymbolsDictionary.FromPointer); // 02466755EBD0 0x20 Symbols                     ( 0001866005F0 ModelClassType SymbolsDictionary SymbolsDictionary SymbolsDictionary Pointer )

            return value;
        }
    }
}
