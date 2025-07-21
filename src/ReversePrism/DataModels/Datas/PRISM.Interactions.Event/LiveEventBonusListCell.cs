using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 TotalObject                              ModelClassType GameObject GameObject GameObject Pointer
    // 048 DetailObject                             ModelClassType GameObject GameObject GameObject Pointer
    // 050 IdolName                                 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 058 IdolIcon                                 ModelClassType PFIdolIconView PFIdolIconView PFIdolIconView Pointer
    // 060 BonusRateText                            ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 068 MaxRateText                              ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 070 BaseEffectText                           ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 078 BaseMaxText                              ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 080 StarEffectText                           ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 088 StarMaxText                              ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 090 LvEffectText                             ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 098 LvMaxText                                ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 0A0 DeniedColor                              ModelEnumType Color Color Color Int32
    // 0B0 AvailableColor                           ModelEnumType Color Color Color Int32
    // 0C0 MaxColor                                 ModelEnumType Color Color Color Int32
    // 0D0 GrayOutObject                            ModelClassType GameObject GameObject GameObject Pointer
    // 0D8 Disposables                              ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    public partial class LiveEventBonusListCell : DataModel
    {
        public GameObject?                              TotalObject                             { get; set; }
        public GameObject?                              DetailObject                            { get; set; }
        public UITextMeshProUGUI?                       IdolName                                { get; set; }
        public PFIdolIconView?                          IdolIcon                                { get; set; }
        public UITextMeshProUGUI?                       BonusRateText                           { get; set; }
        public UITextMeshProUGUI?                       MaxRateText                             { get; set; }
        public UITextMeshProUGUI?                       BaseEffectText                          { get; set; }
        public UITextMeshProUGUI?                       BaseMaxText                             { get; set; }
        public UITextMeshProUGUI?                       StarEffectText                          { get; set; }
        public UITextMeshProUGUI?                       StarMaxText                             { get; set; }
        public UITextMeshProUGUI?                       LvEffectText                            { get; set; }
        public UITextMeshProUGUI?                       LvMaxText                               { get; set; }
        public Color                                    DeniedColor                             { get; set; }
        public Color                                    AvailableColor                          { get; set; }
        public Color                                    MaxColor                                { get; set; }
        public GameObject?                              GrayOutObject                           { get; set; }
        public CompositeDisposable?                     Disposables                             { get; set; }

        public static LiveEventBonusListCell? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveEventBonusListCell() { Pointer= p0 };

            value.TotalObject                               = GetObject<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 0x40 TotalObject                 ( ModelClassType GameObject GameObject GameObject Pointer )
            value.DetailObject                              = GetObject<GameObject>(new IntPtr(p + 0x048), ReversePrism.DataModels.GameObject.FromPointer); // 0x48 DetailObject                ( ModelClassType GameObject GameObject GameObject Pointer )
            value.IdolName                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x050), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x50 IdolName                    ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.IdolIcon                                  = GetObject<PFIdolIconView>(new IntPtr(p + 0x058), ReversePrism.DataModels.PFIdolIconView.FromPointer); // 0x58 IdolIcon                    ( ModelClassType PFIdolIconView PFIdolIconView PFIdolIconView Pointer )
            value.BonusRateText                             = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x060), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x60 BonusRateText               ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.MaxRateText                               = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x068), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x68 MaxRateText                 ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.BaseEffectText                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x070), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x70 BaseEffectText              ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.BaseMaxText                               = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x078), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x78 BaseMaxText                 ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.StarEffectText                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x080), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x80 StarEffectText              ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.StarMaxText                               = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x088), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x88 StarMaxText                 ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.LvEffectText                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x090), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x90 LvEffectText                ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.LvMaxText                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x098), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x98 LvMaxText                   ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.DeniedColor                               = (Color)GetInt32(new IntPtr(p + 0x0A0)); // 0xA0 DeniedColor                 ( ModelEnumType Color Color Color Int32 )
            value.AvailableColor                            = (Color)GetInt32(new IntPtr(p + 0x0B0)); // 0xB0 AvailableColor              ( ModelEnumType Color Color Color Int32 )
            value.MaxColor                                  = (Color)GetInt32(new IntPtr(p + 0x0C0)); // 0xC0 MaxColor                    ( ModelEnumType Color Color Color Int32 )
            value.GrayOutObject                             = GetObject<GameObject>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.GameObject.FromPointer); // 0xD0 GrayOutObject               ( ModelClassType GameObject GameObject GameObject Pointer )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0xD8 Disposables                 ( ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )

            return value;
        }
    }
}
