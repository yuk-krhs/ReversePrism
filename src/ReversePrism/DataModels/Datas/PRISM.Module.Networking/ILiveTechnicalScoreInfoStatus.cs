using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public partial class ILiveTechnicalScoreInfoStatus
    {

        public static ILiveTechnicalScoreInfoStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ILiveTechnicalScoreInfoStatus();


            return value;
        }
    }
}
