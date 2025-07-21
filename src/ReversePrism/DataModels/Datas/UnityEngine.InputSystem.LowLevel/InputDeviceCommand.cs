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
    // 010 Type                                     ModelEnumType FourCC FourCC FourCC Int32
    // 014 SizeInBytes                              ModelPrimitiveType int int int Int32
    public partial class InputDeviceCommand : DataModel
    {
        public FourCC                                   Type                                    { get; set; }
        public int                                      SizeInBytes                             { get; set; }

        public static InputDeviceCommand? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InputDeviceCommand() { Pointer= p0 };

            value.Type                                      = (FourCC)GetInt32(new IntPtr(p + 0x010)); // 0x10 Type                        ( ModelEnumType FourCC FourCC FourCC Int32 )
            value.SizeInBytes                               = GetInt32(new IntPtr(p + 0x014)); // 0x14 SizeInBytes                 ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
