using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 factoryMethod                            Func`1<InputDevice> IL2CPP_TYPE_GENERICINST
    // 018 Metadata                                 ModelPrimitiveType string string string String
    public partial class PrecompiledLayout : DataModel
    {
        public string                                   Metadata                                { get; set; }

        public static PrecompiledLayout? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PrecompiledLayout() { Pointer= p0 };

            value.Metadata                                  = GetString(new IntPtr(p + 0x018)); // 0x18 Metadata                    ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
