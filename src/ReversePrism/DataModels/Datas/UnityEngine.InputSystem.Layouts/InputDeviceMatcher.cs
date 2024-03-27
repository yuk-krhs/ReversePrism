using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 m_Patterns                               KeyValuePair`2<InternedString, <object>>[] IL2CPP_TYPE_SZARRAY
    // 000 kInterfaceKey                            InternedString IL2CPP_TYPE_VALUETYPE
    // 010 KDeviceClassKey                          0001865FEAB0 ModelEnumType InternedString InternedString InternedString Int32
    // 020 KManufacturerKey                         0001865FEAB0 ModelEnumType InternedString InternedString InternedString Int32
    // 030 KProductKey                              0001865FEAB0 ModelEnumType InternedString InternedString InternedString Int32
    // 040 KVersionKey                              0001865FEAB0 ModelEnumType InternedString InternedString InternedString Int32
    public partial class InputDeviceMatcher
    {
        public InternedString                           KDeviceClassKey                         { get; set; }
        public InternedString                           KManufacturerKey                        { get; set; }
        public InternedString                           KProductKey                             { get; set; }
        public InternedString                           KVersionKey                             { get; set; }

        public static InputDeviceMatcher? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InputDeviceMatcher();

            value.KDeviceClassKey                           = (InternedString)GetInt32(new IntPtr(p + 0x010)); // 027002E5D930 0x10 KDeviceClassKey             ( 0001865FEAB0 ModelEnumType InternedString InternedString InternedString Int32 )
            value.KManufacturerKey                          = (InternedString)GetInt32(new IntPtr(p + 0x020)); // 027002E5D950 0x20 KManufacturerKey            ( 0001865FEAB0 ModelEnumType InternedString InternedString InternedString Int32 )
            value.KProductKey                               = (InternedString)GetInt32(new IntPtr(p + 0x030)); // 027002E5D970 0x30 KProductKey                 ( 0001865FEAB0 ModelEnumType InternedString InternedString InternedString Int32 )
            value.KVersionKey                               = (InternedString)GetInt32(new IntPtr(p + 0x040)); // 027002E5D990 0x40 KVersionKey                 ( 0001865FEAB0 ModelEnumType InternedString InternedString InternedString Int32 )

            return value;
        }
    }
}
