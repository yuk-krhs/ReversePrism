using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 factoryMethod                            Func`1<InputDevice> IL2CPP_TYPE_GENERICINST
    // 018 Metadata                                 0001866722E0 ModelPrimitiveType string string string String
    public partial class PrecompiledLayout
    {
        public string                                   Metadata                                { get; set; }

        public static PrecompiledLayout? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PrecompiledLayout();

            value.Metadata                                  = GetString(new IntPtr(p + 0x018)); // 027002E4C238 0x18 Metadata                    ( 0001866722E0 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
