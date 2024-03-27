using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TargetPhase                              0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class UpdatePhaseSequence
    {
        public int                                      TargetPhase                             { get; set; }

        public static UpdatePhaseSequence? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UpdatePhaseSequence();

            value.TargetPhase                               = GetInt32(new IntPtr(p + 0x010)); // 027005AB1B58 0x10 TargetPhase                 ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
