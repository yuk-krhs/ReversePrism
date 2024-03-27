using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 UserNameText                             0001866409F0 ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer
    // 028 RankingText                              0001866409F0 ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer
    // 030 RankingLabelText                         0001866409F0 ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer
    // 038 ScoreText                                0001866409F0 ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer
    public partial class UserRankingView
    {
        public TextMeshProUGUI?                         UserNameText                            { get; set; }
        public TextMeshProUGUI?                         RankingText                             { get; set; }
        public TextMeshProUGUI?                         RankingLabelText                        { get; set; }
        public TextMeshProUGUI?                         ScoreText                               { get; set; }

        public static UserRankingView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UserRankingView();

            value.UserNameText                              = GetObject<TextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.TextMeshProUGUI.FromPointer); // 0270D51ECC28 0x20 UserNameText                ( 0001866409F0 ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer )
            value.RankingText                               = GetObject<TextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.TextMeshProUGUI.FromPointer); // 0270D51ECC48 0x28 RankingText                 ( 0001866409F0 ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer )
            value.RankingLabelText                          = GetObject<TextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.TextMeshProUGUI.FromPointer); // 0270D51ECC68 0x30 RankingLabelText            ( 0001866409F0 ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer )
            value.ScoreText                                 = GetObject<TextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.TextMeshProUGUI.FromPointer); // 0270D51ECC88 0x38 ScoreText                   ( 0001866409F0 ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer )

            return value;
        }
    }
}
