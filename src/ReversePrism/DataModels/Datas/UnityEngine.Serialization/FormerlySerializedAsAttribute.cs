using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_oldName                                000186671910 ModelPrimitiveType string string string String
    public partial class FormerlySerializedAsAttribute
    {
        public string                                   M_oldName                               { get; set; }

        public static FormerlySerializedAsAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FormerlySerializedAsAttribute();

            value.M_oldName                                 = GetString(new IntPtr(p + 0x010)); // 027002493400 0x10 M_oldName                   ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
