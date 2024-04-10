using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 CancelCancellationTokenSourceStateDelegate Action`1<<object>> IL2CPP_TYPE_GENERICINST
    // 010 TimeoutSource                            0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 018 LinkedSource                             0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 020 Timer                                    000186752CE0 ModelClassType PlayerLoopTimer PlayerLoopTimer PlayerLoopTimer Pointer
    // 028 IsDisposed                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 02C DelayType                                0001866B9D60 ModelEnumType DelayType DelayType DelayType Int32
    // 030 DelayTiming                              000186753670 ModelEnumType PlayerLoopTiming PlayerLoopTiming PlayerLoopTiming Int32
    // 038 OriginalLinkCancellationTokenSource      0001865A4380 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    public partial class TimeoutController : DataModel
    {
        public CancellationTokenSource?                 TimeoutSource                           { get; set; }
        public CancellationTokenSource?                 LinkedSource                            { get; set; }
        public PlayerLoopTimer?                         Timer                                   { get; set; }
        public bool                                     IsDisposed                              { get; set; }
        public DelayType                                DelayType                               { get; set; }
        public PlayerLoopTiming                         DelayTiming                             { get; set; }
        public CancellationTokenSource?                 OriginalLinkCancellationTokenSource     { get; set; }

        public static TimeoutController? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TimeoutController() { Pointer= p0 };

            value.TimeoutSource                             = GetObject<CancellationTokenSource>(new IntPtr(p + 0x010), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0245A4E56310 0x10 TimeoutSource               ( 0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.LinkedSource                              = GetObject<CancellationTokenSource>(new IntPtr(p + 0x018), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0245A4E56330 0x18 LinkedSource                ( 0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.Timer                                     = GetObject<PlayerLoopTimer>(new IntPtr(p + 0x020), ReversePrism.DataModels.PlayerLoopTimer.FromPointer); // 0245A4E56350 0x20 Timer                       ( 000186752CE0 ModelClassType PlayerLoopTimer PlayerLoopTimer PlayerLoopTimer Pointer )
            value.IsDisposed                                = GetBool(new IntPtr(p + 0x028)); // 0245A4E56370 0x28 IsDisposed                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.DelayType                                 = (DelayType)GetInt32(new IntPtr(p + 0x02C)); // 0245A4E56390 0x2C DelayType                   ( 0001866B9D60 ModelEnumType DelayType DelayType DelayType Int32 )
            value.DelayTiming                               = (PlayerLoopTiming)GetInt32(new IntPtr(p + 0x030)); // 0245A4E563B0 0x30 DelayTiming                 ( 000186753670 ModelEnumType PlayerLoopTiming PlayerLoopTiming PlayerLoopTiming Int32 )
            value.OriginalLinkCancellationTokenSource       = GetObject<CancellationTokenSource>(new IntPtr(p + 0x038), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0245A4E563D0 0x38 OriginalLinkCancellationTokenSource ( 0001865A4380 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )

            return value;
        }
    }
}
