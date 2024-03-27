using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 PrismGaugeItem                           000185B9C4A0 ModelClassListType PrismGaugeItem[] PrismGaugeItem[] List<PrismGaugeItem> Pointer
    // 028 Gauge                                    0001866CCDB0 ModelClassType Image Image Image Pointer
    // 030 RectItem                                 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 038 GashaPrismGauge                          000186527050 ModelClassType IGashaPrismGaugeStatus IGashaPrismGaugeStatus IGashaPrismGaugeStatus Pointer
    // 040 CurrentPoint                             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 044 Playback                                 0001866481C0 ModelEnumType CriAtomExPlayback CriAtomExPlayback CriAtomExPlayback Int32
    // 048 Endcallback                              0001866792B0 ModelClassType Action Action Action Pointer
    // 050 After                                    0001866656B0 ModelPrimitiveType float float float Single
    public partial class PrismGauge
    {
        public List<PrismGaugeItem>?                    PrismGaugeItem                          { get; set; }
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
            var value   = new PrismGauge();

            value.PrismGaugeItem                            = GetObjectList<PrismGaugeItem>(new IntPtr(p + 0x020), ReversePrism.DataModels.PrismGaugeItem.FromPointer); // 0270D53DCFE0 0x20 PrismGaugeItem              ( 000185B9C4A0 ModelClassListType PrismGaugeItem[] PrismGaugeItem[] List<PrismGaugeItem> Pointer )
            value.Gauge                                     = GetObject<Image>(new IntPtr(p + 0x028), ReversePrism.DataModels.Image.FromPointer); // 0270D53DD000 0x28 Gauge                       ( 0001866CCDB0 ModelClassType Image Image Image Pointer )
            value.RectItem                                  = GetObject<RectTransform>(new IntPtr(p + 0x030), ReversePrism.DataModels.RectTransform.FromPointer); // 0270D53DD020 0x30 RectItem                    ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.GashaPrismGauge                           = GetObject<IGashaPrismGaugeStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.IGashaPrismGaugeStatus.FromPointer); // 0270D53DD040 0x38 GashaPrismGauge             ( 000186527050 ModelClassType IGashaPrismGaugeStatus IGashaPrismGaugeStatus IGashaPrismGaugeStatus Pointer )
            value.CurrentPoint                              = GetInt32(new IntPtr(p + 0x040)); // 0270D53DD060 0x40 CurrentPoint                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Playback                                  = (CriAtomExPlayback)GetInt32(new IntPtr(p + 0x044)); // 0270D53DD080 0x44 Playback                    ( 0001866481C0 ModelEnumType CriAtomExPlayback CriAtomExPlayback CriAtomExPlayback Int32 )
            value.Endcallback                               = GetObject<Action>(new IntPtr(p + 0x048), ReversePrism.DataModels.Action.FromPointer); // 0270D53DD0A0 0x48 Endcallback                 ( 0001866792B0 ModelClassType Action Action Action Pointer )
            value.After                                     = GetSingle(new IntPtr(p + 0x050)); // 0270D53DD0C0 0x50 After                       ( 0001866656B0 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
