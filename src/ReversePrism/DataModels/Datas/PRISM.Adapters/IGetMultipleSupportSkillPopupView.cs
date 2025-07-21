using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public partial class IGetMultipleSupportSkillPopupView : DataModel
    {

        public static IGetMultipleSupportSkillPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IGetMultipleSupportSkillPopupView() { Pointer= p0 };


            return value;
        }
    }
}
