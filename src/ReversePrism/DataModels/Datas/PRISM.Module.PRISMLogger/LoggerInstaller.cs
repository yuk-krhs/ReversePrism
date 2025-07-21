using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Logger                                   ModelClassType PRISMLoggerBase PRISMLoggerBase PRISMLoggerBase Pointer
    // 018 LoggerAnalysis                           ModelClassType ILoggerAnalysis ILoggerAnalysis ILoggerAnalysis Pointer
    public partial class LoggerInstaller : DataModel
    {
        public PRISMLoggerBase?                         Logger                                  { get; set; }
        public ILoggerAnalysis?                         LoggerAnalysis                          { get; set; }

        public static LoggerInstaller? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LoggerInstaller() { Pointer= p0 };

            value.Logger                                    = GetObject<PRISMLoggerBase>(new IntPtr(p + 0x010), ReversePrism.DataModels.PRISMLoggerBase.FromPointer); // 0x10 Logger                      ( ModelClassType PRISMLoggerBase PRISMLoggerBase PRISMLoggerBase Pointer )
            value.LoggerAnalysis                            = GetObject<ILoggerAnalysis>(new IntPtr(p + 0x018), ReversePrism.DataModels.ILoggerAnalysis.FromPointer); // 0x18 LoggerAnalysis              ( ModelClassType ILoggerAnalysis ILoggerAnalysis ILoggerAnalysis Pointer )

            return value;
        }
    }
}
