using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 HighScoreRateObjects                     000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 028 HighScoreRateTexts                       000185CAE588 ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer
    // 030 HighScoreRateIncreaseTexts               000185CAE588 ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer
    // 038 TotalHighScoreRateObjects                000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 040 TotalHighScoreRateTexts                  000185CAE588 ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer
    // 048 TotalHighScoreRateIncreaseTexts          000185CAE588 ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer
    // 050 TechnicalRateObjects                     000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 058 TechnicalRateTexts                       000185CAE588 ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer
    // 060 TechnicalRateIncreaseTexts               000185CAE588 ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer
    // 068 AverageTechnicalRateObjects              000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 070 AverageTechnicalRateTexts                000185CAE588 ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer
    // 078 AverageTechnicalRateIncreaseTexts        000185CAE588 ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer
    public partial class LiveResultRateInfoView
    {
        public List<GameObject>?                        HighScoreRateObjects                    { get; set; }
        public List<UITextMeshProUGUI>?                 HighScoreRateTexts                      { get; set; }
        public List<UITextMeshProUGUI>?                 HighScoreRateIncreaseTexts              { get; set; }
        public List<GameObject>?                        TotalHighScoreRateObjects               { get; set; }
        public List<UITextMeshProUGUI>?                 TotalHighScoreRateTexts                 { get; set; }
        public List<UITextMeshProUGUI>?                 TotalHighScoreRateIncreaseTexts         { get; set; }
        public List<GameObject>?                        TechnicalRateObjects                    { get; set; }
        public List<UITextMeshProUGUI>?                 TechnicalRateTexts                      { get; set; }
        public List<UITextMeshProUGUI>?                 TechnicalRateIncreaseTexts              { get; set; }
        public List<GameObject>?                        AverageTechnicalRateObjects             { get; set; }
        public List<UITextMeshProUGUI>?                 AverageTechnicalRateTexts               { get; set; }
        public List<UITextMeshProUGUI>?                 AverageTechnicalRateIncreaseTexts       { get; set; }

        public static LiveResultRateInfoView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveResultRateInfoView();

            value.HighScoreRateObjects                      = GetObjectList<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 0270D526B760 0x20 HighScoreRateObjects        ( 000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.HighScoreRateTexts                        = GetObjectList<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D526B780 0x28 HighScoreRateTexts          ( 000185CAE588 ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer )
            value.HighScoreRateIncreaseTexts                = GetObjectList<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D526B7A0 0x30 HighScoreRateIncreaseTexts  ( 000185CAE588 ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer )
            value.TotalHighScoreRateObjects                 = GetObjectList<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 0270D526B7C0 0x38 TotalHighScoreRateObjects   ( 000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.TotalHighScoreRateTexts                   = GetObjectList<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D526B7E0 0x40 TotalHighScoreRateTexts     ( 000185CAE588 ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer )
            value.TotalHighScoreRateIncreaseTexts           = GetObjectList<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D526B800 0x48 TotalHighScoreRateIncreaseTexts ( 000185CAE588 ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer )
            value.TechnicalRateObjects                      = GetObjectList<GameObject>(new IntPtr(p + 0x050), ReversePrism.DataModels.GameObject.FromPointer); // 0270D526B820 0x50 TechnicalRateObjects        ( 000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.TechnicalRateTexts                        = GetObjectList<UITextMeshProUGUI>(new IntPtr(p + 0x058), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D526B840 0x58 TechnicalRateTexts          ( 000185CAE588 ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer )
            value.TechnicalRateIncreaseTexts                = GetObjectList<UITextMeshProUGUI>(new IntPtr(p + 0x060), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D526B860 0x60 TechnicalRateIncreaseTexts  ( 000185CAE588 ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer )
            value.AverageTechnicalRateObjects               = GetObjectList<GameObject>(new IntPtr(p + 0x068), ReversePrism.DataModels.GameObject.FromPointer); // 0270D526B880 0x68 AverageTechnicalRateObjects ( 000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.AverageTechnicalRateTexts                 = GetObjectList<UITextMeshProUGUI>(new IntPtr(p + 0x070), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D526B8A0 0x70 AverageTechnicalRateTexts   ( 000185CAE588 ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer )
            value.AverageTechnicalRateIncreaseTexts         = GetObjectList<UITextMeshProUGUI>(new IntPtr(p + 0x078), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D526B8C0 0x78 AverageTechnicalRateIncreaseTexts ( 000185CAE588 ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer )

            return value;
        }
    }
}
