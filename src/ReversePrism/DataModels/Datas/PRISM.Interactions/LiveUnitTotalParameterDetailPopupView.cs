using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TotalText                                ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 BasicTotalText                           ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 VocalText                                ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 DanceText                                ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 VisualText                               ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 MentalText                               ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 050 SupportBonusText                         ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 058 UnitBonusText                            ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 060 ParameterGauges                          ModelClassListType RectTransform[] RectTransform[] List<RectTransform> Pointer
    // 068 UnitBonusGaugeLabel                      ModelClassType GameObject GameObject GameObject Pointer
    // 070 ScoreOverflowMark                        ModelClassType GameObject GameObject GameObject Pointer
    // 078 onClick                                  Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 080 Parent                                   ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
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

            value.TotalText                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x20 TotalText                   ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.BasicTotalText                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x28 BasicTotalText              ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.VocalText                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x30 VocalText                   ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.DanceText                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x38 DanceText                   ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.VisualText                                = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x40 VisualText                  ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.MentalText                                = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x48 MentalText                  ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.SupportBonusText                          = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x050), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x50 SupportBonusText            ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.UnitBonusText                             = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x058), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x58 UnitBonusText               ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ParameterGauges                           = GetObjectList<RectTransform>(new IntPtr(p + 0x060), ReversePrism.DataModels.RectTransform.FromPointer); // 0x60 ParameterGauges             ( ModelClassListType RectTransform[] RectTransform[] List<RectTransform> Pointer )
            value.UnitBonusGaugeLabel                       = GetObject<GameObject>(new IntPtr(p + 0x068), ReversePrism.DataModels.GameObject.FromPointer); // 0x68 UnitBonusGaugeLabel         ( ModelClassType GameObject GameObject GameObject Pointer )
            value.ScoreOverflowMark                         = GetObject<GameObject>(new IntPtr(p + 0x070), ReversePrism.DataModels.GameObject.FromPointer); // 0x70 ScoreOverflowMark           ( ModelClassType GameObject GameObject GameObject Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x080), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0x80 Parent                      ( ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
