using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 HighScoreRateObjects                     ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 028 HighScoreRateTexts                       ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer
    // 030 HighScoreRateIncreaseTexts               ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer
    // 038 TotalHighScoreRateObjects                ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 040 TotalHighScoreRateTexts                  ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer
    // 048 TotalHighScoreRateIncreaseTexts          ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer
    // 050 TechnicalRateObjects                     ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 058 TechnicalRateTexts                       ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer
    // 060 TechnicalRateIncreaseTexts               ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer
    // 068 AverageTechnicalRateObjects              ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 070 AverageTechnicalRateTexts                ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer
    // 078 AverageTechnicalRateIncreaseTexts        ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer
    public partial class LiveResultRateInfoView : DataModel
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
            var value   = new LiveResultRateInfoView() { Pointer= p0 };

            value.HighScoreRateObjects                      = GetObjectList<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 0x20 HighScoreRateObjects        ( ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.HighScoreRateTexts                        = GetObjectList<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x28 HighScoreRateTexts          ( ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer )
            value.HighScoreRateIncreaseTexts                = GetObjectList<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x30 HighScoreRateIncreaseTexts  ( ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer )
            value.TotalHighScoreRateObjects                 = GetObjectList<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 0x38 TotalHighScoreRateObjects   ( ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.TotalHighScoreRateTexts                   = GetObjectList<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x40 TotalHighScoreRateTexts     ( ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer )
            value.TotalHighScoreRateIncreaseTexts           = GetObjectList<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x48 TotalHighScoreRateIncreaseTexts ( ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer )
            value.TechnicalRateObjects                      = GetObjectList<GameObject>(new IntPtr(p + 0x050), ReversePrism.DataModels.GameObject.FromPointer); // 0x50 TechnicalRateObjects        ( ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.TechnicalRateTexts                        = GetObjectList<UITextMeshProUGUI>(new IntPtr(p + 0x058), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x58 TechnicalRateTexts          ( ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer )
            value.TechnicalRateIncreaseTexts                = GetObjectList<UITextMeshProUGUI>(new IntPtr(p + 0x060), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x60 TechnicalRateIncreaseTexts  ( ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer )
            value.AverageTechnicalRateObjects               = GetObjectList<GameObject>(new IntPtr(p + 0x068), ReversePrism.DataModels.GameObject.FromPointer); // 0x68 AverageTechnicalRateObjects ( ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.AverageTechnicalRateTexts                 = GetObjectList<UITextMeshProUGUI>(new IntPtr(p + 0x070), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x70 AverageTechnicalRateTexts   ( ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer )
            value.AverageTechnicalRateIncreaseTexts         = GetObjectList<UITextMeshProUGUI>(new IntPtr(p + 0x078), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x78 AverageTechnicalRateIncreaseTexts ( ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer )

            return value;
        }
    }
}
