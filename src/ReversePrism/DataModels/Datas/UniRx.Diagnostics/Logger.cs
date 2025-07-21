using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 isInitialized                            bool IL2CPP_TYPE_BOOLEAN
    // 001 isDebugBuild                             bool IL2CPP_TYPE_BOOLEAN
    // 010 Name                                     ModelPrimitiveType string string string String
    // 018 logPublisher                             Action`1<LogEntry> IL2CPP_TYPE_GENERICINST
    public partial class Logger : DataModel
    {
        public string                                   Name                                    { get; set; }

        public static Logger? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Logger() { Pointer= p0 };

            value.Name                                      = GetString(new IntPtr(p + 0x010)); // 0x10 Name                        ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
