using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Adid                                     ModelPrimitiveType string string string String
    // 018 Network                                  ModelPrimitiveType string string string String
    // 020 Adgroup                                  ModelPrimitiveType string string string String
    // 028 Campaign                                 ModelPrimitiveType string string string String
    // 030 Creative                                 ModelPrimitiveType string string string String
    // 038 ClickLabel                               ModelPrimitiveType string string string String
    // 040 TrackerName                              ModelPrimitiveType string string string String
    // 048 TrackerToken                             ModelPrimitiveType string string string String
    // 050 CostType                                 ModelPrimitiveType string string string String
    // 058 <costAmount>k__BackingField              Nullable`1<double> IL2CPP_TYPE_GENERICINST
    // 068 CostCurrency                             ModelPrimitiveType string string string String
    // 070 FbInstallReferrer                        ModelPrimitiveType string string string String
    public partial class AdjustAttribution : DataModel
    {
        public string                                   Adid                                    { get; set; }
        public string                                   Network                                 { get; set; }
        public string                                   Adgroup                                 { get; set; }
        public string                                   Campaign                                { get; set; }
        public string                                   Creative                                { get; set; }
        public string                                   ClickLabel                              { get; set; }
        public string                                   TrackerName                             { get; set; }
        public string                                   TrackerToken                            { get; set; }
        public string                                   CostType                                { get; set; }
        public string                                   CostCurrency                            { get; set; }
        public string                                   FbInstallReferrer                       { get; set; }

        public static AdjustAttribution? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AdjustAttribution() { Pointer= p0 };

            value.Adid                                      = GetString(new IntPtr(p + 0x010)); // 0x10 Adid                        ( ModelPrimitiveType string string string String )
            value.Network                                   = GetString(new IntPtr(p + 0x018)); // 0x18 Network                     ( ModelPrimitiveType string string string String )
            value.Adgroup                                   = GetString(new IntPtr(p + 0x020)); // 0x20 Adgroup                     ( ModelPrimitiveType string string string String )
            value.Campaign                                  = GetString(new IntPtr(p + 0x028)); // 0x28 Campaign                    ( ModelPrimitiveType string string string String )
            value.Creative                                  = GetString(new IntPtr(p + 0x030)); // 0x30 Creative                    ( ModelPrimitiveType string string string String )
            value.ClickLabel                                = GetString(new IntPtr(p + 0x038)); // 0x38 ClickLabel                  ( ModelPrimitiveType string string string String )
            value.TrackerName                               = GetString(new IntPtr(p + 0x040)); // 0x40 TrackerName                 ( ModelPrimitiveType string string string String )
            value.TrackerToken                              = GetString(new IntPtr(p + 0x048)); // 0x48 TrackerToken                ( ModelPrimitiveType string string string String )
            value.CostType                                  = GetString(new IntPtr(p + 0x050)); // 0x50 CostType                    ( ModelPrimitiveType string string string String )
            value.CostCurrency                              = GetString(new IntPtr(p + 0x068)); // 0x68 CostCurrency                ( ModelPrimitiveType string string string String )
            value.FbInstallReferrer                         = GetString(new IntPtr(p + 0x070)); // 0x70 FbInstallReferrer           ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
