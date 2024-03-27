using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 kIMECharBufferSize                       int IL2CPP_TYPE_I4
    // 000 Type                                     int IL2CPP_TYPE_I4
    // 010 BaseEvent                                0001866FCF10 ModelEnumType InputEvent InputEvent InputEvent Int32
    // 024 CompositionString                        0001865A5C00 ModelEnumType IMECompositionString IMECompositionString IMECompositionString Int32
    public partial class IMECompositionEvent
    {
        public InputEvent                               BaseEvent                               { get; set; }
        public IMECompositionString                     CompositionString                       { get; set; }

        public static IMECompositionEvent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IMECompositionEvent();

            value.BaseEvent                                 = (InputEvent)GetInt32(new IntPtr(p + 0x010)); // 0270D7818230 0x10 BaseEvent                   ( 0001866FCF10 ModelEnumType InputEvent InputEvent InputEvent Int32 )
            value.CompositionString                         = (IMECompositionString)GetInt32(new IntPtr(p + 0x024)); // 0270D7818250 0x24 CompositionString           ( 0001865A5C00 ModelEnumType IMECompositionString IMECompositionString IMECompositionString Int32 )

            return value;
        }
    }
}
