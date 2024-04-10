using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 kSize                                    int IL2CPP_TYPE_I4
    // 010 BaseCommand                              0001865ECDD0 ModelEnumType InputDeviceCommand InputDeviceCommand InputDeviceCommand Int32
    // 018 OutDimensions                            0001866A8740 ModelEnumType Vector2 Vector2 Vector2 Int32
    public partial class QueryDimensionsCommand : DataModel
    {
        public InputDeviceCommand                       BaseCommand                             { get; set; }
        public Vector2                                  OutDimensions                           { get; set; }

        public static QueryDimensionsCommand? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new QueryDimensionsCommand() { Pointer= p0 };

            value.BaseCommand                               = (InputDeviceCommand)GetInt32(new IntPtr(p + 0x010)); // 024667853350 0x10 BaseCommand                 ( 0001865ECDD0 ModelEnumType InputDeviceCommand InputDeviceCommand InputDeviceCommand Int32 )
            value.OutDimensions                             = (Vector2)GetInt32(new IntPtr(p + 0x018)); // 024667853370 0x18 OutDimensions               ( 0001866A8740 ModelEnumType Vector2 Vector2 Vector2 Int32 )

            return value;
        }
    }
}
