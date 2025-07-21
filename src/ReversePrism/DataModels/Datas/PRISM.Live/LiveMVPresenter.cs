using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 View                                     ModelClassType LiveMVView LiveMVView LiveMVView Pointer
    // 028 SetTimeDelayFrame                        ModelPrimitiveType int int int Int32
    // 02C SetTimeDelayTiming                       ModelEnumType PlayerLoopTiming PlayerLoopTiming PlayerLoopTiming Int32
    // 000 SeekWaitMilliSeconds                     int IL2CPP_TYPE_I4
    // 030 IsPausing                                ModelPrimitiveType bool bool bool Bool
    // 038 Canceller                                ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 040 IsInitialized                            ModelPrimitiveType bool bool bool Bool
    // 048 MvPauser                                 ModelClassType IPausable IPausable IPausable Pointer
    // 050 ProgressManager                          ModelClassType LiveProgressManager LiveProgressManager LiveProgressManager Pointer
    // 058 EffectPlayer                             ModelClassType EffectPlayer EffectPlayer EffectPlayer Pointer
    // 060 IsPlaying                                ModelPrimitiveType bool bool bool Bool
    // 068 CurrentLyrics                            ModelPrimitiveType string string string String
    // 070 IsRetrying                               ModelPrimitiveType bool bool bool Bool
    // 078 SeekCanceller                            ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    public partial class LiveMVPresenter : DataModel
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
            var value   = new LiveMVPresenter() { Pointer= p0 };

            value.View                                      = GetObject<LiveMVView>(new IntPtr(p + 0x020), ReversePrism.DataModels.LiveMVView.FromPointer); // 0x20 View                        ( ModelClassType LiveMVView LiveMVView LiveMVView Pointer )
            value.SetTimeDelayFrame                         = GetInt32(new IntPtr(p + 0x028)); // 0x28 SetTimeDelayFrame           ( ModelPrimitiveType int int int Int32 )
            value.SetTimeDelayTiming                        = (PlayerLoopTiming)GetInt32(new IntPtr(p + 0x02C)); // 0x2C SetTimeDelayTiming          ( ModelEnumType PlayerLoopTiming PlayerLoopTiming PlayerLoopTiming Int32 )
            value.IsPausing                                 = GetBool(new IntPtr(p + 0x030)); // 0x30 IsPausing                   ( ModelPrimitiveType bool bool bool Bool )
            value.Canceller                                 = GetObject<CancellationTokenSource>(new IntPtr(p + 0x038), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0x38 Canceller                   ( ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.IsInitialized                             = GetBool(new IntPtr(p + 0x040)); // 0x40 IsInitialized               ( ModelPrimitiveType bool bool bool Bool )
            value.MvPauser                                  = GetObject<IPausable>(new IntPtr(p + 0x048), ReversePrism.DataModels.IPausable.FromPointer); // 0x48 MvPauser                    ( ModelClassType IPausable IPausable IPausable Pointer )
            value.ProgressManager                           = GetObject<LiveProgressManager>(new IntPtr(p + 0x050), ReversePrism.DataModels.LiveProgressManager.FromPointer); // 0x50 ProgressManager             ( ModelClassType LiveProgressManager LiveProgressManager LiveProgressManager Pointer )
            value.EffectPlayer                              = GetObject<EffectPlayer>(new IntPtr(p + 0x058), ReversePrism.DataModels.EffectPlayer.FromPointer); // 0x58 EffectPlayer                ( ModelClassType EffectPlayer EffectPlayer EffectPlayer Pointer )
            value.IsPlaying                                 = GetBool(new IntPtr(p + 0x060)); // 0x60 IsPlaying                   ( ModelPrimitiveType bool bool bool Bool )
            value.CurrentLyrics                             = GetString(new IntPtr(p + 0x068)); // 0x68 CurrentLyrics               ( ModelPrimitiveType string string string String )
            value.IsRetrying                                = GetBool(new IntPtr(p + 0x070)); // 0x70 IsRetrying                  ( ModelPrimitiveType bool bool bool Bool )
            value.SeekCanceller                             = GetObject<CancellationTokenSource>(new IntPtr(p + 0x078), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0x78 SeekCanceller               ( ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )

            return value;
        }
    }
}
