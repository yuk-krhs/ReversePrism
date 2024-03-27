using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     000186671BA0 ModelPrimitiveType string string string String
    public partial class FieldFilter
    {
        public string                                   Name                                    { get; set; }

        public static FieldFilter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FieldFilter();

            value.Name                                      = GetString(new IntPtr(p + 0x010)); // 0270D8837FA0 0x10 Name                        ( 000186671BA0 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
