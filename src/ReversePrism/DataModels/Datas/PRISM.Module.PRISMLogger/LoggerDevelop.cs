using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Formatter                                ModelClassType IMessageFormatter IMessageFormatter IMessageFormatter Pointer
    // 018 EditorMode                               ModelPrimitiveType bool bool bool Bool
    // 020 categoryFilter                           HashSet`1<Category> IL2CPP_TYPE_GENERICINST
    // 028 levelFilter                              HashSet`1<Level> IL2CPP_TYPE_GENERICINST
    // 030 Analysis                                 ModelClassType ILoggerAnalysis ILoggerAnalysis ILoggerAnalysis Pointer
    // 038 UnityLogger                              ModelClassType UnityLogHandlerWrapper UnityLogHandlerWrapper UnityLogHandlerWrapper Pointer
    public partial class LoggerDevelop : DataModel
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
            var value   = new LoggerDevelop() { Pointer= p0 };

            value.Formatter                                 = GetObject<IMessageFormatter>(new IntPtr(p + 0x010), ReversePrism.DataModels.IMessageFormatter.FromPointer); // 0x10 Formatter                   ( ModelClassType IMessageFormatter IMessageFormatter IMessageFormatter Pointer )
            value.EditorMode                                = GetBool(new IntPtr(p + 0x018)); // 0x18 EditorMode                  ( ModelPrimitiveType bool bool bool Bool )
            value.Analysis                                  = GetObject<ILoggerAnalysis>(new IntPtr(p + 0x030), ReversePrism.DataModels.ILoggerAnalysis.FromPointer); // 0x30 Analysis                    ( ModelClassType ILoggerAnalysis ILoggerAnalysis ILoggerAnalysis Pointer )
            value.UnityLogger                               = GetObject<UnityLogHandlerWrapper>(new IntPtr(p + 0x038), ReversePrism.DataModels.UnityLogHandlerWrapper.FromPointer); // 0x38 UnityLogger                 ( ModelClassType UnityLogHandlerWrapper UnityLogHandlerWrapper UnityLogHandlerWrapper Pointer )

            return value;
        }
    }
}
