using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_HaveValue                              000186594D10 ModelPrimitiveType bool bool bool Bool
    // 014 M_DeviceCount                            0001865F2AF0 ModelPrimitiveType int int int Int32
    // 018 M_DeviceArray                            000185B8CC70 ModelClassListType InputDevice[] InputDevice[] List<InputDevice> Pointer
    public partial class DeviceArray : DataModel
    {
        public bool                                     M_HaveValue                             { get; set; }
        public int                                      M_DeviceCount                           { get; set; }
        public List<InputDevice>?                       M_DeviceArray                           { get; set; }

        public static DeviceArray? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DeviceArray() { Pointer= p0 };

            value.M_HaveValue                               = GetBool(new IntPtr(p + 0x010)); // 0246676AC5B8 0x10 M_HaveValue                 ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_DeviceCount                             = GetInt32(new IntPtr(p + 0x014)); // 0246676AC5D8 0x14 M_DeviceCount               ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_DeviceArray                             = GetObjectList<InputDevice>(new IntPtr(p + 0x018), ReversePrism.DataModels.InputDevice.FromPointer); // 0246676AC5F8 0x18 M_DeviceArray               ( 000185B8CC70 ModelClassListType InputDevice[] InputDevice[] List<InputDevice> Pointer )

            return value;
        }
    }
}
