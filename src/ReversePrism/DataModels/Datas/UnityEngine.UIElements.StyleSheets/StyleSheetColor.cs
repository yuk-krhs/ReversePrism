using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_NameToColor                            Dictionary`2<string, Color32> IL2CPP_TYPE_GENERICINST
    public partial class StyleSheetColor
    {

        public static StyleSheetColor? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StyleSheetColor();


            return value;
        }
    }
}
