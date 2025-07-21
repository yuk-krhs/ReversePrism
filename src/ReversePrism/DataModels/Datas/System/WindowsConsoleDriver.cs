using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 inputHandle                              <int> IL2CPP_TYPE_I
    // 018 outputHandle                             <int> IL2CPP_TYPE_I
    // 020 DefaultAttribute                         ModelPrimitiveType short short short Int16
    public partial class WindowsConsoleDriver : DataModel
    {
        public short                                    DefaultAttribute                        { get; set; }

        public static WindowsConsoleDriver? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new WindowsConsoleDriver() { Pointer= p0 };

            value.DefaultAttribute                          = GetInt16(new IntPtr(p + 0x020)); // 0x20 DefaultAttribute            ( ModelPrimitiveType short short short Int16 )

            return value;
        }
    }
}
