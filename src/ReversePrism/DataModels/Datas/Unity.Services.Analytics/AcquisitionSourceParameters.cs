using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Channel                                  ModelPrimitiveType string string string String
    // 018 CampaignId                               ModelPrimitiveType string string string String
    // 020 CreativeId                               ModelPrimitiveType string string string String
    // 028 CampaignName                             ModelPrimitiveType string string string String
    // 030 Provider                                 ModelPrimitiveType string string string String
    // 038 Cost                                     Nullable`1<float> IL2CPP_TYPE_GENERICINST
    // 040 CostCurrency                             ModelPrimitiveType string string string String
    // 048 Network                                  ModelPrimitiveType string string string String
    // 050 CampaignType                             ModelPrimitiveType string string string String
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

            value.Channel                                   = GetString(new IntPtr(p + 0x010)); // 0x10 Channel                     ( ModelPrimitiveType string string string String )
            value.CampaignId                                = GetString(new IntPtr(p + 0x018)); // 0x18 CampaignId                  ( ModelPrimitiveType string string string String )
            value.CreativeId                                = GetString(new IntPtr(p + 0x020)); // 0x20 CreativeId                  ( ModelPrimitiveType string string string String )
            value.CampaignName                              = GetString(new IntPtr(p + 0x028)); // 0x28 CampaignName                ( ModelPrimitiveType string string string String )
            value.Provider                                  = GetString(new IntPtr(p + 0x030)); // 0x30 Provider                    ( ModelPrimitiveType string string string String )
            value.CostCurrency                              = GetString(new IntPtr(p + 0x040)); // 0x40 CostCurrency                ( ModelPrimitiveType string string string String )
            value.Network                                   = GetString(new IntPtr(p + 0x048)); // 0x48 Network                     ( ModelPrimitiveType string string string String )
            value.CampaignType                              = GetString(new IntPtr(p + 0x050)); // 0x50 CampaignType                ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
