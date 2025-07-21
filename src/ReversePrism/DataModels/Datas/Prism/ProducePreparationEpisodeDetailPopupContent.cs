using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 Title                                    ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 068 SynopsisText                             ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 070 Thumbnail                                ModelClassType UIImage UIImage UIImage Pointer
    // 078 VoAttributeGrayOutController             ModelClassType UIGrayOutController UIGrayOutController UIGrayOutController Pointer
    // 080 DaAttributeGrayOutController             ModelClassType UIGrayOutController UIGrayOutController UIGrayOutController Pointer
    // 088 ViAttributeGrayOutController             ModelClassType UIGrayOutController UIGrayOutController UIGrayOutController Pointer
    // 090 DifficultyButtons                        ModelClassListType ProduceEpisodeEpisodeSelectDifficultyButton[] ProduceEpisodeEpisodeSelectDifficultyButton[] List<ProduceEpisodeEpisodeSelectDifficultyButton> Pointer
    public partial class ProducePreparationEpisodeDetailPopupContent : DataModel
    {
        public UITextMeshProUGUI?                       Title                                   { get; set; }
        public UITextMeshProUGUI?                       SynopsisText                            { get; set; }
        public UIImage?                                 Thumbnail                               { get; set; }
        public UIGrayOutController?                     VoAttributeGrayOutController            { get; set; }
        public UIGrayOutController?                     DaAttributeGrayOutController            { get; set; }
        public UIGrayOutController?                     ViAttributeGrayOutController            { get; set; }
        public List<ProduceEpisodeEpisodeSelectDifficultyButton>? DifficultyButtons                       { get; set; }

        public static ProducePreparationEpisodeDetailPopupContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProducePreparationEpisodeDetailPopupContent() { Pointer= p0 };

            value.Title                                     = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x060), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x60 Title                       ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.SynopsisText                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x068), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x68 SynopsisText                ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.Thumbnail                                 = GetObject<UIImage>(new IntPtr(p + 0x070), ReversePrism.DataModels.UIImage.FromPointer); // 0x70 Thumbnail                   ( ModelClassType UIImage UIImage UIImage Pointer )
            value.VoAttributeGrayOutController              = GetObject<UIGrayOutController>(new IntPtr(p + 0x078), ReversePrism.DataModels.UIGrayOutController.FromPointer); // 0x78 VoAttributeGrayOutController ( ModelClassType UIGrayOutController UIGrayOutController UIGrayOutController Pointer )
            value.DaAttributeGrayOutController              = GetObject<UIGrayOutController>(new IntPtr(p + 0x080), ReversePrism.DataModels.UIGrayOutController.FromPointer); // 0x80 DaAttributeGrayOutController ( ModelClassType UIGrayOutController UIGrayOutController UIGrayOutController Pointer )
            value.ViAttributeGrayOutController              = GetObject<UIGrayOutController>(new IntPtr(p + 0x088), ReversePrism.DataModels.UIGrayOutController.FromPointer); // 0x88 ViAttributeGrayOutController ( ModelClassType UIGrayOutController UIGrayOutController UIGrayOutController Pointer )
            value.DifficultyButtons                         = GetObjectList<ProduceEpisodeEpisodeSelectDifficultyButton>(new IntPtr(p + 0x090), ReversePrism.DataModels.ProduceEpisodeEpisodeSelectDifficultyButton.FromPointer); // 0x90 DifficultyButtons           ( ModelClassListType ProduceEpisodeEpisodeSelectDifficultyButton[] ProduceEpisodeEpisodeSelectDifficultyButton[] List<ProduceEpisodeEpisodeSelectDifficultyButton> Pointer )

            return value;
        }
    }
}
