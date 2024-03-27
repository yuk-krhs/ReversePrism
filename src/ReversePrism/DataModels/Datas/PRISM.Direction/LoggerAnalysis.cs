using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Analytics                                0001866F16F0 ModelClassType IAnalytics IAnalytics IAnalytics Pointer
    // 018 Crashlytics                              000186744360 ModelClassType ICrashlytics ICrashlytics ICrashlytics Pointer
    public partial class LoggerAnalysis
    {
        public IAnalytics?                              Analytics                               { get; set; }
        public ICrashlytics?                            Crashlytics                             { get; set; }

        public static LoggerAnalysis? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LoggerAnalysis();

            value.Analytics                                 = GetObject<IAnalytics>(new IntPtr(p + 0x010), ReversePrism.DataModels.IAnalytics.FromPointer); // 027003C78B28 0x10 Analytics                   ( 0001866F16F0 ModelClassType IAnalytics IAnalytics IAnalytics Pointer )
            value.Crashlytics                               = GetObject<ICrashlytics>(new IntPtr(p + 0x018), ReversePrism.DataModels.ICrashlytics.FromPointer); // 027003C78B48 0x18 Crashlytics                 ( 000186744360 ModelClassType ICrashlytics ICrashlytics ICrashlytics Pointer )

            return value;
        }
    }
}
