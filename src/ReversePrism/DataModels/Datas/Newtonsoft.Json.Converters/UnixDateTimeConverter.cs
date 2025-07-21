using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 UnixEpoch                                DateTime IL2CPP_TYPE_VALUETYPE
    // 010 AllowPreEpoch                            ModelPrimitiveType bool bool bool Bool
    public partial class UnixDateTimeConverter : DataModel
    {
        public bool                                     AllowPreEpoch                           { get; set; }

        public static UnixDateTimeConverter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UnixDateTimeConverter() { Pointer= p0 };

            value.AllowPreEpoch                             = GetBool(new IntPtr(p + 0x010)); // 0x10 AllowPreEpoch               ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
