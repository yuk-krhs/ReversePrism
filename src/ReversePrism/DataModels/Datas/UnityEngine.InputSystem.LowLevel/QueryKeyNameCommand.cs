using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 kMaxNameLength                           int IL2CPP_TYPE_I4
    // 000 kSize                                    int IL2CPP_TYPE_I4
    // 010 BaseCommand                              0001865ECDD0 ModelEnumType InputDeviceCommand InputDeviceCommand InputDeviceCommand Int32
    // 018 ScanOrKeyCode                            0001865F36C0 ModelPrimitiveType int int int Int32
    // 01C NameBuffer                               000186699590 ModelEnumType <nameBuffer>e__FixedBuffer <nameBuffer>e__FixedBuffer <nameBuffer>e__FixedBuffer Int32
    public partial class QueryKeyNameCommand
    {
        public InputDeviceCommand                       BaseCommand                             { get; set; }
        public int                                      ScanOrKeyCode                           { get; set; }
        public <nameBuffer>e__FixedBuffer               NameBuffer                              { get; set; }

        public static QueryKeyNameCommand? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new QueryKeyNameCommand();

            value.BaseCommand                               = (InputDeviceCommand)GetInt32(new IntPtr(p + 0x010)); // 0270D77FBAC0 0x10 BaseCommand                 ( 0001865ECDD0 ModelEnumType InputDeviceCommand InputDeviceCommand InputDeviceCommand Int32 )
            value.ScanOrKeyCode                             = GetInt32(new IntPtr(p + 0x018)); // 0270D77FBAE0 0x18 ScanOrKeyCode               ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.NameBuffer                                = (<nameBuffer>e__FixedBuffer)GetInt32(new IntPtr(p + 0x01C)); // 0270D77FBB00 0x1C NameBuffer                  ( 000186699590 ModelEnumType <nameBuffer>e__FixedBuffer <nameBuffer>e__FixedBuffer <nameBuffer>e__FixedBuffer Int32 )

            return value;
        }
    }
}
