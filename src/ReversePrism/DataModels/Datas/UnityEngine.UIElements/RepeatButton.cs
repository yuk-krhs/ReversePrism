using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 4A0 M_Clickable                              ModelClassType Clickable Clickable Clickable Pointer
    // 000 ussClassName                             string IL2CPP_TYPE_STRING
    public partial class RepeatButton : DataModel
    {
        public Clickable?                               M_Clickable                             { get; set; }

        public static RepeatButton? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RepeatButton() { Pointer= p0 };

            value.M_Clickable                               = GetObject<Clickable>(new IntPtr(p + 0x4A0), ReversePrism.DataModels.Clickable.FromPointer); // 0x4A0 M_Clickable                 ( ModelClassType Clickable Clickable Clickable Pointer )

            return value;
        }
    }
}
