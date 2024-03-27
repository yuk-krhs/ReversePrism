using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 DoNotUseTimeZoneInfo                     bool IL2CPP_TYPE_BOOLEAN
    // 001 DoNotUseEcmaScriptV6EscapeControlCharacter bool IL2CPP_TYPE_BOOLEAN
    public partial class LocalAppContextSwitches
    {

        public static LocalAppContextSwitches? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LocalAppContextSwitches();


            return value;
        }
    }
}
