using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 k_AutoFlushPeriod                        float IL2CPP_TYPE_R4
    // 000 k_GameRunningPeriod                      float IL2CPP_TYPE_R4
    // 000 s_Created                                bool IL2CPP_TYPE_BOOLEAN
    // 008 s_Container                              GameObject IL2CPP_TYPE_CLASS
    // 020 M_AutoFlushTime                          0001866656B0 ModelPrimitiveType float float float Single
    // 024 M_GameRunningTime                        0001866656B0 ModelPrimitiveType float float float Single
    // 028 M_Service                                0001866A9830 ModelClassType AnalyticsServiceInstance AnalyticsServiceInstance AnalyticsServiceInstance Pointer
    // 010 Instance                                 0001866A89A0 ModelClassType AnalyticsContainer AnalyticsContainer AnalyticsContainer Pointer
    public partial class AnalyticsContainer : DataModel
    {
        public float                                    M_AutoFlushTime                         { get; set; }
        public float                                    M_GameRunningTime                       { get; set; }
        public AnalyticsServiceInstance?                M_Service                               { get; set; }
        public AnalyticsContainer?                      Instance                                { get; set; }

        public static AnalyticsContainer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AnalyticsContainer() { Pointer= p0 };

            value.M_AutoFlushTime                           = GetSingle(new IntPtr(p + 0x020)); // 0245A6684730 0x20 M_AutoFlushTime             ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_GameRunningTime                         = GetSingle(new IntPtr(p + 0x024)); // 0245A6684750 0x24 M_GameRunningTime           ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_Service                                 = GetObject<AnalyticsServiceInstance>(new IntPtr(p + 0x028), ReversePrism.DataModels.AnalyticsServiceInstance.FromPointer); // 0245A6684770 0x28 M_Service                   ( 0001866A9830 ModelClassType AnalyticsServiceInstance AnalyticsServiceInstance AnalyticsServiceInstance Pointer )
            value.Instance                                  = GetObject<AnalyticsContainer>(new IntPtr(p + 0x010), ReversePrism.DataModels.AnalyticsContainer.FromPointer); // 0245A6684790 0x10 Instance                    ( 0001866A89A0 ModelClassType AnalyticsContainer AnalyticsContainer AnalyticsContainer Pointer )

            return value;
        }
    }
}
