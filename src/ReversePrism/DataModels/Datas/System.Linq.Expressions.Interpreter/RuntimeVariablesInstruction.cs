using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Count                                    0001865F4260 ModelPrimitiveType int int int Int32
    public partial class RuntimeVariablesInstruction
    {
        public int                                      Count                                   { get; set; }

        public static RuntimeVariablesInstruction? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RuntimeVariablesInstruction();

            value.Count                                     = GetInt32(new IntPtr(p + 0x010)); // 0270DA010F18 0x10 Count                       ( 0001865F4260 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
