using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ScoreNewRecordBadge                      0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 028 ScoreTexts                               000185CAE588 ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer
    // 030 ScoreLeadingZeroTexts                    000185CAE588 ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer
    // 038 ScoreRankIcon                            0001866EE570 ModelClassType ScoreRankIcon ScoreRankIcon ScoreRankIcon Pointer
    // 040 HighScoreText                            0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 TechnicalScoreNewRecordBadge             0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 050 TechnicalScoreTexts                      000185CAE588 ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer
    // 058 TechnicalScoreLeadingZeroTexts           000185CAE588 ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer
    // 060 TechnicalHighScoreText                   0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    public partial class LiveResultScoreInfoView
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
            var value   = new LiveResultScoreInfoView();

            value.ScoreNewRecordBadge                       = GetObject<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 0270D526BCD0 0x20 ScoreNewRecordBadge         ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.ScoreTexts                                = GetObjectList<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D526BCF0 0x28 ScoreTexts                  ( 000185CAE588 ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer )
            value.ScoreLeadingZeroTexts                     = GetObjectList<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D526BD10 0x30 ScoreLeadingZeroTexts       ( 000185CAE588 ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer )
            value.ScoreRankIcon                             = GetObject<ScoreRankIcon>(new IntPtr(p + 0x038), ReversePrism.DataModels.ScoreRankIcon.FromPointer); // 0270D526BD30 0x38 ScoreRankIcon               ( 0001866EE570 ModelClassType ScoreRankIcon ScoreRankIcon ScoreRankIcon Pointer )
            value.HighScoreText                             = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D526BD50 0x40 HighScoreText               ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TechnicalScoreNewRecordBadge              = GetObject<GameObject>(new IntPtr(p + 0x048), ReversePrism.DataModels.GameObject.FromPointer); // 0270D526BD70 0x48 TechnicalScoreNewRecordBadge ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.TechnicalScoreTexts                       = GetObjectList<UITextMeshProUGUI>(new IntPtr(p + 0x050), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D526BD90 0x50 TechnicalScoreTexts         ( 000185CAE588 ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer )
            value.TechnicalScoreLeadingZeroTexts            = GetObjectList<UITextMeshProUGUI>(new IntPtr(p + 0x058), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D526BDB0 0x58 TechnicalScoreLeadingZeroTexts ( 000185CAE588 ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer )
            value.TechnicalHighScoreText                    = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x060), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D526BDD0 0x60 TechnicalHighScoreText      ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )

            return value;
        }
    }
}
