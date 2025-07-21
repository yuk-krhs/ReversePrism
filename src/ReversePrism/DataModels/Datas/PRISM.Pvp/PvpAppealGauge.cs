using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 PlayerGauge                              ModelClassType PvpPlayerAppealGauge PvpPlayerAppealGauge PvpPlayerAppealGauge Pointer
    // 028 EnemyGauge                               ModelClassType PvpPlayerAppealGauge PvpPlayerAppealGauge PvpPlayerAppealGauge Pointer
    // 030 ValueUpDownTextArea                      ModelClassType RectTransform RectTransform RectTransform Pointer
    // 038 ValueUpDownText                          ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 InCreaseAppealTypeTextColor              ModelEnumListType Color[] Color[] List<Color> Pointer
    // 048 InCreaseDefaultTextColor                 ModelEnumType Color Color Color Int32
    // 058 DeCreaseDefaultTextColor                 ModelEnumType Color Color Color Int32
    // 068 GaugeSizeRect                            ModelClassType RectTransform RectTransform RectTransform Pointer
    // 070 TokenSource                              ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 078 AnimationSpeed                           ModelPrimitiveType float float float Single
    // 080 Tweener                                  ModelClassType Tweener Tweener Tweener Pointer
    public partial class PvpAppealGauge : DataModel
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
            var value   = new PvpAppealGauge() { Pointer= p0 };

            value.PlayerGauge                               = GetObject<PvpPlayerAppealGauge>(new IntPtr(p + 0x020), ReversePrism.DataModels.PvpPlayerAppealGauge.FromPointer); // 0x20 PlayerGauge                 ( ModelClassType PvpPlayerAppealGauge PvpPlayerAppealGauge PvpPlayerAppealGauge Pointer )
            value.EnemyGauge                                = GetObject<PvpPlayerAppealGauge>(new IntPtr(p + 0x028), ReversePrism.DataModels.PvpPlayerAppealGauge.FromPointer); // 0x28 EnemyGauge                  ( ModelClassType PvpPlayerAppealGauge PvpPlayerAppealGauge PvpPlayerAppealGauge Pointer )
            value.ValueUpDownTextArea                       = GetObject<RectTransform>(new IntPtr(p + 0x030), ReversePrism.DataModels.RectTransform.FromPointer); // 0x30 ValueUpDownTextArea         ( ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.ValueUpDownText                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x38 ValueUpDownText             ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.InCreaseAppealTypeTextColor               = GetEnumList<Color>(new IntPtr(p + 0x040)); // 0x40 InCreaseAppealTypeTextColor ( ModelEnumListType Color[] Color[] List<Color> Pointer )
            value.InCreaseDefaultTextColor                  = (Color)GetInt32(new IntPtr(p + 0x048)); // 0x48 InCreaseDefaultTextColor    ( ModelEnumType Color Color Color Int32 )
            value.DeCreaseDefaultTextColor                  = (Color)GetInt32(new IntPtr(p + 0x058)); // 0x58 DeCreaseDefaultTextColor    ( ModelEnumType Color Color Color Int32 )
            value.GaugeSizeRect                             = GetObject<RectTransform>(new IntPtr(p + 0x068), ReversePrism.DataModels.RectTransform.FromPointer); // 0x68 GaugeSizeRect               ( ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.TokenSource                               = GetObject<CancellationTokenSource>(new IntPtr(p + 0x070), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0x70 TokenSource                 ( ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.AnimationSpeed                            = GetSingle(new IntPtr(p + 0x078)); // 0x78 AnimationSpeed              ( ModelPrimitiveType float float float Single )
            value.Tweener                                   = GetObject<Tweener>(new IntPtr(p + 0x080), ReversePrism.DataModels.Tweener.FromPointer); // 0x80 Tweener                     ( ModelClassType Tweener Tweener Tweener Pointer )

            return value;
        }
    }
}
