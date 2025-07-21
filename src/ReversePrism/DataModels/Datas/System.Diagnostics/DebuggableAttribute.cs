using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_debuggingModes                         ModelEnumType DebuggingModes DebuggingModes DebuggingModes Int32
    public partial class DebuggableAttribute : DataModel
    {
        public DebuggingModes                           M_debuggingModes                        { get; set; }

        public static DebuggableAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DebuggableAttribute() { Pointer= p0 };

            value.M_debuggingModes                          = (DebuggingModes)GetInt32(new IntPtr(p + 0x010)); // 0x10 M_debuggingModes            ( ModelEnumType DebuggingModes DebuggingModes DebuggingModes Int32 )

            return value;
        }
    }
}
