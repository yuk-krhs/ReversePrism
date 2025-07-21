using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 kHandledMask                             uint IL2CPP_TYPE_U4
    // 000 kIdMask                                  uint IL2CPP_TYPE_U4
    // 000 kBaseEventSize                           int IL2CPP_TYPE_I4
    // 000 InvalidEventId                           int IL2CPP_TYPE_I4
    // 000 kAlignment                               int IL2CPP_TYPE_I4
    // 010 M_Event                                  ModelEnumType NativeInputEvent NativeInputEvent NativeInputEvent Int32
    public partial class InputEvent : DataModel
    {
        public NativeInputEvent                         M_Event                                 { get; set; }

        public static InputEvent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InputEvent() { Pointer= p0 };

            value.M_Event                                   = (NativeInputEvent)GetInt32(new IntPtr(p + 0x010)); // 0x10 M_Event                     ( ModelEnumType NativeInputEvent NativeInputEvent NativeInputEvent Int32 )

            return value;
        }
    }
}
