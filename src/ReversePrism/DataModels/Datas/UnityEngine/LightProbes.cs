using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 lightProbesUpdated                       Action IL2CPP_TYPE_CLASS
    // 008 tetrahedralizationCompleted              Action IL2CPP_TYPE_CLASS
    // 010 NeedsRetetrahedralization                ModelClassType Action Action Action Pointer
    public partial class LightProbes : DataModel
    {
        public Action?                                  NeedsRetetrahedralization               { get; set; }

        public static LightProbes? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LightProbes() { Pointer= p0 };

            value.NeedsRetetrahedralization                 = GetObject<Action>(new IntPtr(p + 0x010), ReversePrism.DataModels.Action.FromPointer); // 0x10 NeedsRetetrahedralization   ( ModelClassType Action Action Action Pointer )

            return value;
        }
    }
}
