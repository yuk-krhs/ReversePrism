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
    // 018 CanRunInBackground                       000186595960 ModelPrimitiveType bool bool bool Bool
    public partial class QueryCanRunInBackground : DataModel
    {
        public InputDeviceCommand                       BaseCommand                             { get; set; }
        public bool                                     CanRunInBackground                      { get; set; }

        public static QueryCanRunInBackground? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new QueryCanRunInBackground() { Pointer= p0 };

            value.BaseCommand                               = (InputDeviceCommand)GetInt32(new IntPtr(p + 0x010)); // 024667853120 0x10 BaseCommand                 ( 0001865ECDD0 ModelEnumType InputDeviceCommand InputDeviceCommand InputDeviceCommand Int32 )
            value.CanRunInBackground                        = GetBool(new IntPtr(p + 0x018)); // 024667853140 0x18 CanRunInBackground          ( 000186595960 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
