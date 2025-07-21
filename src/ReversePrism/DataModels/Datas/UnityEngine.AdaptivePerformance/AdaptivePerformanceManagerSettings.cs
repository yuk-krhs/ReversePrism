using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 M_InitializationComplete                 ModelPrimitiveType bool bool bool Bool
    // 019 M_AutomaticLoading                       ModelPrimitiveType bool bool bool Bool
    // 01A M_AutomaticRunning                       ModelPrimitiveType bool bool bool Bool
    // 020 M_Loaders                                ModelClassListType List`1<AdaptivePerformanceLoader> List`1<AdaptivePerformanceLoader> List<AdaptivePerformanceLoader> Pointer
    // 000 s_ActiveLoader                           AdaptivePerformanceLoader IL2CPP_TYPE_CLASS
    public partial class AdaptivePerformanceManagerSettings : DataModel
    {
        public bool                                     M_InitializationComplete                { get; set; }
        public bool                                     M_AutomaticLoading                      { get; set; }
        public bool                                     M_AutomaticRunning                      { get; set; }
        public List<AdaptivePerformanceLoader>?         M_Loaders                               { get; set; }

        public static AdaptivePerformanceManagerSettings? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AdaptivePerformanceManagerSettings() { Pointer= p0 };

            value.M_InitializationComplete                  = GetBool(new IntPtr(p + 0x018)); // 0x18 M_InitializationComplete    ( ModelPrimitiveType bool bool bool Bool )
            value.M_AutomaticLoading                        = GetBool(new IntPtr(p + 0x019)); // 0x19 M_AutomaticLoading          ( ModelPrimitiveType bool bool bool Bool )
            value.M_AutomaticRunning                        = GetBool(new IntPtr(p + 0x01A)); // 0x1A M_AutomaticRunning          ( ModelPrimitiveType bool bool bool Bool )
            value.M_Loaders                                 = GetObjectList<AdaptivePerformanceLoader>(new IntPtr(p + 0x020), ReversePrism.DataModels.AdaptivePerformanceLoader.FromPointer); // 0x20 M_Loaders                   ( ModelClassListType List`1<AdaptivePerformanceLoader> List`1<AdaptivePerformanceLoader> List<AdaptivePerformanceLoader> Pointer )

            return value;
        }
    }
}
