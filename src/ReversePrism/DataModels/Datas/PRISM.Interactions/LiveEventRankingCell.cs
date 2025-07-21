using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 HeaderView                               ModelClassType MusicRankingHeaderView MusicRankingHeaderView MusicRankingHeaderView Pointer
    // 068 IdolIcon                                 ModelClassType PFIdolIconView PFIdolIconView PFIdolIconView Pointer
    // 070 UserName                                 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 078 AchievementIcons                         ModelClassListType SimpleAchievementIcon[] SimpleAchievementIcon[] List<SimpleAchievementIcon> Pointer
    // 080 MyselfCellBase                           ModelClassType GameObject GameObject GameObject Pointer
    // 088 RankingTypeObjects                       ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 090 Point                                    ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 098 Score                                    ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 0A0 IdolPoint                                ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 0A8 DifficultyIcon                           ModelClassType MusicDifficultyIcon MusicDifficultyIcon MusicDifficultyIcon Pointer
    // 0B0 PointIcon                                ModelClassType RawImage RawImage RawImage Pointer
    // 0B8 IdolPointIcon                            ModelClassType RawImage RawImage RawImage Pointer
    // 0C0 CommentText                              ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 0C8 Canceller                                ModelEnumType AutoCancellationTokenSource AutoCancellationTokenSource AutoCancellationTokenSource Int32
    public partial class LiveEventRankingCell : DataModel
    {
        public MusicRankingHeaderView?                  HeaderView                              { get; set; }
        public PFIdolIconView?                          IdolIcon                                { get; set; }
        public UITextMeshProUGUI?                       UserName                                { get; set; }
        public List<SimpleAchievementIcon>?             AchievementIcons                        { get; set; }
        public GameObject?                              MyselfCellBase                          { get; set; }
        public List<GameObject>?                        RankingTypeObjects                      { get; set; }
        public UITextMeshProUGUI?                       Point                                   { get; set; }
        public UITextMeshProUGUI?                       Score                                   { get; set; }
        public UITextMeshProUGUI?                       IdolPoint                               { get; set; }
        public MusicDifficultyIcon?                     DifficultyIcon                          { get; set; }
        public RawImage?                                PointIcon                               { get; set; }
        public RawImage?                                IdolPointIcon                           { get; set; }
        public UITextMeshProUGUI?                       CommentText                             { get; set; }
        public AutoCancellationTokenSource              Canceller                               { get; set; }

        public static LiveEventRankingCell? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveEventRankingCell() { Pointer= p0 };

            value.HeaderView                                = GetObject<MusicRankingHeaderView>(new IntPtr(p + 0x060), ReversePrism.DataModels.MusicRankingHeaderView.FromPointer); // 0x60 HeaderView                  ( ModelClassType MusicRankingHeaderView MusicRankingHeaderView MusicRankingHeaderView Pointer )
            value.IdolIcon                                  = GetObject<PFIdolIconView>(new IntPtr(p + 0x068), ReversePrism.DataModels.PFIdolIconView.FromPointer); // 0x68 IdolIcon                    ( ModelClassType PFIdolIconView PFIdolIconView PFIdolIconView Pointer )
            value.UserName                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x070), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x70 UserName                    ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.AchievementIcons                          = GetObjectList<SimpleAchievementIcon>(new IntPtr(p + 0x078), ReversePrism.DataModels.SimpleAchievementIcon.FromPointer); // 0x78 AchievementIcons            ( ModelClassListType SimpleAchievementIcon[] SimpleAchievementIcon[] List<SimpleAchievementIcon> Pointer )
            value.MyselfCellBase                            = GetObject<GameObject>(new IntPtr(p + 0x080), ReversePrism.DataModels.GameObject.FromPointer); // 0x80 MyselfCellBase              ( ModelClassType GameObject GameObject GameObject Pointer )
            value.RankingTypeObjects                        = GetObjectList<GameObject>(new IntPtr(p + 0x088), ReversePrism.DataModels.GameObject.FromPointer); // 0x88 RankingTypeObjects          ( ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.Point                                     = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x090), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x90 Point                       ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.Score                                     = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x098), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x98 Score                       ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.IdolPoint                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0xA0 IdolPoint                   ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.DifficultyIcon                            = GetObject<MusicDifficultyIcon>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.MusicDifficultyIcon.FromPointer); // 0xA8 DifficultyIcon              ( ModelClassType MusicDifficultyIcon MusicDifficultyIcon MusicDifficultyIcon Pointer )
            value.PointIcon                                 = GetObject<RawImage>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.RawImage.FromPointer); // 0xB0 PointIcon                   ( ModelClassType RawImage RawImage RawImage Pointer )
            value.IdolPointIcon                             = GetObject<RawImage>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.RawImage.FromPointer); // 0xB8 IdolPointIcon               ( ModelClassType RawImage RawImage RawImage Pointer )
            value.CommentText                               = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0xC0 CommentText                 ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.Canceller                                 = (AutoCancellationTokenSource)GetInt32(new IntPtr(p + 0x0C8)); // 0xC8 Canceller                   ( ModelEnumType AutoCancellationTokenSource AutoCancellationTokenSource AutoCancellationTokenSource Int32 )

            return value;
        }
    }
}
