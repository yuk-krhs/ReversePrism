using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 kMaxIdLength                             int IL2CPP_TYPE_I4
    // 000 kSize                                    int IL2CPP_TYPE_I4
    // 010 BaseCommand                              ModelEnumType InputDeviceCommand InputDeviceCommand InputDeviceCommand Int32
    // 018 IdBuffer                                 ModelEnumType <idBuffer>e__FixedBuffer <idBuffer>e__FixedBuffer <idBuffer>e__FixedBuffer Int32
    public partial class QueryUserIdCommand : DataModel
    {
        public InputDeviceCommand                       BaseCommand                             { get; set; }
        public <idBuffer>e__FixedBuffer                 IdBuffer                                { get; set; }

        public static QueryUserIdCommand? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new QueryUserIdCommand() { Pointer= p0 };

            value.BaseCommand                               = (InputDeviceCommand)GetInt32(new IntPtr(p + 0x010)); // 0x10 BaseCommand                 ( ModelEnumType InputDeviceCommand InputDeviceCommand InputDeviceCommand Int32 )
            value.IdBuffer                                  = (<idBuffer>e__FixedBuffer)GetInt32(new IntPtr(p + 0x018)); // 0x18 IdBuffer                    ( ModelEnumType <idBuffer>e__FixedBuffer <idBuffer>e__FixedBuffer <idBuffer>e__FixedBuffer Int32 )

            return value;
        }
    }
}
