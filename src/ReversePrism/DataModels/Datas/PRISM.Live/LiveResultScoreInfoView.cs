using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ScoreNewRecordBadge                      ModelClassType GameObject GameObject GameObject Pointer
    // 028 ScoreTexts                               ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer
    // 030 ScoreLeadingZeroTexts                    ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer
    // 038 ScoreRankIcon                            ModelClassType ScoreRankIcon ScoreRankIcon ScoreRankIcon Pointer
    // 040 HighScoreText                            ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 TechnicalScoreNewRecordBadge             ModelClassType GameObject GameObject GameObject Pointer
    // 050 TechnicalScoreTexts                      ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer
    // 058 TechnicalScoreLeadingZeroTexts           ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer
    // 060 TechnicalHighScoreText                   ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    public partial class LiveResultScoreInfoView : DataModel
    {
        public GameObject?                              ScoreNewRecordBadge                     { get; set; }
        public List<UITextMeshProUGUI>?                 ScoreTexts                              { get; set; }
        public List<UITextMeshProUGUI>?                 ScoreLeadingZeroTexts                   { get; set; }
        public ScoreRankIcon?                           ScoreRankIcon                           { get; set; }
        public UITextMeshProUGUI?                       HighScoreText                           { get; set; }
        public GameObject?                              TechnicalScoreNewRecordBadge            { get; set; }
        public List<UITextMeshProUGUI>?                 TechnicalScoreTexts                     { get; set; }
        public List<UITextMeshProUGUI>?                 TechnicalScoreLeadingZeroTexts          { get; set; }
        public UITextMeshProUGUI?                       TechnicalHighScoreText                  { get; set; }

        public static LiveResultScoreInfoView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveResultScoreInfoView() { Pointer= p0 };

            value.ScoreNewRecordBadge                       = GetObject<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 0x20 ScoreNewRecordBadge         ( ModelClassType GameObject GameObject GameObject Pointer )
            value.ScoreTexts                                = GetObjectList<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x28 ScoreTexts                  ( ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer )
            value.ScoreLeadingZeroTexts                     = GetObjectList<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x30 ScoreLeadingZeroTexts       ( ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer )
            value.ScoreRankIcon                             = GetObject<ScoreRankIcon>(new IntPtr(p + 0x038), ReversePrism.DataModels.ScoreRankIcon.FromPointer); // 0x38 ScoreRankIcon               ( ModelClassType ScoreRankIcon ScoreRankIcon ScoreRankIcon Pointer )
            value.HighScoreText                             = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x40 HighScoreText               ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TechnicalScoreNewRecordBadge              = GetObject<GameObject>(new IntPtr(p + 0x048), ReversePrism.DataModels.GameObject.FromPointer); // 0x48 TechnicalScoreNewRecordBadge ( ModelClassType GameObject GameObject GameObject Pointer )
            value.TechnicalScoreTexts                       = GetObjectList<UITextMeshProUGUI>(new IntPtr(p + 0x050), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x50 TechnicalScoreTexts         ( ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer )
            value.TechnicalScoreLeadingZeroTexts            = GetObjectList<UITextMeshProUGUI>(new IntPtr(p + 0x058), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x58 TechnicalScoreLeadingZeroTexts ( ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer )
            value.TechnicalHighScoreText                    = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x060), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x60 TechnicalHighScoreText      ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )

            return value;
        }
    }
}
