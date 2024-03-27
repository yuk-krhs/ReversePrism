using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Formatter                                0001865AFBD0 ModelClassType IMessageFormatter IMessageFormatter IMessageFormatter Pointer
    // 018 EditorMode                               0001865965D0 ModelPrimitiveType bool bool bool Bool
    // 020 categoryFilter                           HashSet`1<Category> IL2CPP_TYPE_GENERICINST
    // 028 levelFilter                              HashSet`1<Level> IL2CPP_TYPE_GENERICINST
    // 030 Analysis                                 0001865A23A0 ModelClassType ILoggerAnalysis ILoggerAnalysis ILoggerAnalysis Pointer
    // 038 UnityLogger                              0001867178C0 ModelClassType UnityLogHandlerWrapper UnityLogHandlerWrapper UnityLogHandlerWrapper Pointer
    public partial class LoggerDevelop
    {
        public IMessageFormatter?                       Formatter                               { get; set; }
        public bool                                     EditorMode                              { get; set; }
        public ILoggerAnalysis?                         Analysis                                { get; set; }
        public UnityLogHandlerWrapper?                  UnityLogger                             { get; set; }

        public static LoggerDevelop? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LoggerDevelop();

            value.Formatter                                 = GetObject<IMessageFormatter>(new IntPtr(p + 0x010), ReversePrism.DataModels.IMessageFormatter.FromPointer); // 0270DBEE07D0 0x10 Formatter                   ( 0001865AFBD0 ModelClassType IMessageFormatter IMessageFormatter IMessageFormatter Pointer )
            value.EditorMode                                = GetBool(new IntPtr(p + 0x018)); // 0270DBEE07F0 0x18 EditorMode                  ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )
            value.Analysis                                  = GetObject<ILoggerAnalysis>(new IntPtr(p + 0x030), ReversePrism.DataModels.ILoggerAnalysis.FromPointer); // 0270DBEE0850 0x30 Analysis                    ( 0001865A23A0 ModelClassType ILoggerAnalysis ILoggerAnalysis ILoggerAnalysis Pointer )
            value.UnityLogger                               = GetObject<UnityLogHandlerWrapper>(new IntPtr(p + 0x038), ReversePrism.DataModels.UnityLogHandlerWrapper.FromPointer); // 0270DBEE0870 0x38 UnityLogger                 ( 0001867178C0 ModelClassType UnityLogHandlerWrapper UnityLogHandlerWrapper UnityLogHandlerWrapper Pointer )

            return value;
        }
    }
}
