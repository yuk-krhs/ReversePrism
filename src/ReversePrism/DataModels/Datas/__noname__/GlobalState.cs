using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 touchscreens                             InlinedArray`1<Touchscreen> IL2CPP_TYPE_GENERICINST
    // 028 HistoryLengthPerFinger                   0001865F2F90 ModelPrimitiveType int int int Int32
    // 030 onFingerDown                             CallbackArray`1<Action`1<Finger>> IL2CPP_TYPE_GENERICINST
    // 080 onFingerMove                             CallbackArray`1<Action`1<Finger>> IL2CPP_TYPE_GENERICINST
    // 0D0 onFingerUp                               CallbackArray`1<Action`1<Finger>> IL2CPP_TYPE_GENERICINST
    // 120 PlayerState                              000186628790 ModelEnumType FingerAndTouchState FingerAndTouchState FingerAndTouchState Int32
    public partial class GlobalState
    {
        public int                                      HistoryLengthPerFinger                  { get; set; }
        public FingerAndTouchState                      PlayerState                             { get; set; }

        public static GlobalState? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GlobalState();

            value.HistoryLengthPerFinger                    = GetInt32(new IntPtr(p + 0x028)); // 0270D77DDEC8 0x28 HistoryLengthPerFinger      ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.PlayerState                               = (FingerAndTouchState)GetInt32(new IntPtr(p + 0x120)); // 0270D77DDF48 0x120 PlayerState                 ( 000186628790 ModelEnumType FingerAndTouchState FingerAndTouchState FingerAndTouchState Int32 )

            return value;
        }
    }
}
