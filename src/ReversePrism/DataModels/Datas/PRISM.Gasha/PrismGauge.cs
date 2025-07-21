using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 PrismGaugeItem                           ModelClassType PrismGaugeItem PrismGaugeItem PrismGaugeItem Pointer
    // 028 Gauge                                    ModelClassType Image Image Image Pointer
    // 030 RectItem                                 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 038 GashaPrismGauge                          ModelClassType IGashaPrismGaugeStatus IGashaPrismGaugeStatus IGashaPrismGaugeStatus Pointer
    // 040 CurrentPoint                             ModelPrimitiveType int int int Int32
    // 044 Playback                                 ModelEnumType CriAtomExPlayback CriAtomExPlayback CriAtomExPlayback Int32
    // 048 Endcallback                              ModelClassType Action Action Action Pointer
    // 050 After                                    ModelPrimitiveType float float float Single
    public partial class PrismGauge : DataModel
    {
        public PrismGaugeItem?                          PrismGaugeItem                          { get; set; }
        public Image?                                   Gauge                                   { get; set; }
        public RectTransform?                           RectItem                                { get; set; }
        public IGashaPrismGaugeStatus?                  GashaPrismGauge                         { get; set; }
        public int                                      CurrentPoint                            { get; set; }
        public CriAtomExPlayback                        Playback                                { get; set; }
        public Action?                                  Endcallback                             { get; set; }
        public float                                    After                                   { get; set; }

        public static PrismGauge? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PrismGauge() { Pointer= p0 };

            value.PrismGaugeItem                            = GetObject<PrismGaugeItem>(new IntPtr(p + 0x020), ReversePrism.DataModels.PrismGaugeItem.FromPointer); // 0x20 PrismGaugeItem              ( ModelClassType PrismGaugeItem PrismGaugeItem PrismGaugeItem Pointer )
            value.Gauge                                     = GetObject<Image>(new IntPtr(p + 0x028), ReversePrism.DataModels.Image.FromPointer); // 0x28 Gauge                       ( ModelClassType Image Image Image Pointer )
            value.RectItem                                  = GetObject<RectTransform>(new IntPtr(p + 0x030), ReversePrism.DataModels.RectTransform.FromPointer); // 0x30 RectItem                    ( ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.GashaPrismGauge                           = GetObject<IGashaPrismGaugeStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.IGashaPrismGaugeStatus.FromPointer); // 0x38 GashaPrismGauge             ( ModelClassType IGashaPrismGaugeStatus IGashaPrismGaugeStatus IGashaPrismGaugeStatus Pointer )
            value.CurrentPoint                              = GetInt32(new IntPtr(p + 0x040)); // 0x40 CurrentPoint                ( ModelPrimitiveType int int int Int32 )
            value.Playback                                  = (CriAtomExPlayback)GetInt32(new IntPtr(p + 0x044)); // 0x44 Playback                    ( ModelEnumType CriAtomExPlayback CriAtomExPlayback CriAtomExPlayback Int32 )
            value.Endcallback                               = GetObject<Action>(new IntPtr(p + 0x048), ReversePrism.DataModels.Action.FromPointer); // 0x48 Endcallback                 ( ModelClassType Action Action Action Pointer )
            value.After                                     = GetSingle(new IntPtr(p + 0x050)); // 0x50 After                       ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
