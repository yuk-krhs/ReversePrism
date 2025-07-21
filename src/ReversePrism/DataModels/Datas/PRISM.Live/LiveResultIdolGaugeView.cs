using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Gauge                                    ModelClassType RectMaskGauge RectMaskGauge RectMaskGauge Pointer
    // 028 LevelText                                ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer
    // 030 LevelDefaultColor                        ModelEnumType Color Color Color Int32
    // 040 LevelMaxColor                            ModelEnumType Color Color Color Int32
    // 050 LevelUpArrow                             ModelClassType GameObject GameObject GameObject Pointer
    // 058 MaxIcon                                  ModelClassType GameObject GameObject GameObject Pointer
    // 060 DiffExpText                              ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer
    // 068 ViewModel                                ModelClassType LiveResultIdolGaugeViewModel LiveResultIdolGaugeViewModel LiveResultIdolGaugeViewModel Pointer
    // 070 CurrentLevel                             ModelPrimitiveType int int int Int32
    public partial class LiveResultIdolGaugeView : DataModel
    {
        public RectMaskGauge?                           Gauge                                   { get; set; }
        public TextMeshProUGUI?                         LevelText                               { get; set; }
        public Color                                    LevelDefaultColor                       { get; set; }
        public Color                                    LevelMaxColor                           { get; set; }
        public GameObject?                              LevelUpArrow                            { get; set; }
        public GameObject?                              MaxIcon                                 { get; set; }
        public TextMeshProUGUI?                         DiffExpText                             { get; set; }
        public LiveResultIdolGaugeViewModel?            ViewModel                               { get; set; }
        public int                                      CurrentLevel                            { get; set; }

        public static LiveResultIdolGaugeView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveResultIdolGaugeView() { Pointer= p0 };

            value.Gauge                                     = GetObject<RectMaskGauge>(new IntPtr(p + 0x020), ReversePrism.DataModels.RectMaskGauge.FromPointer); // 0x20 Gauge                       ( ModelClassType RectMaskGauge RectMaskGauge RectMaskGauge Pointer )
            value.LevelText                                 = GetObject<TextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.TextMeshProUGUI.FromPointer); // 0x28 LevelText                   ( ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer )
            value.LevelDefaultColor                         = (Color)GetInt32(new IntPtr(p + 0x030)); // 0x30 LevelDefaultColor           ( ModelEnumType Color Color Color Int32 )
            value.LevelMaxColor                             = (Color)GetInt32(new IntPtr(p + 0x040)); // 0x40 LevelMaxColor               ( ModelEnumType Color Color Color Int32 )
            value.LevelUpArrow                              = GetObject<GameObject>(new IntPtr(p + 0x050), ReversePrism.DataModels.GameObject.FromPointer); // 0x50 LevelUpArrow                ( ModelClassType GameObject GameObject GameObject Pointer )
            value.MaxIcon                                   = GetObject<GameObject>(new IntPtr(p + 0x058), ReversePrism.DataModels.GameObject.FromPointer); // 0x58 MaxIcon                     ( ModelClassType GameObject GameObject GameObject Pointer )
            value.DiffExpText                               = GetObject<TextMeshProUGUI>(new IntPtr(p + 0x060), ReversePrism.DataModels.TextMeshProUGUI.FromPointer); // 0x60 DiffExpText                 ( ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer )
            value.ViewModel                                 = GetObject<LiveResultIdolGaugeViewModel>(new IntPtr(p + 0x068), ReversePrism.DataModels.LiveResultIdolGaugeViewModel.FromPointer); // 0x68 ViewModel                   ( ModelClassType LiveResultIdolGaugeViewModel LiveResultIdolGaugeViewModel LiveResultIdolGaugeViewModel Pointer )
            value.CurrentLevel                              = GetInt32(new IntPtr(p + 0x070)); // 0x70 CurrentLevel                ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
