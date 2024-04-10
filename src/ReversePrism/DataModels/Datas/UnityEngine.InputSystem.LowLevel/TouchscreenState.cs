using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 MaxTouches                               int IL2CPP_TYPE_I4
    // 010 PrimaryTouchData                         00018662B8B0 ModelEnumType <primaryTouchData>e__FixedBuffer <primaryTouchData>e__FixedBuffer <primaryTouchData>e__FixedBuffer Int32
    // 000 kTouchDataOffset                         int IL2CPP_TYPE_I4
    // 048 TouchData                                00018662BDA0 ModelEnumType <touchData>e__FixedBuffer <touchData>e__FixedBuffer <touchData>e__FixedBuffer Int32
    public partial class TouchscreenState : DataModel
    {
        public <primaryTouchData>e__FixedBuffer         PrimaryTouchData                        { get; set; }
        public <touchData>e__FixedBuffer                TouchData                               { get; set; }

        public static TouchscreenState? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TouchscreenState() { Pointer= p0 };

            value.PrimaryTouchData                          = (<primaryTouchData>e__FixedBuffer)GetInt32(new IntPtr(p + 0x010)); // 024667856F30 0x10 PrimaryTouchData            ( 00018662B8B0 ModelEnumType <primaryTouchData>e__FixedBuffer <primaryTouchData>e__FixedBuffer <primaryTouchData>e__FixedBuffer Int32 )
            value.TouchData                                 = (<touchData>e__FixedBuffer)GetInt32(new IntPtr(p + 0x048)); // 024667856F70 0x48 TouchData                   ( 00018662BDA0 ModelEnumType <touchData>e__FixedBuffer <touchData>e__FixedBuffer <touchData>e__FixedBuffer Int32 )

            return value;
        }
    }
}
