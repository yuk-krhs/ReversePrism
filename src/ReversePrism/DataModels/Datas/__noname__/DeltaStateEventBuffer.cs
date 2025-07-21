using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 StateEvent                               ModelEnumType DeltaStateEvent DeltaStateEvent DeltaStateEvent Int32
    // 000 kMaxSize                                 int IL2CPP_TYPE_I4
    // 02D Data                                     ModelEnumType <data>e__FixedBuffer <data>e__FixedBuffer <data>e__FixedBuffer Int32
    public partial class DeltaStateEventBuffer : DataModel
    {
        public DeltaStateEvent                          StateEvent                              { get; set; }
        public <data>e__FixedBuffer                     Data                                    { get; set; }

        public static DeltaStateEventBuffer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DeltaStateEventBuffer() { Pointer= p0 };

            value.StateEvent                                = (DeltaStateEvent)GetInt32(new IntPtr(p + 0x010)); // 0x10 StateEvent                  ( ModelEnumType DeltaStateEvent DeltaStateEvent DeltaStateEvent Int32 )
            value.Data                                      = (<data>e__FixedBuffer)GetInt32(new IntPtr(p + 0x02D)); // 0x2D Data                        ( ModelEnumType <data>e__FixedBuffer <data>e__FixedBuffer <data>e__FixedBuffer Int32 )

            return value;
        }
    }
}
