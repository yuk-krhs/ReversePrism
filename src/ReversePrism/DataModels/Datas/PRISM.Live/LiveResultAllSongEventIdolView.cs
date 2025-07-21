using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Icon                                     ModelClassType PFIdolIconViewBase PFIdolIconViewBase PFIdolIconViewBase Pointer
    // 028 PointText                                ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer
    // 030 DiffText                                 ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer
    // 038 GradeIcons                               ModelClassListType LiveEventRankingGradeIcon[] LiveEventRankingGradeIcon[] List<LiveEventRankingGradeIcon> Pointer
    // 040 CharacterId                              ModelPrimitiveType int int int Int32
    public partial class LiveResultAllSongEventIdolView : DataModel
    {
        public PFIdolIconViewBase?                      Icon                                    { get; set; }
        public TextMeshProUGUI?                         PointText                               { get; set; }
        public TextMeshProUGUI?                         DiffText                                { get; set; }
        public List<LiveEventRankingGradeIcon>?         GradeIcons                              { get; set; }
        public int                                      CharacterId                             { get; set; }

        public static LiveResultAllSongEventIdolView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveResultAllSongEventIdolView() { Pointer= p0 };

            value.Icon                                      = GetObject<PFIdolIconViewBase>(new IntPtr(p + 0x020), ReversePrism.DataModels.PFIdolIconViewBase.FromPointer); // 0x20 Icon                        ( ModelClassType PFIdolIconViewBase PFIdolIconViewBase PFIdolIconViewBase Pointer )
            value.PointText                                 = GetObject<TextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.TextMeshProUGUI.FromPointer); // 0x28 PointText                   ( ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer )
            value.DiffText                                  = GetObject<TextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.TextMeshProUGUI.FromPointer); // 0x30 DiffText                    ( ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer )
            value.GradeIcons                                = GetObjectList<LiveEventRankingGradeIcon>(new IntPtr(p + 0x038), ReversePrism.DataModels.LiveEventRankingGradeIcon.FromPointer); // 0x38 GradeIcons                  ( ModelClassListType LiveEventRankingGradeIcon[] LiveEventRankingGradeIcon[] List<LiveEventRankingGradeIcon> Pointer )
            value.CharacterId                               = GetInt32(new IntPtr(p + 0x040)); // 0x40 CharacterId                 ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
