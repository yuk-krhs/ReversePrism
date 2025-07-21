using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 IsULong                                  ModelPrimitiveType bool bool bool Bool
    public partial class JsonEnumDataContractCriticalHelper : DataModel
    {
        public bool                                     IsULong                                 { get; set; }

        public static JsonEnumDataContractCriticalHelper? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new JsonEnumDataContractCriticalHelper() { Pointer= p0 };

            value.IsULong                                   = GetBool(new IntPtr(p + 0x028)); // 0x28 IsULong                     ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
