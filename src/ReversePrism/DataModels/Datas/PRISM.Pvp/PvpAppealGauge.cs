using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 PlayerGauge                              0001865EE910 ModelClassType PvpPlayerAppealGauge PvpPlayerAppealGauge PvpPlayerAppealGauge Pointer
    // 028 EnemyGauge                               0001865EE910 ModelClassType PvpPlayerAppealGauge PvpPlayerAppealGauge PvpPlayerAppealGauge Pointer
    // 030 ValueUpDownTextArea                      000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 038 ValueUpDownText                          0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 InCreaseAppealTypeTextColor              000185B75890 ModelEnumListType Color[] Color[] List<Color> Pointer
    // 048 InCreaseDefaultTextColor                 0001865AA8E0 ModelEnumType Color Color Color Int32
    // 058 DeCreaseDefaultTextColor                 0001865AA8E0 ModelEnumType Color Color Color Int32
    // 068 GaugeSizeRect                            000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 070 TokenSource                              0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 078 AnimationSpeed                           0001866656B0 ModelPrimitiveType float float float Single
    // 080 Tweener                                  0001866C3DE0 ModelClassType Tweener Tweener Tweener Pointer
    public partial class PvpAppealGauge
    {
        public PvpPlayerAppealGauge?                    PlayerGauge                             { get; set; }
        public PvpPlayerAppealGauge?                    EnemyGauge                              { get; set; }
        public RectTransform?                           ValueUpDownTextArea                     { get; set; }
        public UITextMeshProUGUI?                       ValueUpDownText                         { get; set; }
        public List<Color>?                             InCreaseAppealTypeTextColor             { get; set; }
        public Color                                    InCreaseDefaultTextColor                { get; set; }
        public Color                                    DeCreaseDefaultTextColor                { get; set; }
        public RectTransform?                           GaugeSizeRect                           { get; set; }
        public CancellationTokenSource?                 TokenSource                             { get; set; }
        public float                                    AnimationSpeed                          { get; set; }
        public Tweener?                                 Tweener                                 { get; set; }

        public static PvpAppealGauge? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PvpAppealGauge();

            value.PlayerGauge                               = GetObject<PvpPlayerAppealGauge>(new IntPtr(p + 0x020), ReversePrism.DataModels.PvpPlayerAppealGauge.FromPointer); // 0270D5076990 0x20 PlayerGauge                 ( 0001865EE910 ModelClassType PvpPlayerAppealGauge PvpPlayerAppealGauge PvpPlayerAppealGauge Pointer )
            value.EnemyGauge                                = GetObject<PvpPlayerAppealGauge>(new IntPtr(p + 0x028), ReversePrism.DataModels.PvpPlayerAppealGauge.FromPointer); // 0270D50769B0 0x28 EnemyGauge                  ( 0001865EE910 ModelClassType PvpPlayerAppealGauge PvpPlayerAppealGauge PvpPlayerAppealGauge Pointer )
            value.ValueUpDownTextArea                       = GetObject<RectTransform>(new IntPtr(p + 0x030), ReversePrism.DataModels.RectTransform.FromPointer); // 0270D50769D0 0x30 ValueUpDownTextArea         ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.ValueUpDownText                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D50769F0 0x38 ValueUpDownText             ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.InCreaseAppealTypeTextColor               = GetEnumList<Color>(new IntPtr(p + 0x040)); // 0270D5076A10 0x40 InCreaseAppealTypeTextColor ( 000185B75890 ModelEnumListType Color[] Color[] List<Color> Pointer )
            value.InCreaseDefaultTextColor                  = (Color)GetInt32(new IntPtr(p + 0x048)); // 0270D5076A30 0x48 InCreaseDefaultTextColor    ( 0001865AA8E0 ModelEnumType Color Color Color Int32 )
            value.DeCreaseDefaultTextColor                  = (Color)GetInt32(new IntPtr(p + 0x058)); // 0270D5076A50 0x58 DeCreaseDefaultTextColor    ( 0001865AA8E0 ModelEnumType Color Color Color Int32 )
            value.GaugeSizeRect                             = GetObject<RectTransform>(new IntPtr(p + 0x068), ReversePrism.DataModels.RectTransform.FromPointer); // 0270D5076A70 0x68 GaugeSizeRect               ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.TokenSource                               = GetObject<CancellationTokenSource>(new IntPtr(p + 0x070), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0270D5076A90 0x70 TokenSource                 ( 0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.AnimationSpeed                            = GetSingle(new IntPtr(p + 0x078)); // 0270D5076AB0 0x78 AnimationSpeed              ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.Tweener                                   = GetObject<Tweener>(new IntPtr(p + 0x080), ReversePrism.DataModels.Tweener.FromPointer); // 0270D5076AD0 0x80 Tweener                     ( 0001866C3DE0 ModelClassType Tweener Tweener Tweener Pointer )

            return value;
        }
    }
}
