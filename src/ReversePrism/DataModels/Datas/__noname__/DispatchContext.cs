using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_GateCount                              0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 018 m_Queue                                  Queue`1<EventRecord> IL2CPP_TYPE_GENERICINST
    public partial class DispatchContext : DataModel
    {
        public uint                                     M_GateCount                             { get; set; }

        public static DispatchContext? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DispatchContext() { Pointer= p0 };

            value.M_GateCount                               = GetUInt32(new IntPtr(p + 0x010)); // 0245A671B0A0 0x10 M_GateCount                 ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )

            return value;
        }
    }
}
