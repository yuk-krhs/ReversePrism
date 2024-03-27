using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 Callback                                 0001866735E0 ModelClassType TimerCallback TimerCallback TimerCallback Pointer
    // 020 state                                    <object> IL2CPP_TYPE_OBJECT
    // 028 Due_time_ms                              0001865F7700 ModelPrimitiveType long long long Int64
    // 030 Period_ms                                0001865F7700 ModelPrimitiveType long long long Int64
    // 038 Next_run                                 0001865F7700 ModelPrimitiveType long long long Int64
    // 040 Disposed                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 041 Is_dead                                  000186594D10 ModelPrimitiveType bool bool bool Bool
    // 042 Is_added                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 000 MaxValue                                 long IL2CPP_TYPE_I8
    public partial class Timer
    {
        public TimerCallback?                           Callback                                { get; set; }
        public long                                     Due_time_ms                             { get; set; }
        public long                                     Period_ms                               { get; set; }
        public long                                     Next_run                                { get; set; }
        public bool                                     Disposed                                { get; set; }
        public bool                                     Is_dead                                 { get; set; }
        public bool                                     Is_added                                { get; set; }

        public static Timer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Timer();

            value.Callback                                  = GetObject<TimerCallback>(new IntPtr(p + 0x018), ReversePrism.DataModels.TimerCallback.FromPointer); // 0270D6AC56D8 0x18 Callback                    ( 0001866735E0 ModelClassType TimerCallback TimerCallback TimerCallback Pointer )
            value.Due_time_ms                               = GetInt64(new IntPtr(p + 0x028)); // 0270D6AC5718 0x28 Due_time_ms                 ( 0001865F7700 ModelPrimitiveType long long long Int64 )
            value.Period_ms                                 = GetInt64(new IntPtr(p + 0x030)); // 0270D6AC5738 0x30 Period_ms                   ( 0001865F7700 ModelPrimitiveType long long long Int64 )
            value.Next_run                                  = GetInt64(new IntPtr(p + 0x038)); // 0270D6AC5758 0x38 Next_run                    ( 0001865F7700 ModelPrimitiveType long long long Int64 )
            value.Disposed                                  = GetBool(new IntPtr(p + 0x040)); // 0270D6AC5778 0x40 Disposed                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Is_dead                                   = GetBool(new IntPtr(p + 0x041)); // 0270D6AC5798 0x41 Is_dead                     ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Is_added                                  = GetBool(new IntPtr(p + 0x042)); // 0270D6AC57B8 0x42 Is_added                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
