using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SupportsVibration                        0001865965D0 ModelPrimitiveType bool bool bool Bool
    public partial class RhythmGameVibrateService : DataModel
    {
        public bool                                     SupportsVibration                       { get; set; }

        public static RhythmGameVibrateService? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RhythmGameVibrateService() { Pointer= p0 };

            value.SupportsVibration                         = GetBool(new IntPtr(p + 0x010)); // 02466508A030 0x10 SupportsVibration           ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
