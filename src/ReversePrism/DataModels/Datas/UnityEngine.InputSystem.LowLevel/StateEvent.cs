using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Type                                     int IL2CPP_TYPE_I4
    // 000 kStateDataSizeToSubtract                 int IL2CPP_TYPE_I4
    // 010 BaseEvent                                0001866FCF10 ModelEnumType InputEvent InputEvent InputEvent Int32
    // 024 StateFormat                              0001865BB6D0 ModelEnumType FourCC FourCC FourCC Int32
    // 028 StateData                                00018657D690 ModelEnumType <stateData>e__FixedBuffer <stateData>e__FixedBuffer <stateData>e__FixedBuffer Int32
    public partial class StateEvent
    {
        public InputEvent                               BaseEvent                               { get; set; }
        public FourCC                                   StateFormat                             { get; set; }
        public <stateData>e__FixedBuffer                StateData                               { get; set; }

        public static StateEvent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StateEvent();

            value.BaseEvent                                 = (InputEvent)GetInt32(new IntPtr(p + 0x010)); // 0270D76AC3F0 0x10 BaseEvent                   ( 0001866FCF10 ModelEnumType InputEvent InputEvent InputEvent Int32 )
            value.StateFormat                               = (FourCC)GetInt32(new IntPtr(p + 0x024)); // 0270D76AC410 0x24 StateFormat                 ( 0001865BB6D0 ModelEnumType FourCC FourCC FourCC Int32 )
            value.StateData                                 = (<stateData>e__FixedBuffer)GetInt32(new IntPtr(p + 0x028)); // 0270D76AC430 0x28 StateData                   ( 00018657D690 ModelEnumType <stateData>e__FixedBuffer <stateData>e__FixedBuffer <stateData>e__FixedBuffer Int32 )

            return value;
        }
    }
}
