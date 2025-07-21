using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 <RegexMatchTimeout>k__BackingField       Nullable`1<TimeSpan> IL2CPP_TYPE_GENERICINST
    // 020 ErrorWhenNoMatch                         ModelPrimitiveType bool bool bool Bool
    public partial class JsonSelectSettings : DataModel
    {
        public bool                                     ErrorWhenNoMatch                        { get; set; }

        public static JsonSelectSettings? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new JsonSelectSettings() { Pointer= p0 };

            value.ErrorWhenNoMatch                          = GetBool(new IntPtr(p + 0x020)); // 0x20 ErrorWhenNoMatch            ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
