using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 RemoteId                                 0001865F36C0 ModelPrimitiveType int int int Int32
    // 014 LocalId                                  0001865F36C0 ModelPrimitiveType int int int Int32
    // 018 Description                              0001865ED710 ModelEnumType InputDeviceDescription InputDeviceDescription InputDeviceDescription Int32
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

            value.RemoteId                                  = GetInt32(new IntPtr(p + 0x010)); // 024667770CD8 0x10 RemoteId                    ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.LocalId                                   = GetInt32(new IntPtr(p + 0x014)); // 024667770CF8 0x14 LocalId                     ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Description                               = (InputDeviceDescription)GetInt32(new IntPtr(p + 0x018)); // 024667770D18 0x18 Description                 ( 0001865ED710 ModelEnumType InputDeviceDescription InputDeviceDescription InputDeviceDescription Int32 )

            return value;
        }
    }
}
