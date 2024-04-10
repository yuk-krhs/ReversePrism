using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 HeaderView                               000186669DB0 ModelClassType MusicRankingHeaderView MusicRankingHeaderView MusicRankingHeaderView Pointer
    // 068 IdolIcon                                 000186704160 ModelClassType PFIdolIconView PFIdolIconView PFIdolIconView Pointer
    // 070 UserName                                 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 078 AchievementIcons                         000185B6F170 ModelClassListType AchievementIconView[] AchievementIconView[] List<AchievementIconView> Pointer
    // 080 MyselfCellBase                           0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 088 RankingTypeObjects                       000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 090 Point                                    0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 098 Score                                    0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 0A0 DifficultyIcon                           000186665790 ModelClassType MusicDifficultyIcon MusicDifficultyIcon MusicDifficultyIcon Pointer
    // 0A8 PointIcon                                000186613190 ModelClassType RawImage RawImage RawImage Pointer
    // 0B0 CommentText                              0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    public partial class LiveEventRankingCell : DataModel
    {
        public MusicRankingHeaderView?                  HeaderView                              { get; set; }
        public PFIdolIconView?                          IdolIcon                                { get; set; }
        public UITextMeshProUGUI?                       UserName                                { get; set; }
        public List<AchievementIconView>?               AchievementIcons                        { get; set; }
        public GameObject?                              MyselfCellBase                          { get; set; }
        public List<GameObject>?                        RankingTypeObjects                      { get; set; }
        public UITextMeshProUGUI?                       Point                                   { get; set; }
        public UITextMeshProUGUI?                       Score                                   { get; set; }
        public MusicDifficultyIcon?                     DifficultyIcon                          { get; set; }
        public RawImage?                                PointIcon                               { get; set; }
        public UITextMeshProUGUI?                       CommentText                             { get; set; }

        public static LiveEventRankingCell? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveEventRankingCell() { Pointer= p0 };

            value.HeaderView                                = GetObject<MusicRankingHeaderView>(new IntPtr(p + 0x060), ReversePrism.DataModels.MusicRankingHeaderView.FromPointer); // 02466B993780 0x60 HeaderView                  ( 000186669DB0 ModelClassType MusicRankingHeaderView MusicRankingHeaderView MusicRankingHeaderView Pointer )
            value.IdolIcon                                  = GetObject<PFIdolIconView>(new IntPtr(p + 0x068), ReversePrism.DataModels.PFIdolIconView.FromPointer); // 02466B9937A0 0x68 IdolIcon                    ( 000186704160 ModelClassType PFIdolIconView PFIdolIconView PFIdolIconView Pointer )
            value.UserName                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x070), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B9937C0 0x70 UserName                    ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.AchievementIcons                          = GetObjectList<AchievementIconView>(new IntPtr(p + 0x078), ReversePrism.DataModels.AchievementIconView.FromPointer); // 02466B9937E0 0x78 AchievementIcons            ( 000185B6F170 ModelClassListType AchievementIconView[] AchievementIconView[] List<AchievementIconView> Pointer )
            value.MyselfCellBase                            = GetObject<GameObject>(new IntPtr(p + 0x080), ReversePrism.DataModels.GameObject.FromPointer); // 02466B993800 0x80 MyselfCellBase              ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.RankingTypeObjects                        = GetObjectList<GameObject>(new IntPtr(p + 0x088), ReversePrism.DataModels.GameObject.FromPointer); // 02466B993820 0x88 RankingTypeObjects          ( 000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.Point                                     = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x090), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B993840 0x90 Point                       ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.Score                                     = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x098), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B993860 0x98 Score                       ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.DifficultyIcon                            = GetObject<MusicDifficultyIcon>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.MusicDifficultyIcon.FromPointer); // 02466B993880 0xA0 DifficultyIcon              ( 000186665790 ModelClassType MusicDifficultyIcon MusicDifficultyIcon MusicDifficultyIcon Pointer )
            value.PointIcon                                 = GetObject<RawImage>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.RawImage.FromPointer); // 02466B9938A0 0xA8 PointIcon                   ( 000186613190 ModelClassType RawImage RawImage RawImage Pointer )
            value.CommentText                               = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B9938C0 0xB0 CommentText                 ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )

            return value;
        }
    }
}
