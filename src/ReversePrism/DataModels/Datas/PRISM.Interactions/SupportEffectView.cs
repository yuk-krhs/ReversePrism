using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ContentParent                            000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 028 GoContentPrefab                          0001865EF5A0 ModelClassType SupportEffectContentView SupportEffectContentView SupportEffectContentView Pointer
    // 030 GoEmptyView                              0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 038 ScrollRect                               0001866F7FA0 ModelClassType ScrollRect ScrollRect ScrollRect Pointer
    // 040 ViewPortRect                             000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 048 VerticalLayoutGroup                      000186515B70 ModelClassType VerticalLayoutGroup VerticalLayoutGroup VerticalLayoutGroup Pointer
    // 050 IsSetupCompleted                         000186594D10 ModelPrimitiveType bool bool bool Bool
    // 058 EffectContentViews                       000185D106D8 ModelClassListType List`1<SupportEffectContentView> List`1<SupportEffectContentView> List<SupportEffectContentView> Pointer
    public partial class SupportEffectView : DataModel
    {
        public RectTransform?                           ContentParent                           { get; set; }
        public SupportEffectContentView?                GoContentPrefab                         { get; set; }
        public GameObject?                              GoEmptyView                             { get; set; }
        public ScrollRect?                              ScrollRect                              { get; set; }
        public RectTransform?                           ViewPortRect                            { get; set; }
        public VerticalLayoutGroup?                     VerticalLayoutGroup                     { get; set; }
        public bool                                     IsSetupCompleted                        { get; set; }
        public List<SupportEffectContentView>?          EffectContentViews                      { get; set; }

        public static SupportEffectView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SupportEffectView() { Pointer= p0 };

            value.ContentParent                             = GetObject<RectTransform>(new IntPtr(p + 0x020), ReversePrism.DataModels.RectTransform.FromPointer); // 02466A39BAE0 0x20 ContentParent               ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.GoContentPrefab                           = GetObject<SupportEffectContentView>(new IntPtr(p + 0x028), ReversePrism.DataModels.SupportEffectContentView.FromPointer); // 02466A39BB00 0x28 GoContentPrefab             ( 0001865EF5A0 ModelClassType SupportEffectContentView SupportEffectContentView SupportEffectContentView Pointer )
            value.GoEmptyView                               = GetObject<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 02466A39BB20 0x30 GoEmptyView                 ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.ScrollRect                                = GetObject<ScrollRect>(new IntPtr(p + 0x038), ReversePrism.DataModels.ScrollRect.FromPointer); // 02466A39BB40 0x38 ScrollRect                  ( 0001866F7FA0 ModelClassType ScrollRect ScrollRect ScrollRect Pointer )
            value.ViewPortRect                              = GetObject<RectTransform>(new IntPtr(p + 0x040), ReversePrism.DataModels.RectTransform.FromPointer); // 02466A39BB60 0x40 ViewPortRect                ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.VerticalLayoutGroup                       = GetObject<VerticalLayoutGroup>(new IntPtr(p + 0x048), ReversePrism.DataModels.VerticalLayoutGroup.FromPointer); // 02466A39BB80 0x48 VerticalLayoutGroup         ( 000186515B70 ModelClassType VerticalLayoutGroup VerticalLayoutGroup VerticalLayoutGroup Pointer )
            value.IsSetupCompleted                          = GetBool(new IntPtr(p + 0x050)); // 02466A39BBA0 0x50 IsSetupCompleted            ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.EffectContentViews                        = GetObjectList<SupportEffectContentView>(new IntPtr(p + 0x058), ReversePrism.DataModels.SupportEffectContentView.FromPointer); // 02466A39BBC0 0x58 EffectContentViews          ( 000185D106D8 ModelClassListType List`1<SupportEffectContentView> List`1<SupportEffectContentView> List<SupportEffectContentView> Pointer )

            return value;
        }
    }
}
