using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 kSizeInBits                              int IL2CPP_TYPE_I4
    // 000 kSizeInBytes                             int IL2CPP_TYPE_I4
    // 010 Keys                                     0001866788C0 ModelEnumType <keys>e__FixedBuffer <keys>e__FixedBuffer <keys>e__FixedBuffer Int32
    public partial class KeyboardState : DataModel
    {
        public <keys>e__FixedBuffer                     Keys                                    { get; set; }

        public static KeyboardState? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new KeyboardState() { Pointer= p0 };

            value.Keys                                      = (<keys>e__FixedBuffer)GetInt32(new IntPtr(p + 0x010)); // 024667855D60 0x10 Keys                        ( 0001866788C0 ModelEnumType <keys>e__FixedBuffer <keys>e__FixedBuffer <keys>e__FixedBuffer Int32 )

            return value;
        }
    }
}
