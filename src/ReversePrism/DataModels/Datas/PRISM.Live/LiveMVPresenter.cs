using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 View                                     000186562FC0 ModelClassType LiveMVView LiveMVView LiveMVView Pointer
    // 028 SetTimeDelayFrame                        0001865F2AF0 ModelPrimitiveType int int int Int32
    // 02C SetTimeDelayTiming                       0001867531A0 ModelEnumType PlayerLoopTiming PlayerLoopTiming PlayerLoopTiming Int32
    // 000 SeekWaitMilliSeconds                     int IL2CPP_TYPE_I4
    // 030 IsPausing                                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 038 Canceller                                0001865A4380 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 040 IsInitialized                            000186594D10 ModelPrimitiveType bool bool bool Bool
    // 048 MvPauser                                 0001865D2D40 ModelClassType IPausable IPausable IPausable Pointer
    // 050 ProgressManager                          000186569620 ModelClassType LiveProgressManager LiveProgressManager LiveProgressManager Pointer
    // 058 EffectPlayer                             0001867210F0 ModelClassType EffectPlayer EffectPlayer EffectPlayer Pointer
    // 060 IsPlaying                                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 068 CurrentLyrics                            000186671910 ModelPrimitiveType string string string String
    // 070 IsRetrying                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 078 SeekCanceller                            0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    public partial class LiveMVPresenter
    {
        public LiveMVView?                              View                                    { get; set; }
        public int                                      SetTimeDelayFrame                       { get; set; }
        public PlayerLoopTiming                         SetTimeDelayTiming                      { get; set; }
        public bool                                     IsPausing                               { get; set; }
        public CancellationTokenSource?                 Canceller                               { get; set; }
        public bool                                     IsInitialized                           { get; set; }
        public IPausable?                               MvPauser                                { get; set; }
        public LiveProgressManager?                     ProgressManager                         { get; set; }
        public EffectPlayer?                            EffectPlayer                            { get; set; }
        public bool                                     IsPlaying                               { get; set; }
        public string                                   CurrentLyrics                           { get; set; }
        public bool                                     IsRetrying                              { get; set; }
        public CancellationTokenSource?                 SeekCanceller                           { get; set; }

        public static LiveMVPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveMVPresenter();

            value.View                                      = GetObject<LiveMVView>(new IntPtr(p + 0x020), ReversePrism.DataModels.LiveMVView.FromPointer); // 0270D4E2C8D0 0x20 View                        ( 000186562FC0 ModelClassType LiveMVView LiveMVView LiveMVView Pointer )
            value.SetTimeDelayFrame                         = GetInt32(new IntPtr(p + 0x028)); // 0270D4E2C8F0 0x28 SetTimeDelayFrame           ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.SetTimeDelayTiming                        = (PlayerLoopTiming)GetInt32(new IntPtr(p + 0x02C)); // 0270D4E2C910 0x2C SetTimeDelayTiming          ( 0001867531A0 ModelEnumType PlayerLoopTiming PlayerLoopTiming PlayerLoopTiming Int32 )
            value.IsPausing                                 = GetBool(new IntPtr(p + 0x030)); // 0270D4E2C950 0x30 IsPausing                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Canceller                                 = GetObject<CancellationTokenSource>(new IntPtr(p + 0x038), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0270D4E2C970 0x38 Canceller                   ( 0001865A4380 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.IsInitialized                             = GetBool(new IntPtr(p + 0x040)); // 0270D4E2C990 0x40 IsInitialized               ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.MvPauser                                  = GetObject<IPausable>(new IntPtr(p + 0x048), ReversePrism.DataModels.IPausable.FromPointer); // 0270D4E2C9B0 0x48 MvPauser                    ( 0001865D2D40 ModelClassType IPausable IPausable IPausable Pointer )
            value.ProgressManager                           = GetObject<LiveProgressManager>(new IntPtr(p + 0x050), ReversePrism.DataModels.LiveProgressManager.FromPointer); // 0270D4E2C9D0 0x50 ProgressManager             ( 000186569620 ModelClassType LiveProgressManager LiveProgressManager LiveProgressManager Pointer )
            value.EffectPlayer                              = GetObject<EffectPlayer>(new IntPtr(p + 0x058), ReversePrism.DataModels.EffectPlayer.FromPointer); // 0270D4E2C9F0 0x58 EffectPlayer                ( 0001867210F0 ModelClassType EffectPlayer EffectPlayer EffectPlayer Pointer )
            value.IsPlaying                                 = GetBool(new IntPtr(p + 0x060)); // 0270D4E2CA10 0x60 IsPlaying                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.CurrentLyrics                             = GetString(new IntPtr(p + 0x068)); // 0270D4E2CA30 0x68 CurrentLyrics               ( 000186671910 ModelPrimitiveType string string string String )
            value.IsRetrying                                = GetBool(new IntPtr(p + 0x070)); // 0270D4E2CA50 0x70 IsRetrying                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.SeekCanceller                             = GetObject<CancellationTokenSource>(new IntPtr(p + 0x078), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0270D4E2CA70 0x78 SeekCanceller               ( 0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )

            return value;
        }
    }
}
