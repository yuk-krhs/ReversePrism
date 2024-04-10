using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Type                                     00018671E530 ModelEnumType DeviceType DeviceType DeviceType Int32
    // 014 SubType                                  00018671DD80 ModelEnumType DeviceSubType DeviceSubType DeviceSubType Int32
    // 018 Flags                                    00018671D410 ModelEnumType DeviceFlags DeviceFlags DeviceFlags Int32
    public partial class Capabilities : DataModel
    {
        public DeviceType                               Type                                    { get; set; }
        public DeviceSubType                            SubType                                 { get; set; }
        public DeviceFlags                              Flags                                   { get; set; }

        public static Capabilities? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Capabilities() { Pointer= p0 };

            value.Type                                      = (DeviceType)GetInt32(new IntPtr(p + 0x010)); // 0246677DEE80 0x10 Type                        ( 00018671E530 ModelEnumType DeviceType DeviceType DeviceType Int32 )
            value.SubType                                   = (DeviceSubType)GetInt32(new IntPtr(p + 0x014)); // 0246677DEEA0 0x14 SubType                     ( 00018671DD80 ModelEnumType DeviceSubType DeviceSubType DeviceSubType Int32 )
            value.Flags                                     = (DeviceFlags)GetInt32(new IntPtr(p + 0x018)); // 0246677DEEC0 0x18 Flags                       ( 00018671D410 ModelEnumType DeviceFlags DeviceFlags DeviceFlags Int32 )

            return value;
        }
    }
}
