using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CancellationToken                        00018653D5A0 ModelEnumType CancellationToken CancellationToken CancellationToken Int32
    // 018 timerCallback                            Action`1<<object>> IL2CPP_TYPE_GENERICINST
    // 020 state                                    <object> IL2CPP_TYPE_OBJECT
    // 028 PlayerLoopTiming                         000186753670 ModelEnumType PlayerLoopTiming PlayerLoopTiming PlayerLoopTiming Int32
    // 02C Periodic                                 0001865965D0 ModelPrimitiveType bool bool bool Bool
    // 02D IsRunning                                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 02E TryStop                                  000186594D10 ModelPrimitiveType bool bool bool Bool
    // 02F IsDisposed                               000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class PlayerLoopTimer : DataModel
    {
        public CancellationToken                        CancellationToken                       { get; set; }
        public PlayerLoopTiming                         PlayerLoopTiming                        { get; set; }
        public bool                                     Periodic                                { get; set; }
        public bool                                     IsRunning                               { get; set; }
        public bool                                     TryStop                                 { get; set; }
        public bool                                     IsDisposed                              { get; set; }

        public static PlayerLoopTimer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PlayerLoopTimer() { Pointer= p0 };

            value.CancellationToken                         = (CancellationToken)GetInt32(new IntPtr(p + 0x010)); // 0245A4E56898 0x10 CancellationToken           ( 00018653D5A0 ModelEnumType CancellationToken CancellationToken CancellationToken Int32 )
            value.PlayerLoopTiming                          = (PlayerLoopTiming)GetInt32(new IntPtr(p + 0x028)); // 0245A4E568F8 0x28 PlayerLoopTiming            ( 000186753670 ModelEnumType PlayerLoopTiming PlayerLoopTiming PlayerLoopTiming Int32 )
            value.Periodic                                  = GetBool(new IntPtr(p + 0x02C)); // 0245A4E56918 0x2C Periodic                    ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )
            value.IsRunning                                 = GetBool(new IntPtr(p + 0x02D)); // 0245A4E56938 0x2D IsRunning                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.TryStop                                   = GetBool(new IntPtr(p + 0x02E)); // 0245A4E56958 0x2E TryStop                     ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsDisposed                                = GetBool(new IntPtr(p + 0x02F)); // 0245A4E56978 0x2F IsDisposed                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
