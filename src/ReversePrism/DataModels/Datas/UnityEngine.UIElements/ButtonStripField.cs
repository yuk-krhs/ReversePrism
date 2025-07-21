using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 440 M_Buttons                                ModelClassListType List`1<Button> List`1<Button> List<Button> Pointer
    public partial class ButtonStripField : DataModel
    {
        public List<Button>?                            M_Buttons                               { get; set; }

        public static ButtonStripField? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ButtonStripField() { Pointer= p0 };

            value.M_Buttons                                 = GetObjectList<Button>(new IntPtr(p + 0x440), ReversePrism.DataModels.Button.FromPointer); // 0x440 M_Buttons                   ( ModelClassListType List`1<Button> List`1<Button> List<Button> Pointer )

            return value;
        }
    }
}
