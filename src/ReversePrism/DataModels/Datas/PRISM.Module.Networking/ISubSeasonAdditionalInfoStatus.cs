using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public partial class ISubSeasonAdditionalInfoStatus : DataModel
    {

        public static ISubSeasonAdditionalInfoStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ISubSeasonAdditionalInfoStatus() { Pointer= p0 };


            return value;
        }
    }
}
