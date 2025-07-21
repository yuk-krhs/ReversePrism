using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 PFIdolIconRectView                       ModelClassType PFIdolIconRectView PFIdolIconRectView PFIdolIconRectView Pointer
    // 028 ProduceIdolSkillIcon                     ModelClassType IdolSkillIconView IdolSkillIconView IdolSkillIconView Pointer
    // 030 BaseVocalValue                           ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 BaseDanceValue                           ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 BaseVisualValue                          ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 BaseMentalValue                          ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 050 VocalChangeValue                         ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 058 DanceChangeValue                         ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 060 VisualChangeValue                        ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 068 MentalChangeValue                        ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 070 VocalRankImage                           ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 078 DanceRankImage                           ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 080 VisualRankImage                          ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 088 MentalRankImage                          ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    public partial class UnitInfoProduceIdolContent : DataModel
    {
        public PFIdolIconRectView?                      PFIdolIconRectView                      { get; set; }
        public IdolSkillIconView?                       ProduceIdolSkillIcon                    { get; set; }
        public UITextMeshProUGUI?                       BaseVocalValue                          { get; set; }
        public UITextMeshProUGUI?                       BaseDanceValue                          { get; set; }
        public UITextMeshProUGUI?                       BaseVisualValue                         { get; set; }
        public UITextMeshProUGUI?                       BaseMentalValue                         { get; set; }
        public UITextMeshProUGUI?                       VocalChangeValue                        { get; set; }
        public UITextMeshProUGUI?                       DanceChangeValue                        { get; set; }
        public UITextMeshProUGUI?                       VisualChangeValue                       { get; set; }
        public UITextMeshProUGUI?                       MentalChangeValue                       { get; set; }
        public UIRawImage?                              VocalRankImage                          { get; set; }
        public UIRawImage?                              DanceRankImage                          { get; set; }
        public UIRawImage?                              VisualRankImage                         { get; set; }
        public UIRawImage?                              MentalRankImage                         { get; set; }

        public static UnitInfoProduceIdolContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UnitInfoProduceIdolContent() { Pointer= p0 };

            value.PFIdolIconRectView                        = GetObject<PFIdolIconRectView>(new IntPtr(p + 0x020), ReversePrism.DataModels.PFIdolIconRectView.FromPointer); // 0x20 PFIdolIconRectView          ( ModelClassType PFIdolIconRectView PFIdolIconRectView PFIdolIconRectView Pointer )
            value.ProduceIdolSkillIcon                      = GetObject<IdolSkillIconView>(new IntPtr(p + 0x028), ReversePrism.DataModels.IdolSkillIconView.FromPointer); // 0x28 ProduceIdolSkillIcon        ( ModelClassType IdolSkillIconView IdolSkillIconView IdolSkillIconView Pointer )
            value.BaseVocalValue                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x30 BaseVocalValue              ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.BaseDanceValue                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x38 BaseDanceValue              ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.BaseVisualValue                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x40 BaseVisualValue             ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.BaseMentalValue                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x48 BaseMentalValue             ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.VocalChangeValue                          = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x050), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x50 VocalChangeValue            ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.DanceChangeValue                          = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x058), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x58 DanceChangeValue            ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.VisualChangeValue                         = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x060), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x60 VisualChangeValue           ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.MentalChangeValue                         = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x068), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x68 MentalChangeValue           ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.VocalRankImage                            = GetObject<UIRawImage>(new IntPtr(p + 0x070), ReversePrism.DataModels.UIRawImage.FromPointer); // 0x70 VocalRankImage              ( ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.DanceRankImage                            = GetObject<UIRawImage>(new IntPtr(p + 0x078), ReversePrism.DataModels.UIRawImage.FromPointer); // 0x78 DanceRankImage              ( ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.VisualRankImage                           = GetObject<UIRawImage>(new IntPtr(p + 0x080), ReversePrism.DataModels.UIRawImage.FromPointer); // 0x80 VisualRankImage             ( ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.MentalRankImage                           = GetObject<UIRawImage>(new IntPtr(p + 0x088), ReversePrism.DataModels.UIRawImage.FromPointer); // 0x88 MentalRankImage             ( ModelClassType UIRawImage UIRawImage UIRawImage Pointer )

            return value;
        }
    }
}
