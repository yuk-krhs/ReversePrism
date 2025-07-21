using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 IsPausing                                ModelPrimitiveType bool bool bool Bool
    // 011 IsPlaying                                ModelPrimitiveType bool bool bool Bool
    // 012 IsRetrying                               ModelPrimitiveType bool bool bool Bool
    // 018 CurrentLyrics                            ModelPrimitiveType string string string String
    // 020 Disposable                               ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 028 Canceller                                ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 030 SeekCanceller                            ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    public partial class LiveMVOverlaySequencer : DataModel
    {
        public bool                                     IsPausing                               { get; set; }
        public bool                                     IsPlaying                               { get; set; }
        public bool                                     IsRetrying                              { get; set; }
        public string                                   CurrentLyrics                           { get; set; }
        public CompositeDisposable?                     Disposable                              { get; set; }
        public CancellationTokenSource?                 Canceller                               { get; set; }
        public CancellationTokenSource?                 SeekCanceller                           { get; set; }

        public static LiveMVOverlaySequencer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveMVOverlaySequencer() { Pointer= p0 };

            value.IsPausing                                 = GetBool(new IntPtr(p + 0x010)); // 0x10 IsPausing                   ( ModelPrimitiveType bool bool bool Bool )
            value.IsPlaying                                 = GetBool(new IntPtr(p + 0x011)); // 0x11 IsPlaying                   ( ModelPrimitiveType bool bool bool Bool )
            value.IsRetrying                                = GetBool(new IntPtr(p + 0x012)); // 0x12 IsRetrying                  ( ModelPrimitiveType bool bool bool Bool )
            value.CurrentLyrics                             = GetString(new IntPtr(p + 0x018)); // 0x18 CurrentLyrics               ( ModelPrimitiveType string string string String )
            value.Disposable                                = GetObject<CompositeDisposable>(new IntPtr(p + 0x020), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0x20 Disposable                  ( ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.Canceller                                 = GetObject<CancellationTokenSource>(new IntPtr(p + 0x028), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0x28 Canceller                   ( ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.SeekCanceller                             = GetObject<CancellationTokenSource>(new IntPtr(p + 0x030), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0x30 SeekCanceller               ( ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )

            return value;
        }
    }
}
