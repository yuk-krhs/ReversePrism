using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 <TargetIndex>k__BackingField             Nullable`1<int> IL2CPP_TYPE_GENERICINST
    public partial class LegacyIntroductionLauncherParameter : DataModel
    {

        public static LegacyIntroductionLauncherParameter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LegacyIntroductionLauncherParameter() { Pointer= p0 };


            return value;
        }
    }
}
