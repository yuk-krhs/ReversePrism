using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 k_searchedFontAssets                     List`1<int> IL2CPP_TYPE_GENERICINST
    public partial class TMP_FontUtilities
    {

        public static TMP_FontUtilities? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TMP_FontUtilities();


            return value;
        }
    }
}
