using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Gauge                                    00018662F280 ModelClassType RectMaskGauge RectMaskGauge RectMaskGauge Pointer
    // 028 LevelText                                0001866409F0 ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer
    // 030 LevelDefaultColor                        0001865AA8E0 ModelEnumType Color Color Color Int32
    // 040 LevelMaxColor                            0001865AA8E0 ModelEnumType Color Color Color Int32
    // 050 LevelUpArrow                             0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 058 MaxIcon                                  0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 060 DiffExpText                              0001866409F0 ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer
    // 068 ViewModel                                00018656F8E0 ModelClassType LiveResultIdolGaugeViewModel LiveResultIdolGaugeViewModel LiveResultIdolGaugeViewModel Pointer
    // 070 CurrentLevel                             0001865F2AF0 ModelPrimitiveType int int int Int32
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

            value.Gauge                                     = GetObject<RectMaskGauge>(new IntPtr(p + 0x020), ReversePrism.DataModels.RectMaskGauge.FromPointer); // 0246652ACDF8 0x20 Gauge                       ( 00018662F280 ModelClassType RectMaskGauge RectMaskGauge RectMaskGauge Pointer )
            value.LevelText                                 = GetObject<TextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.TextMeshProUGUI.FromPointer); // 0246652ACE18 0x28 LevelText                   ( 0001866409F0 ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer )
            value.LevelDefaultColor                         = (Color)GetInt32(new IntPtr(p + 0x030)); // 0246652ACE38 0x30 LevelDefaultColor           ( 0001865AA8E0 ModelEnumType Color Color Color Int32 )
            value.LevelMaxColor                             = (Color)GetInt32(new IntPtr(p + 0x040)); // 0246652ACE58 0x40 LevelMaxColor               ( 0001865AA8E0 ModelEnumType Color Color Color Int32 )
            value.LevelUpArrow                              = GetObject<GameObject>(new IntPtr(p + 0x050), ReversePrism.DataModels.GameObject.FromPointer); // 0246652ACE78 0x50 LevelUpArrow                ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.MaxIcon                                   = GetObject<GameObject>(new IntPtr(p + 0x058), ReversePrism.DataModels.GameObject.FromPointer); // 0246652ACE98 0x58 MaxIcon                     ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.DiffExpText                               = GetObject<TextMeshProUGUI>(new IntPtr(p + 0x060), ReversePrism.DataModels.TextMeshProUGUI.FromPointer); // 0246652ACEB8 0x60 DiffExpText                 ( 0001866409F0 ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer )
            value.ViewModel                                 = GetObject<LiveResultIdolGaugeViewModel>(new IntPtr(p + 0x068), ReversePrism.DataModels.LiveResultIdolGaugeViewModel.FromPointer); // 0246652ACED8 0x68 ViewModel                   ( 00018656F8E0 ModelClassType LiveResultIdolGaugeViewModel LiveResultIdolGaugeViewModel LiveResultIdolGaugeViewModel Pointer )
            value.CurrentLevel                              = GetInt32(new IntPtr(p + 0x070)); // 0246652ACEF8 0x70 CurrentLevel                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
