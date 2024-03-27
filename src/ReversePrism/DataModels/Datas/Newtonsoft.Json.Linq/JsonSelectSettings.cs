using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 <RegexMatchTimeout>k__BackingField       Nullable`1<TimeSpan> IL2CPP_TYPE_GENERICINST
    // 020 ErrorWhenNoMatch                         000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class JsonSelectSettings
    {
        public bool                                     ErrorWhenNoMatch                        { get; set; }

        public static JsonSelectSettings? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new JsonSelectSettings();

            value.ErrorWhenNoMatch                          = GetBool(new IntPtr(p + 0x020)); // 0270D8815F30 0x20 ErrorWhenNoMatch            ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
