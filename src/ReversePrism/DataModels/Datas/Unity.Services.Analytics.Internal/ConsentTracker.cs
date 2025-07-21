using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_GeoAPI                                 ModelClassType IGeoAPI IGeoAPI IGeoAPI Pointer
    // 018 M_CoreStatsHelper                        ModelClassType ICoreStatsHelper ICoreStatsHelper ICoreStatsHelper Pointer
    // 020 OptInPiplConsentStatus                   ModelEnumType ConsentStatus ConsentStatus ConsentStatus Int32
    // 024 OptOutConsentStatus                      ModelEnumType ConsentStatus ConsentStatus ConsentStatus Int32
    // 028 Response                                 ModelClassType GeoIPResponse GeoIPResponse GeoIPResponse Pointer
    // 000 optInPiplConsentStatusPrefKey            string IL2CPP_TYPE_STRING
    // 000 optOutConsentStatusPrefKey               string IL2CPP_TYPE_STRING
    public partial class ConsentTracker : DataModel
    {
        public IGeoAPI?                                 M_GeoAPI                                { get; set; }
        public ICoreStatsHelper?                        M_CoreStatsHelper                       { get; set; }
        public ConsentStatus                            OptInPiplConsentStatus                  { get; set; }
        public ConsentStatus                            OptOutConsentStatus                     { get; set; }
        public GeoIPResponse?                           Response                                { get; set; }

        public static ConsentTracker? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ConsentTracker() { Pointer= p0 };

            value.M_GeoAPI                                  = GetObject<IGeoAPI>(new IntPtr(p + 0x010), ReversePrism.DataModels.IGeoAPI.FromPointer); // 0x10 M_GeoAPI                    ( ModelClassType IGeoAPI IGeoAPI IGeoAPI Pointer )
            value.M_CoreStatsHelper                         = GetObject<ICoreStatsHelper>(new IntPtr(p + 0x018), ReversePrism.DataModels.ICoreStatsHelper.FromPointer); // 0x18 M_CoreStatsHelper           ( ModelClassType ICoreStatsHelper ICoreStatsHelper ICoreStatsHelper Pointer )
            value.OptInPiplConsentStatus                    = (ConsentStatus)GetInt32(new IntPtr(p + 0x020)); // 0x20 OptInPiplConsentStatus      ( ModelEnumType ConsentStatus ConsentStatus ConsentStatus Int32 )
            value.OptOutConsentStatus                       = (ConsentStatus)GetInt32(new IntPtr(p + 0x024)); // 0x24 OptOutConsentStatus         ( ModelEnumType ConsentStatus ConsentStatus ConsentStatus Int32 )
            value.Response                                  = GetObject<GeoIPResponse>(new IntPtr(p + 0x028), ReversePrism.DataModels.GeoIPResponse.FromPointer); // 0x28 Response                    ( ModelClassType GeoIPResponse GeoIPResponse GeoIPResponse Pointer )

            return value;
        }
    }
}
