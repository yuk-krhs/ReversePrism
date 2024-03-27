using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Formatter                                0001865AFBD0 ModelClassType IMessageFormatter IMessageFormatter IMessageFormatter Pointer
    // 018 LoggerAnalysis                           0001865A23A0 ModelClassType ILoggerAnalysis ILoggerAnalysis ILoggerAnalysis Pointer
    public partial class LoggerProduction
    {
        public IMessageFormatter?                       Formatter                               { get; set; }
        public ILoggerAnalysis?                         LoggerAnalysis                          { get; set; }

        public static LoggerProduction? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LoggerProduction();

            value.Formatter                                 = GetObject<IMessageFormatter>(new IntPtr(p + 0x010), ReversePrism.DataModels.IMessageFormatter.FromPointer); // 027003C9D5B0 0x10 Formatter                   ( 0001865AFBD0 ModelClassType IMessageFormatter IMessageFormatter IMessageFormatter Pointer )
            value.LoggerAnalysis                            = GetObject<ILoggerAnalysis>(new IntPtr(p + 0x018), ReversePrism.DataModels.ILoggerAnalysis.FromPointer); // 027003C9D5D0 0x18 LoggerAnalysis              ( 0001865A23A0 ModelClassType ILoggerAnalysis ILoggerAnalysis ILoggerAnalysis Pointer )

            return value;
        }
    }
}
