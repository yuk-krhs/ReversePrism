using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 kBaseCommandSize                         int IL2CPP_TYPE_I4
    // 000 BaseCommandSize                          int IL2CPP_TYPE_I4
    // 000 GenericFailure                           long IL2CPP_TYPE_I8
    // 000 GenericSuccess                           long IL2CPP_TYPE_I8
    // 010 Type                                     0001865BB6D0 ModelEnumType FourCC FourCC FourCC Int32
    // 014 SizeInBytes                              0001865F36C0 ModelPrimitiveType int int int Int32
    public partial class InputDeviceCommand
    {
        public FourCC                                   Type                                    { get; set; }
        public int                                      SizeInBytes                             { get; set; }

        public static InputDeviceCommand? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InputDeviceCommand();

            value.Type                                      = (FourCC)GetInt32(new IntPtr(p + 0x010)); // 0270D76FD340 0x10 Type                        ( 0001865BB6D0 ModelEnumType FourCC FourCC FourCC Int32 )
            value.SizeInBytes                               = GetInt32(new IntPtr(p + 0x014)); // 0270D76FD360 0x14 SizeInBytes                 ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
