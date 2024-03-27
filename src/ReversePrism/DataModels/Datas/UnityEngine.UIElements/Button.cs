using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 ussClassName                             string IL2CPP_TYPE_STRING
    // 4A0 M_Clickable                              0001865B4AC0 ModelClassType Clickable Clickable Clickable Pointer
    // 008 NonEmptyString                           string IL2CPP_TYPE_STRING
    public partial class Button
    {
        public Clickable?                               M_Clickable                             { get; set; }

        public static Button? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Button();

            value.M_Clickable                               = GetObject<Clickable>(new IntPtr(p + 0x4A0), ReversePrism.DataModels.Clickable.FromPointer); // 0270066FCD98 0x4A0 M_Clickable                 ( 0001865B4AC0 ModelClassType Clickable Clickable Clickable Pointer )

            return value;
        }
    }
}
