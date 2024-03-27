using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 LastUpdateType                           000186705EF0 ModelEnumType InputUpdateType InputUpdateType InputUpdateType Int32
    // 014 PlayerUpdateStepCount                    00018663D110 ModelEnumType UpdateStepCount UpdateStepCount UpdateStepCount Int32
    public partial class SerializedState
    {
        public InputUpdateType                          LastUpdateType                          { get; set; }
        public UpdateStepCount                          PlayerUpdateStepCount                   { get; set; }

        public static SerializedState? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SerializedState();

            value.LastUpdateType                            = (InputUpdateType)GetInt32(new IntPtr(p + 0x010)); // 0270D7831E00 0x10 LastUpdateType              ( 000186705EF0 ModelEnumType InputUpdateType InputUpdateType InputUpdateType Int32 )
            value.PlayerUpdateStepCount                     = (UpdateStepCount)GetInt32(new IntPtr(p + 0x014)); // 0270D7831E20 0x14 PlayerUpdateStepCount       ( 00018663D110 ModelEnumType UpdateStepCount UpdateStepCount UpdateStepCount Int32 )

            return value;
        }
    }
}
