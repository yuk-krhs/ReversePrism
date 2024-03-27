using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CaseInsensitive                          0001865965D0 ModelPrimitiveType bool bool bool Bool
    // 000 <Empty>k__BackingField                   RegexPrefix IL2CPP_TYPE_VALUETYPE
    // 018 Prefix                                   000186672F10 ModelPrimitiveType string string string String
    public partial class RegexPrefix
    {
        public bool                                     CaseInsensitive                         { get; set; }
        public string                                   Prefix                                  { get; set; }

        public static RegexPrefix? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RegexPrefix();

            value.CaseInsensitive                           = GetBool(new IntPtr(p + 0x010)); // 0270034241C8 0x10 CaseInsensitive             ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )
            value.Prefix                                    = GetString(new IntPtr(p + 0x018)); // 027003424208 0x18 Prefix                      ( 000186672F10 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
