using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public partial class GetSupportSkillPopupSequencerForLegacy : DataModel
    {

        public static GetSupportSkillPopupSequencerForLegacy? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetSupportSkillPopupSequencerForLegacy() { Pointer= p0 };


            return value;
        }
    }
}
