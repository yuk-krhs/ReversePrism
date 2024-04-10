using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CompositionString                        000186672F10 ModelPrimitiveType string string string String
    public partial class BaseInputOverride : DataModel
    {
        public string                                   CompositionString                       { get; set; }

        public static BaseInputOverride? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BaseInputOverride() { Pointer= p0 };

            value.CompositionString                         = GetString(new IntPtr(p + 0x020)); // 0246677FCD70 0x20 CompositionString           ( 000186672F10 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
