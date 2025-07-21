using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 AdCompletionStatus                       ModelEnumType AdCompletionStatus AdCompletionStatus AdCompletionStatus Int32
    // 014 AdProvider                               ModelEnumType AdProvider AdProvider AdProvider Int32
    // 018 PlacementID                              ModelPrimitiveType string string string String
    // 020 PlacementName                            ModelPrimitiveType string string string String
    // 028 PlacementType                            Nullable`1<AdPlacementType> IL2CPP_TYPE_GENERICINST
    // 030 AdEcpmUsd                                Nullable`1<double> IL2CPP_TYPE_GENERICINST
    // 040 SdkVersion                               ModelPrimitiveType string string string String
    // 048 AdImpressionID                           ModelPrimitiveType string string string String
    // 050 AdStoreDstID                             ModelPrimitiveType string string string String
    // 058 AdMediaType                              ModelPrimitiveType string string string String
    // 060 AdTimeWatchedMs                          Nullable`1<long> IL2CPP_TYPE_GENERICINST
    // 070 AdTimeCloseButtonShownMs                 Nullable`1<long> IL2CPP_TYPE_GENERICINST
    // 080 AdLengthMs                               Nullable`1<long> IL2CPP_TYPE_GENERICINST
    // 090 AdHasClicked                             Nullable`1<bool> IL2CPP_TYPE_GENERICINST
    // 098 AdSource                                 ModelPrimitiveType string string string String
    // 0A0 AdStatusCallback                         ModelPrimitiveType string string string String
    public partial class AdImpressionParameters : DataModel
    {
        public AdCompletionStatus                       AdCompletionStatus                      { get; set; }
        public AdProvider                               AdProvider                              { get; set; }
        public string                                   PlacementID                             { get; set; }
        public string                                   PlacementName                           { get; set; }
        public string                                   SdkVersion                              { get; set; }
        public string                                   AdImpressionID                          { get; set; }
        public string                                   AdStoreDstID                            { get; set; }
        public string                                   AdMediaType                             { get; set; }
        public string                                   AdSource                                { get; set; }
        public string                                   AdStatusCallback                        { get; set; }

        public static AdImpressionParameters? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AdImpressionParameters() { Pointer= p0 };

            value.AdCompletionStatus                        = (AdCompletionStatus)GetInt32(new IntPtr(p + 0x010)); // 0x10 AdCompletionStatus          ( ModelEnumType AdCompletionStatus AdCompletionStatus AdCompletionStatus Int32 )
            value.AdProvider                                = (AdProvider)GetInt32(new IntPtr(p + 0x014)); // 0x14 AdProvider                  ( ModelEnumType AdProvider AdProvider AdProvider Int32 )
            value.PlacementID                               = GetString(new IntPtr(p + 0x018)); // 0x18 PlacementID                 ( ModelPrimitiveType string string string String )
            value.PlacementName                             = GetString(new IntPtr(p + 0x020)); // 0x20 PlacementName               ( ModelPrimitiveType string string string String )
            value.SdkVersion                                = GetString(new IntPtr(p + 0x040)); // 0x40 SdkVersion                  ( ModelPrimitiveType string string string String )
            value.AdImpressionID                            = GetString(new IntPtr(p + 0x048)); // 0x48 AdImpressionID              ( ModelPrimitiveType string string string String )
            value.AdStoreDstID                              = GetString(new IntPtr(p + 0x050)); // 0x50 AdStoreDstID                ( ModelPrimitiveType string string string String )
            value.AdMediaType                               = GetString(new IntPtr(p + 0x058)); // 0x58 AdMediaType                 ( ModelPrimitiveType string string string String )
            value.AdSource                                  = GetString(new IntPtr(p + 0x098)); // 0x98 AdSource                    ( ModelPrimitiveType string string string String )
            value.AdStatusCallback                          = GetString(new IntPtr(p + 0x0A0)); // 0xA0 AdStatusCallback            ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
