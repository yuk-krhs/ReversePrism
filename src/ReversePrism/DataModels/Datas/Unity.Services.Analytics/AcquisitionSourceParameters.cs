using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Channel                                  0001866722E0 ModelPrimitiveType string string string String
    // 018 CampaignId                               0001866722E0 ModelPrimitiveType string string string String
    // 020 CreativeId                               0001866722E0 ModelPrimitiveType string string string String
    // 028 CampaignName                             0001866722E0 ModelPrimitiveType string string string String
    // 030 Provider                                 0001866722E0 ModelPrimitiveType string string string String
    // 038 Cost                                     Nullable`1<float> IL2CPP_TYPE_GENERICINST
    // 040 CostCurrency                             0001866722E0 ModelPrimitiveType string string string String
    // 048 Network                                  0001866722E0 ModelPrimitiveType string string string String
    // 050 CampaignType                             0001866722E0 ModelPrimitiveType string string string String
    public partial class AcquisitionSourceParameters : DataModel
    {
        public string                                   Channel                                 { get; set; }
        public string                                   CampaignId                              { get; set; }
        public string                                   CreativeId                              { get; set; }
        public string                                   CampaignName                            { get; set; }
        public string                                   Provider                                { get; set; }
        public string                                   CostCurrency                            { get; set; }
        public string                                   Network                                 { get; set; }
        public string                                   CampaignType                            { get; set; }

        public static AcquisitionSourceParameters? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AcquisitionSourceParameters() { Pointer= p0 };

            value.Channel                                   = GetString(new IntPtr(p + 0x010)); // 02466B8346D8 0x10 Channel                     ( 0001866722E0 ModelPrimitiveType string string string String )
            value.CampaignId                                = GetString(new IntPtr(p + 0x018)); // 02466B8346F8 0x18 CampaignId                  ( 0001866722E0 ModelPrimitiveType string string string String )
            value.CreativeId                                = GetString(new IntPtr(p + 0x020)); // 02466B834718 0x20 CreativeId                  ( 0001866722E0 ModelPrimitiveType string string string String )
            value.CampaignName                              = GetString(new IntPtr(p + 0x028)); // 02466B834738 0x28 CampaignName                ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Provider                                  = GetString(new IntPtr(p + 0x030)); // 02466B834758 0x30 Provider                    ( 0001866722E0 ModelPrimitiveType string string string String )
            value.CostCurrency                              = GetString(new IntPtr(p + 0x040)); // 02466B834798 0x40 CostCurrency                ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Network                                   = GetString(new IntPtr(p + 0x048)); // 02466B8347B8 0x48 Network                     ( 0001866722E0 ModelPrimitiveType string string string String )
            value.CampaignType                              = GetString(new IntPtr(p + 0x050)); // 02466B8347D8 0x50 CampaignType                ( 0001866722E0 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
