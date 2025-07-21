using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 touchscreens                             InlinedArray`1<Touchscreen> IL2CPP_TYPE_GENERICINST
    // 028 HistoryLengthPerFinger                   ModelPrimitiveType int int int Int32
    // 030 onFingerDown                             CallbackArray`1<Action`1<Finger>> IL2CPP_TYPE_GENERICINST
    // 080 onFingerMove                             CallbackArray`1<Action`1<Finger>> IL2CPP_TYPE_GENERICINST
    // 0D0 onFingerUp                               CallbackArray`1<Action`1<Finger>> IL2CPP_TYPE_GENERICINST
    // 120 PlayerState                              ModelEnumType FingerAndTouchState FingerAndTouchState FingerAndTouchState Int32
    public partial class GlobalState : DataModel
    {
        public int                                      HistoryLengthPerFinger                  { get; set; }
        public FingerAndTouchState                      PlayerState                             { get; set; }

        public static GlobalState? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GlobalState() { Pointer= p0 };

            value.HistoryLengthPerFinger                    = GetInt32(new IntPtr(p + 0x028)); // 0x28 HistoryLengthPerFinger      ( ModelPrimitiveType int int int Int32 )
            value.PlayerState                               = (FingerAndTouchState)GetInt32(new IntPtr(p + 0x120)); // 0x120 PlayerState                 ( ModelEnumType FingerAndTouchState FingerAndTouchState FingerAndTouchState Int32 )

            return value;
        }
    }
}
