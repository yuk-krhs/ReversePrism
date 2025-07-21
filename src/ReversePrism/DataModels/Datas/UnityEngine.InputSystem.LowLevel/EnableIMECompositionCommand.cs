using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 kSize                                    int IL2CPP_TYPE_I4
    // 010 BaseCommand                              ModelEnumType InputDeviceCommand InputDeviceCommand InputDeviceCommand Int32
    // 018 M_ImeEnabled                             ModelPrimitiveType sbyte sbyte sbyte SByte
    public partial class EnableIMECompositionCommand : DataModel
    {
        public InputDeviceCommand                       BaseCommand                             { get; set; }
        public sbyte                                    M_ImeEnabled                            { get; set; }

        public static EnableIMECompositionCommand? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EnableIMECompositionCommand() { Pointer= p0 };

            value.BaseCommand                               = (InputDeviceCommand)GetInt32(new IntPtr(p + 0x010)); // 0x10 BaseCommand                 ( ModelEnumType InputDeviceCommand InputDeviceCommand InputDeviceCommand Int32 )
            value.M_ImeEnabled                              = GetSByte(new IntPtr(p + 0x018)); // 0x18 M_ImeEnabled                ( ModelPrimitiveType sbyte sbyte sbyte SByte )

            return value;
        }
    }
}
