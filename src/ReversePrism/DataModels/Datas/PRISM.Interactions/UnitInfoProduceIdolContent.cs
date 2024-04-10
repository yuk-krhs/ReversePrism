using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 PFIdolIconRectView                       000186703B70 ModelClassType PFIdolIconRectView PFIdolIconRectView PFIdolIconRectView Pointer
    // 028 ProduceIdolSkillIcon                     0001866BD790 ModelClassType IdolSkillIconView IdolSkillIconView IdolSkillIconView Pointer
    // 030 BaseVocalValue                           0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 BaseDanceValue                           0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 BaseVisualValue                          0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 BaseMentalValue                          0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 050 VocalChangeValue                         0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 058 DanceChangeValue                         0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 060 VisualChangeValue                        0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 068 MentalChangeValue                        0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 070 VocalRankImage                           0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 078 DanceRankImage                           0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 080 VisualRankImage                          0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 088 MentalRankImage                          0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer
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

            value.PFIdolIconRectView                        = GetObject<PFIdolIconRectView>(new IntPtr(p + 0x020), ReversePrism.DataModels.PFIdolIconRectView.FromPointer); // 02466A158750 0x20 PFIdolIconRectView          ( 000186703B70 ModelClassType PFIdolIconRectView PFIdolIconRectView PFIdolIconRectView Pointer )
            value.ProduceIdolSkillIcon                      = GetObject<IdolSkillIconView>(new IntPtr(p + 0x028), ReversePrism.DataModels.IdolSkillIconView.FromPointer); // 02466A158770 0x28 ProduceIdolSkillIcon        ( 0001866BD790 ModelClassType IdolSkillIconView IdolSkillIconView IdolSkillIconView Pointer )
            value.BaseVocalValue                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466A158790 0x30 BaseVocalValue              ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.BaseDanceValue                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466A1587B0 0x38 BaseDanceValue              ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.BaseVisualValue                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466A1587D0 0x40 BaseVisualValue             ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.BaseMentalValue                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466A1587F0 0x48 BaseMentalValue             ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.VocalChangeValue                          = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x050), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466A158810 0x50 VocalChangeValue            ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.DanceChangeValue                          = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x058), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466A158830 0x58 DanceChangeValue            ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.VisualChangeValue                         = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x060), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466A158850 0x60 VisualChangeValue           ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.MentalChangeValue                         = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x068), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466A158870 0x68 MentalChangeValue           ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.VocalRankImage                            = GetObject<UIRawImage>(new IntPtr(p + 0x070), ReversePrism.DataModels.UIRawImage.FromPointer); // 02466A158890 0x70 VocalRankImage              ( 0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.DanceRankImage                            = GetObject<UIRawImage>(new IntPtr(p + 0x078), ReversePrism.DataModels.UIRawImage.FromPointer); // 02466A1588B0 0x78 DanceRankImage              ( 0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.VisualRankImage                           = GetObject<UIRawImage>(new IntPtr(p + 0x080), ReversePrism.DataModels.UIRawImage.FromPointer); // 02466A1588D0 0x80 VisualRankImage             ( 0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.MentalRankImage                           = GetObject<UIRawImage>(new IntPtr(p + 0x088), ReversePrism.DataModels.UIRawImage.FromPointer); // 02466A1588F0 0x88 MentalRankImage             ( 0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer )

            return value;
        }
    }
}
