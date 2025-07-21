using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Configuration                          ModelClassType IProjectConfiguration IProjectConfiguration IProjectConfiguration Pointer
    // 018 M_AnalyticsService                       ModelClassType IUnstructuredEventRecorder IUnstructuredEventRecorder IUnstructuredEventRecorder Pointer
    public partial class StandardEventServiceComponent : DataModel
    {
        public IProjectConfiguration?                   M_Configuration                         { get; set; }
        public IUnstructuredEventRecorder?              M_AnalyticsService                      { get; set; }

        public static StandardEventServiceComponent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StandardEventServiceComponent() { Pointer= p0 };

            value.M_Configuration                           = GetObject<IProjectConfiguration>(new IntPtr(p + 0x010), ReversePrism.DataModels.IProjectConfiguration.FromPointer); // 0x10 M_Configuration             ( ModelClassType IProjectConfiguration IProjectConfiguration IProjectConfiguration Pointer )
            value.M_AnalyticsService                        = GetObject<IUnstructuredEventRecorder>(new IntPtr(p + 0x018), ReversePrism.DataModels.IUnstructuredEventRecorder.FromPointer); // 0x18 M_AnalyticsService          ( ModelClassType IUnstructuredEventRecorder IUnstructuredEventRecorder IUnstructuredEventRecorder Pointer )

            return value;
        }
    }
}
