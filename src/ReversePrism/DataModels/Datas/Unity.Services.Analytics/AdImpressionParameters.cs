using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 AdCompletionStatus                       0001866806D0 ModelEnumType AdCompletionStatus AdCompletionStatus AdCompletionStatus Int32
    // 014 AdProvider                               000186681500 ModelEnumType AdProvider AdProvider AdProvider Int32
    // 018 PlacementID                              0001866722E0 ModelPrimitiveType string string string String
    // 020 PlacementName                            0001866722E0 ModelPrimitiveType string string string String
    // 028 PlacementType                            Nullable`1<AdPlacementType> IL2CPP_TYPE_GENERICINST
    // 030 AdEcpmUsd                                Nullable`1<double> IL2CPP_TYPE_GENERICINST
    // 040 SdkVersion                               0001866722E0 ModelPrimitiveType string string string String
    // 048 AdImpressionID                           0001866722E0 ModelPrimitiveType string string string String
    // 050 AdStoreDstID                             0001866722E0 ModelPrimitiveType string string string String
    // 058 AdMediaType                              0001866722E0 ModelPrimitiveType string string string String
    // 060 AdTimeWatchedMs                          Nullable`1<long> IL2CPP_TYPE_GENERICINST
    // 070 AdTimeCloseButtonShownMs                 Nullable`1<long> IL2CPP_TYPE_GENERICINST
    // 080 AdLengthMs                               Nullable`1<long> IL2CPP_TYPE_GENERICINST
    // 090 AdHasClicked                             Nullable`1<bool> IL2CPP_TYPE_GENERICINST
    // 098 AdSource                                 0001866722E0 ModelPrimitiveType string string string String
    // 0A0 AdStatusCallback                         0001866722E0 ModelPrimitiveType string string string String
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

            value.AdCompletionStatus                        = (AdCompletionStatus)GetInt32(new IntPtr(p + 0x010)); // 02466B8347F8 0x10 AdCompletionStatus          ( 0001866806D0 ModelEnumType AdCompletionStatus AdCompletionStatus AdCompletionStatus Int32 )
            value.AdProvider                                = (AdProvider)GetInt32(new IntPtr(p + 0x014)); // 02466B834818 0x14 AdProvider                  ( 000186681500 ModelEnumType AdProvider AdProvider AdProvider Int32 )
            value.PlacementID                               = GetString(new IntPtr(p + 0x018)); // 02466B834838 0x18 PlacementID                 ( 0001866722E0 ModelPrimitiveType string string string String )
            value.PlacementName                             = GetString(new IntPtr(p + 0x020)); // 02466B834858 0x20 PlacementName               ( 0001866722E0 ModelPrimitiveType string string string String )
            value.SdkVersion                                = GetString(new IntPtr(p + 0x040)); // 02466B8348B8 0x40 SdkVersion                  ( 0001866722E0 ModelPrimitiveType string string string String )
            value.AdImpressionID                            = GetString(new IntPtr(p + 0x048)); // 02466B8348D8 0x48 AdImpressionID              ( 0001866722E0 ModelPrimitiveType string string string String )
            value.AdStoreDstID                              = GetString(new IntPtr(p + 0x050)); // 02466B8348F8 0x50 AdStoreDstID                ( 0001866722E0 ModelPrimitiveType string string string String )
            value.AdMediaType                               = GetString(new IntPtr(p + 0x058)); // 02466B834918 0x58 AdMediaType                 ( 0001866722E0 ModelPrimitiveType string string string String )
            value.AdSource                                  = GetString(new IntPtr(p + 0x098)); // 02466B8349B8 0x98 AdSource                    ( 0001866722E0 ModelPrimitiveType string string string String )
            value.AdStatusCallback                          = GetString(new IntPtr(p + 0x0A0)); // 02466B8349D8 0xA0 AdStatusCallback            ( 0001866722E0 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
