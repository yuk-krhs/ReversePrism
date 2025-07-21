using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Type                                     ModelEnumType DeviceType DeviceType DeviceType Int32
    // 014 SubType                                  ModelEnumType DeviceSubType DeviceSubType DeviceSubType Int32
    // 018 Flags                                    ModelEnumType DeviceFlags DeviceFlags DeviceFlags Int32
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

            value.Type                                      = (DeviceType)GetInt32(new IntPtr(p + 0x010)); // 0x10 Type                        ( ModelEnumType DeviceType DeviceType DeviceType Int32 )
            value.SubType                                   = (DeviceSubType)GetInt32(new IntPtr(p + 0x014)); // 0x14 SubType                     ( ModelEnumType DeviceSubType DeviceSubType DeviceSubType Int32 )
            value.Flags                                     = (DeviceFlags)GetInt32(new IntPtr(p + 0x018)); // 0x18 Flags                       ( ModelEnumType DeviceFlags DeviceFlags DeviceFlags Int32 )

            return value;
        }
    }
}
