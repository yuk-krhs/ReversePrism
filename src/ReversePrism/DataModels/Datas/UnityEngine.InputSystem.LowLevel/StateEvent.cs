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
    // 010 BaseEvent                                ModelEnumType InputEvent InputEvent InputEvent Int32
    // 024 StateFormat                              ModelEnumType FourCC FourCC FourCC Int32
    // 028 StateData                                ModelEnumType <stateData>e__FixedBuffer <stateData>e__FixedBuffer <stateData>e__FixedBuffer Int32
    public partial class StateEvent : DataModel
    {
        public InputEvent                               BaseEvent                               { get; set; }
        public FourCC                                   StateFormat                             { get; set; }
        public <stateData>e__FixedBuffer                StateData                               { get; set; }

        public static StateEvent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StateEvent() { Pointer= p0 };

            value.BaseEvent                                 = (InputEvent)GetInt32(new IntPtr(p + 0x010)); // 0x10 BaseEvent                   ( ModelEnumType InputEvent InputEvent InputEvent Int32 )
            value.StateFormat                               = (FourCC)GetInt32(new IntPtr(p + 0x024)); // 0x24 StateFormat                 ( ModelEnumType FourCC FourCC FourCC Int32 )
            value.StateData                                 = (<stateData>e__FixedBuffer)GetInt32(new IntPtr(p + 0x028)); // 0x28 StateData                   ( ModelEnumType <stateData>e__FixedBuffer <stateData>e__FixedBuffer <stateData>e__FixedBuffer Int32 )

            return value;
        }
    }
}
