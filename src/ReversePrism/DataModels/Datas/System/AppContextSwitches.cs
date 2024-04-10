using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 SetActorAsReferenceWhenCopyingClaimsIdentity bool IL2CPP_TYPE_BOOLEAN
    // 001 EnforceJapaneseEraYearRanges             bool IL2CPP_TYPE_BOOLEAN
    // 002 FormatJapaneseFirstYearAsANumber         bool IL2CPP_TYPE_BOOLEAN
    // 003 EnforceLegacyJapaneseDateParsing         bool IL2CPP_TYPE_BOOLEAN
    public partial class AppContextSwitches : DataModel
    {

        public static AppContextSwitches? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AppContextSwitches() { Pointer= p0 };


            return value;
        }
    }
}
