using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 IsFeatured                               ModelPrimitiveType bool bool bool Bool
    public partial class MedalGashaRewardHeaderData : DataModel
    {
        public bool                                     IsFeatured                              { get; set; }

        public static MedalGashaRewardHeaderData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MedalGashaRewardHeaderData() { Pointer= p0 };

            value.IsFeatured                                = GetBool(new IntPtr(p + 0x010)); // 0x10 IsFeatured                  ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
