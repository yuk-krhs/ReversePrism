using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 FeaturedObject                           ModelClassType GameObject GameObject GameObject Pointer
    public partial class MedalGashaRewardAllListHeader : DataModel
    {
        public GameObject?                              FeaturedObject                          { get; set; }

        public static MedalGashaRewardAllListHeader? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MedalGashaRewardAllListHeader() { Pointer= p0 };

            value.FeaturedObject                            = GetObject<GameObject>(new IntPtr(p + 0x060), ReversePrism.DataModels.GameObject.FromPointer); // 0x60 FeaturedObject              ( ModelClassType GameObject GameObject GameObject Pointer )

            return value;
        }
    }
}
