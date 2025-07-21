using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 StateEvent                               ModelEnumType StateEvent StateEvent StateEvent Int32
    // 000 kMaxSize                                 int IL2CPP_TYPE_I4
    // 029 Data                                     ModelEnumType <data>e__FixedBuffer <data>e__FixedBuffer <data>e__FixedBuffer Int32
    public partial class StateEventBuffer : DataModel
    {
        public StateEvent                               StateEvent                              { get; set; }
        public <data>e__FixedBuffer                     Data                                    { get; set; }

        public static StateEventBuffer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StateEventBuffer() { Pointer= p0 };

            value.StateEvent                                = (StateEvent)GetInt32(new IntPtr(p + 0x010)); // 0x10 StateEvent                  ( ModelEnumType StateEvent StateEvent StateEvent Int32 )
            value.Data                                      = (<data>e__FixedBuffer)GetInt32(new IntPtr(p + 0x029)); // 0x29 Data                        ( ModelEnumType <data>e__FixedBuffer <data>e__FixedBuffer <data>e__FixedBuffer Int32 )

            return value;
        }
    }
}
