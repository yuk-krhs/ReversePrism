using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 NormalBlend                              ModelEnumType DecalNormalBlend DecalNormalBlend DecalNormalBlend Int32
    public partial class DecalScreenSpaceSettings : DataModel
    {
        public DecalNormalBlend                         NormalBlend                             { get; set; }

        public static DecalScreenSpaceSettings? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DecalScreenSpaceSettings() { Pointer= p0 };

            value.NormalBlend                               = (DecalNormalBlend)GetInt32(new IntPtr(p + 0x010)); // 0x10 NormalBlend                 ( ModelEnumType DecalNormalBlend DecalNormalBlend DecalNormalBlend Int32 )

            return value;
        }
    }
}
