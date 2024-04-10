using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 State                                    0001866A7EB0 ModelEnumType DebuggerBrowsableState DebuggerBrowsableState DebuggerBrowsableState Int32
    public partial class DebuggerBrowsableAttribute : DataModel
    {
        public DebuggerBrowsableState                   State                                   { get; set; }

        public static DebuggerBrowsableAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DebuggerBrowsableAttribute() { Pointer= p0 };

            value.State                                     = (DebuggerBrowsableState)GetInt32(new IntPtr(p + 0x010)); // 024666D927F8 0x10 State                       ( 0001866A7EB0 ModelEnumType DebuggerBrowsableState DebuggerBrowsableState DebuggerBrowsableState Int32 )

            return value;
        }
    }
}
