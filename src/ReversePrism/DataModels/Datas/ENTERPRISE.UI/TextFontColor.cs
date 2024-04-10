using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 <Dict>k__BackingField                    Dictionary`2<TextFontColorId, Color> IL2CPP_TYPE_GENERICINST
    public partial class TextFontColor : DataModel
    {

        public static TextFontColor? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TextFontColor() { Pointer= p0 };


            return value;
        }
    }
}
