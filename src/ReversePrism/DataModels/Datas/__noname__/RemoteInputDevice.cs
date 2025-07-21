using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 RemoteId                                 ModelPrimitiveType int int int Int32
    // 014 LocalId                                  ModelPrimitiveType int int int Int32
    // 018 Description                              ModelEnumType InputDeviceDescription InputDeviceDescription InputDeviceDescription Int32
    public partial class RemoteInputDevice : DataModel
    {
        public int                                      RemoteId                                { get; set; }
        public int                                      LocalId                                 { get; set; }
        public InputDeviceDescription                   Description                             { get; set; }

        public static RemoteInputDevice? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RemoteInputDevice() { Pointer= p0 };

            value.RemoteId                                  = GetInt32(new IntPtr(p + 0x010)); // 0x10 RemoteId                    ( ModelPrimitiveType int int int Int32 )
            value.LocalId                                   = GetInt32(new IntPtr(p + 0x014)); // 0x14 LocalId                     ( ModelPrimitiveType int int int Int32 )
            value.Description                               = (InputDeviceDescription)GetInt32(new IntPtr(p + 0x018)); // 0x18 Description                 ( ModelEnumType InputDeviceDescription InputDeviceDescription InputDeviceDescription Int32 )

            return value;
        }
    }
}
