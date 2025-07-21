using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 CancelCancellationTokenSourceStateDelegate Action`1<<object>> IL2CPP_TYPE_GENERICINST
    // 010 TimeoutSource                            ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 018 LinkedSource                             ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 020 Timer                                    ModelClassType PlayerLoopTimer PlayerLoopTimer PlayerLoopTimer Pointer
    // 028 IsDisposed                               ModelPrimitiveType bool bool bool Bool
    // 02C DelayType                                ModelEnumType DelayType DelayType DelayType Int32
    // 030 DelayTiming                              ModelEnumType PlayerLoopTiming PlayerLoopTiming PlayerLoopTiming Int32
    // 038 OriginalLinkCancellationTokenSource      ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
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

            value.TimeoutSource                             = GetObject<CancellationTokenSource>(new IntPtr(p + 0x010), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0x10 TimeoutSource               ( ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.LinkedSource                              = GetObject<CancellationTokenSource>(new IntPtr(p + 0x018), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0x18 LinkedSource                ( ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.Timer                                     = GetObject<PlayerLoopTimer>(new IntPtr(p + 0x020), ReversePrism.DataModels.PlayerLoopTimer.FromPointer); // 0x20 Timer                       ( ModelClassType PlayerLoopTimer PlayerLoopTimer PlayerLoopTimer Pointer )
            value.IsDisposed                                = GetBool(new IntPtr(p + 0x028)); // 0x28 IsDisposed                  ( ModelPrimitiveType bool bool bool Bool )
            value.DelayType                                 = (DelayType)GetInt32(new IntPtr(p + 0x02C)); // 0x2C DelayType                   ( ModelEnumType DelayType DelayType DelayType Int32 )
            value.DelayTiming                               = (PlayerLoopTiming)GetInt32(new IntPtr(p + 0x030)); // 0x30 DelayTiming                 ( ModelEnumType PlayerLoopTiming PlayerLoopTiming PlayerLoopTiming Int32 )
            value.OriginalLinkCancellationTokenSource       = GetObject<CancellationTokenSource>(new IntPtr(p + 0x038), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0x38 OriginalLinkCancellationTokenSource ( ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )

            return value;
        }
    }
}
