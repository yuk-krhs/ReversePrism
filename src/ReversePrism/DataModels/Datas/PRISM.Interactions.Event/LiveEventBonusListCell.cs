using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TotalObject                              0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 028 DetailObject                             0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 030 IdolName                                 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 IdolIcon                                 000186704160 ModelClassType PFIdolIconView PFIdolIconView PFIdolIconView Pointer
    // 040 BonusRateText                            0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 MaxRateText                              0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 050 BaseEffectText                           0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 058 BaseMaxText                              0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 060 StarEffectText                           0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 068 StarMaxText                              0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 070 LvEffectText                             0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 078 LvMaxText                                0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 080 DeniedColor                              0001865AA8E0 ModelEnumType Color Color Color Int32
    // 090 AvailableColor                           0001865AA8E0 ModelEnumType Color Color Color Int32
    // 0A0 MaxColor                                 0001865AA8E0 ModelEnumType Color Color Color Int32
    // 0B0 GrayOutObject                            0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 0B8 IdolDetailPopupCaller                    000186709050 ModelClassType PIdolDetailPopupCaller PIdolDetailPopupCaller PIdolDetailPopupCaller Pointer
    // 0C0 IconDisposable                           0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer
    public partial class LiveEventBonusListCell
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
        public PIdolDetailPopupCaller?                  IdolDetailPopupCaller                   { get; set; }
        public IDisposable?                             IconDisposable                          { get; set; }

        public static LiveEventBonusListCell? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveEventBonusListCell();

            value.TotalObject                               = GetObject<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 0270DB93CA38 0x20 TotalObject                 ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.DetailObject                              = GetObject<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 0270DB93CA58 0x28 DetailObject                ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.IdolName                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DB93CA78 0x30 IdolName                    ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.IdolIcon                                  = GetObject<PFIdolIconView>(new IntPtr(p + 0x038), ReversePrism.DataModels.PFIdolIconView.FromPointer); // 0270DB93CA98 0x38 IdolIcon                    ( 000186704160 ModelClassType PFIdolIconView PFIdolIconView PFIdolIconView Pointer )
            value.BonusRateText                             = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DB93CAB8 0x40 BonusRateText               ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.MaxRateText                               = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DB93CAD8 0x48 MaxRateText                 ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.BaseEffectText                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x050), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DB93CAF8 0x50 BaseEffectText              ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.BaseMaxText                               = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x058), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DB93CB18 0x58 BaseMaxText                 ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.StarEffectText                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x060), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DB93CB38 0x60 StarEffectText              ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.StarMaxText                               = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x068), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DB93CB58 0x68 StarMaxText                 ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.LvEffectText                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x070), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DB93CB78 0x70 LvEffectText                ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.LvMaxText                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x078), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DB93CB98 0x78 LvMaxText                   ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.DeniedColor                               = (Color)GetInt32(new IntPtr(p + 0x080)); // 0270DB93CBB8 0x80 DeniedColor                 ( 0001865AA8E0 ModelEnumType Color Color Color Int32 )
            value.AvailableColor                            = (Color)GetInt32(new IntPtr(p + 0x090)); // 0270DB93CBD8 0x90 AvailableColor              ( 0001865AA8E0 ModelEnumType Color Color Color Int32 )
            value.MaxColor                                  = (Color)GetInt32(new IntPtr(p + 0x0A0)); // 0270DB93CBF8 0xA0 MaxColor                    ( 0001865AA8E0 ModelEnumType Color Color Color Int32 )
            value.GrayOutObject                             = GetObject<GameObject>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.GameObject.FromPointer); // 0270DB93CC18 0xB0 GrayOutObject               ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.IdolDetailPopupCaller                     = GetObject<PIdolDetailPopupCaller>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.PIdolDetailPopupCaller.FromPointer); // 0270DB93CC38 0xB8 IdolDetailPopupCaller       ( 000186709050 ModelClassType PIdolDetailPopupCaller PIdolDetailPopupCaller PIdolDetailPopupCaller Pointer )
            value.IconDisposable                            = GetObject<IDisposable>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.IDisposable.FromPointer); // 0270DB93CC58 0xC0 IconDisposable              ( 0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer )

            return value;
        }
    }
}
