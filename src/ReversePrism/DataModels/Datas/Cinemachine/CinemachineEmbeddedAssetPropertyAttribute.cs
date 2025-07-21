using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 WarnIfNull                               ModelPrimitiveType bool bool bool Bool
    public partial class CinemachineEmbeddedAssetPropertyAttribute : DataModel
    {
        public bool                                     WarnIfNull                              { get; set; }

        public static CinemachineEmbeddedAssetPropertyAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CinemachineEmbeddedAssetPropertyAttribute() { Pointer= p0 };

            value.WarnIfNull                                = GetBool(new IntPtr(p + 0x010)); // 0x10 WarnIfNull                  ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
