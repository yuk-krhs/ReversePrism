using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Type                                     int IL2CPP_TYPE_I4
    // 010 BaseEvent                                0001866FCF10 ModelEnumType InputEvent InputEvent InputEvent Int32
    // 024 StateFormat                              0001865BB6D0 ModelEnumType FourCC FourCC FourCC Int32
    // 028 StateOffset                              0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 02C StateData                                00018659CF40 ModelEnumType <stateData>e__FixedBuffer <stateData>e__FixedBuffer <stateData>e__FixedBuffer Int32
    public partial class DeltaStateEvent
    {
        public InputEvent                               BaseEvent                               { get; set; }
        public FourCC                                   StateFormat                             { get; set; }
        public uint                                     StateOffset                             { get; set; }
        public <stateData>e__FixedBuffer                StateData                               { get; set; }

        public static DeltaStateEvent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DeltaStateEvent();

            value.BaseEvent                                 = (InputEvent)GetInt32(new IntPtr(p + 0x010)); // 0270D76AC5A8 0x10 BaseEvent                   ( 0001866FCF10 ModelEnumType InputEvent InputEvent InputEvent Int32 )
            value.StateFormat                               = (FourCC)GetInt32(new IntPtr(p + 0x024)); // 0270D76AC5C8 0x24 StateFormat                 ( 0001865BB6D0 ModelEnumType FourCC FourCC FourCC Int32 )
            value.StateOffset                               = GetUInt32(new IntPtr(p + 0x028)); // 0270D76AC5E8 0x28 StateOffset                 ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.StateData                                 = (<stateData>e__FixedBuffer)GetInt32(new IntPtr(p + 0x02C)); // 0270D76AC608 0x2C StateData                   ( 00018659CF40 ModelEnumType <stateData>e__FixedBuffer <stateData>e__FixedBuffer <stateData>e__FixedBuffer Int32 )

            return value;
        }
    }
}
