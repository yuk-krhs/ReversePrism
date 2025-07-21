using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 PointerDown                              ModelClassType PointerEvent PointerEvent PointerEvent Pointer
    // 028 PointerUp                                ModelClassType PointerEvent PointerEvent PointerEvent Pointer
    // 030 PointerClick                             ModelClassType PointerEvent PointerEvent PointerEvent Pointer
    public partial class PointerEventListener : DataModel
    {
        public PointerEvent?                            PointerDown                             { get; set; }
        public PointerEvent?                            PointerUp                               { get; set; }
        public PointerEvent?                            PointerClick                            { get; set; }

        public static PointerEventListener? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PointerEventListener() { Pointer= p0 };

            value.PointerDown                               = GetObject<PointerEvent>(new IntPtr(p + 0x020), ReversePrism.DataModels.PointerEvent.FromPointer); // 0x20 PointerDown                 ( ModelClassType PointerEvent PointerEvent PointerEvent Pointer )
            value.PointerUp                                 = GetObject<PointerEvent>(new IntPtr(p + 0x028), ReversePrism.DataModels.PointerEvent.FromPointer); // 0x28 PointerUp                   ( ModelClassType PointerEvent PointerEvent PointerEvent Pointer )
            value.PointerClick                              = GetObject<PointerEvent>(new IntPtr(p + 0x030), ReversePrism.DataModels.PointerEvent.FromPointer); // 0x30 PointerClick                ( ModelClassType PointerEvent PointerEvent PointerEvent Pointer )

            return value;
        }
    }
}
