using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Gate                                     0001865F2AF0 ModelPrimitiveType int int int Int32
    // 018 callback                                 Action`1<<object>> IL2CPP_TYPE_GENERICINST
    // 020 state                                    <object> IL2CPP_TYPE_OBJECT
    public partial class Slot : DataModel
    {
        public int                                      Gate                                    { get; set; }

        public static Slot? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Slot() { Pointer= p0 };

            value.Gate                                      = GetInt32(new IntPtr(p + 0x010)); // 02466BAB2460 0x10 Gate                        ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
