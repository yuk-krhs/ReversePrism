using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CaseInsensitive                          ModelPrimitiveType bool bool bool Bool
    // 000 <Empty>k__BackingField                   RegexPrefix IL2CPP_TYPE_VALUETYPE
    // 018 Prefix                                   ModelPrimitiveType string string string String
    public partial class RegexPrefix : DataModel
    {
        public bool                                     CaseInsensitive                         { get; set; }
        public string                                   Prefix                                  { get; set; }

        public static RegexPrefix? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RegexPrefix() { Pointer= p0 };

            value.CaseInsensitive                           = GetBool(new IntPtr(p + 0x010)); // 0x10 CaseInsensitive             ( ModelPrimitiveType bool bool bool Bool )
            value.Prefix                                    = GetString(new IntPtr(p + 0x018)); // 0x18 Prefix                      ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
