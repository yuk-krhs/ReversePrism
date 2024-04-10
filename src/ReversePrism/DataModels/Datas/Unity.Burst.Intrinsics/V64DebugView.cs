using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Value                                  0001865F7F70 ModelEnumType v64 v64 v64 Int32
    public partial class V64DebugView : DataModel
    {
        public v64                                      M_Value                                 { get; set; }

        public static V64DebugView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new V64DebugView() { Pointer= p0 };

            value.M_Value                                   = (v64)GetInt32(new IntPtr(p + 0x010)); // 02466A96EB58 0x10 M_Value                     ( 0001865F7F70 ModelEnumType v64 v64 v64 Int32 )

            return value;
        }
    }
}
