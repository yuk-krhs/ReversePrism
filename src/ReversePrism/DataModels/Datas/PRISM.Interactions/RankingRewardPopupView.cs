using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 onClick                                  Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 028 TabGroup                                 0001866F5490 ModelClassType UITabGroup UITabGroup UITabGroup Pointer
    // 030 TabViews                                 000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 038 HighScoreRewardListView                  00018660EBF0 ModelClassType RankingRewardListView RankingRewardListView RankingRewardListView Pointer
    // 040 TechnicalRewardListView                  00018660EBF0 ModelClassType RankingRewardListView RankingRewardListView RankingRewardListView Pointer
    // 048 SeasonNumber                             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 050 Parent                                   0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class RankingRewardPopupView
    {
        public UITabGroup?                              TabGroup                                { get; set; }
        public List<GameObject>?                        TabViews                                { get; set; }
        public RankingRewardListView?                   HighScoreRewardListView                 { get; set; }
        public RankingRewardListView?                   TechnicalRewardListView                 { get; set; }
        public int                                      SeasonNumber                            { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static RankingRewardPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RankingRewardPopupView();

            value.TabGroup                                  = GetObject<UITabGroup>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITabGroup.FromPointer); // 0270DB57BB28 0x28 TabGroup                    ( 0001866F5490 ModelClassType UITabGroup UITabGroup UITabGroup Pointer )
            value.TabViews                                  = GetObjectList<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 0270DB57BB48 0x30 TabViews                    ( 000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.HighScoreRewardListView                   = GetObject<RankingRewardListView>(new IntPtr(p + 0x038), ReversePrism.DataModels.RankingRewardListView.FromPointer); // 0270DB57BB68 0x38 HighScoreRewardListView     ( 00018660EBF0 ModelClassType RankingRewardListView RankingRewardListView RankingRewardListView Pointer )
            value.TechnicalRewardListView                   = GetObject<RankingRewardListView>(new IntPtr(p + 0x040), ReversePrism.DataModels.RankingRewardListView.FromPointer); // 0270DB57BB88 0x40 TechnicalRewardListView     ( 00018660EBF0 ModelClassType RankingRewardListView RankingRewardListView RankingRewardListView Pointer )
            value.SeasonNumber                              = GetInt32(new IntPtr(p + 0x048)); // 0270DB57BBA8 0x48 SeasonNumber                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x050), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0270DB57BBC8 0x50 Parent                      ( 0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
