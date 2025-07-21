using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Animators                                ModelClassListType Animator[] Animator[] List<Animator> Pointer
    // 028 SkipAnimationButton                      ModelClassType Button Button Button Pointer
    // 030 CanvasGroup                              ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 038 Data                                     ModelClassType IFinishLiveReply IFinishLiveReply IFinishLiveReply Pointer
    // 040 Cache                                    ModelClassType SongCacheForResult SongCacheForResult SongCacheForResult Pointer
    // 048 InGameData                               ModelClassType LiveResultData LiveResultData LiveResultData Pointer
    // 050 AnimationCanceller                       ModelEnumType AutoCancellationTokenSource AutoCancellationTokenSource AutoCancellationTokenSource Int32
    // 058 IsSkip                                   ModelPrimitiveType bool bool bool Bool
    // 059 IsExecutedPostTask                       ModelPrimitiveType bool bool bool Bool
    public partial class LiveResultViewBase : DataModel
    {
        public List<Animator>?                          Animators                               { get; set; }
        public Button?                                  SkipAnimationButton                     { get; set; }
        public CanvasGroup?                             CanvasGroup                             { get; set; }
        public IFinishLiveReply?                        Data                                    { get; set; }
        public SongCacheForResult?                      Cache                                   { get; set; }
        public LiveResultData?                          InGameData                              { get; set; }
        public AutoCancellationTokenSource              AnimationCanceller                      { get; set; }
        public bool                                     IsSkip                                  { get; set; }
        public bool                                     IsExecutedPostTask                      { get; set; }

        public static LiveResultViewBase? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveResultViewBase() { Pointer= p0 };

            value.Animators                                 = GetObjectList<Animator>(new IntPtr(p + 0x020), ReversePrism.DataModels.Animator.FromPointer); // 0x20 Animators                   ( ModelClassListType Animator[] Animator[] List<Animator> Pointer )
            value.SkipAnimationButton                       = GetObject<Button>(new IntPtr(p + 0x028), ReversePrism.DataModels.Button.FromPointer); // 0x28 SkipAnimationButton         ( ModelClassType Button Button Button Pointer )
            value.CanvasGroup                               = GetObject<CanvasGroup>(new IntPtr(p + 0x030), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0x30 CanvasGroup                 ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.Data                                      = GetObject<IFinishLiveReply>(new IntPtr(p + 0x038), ReversePrism.DataModels.IFinishLiveReply.FromPointer); // 0x38 Data                        ( ModelClassType IFinishLiveReply IFinishLiveReply IFinishLiveReply Pointer )
            value.Cache                                     = GetObject<SongCacheForResult>(new IntPtr(p + 0x040), ReversePrism.DataModels.SongCacheForResult.FromPointer); // 0x40 Cache                       ( ModelClassType SongCacheForResult SongCacheForResult SongCacheForResult Pointer )
            value.InGameData                                = GetObject<LiveResultData>(new IntPtr(p + 0x048), ReversePrism.DataModels.LiveResultData.FromPointer); // 0x48 InGameData                  ( ModelClassType LiveResultData LiveResultData LiveResultData Pointer )
            value.AnimationCanceller                        = (AutoCancellationTokenSource)GetInt32(new IntPtr(p + 0x050)); // 0x50 AnimationCanceller          ( ModelEnumType AutoCancellationTokenSource AutoCancellationTokenSource AutoCancellationTokenSource Int32 )
            value.IsSkip                                    = GetBool(new IntPtr(p + 0x058)); // 0x58 IsSkip                      ( ModelPrimitiveType bool bool bool Bool )
            value.IsExecutedPostTask                        = GetBool(new IntPtr(p + 0x059)); // 0x59 IsExecutedPostTask          ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
