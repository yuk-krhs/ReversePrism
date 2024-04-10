using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Target                                 0001866B2D70 ModelClassType VisualElement VisualElement VisualElement Pointer
    public partial class Manipulator : DataModel
    {
        public VisualElement?                           M_Target                                { get; set; }

        public static Manipulator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Manipulator() { Pointer= p0 };

            value.M_Target                                  = GetObject<VisualElement>(new IntPtr(p + 0x010), ReversePrism.DataModels.VisualElement.FromPointer); // 0245A66A51D8 0x10 M_Target                    ( 0001866B2D70 ModelClassType VisualElement VisualElement VisualElement Pointer )

            return value;
        }
    }
}
