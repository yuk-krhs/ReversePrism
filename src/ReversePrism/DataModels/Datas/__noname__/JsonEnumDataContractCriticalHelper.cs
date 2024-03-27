using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 IsULong                                  000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class JsonEnumDataContractCriticalHelper
    {
        public bool                                     IsULong                                 { get; set; }

        public static JsonEnumDataContractCriticalHelper? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new JsonEnumDataContractCriticalHelper();

            value.IsULong                                   = GetBool(new IntPtr(p + 0x028)); // 0270D7DC4760 0x28 IsULong                     ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
