using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TotalText                                0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 BasicTotalText                           0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 VocalText                                0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 DanceText                                0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 VisualText                               0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 MentalText                               0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 050 SupportBonusText                         0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 058 UnitBonusText                            0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 060 ParameterGauges                          000185CA0448 ModelClassListType RectTransform[] RectTransform[] List<RectTransform> Pointer
    // 068 UnitBonusGaugeLabel                      0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 070 ScoreOverflowMark                        0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 078 onClick                                  Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 080 Parent                                   0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class LiveUnitTotalParameterDetailPopupView : DataModel
    {
        public UITextMeshProUGUI?                       TotalText                               { get; set; }
        public UITextMeshProUGUI?                       BasicTotalText                          { get; set; }
        public UITextMeshProUGUI?                       VocalText                               { get; set; }
        public UITextMeshProUGUI?                       DanceText                               { get; set; }
        public UITextMeshProUGUI?                       VisualText                              { get; set; }
        public UITextMeshProUGUI?                       MentalText                              { get; set; }
        public UITextMeshProUGUI?                       SupportBonusText                        { get; set; }
        public UITextMeshProUGUI?                       UnitBonusText                           { get; set; }
        public List<RectTransform>?                     ParameterGauges                         { get; set; }
        public GameObject?                              UnitBonusGaugeLabel                     { get; set; }
        public GameObject?                              ScoreOverflowMark                       { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static LiveUnitTotalParameterDetailPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveUnitTotalParameterDetailPopupView() { Pointer= p0 };

            value.TotalText                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B4A2D90 0x20 TotalText                   ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.BasicTotalText                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B4A2DB0 0x28 BasicTotalText              ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.VocalText                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B4A2DD0 0x30 VocalText                   ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.DanceText                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B4A2DF0 0x38 DanceText                   ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.VisualText                                = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B4A2E10 0x40 VisualText                  ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.MentalText                                = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B4A2E30 0x48 MentalText                  ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.SupportBonusText                          = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x050), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B4A2E50 0x50 SupportBonusText            ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.UnitBonusText                             = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x058), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B4A2E70 0x58 UnitBonusText               ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ParameterGauges                           = GetObjectList<RectTransform>(new IntPtr(p + 0x060), ReversePrism.DataModels.RectTransform.FromPointer); // 02466B4A2E90 0x60 ParameterGauges             ( 000185CA0448 ModelClassListType RectTransform[] RectTransform[] List<RectTransform> Pointer )
            value.UnitBonusGaugeLabel                       = GetObject<GameObject>(new IntPtr(p + 0x068), ReversePrism.DataModels.GameObject.FromPointer); // 02466B4A2EB0 0x68 UnitBonusGaugeLabel         ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.ScoreOverflowMark                         = GetObject<GameObject>(new IntPtr(p + 0x070), ReversePrism.DataModels.GameObject.FromPointer); // 02466B4A2ED0 0x70 ScoreOverflowMark           ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x080), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 02466B4A2F10 0x80 Parent                      ( 0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
