using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public partial class ISpecialMissionBannerStatus : DataModel
    {

        public static ISpecialMissionBannerStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ISpecialMissionBannerStatus() { Pointer= p0 };


            return value;
        }
    }
}
