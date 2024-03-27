using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Animators                                000185B702A0 ModelClassListType Animator[] Animator[] List<Animator> Pointer
    // 028 SkipAnimationButton                      000186514380 ModelClassType Button Button Button Pointer
    // 030 CanvasGroup                              000186541150 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 038 Data                                     00018650F090 ModelClassType IFinishLiveReply IFinishLiveReply IFinishLiveReply Pointer
    // 040 Cache                                    000186528930 ModelClassType SongCacheForResult SongCacheForResult SongCacheForResult Pointer
    // 048 AnimationCanceller                       000186724700 ModelEnumType AutoCancellationTokenSource AutoCancellationTokenSource AutoCancellationTokenSource Int32
    // 050 IsSkip                                   000186595480 ModelPrimitiveType bool bool bool Bool
    // 051 IsExecutedPostTask                       000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class LiveResultViewBase
    {
        public List<Animator>?                          Animators                               { get; set; }
        public Button?                                  SkipAnimationButton                     { get; set; }
        public CanvasGroup?                             CanvasGroup                             { get; set; }
        public IFinishLiveReply?                        Data                                    { get; set; }
        public SongCacheForResult?                      Cache                                   { get; set; }
        public AutoCancellationTokenSource              AnimationCanceller                      { get; set; }
        public bool                                     IsSkip                                  { get; set; }
        public bool                                     IsExecutedPostTask                      { get; set; }

        public static LiveResultViewBase? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveResultViewBase();

            value.Animators                                 = GetObjectList<Animator>(new IntPtr(p + 0x020), ReversePrism.DataModels.Animator.FromPointer); // 0270D5237038 0x20 Animators                   ( 000185B702A0 ModelClassListType Animator[] Animator[] List<Animator> Pointer )
            value.SkipAnimationButton                       = GetObject<Button>(new IntPtr(p + 0x028), ReversePrism.DataModels.Button.FromPointer); // 0270D5237058 0x28 SkipAnimationButton         ( 000186514380 ModelClassType Button Button Button Pointer )
            value.CanvasGroup                               = GetObject<CanvasGroup>(new IntPtr(p + 0x030), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0270D5237078 0x30 CanvasGroup                 ( 000186541150 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.Data                                      = GetObject<IFinishLiveReply>(new IntPtr(p + 0x038), ReversePrism.DataModels.IFinishLiveReply.FromPointer); // 0270D5237098 0x38 Data                        ( 00018650F090 ModelClassType IFinishLiveReply IFinishLiveReply IFinishLiveReply Pointer )
            value.Cache                                     = GetObject<SongCacheForResult>(new IntPtr(p + 0x040), ReversePrism.DataModels.SongCacheForResult.FromPointer); // 0270D52370B8 0x40 Cache                       ( 000186528930 ModelClassType SongCacheForResult SongCacheForResult SongCacheForResult Pointer )
            value.AnimationCanceller                        = (AutoCancellationTokenSource)GetInt32(new IntPtr(p + 0x048)); // 0270D52370D8 0x48 AnimationCanceller          ( 000186724700 ModelEnumType AutoCancellationTokenSource AutoCancellationTokenSource AutoCancellationTokenSource Int32 )
            value.IsSkip                                    = GetBool(new IntPtr(p + 0x050)); // 0270D52370F8 0x50 IsSkip                      ( 000186595480 ModelPrimitiveType bool bool bool Bool )
            value.IsExecutedPostTask                        = GetBool(new IntPtr(p + 0x051)); // 0270D5237118 0x51 IsExecutedPostTask          ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
