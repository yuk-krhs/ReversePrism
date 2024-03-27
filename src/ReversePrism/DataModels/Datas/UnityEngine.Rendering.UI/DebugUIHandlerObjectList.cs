using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 088 M_Index                                  0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class DebugUIHandlerObjectList
    {
        public int                                      M_Index                                 { get; set; }

        public static DebugUIHandlerObjectList? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DebugUIHandlerObjectList();

            value.M_Index                                   = GetInt32(new IntPtr(p + 0x088)); // 0270D9337820 0x88 M_Index                     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
