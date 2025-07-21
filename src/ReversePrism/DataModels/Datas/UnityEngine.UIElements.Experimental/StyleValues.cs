using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_StyleValues                            ModelClassType StyleValueCollection StyleValueCollection StyleValueCollection Pointer
    public partial class StyleValues : DataModel
    {
        public StyleValueCollection?                    M_StyleValues                           { get; set; }

        public static StyleValues? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StyleValues() { Pointer= p0 };

            value.M_StyleValues                             = GetObject<StyleValueCollection>(new IntPtr(p + 0x010), ReversePrism.DataModels.StyleValueCollection.FromPointer); // 0x10 M_StyleValues               ( ModelClassType StyleValueCollection StyleValueCollection StyleValueCollection Pointer )

            return value;
        }
    }
}
