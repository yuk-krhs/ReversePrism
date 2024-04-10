using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public partial class MstSupportCharacterLimitBreakRecipeFormatter : DataModel
    {

        public static MstSupportCharacterLimitBreakRecipeFormatter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MstSupportCharacterLimitBreakRecipeFormatter() { Pointer= p0 };


            return value;
        }
    }
}
