using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public partial class FinishChallengeTourStageArgsTranslator : DataModel
    {

        public static FinishChallengeTourStageArgsTranslator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FinishChallengeTourStageArgsTranslator() { Pointer= p0 };


            return value;
        }
    }
}
