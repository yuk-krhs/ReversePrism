using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 LogString                                string IL2CPP_TYPE_STRING
    // 008 SetKeyValueString                        string IL2CPP_TYPE_STRING
    // 010 SetUserIdentifierString                  0001866738F0 ModelPrimitiveType string string string String
    // 018 LogExceptionString                       0001866738F0 ModelPrimitiveType string string string String
    // 020 LogExceptionAsFatalString                0001866738F0 ModelPrimitiveType string string string String
    // 028 IsCrashlyticsCollectionEnabledString     0001866738F0 ModelPrimitiveType string string string String
    // 030 SetCrashlyticsCollectionEnabledString    0001866738F0 ModelPrimitiveType string string string String
    public partial class Impl : DataModel
    {
        public string                                   SetUserIdentifierString                 { get; set; }
        public string                                   LogExceptionString                      { get; set; }
        public string                                   LogExceptionAsFatalString               { get; set; }
        public string                                   IsCrashlyticsCollectionEnabledString    { get; set; }
        public string                                   SetCrashlyticsCollectionEnabledString   { get; set; }

        public static Impl? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Impl() { Pointer= p0 };

            value.SetUserIdentifierString                   = GetString(new IntPtr(p + 0x010)); // 02466BCE0040 0x10 SetUserIdentifierString     ( 0001866738F0 ModelPrimitiveType string string string String )
            value.LogExceptionString                        = GetString(new IntPtr(p + 0x018)); // 02466BCE0060 0x18 LogExceptionString          ( 0001866738F0 ModelPrimitiveType string string string String )
            value.LogExceptionAsFatalString                 = GetString(new IntPtr(p + 0x020)); // 02466BCE0080 0x20 LogExceptionAsFatalString   ( 0001866738F0 ModelPrimitiveType string string string String )
            value.IsCrashlyticsCollectionEnabledString      = GetString(new IntPtr(p + 0x028)); // 02466BCE00A0 0x28 IsCrashlyticsCollectionEnabledString ( 0001866738F0 ModelPrimitiveType string string string String )
            value.SetCrashlyticsCollectionEnabledString     = GetString(new IntPtr(p + 0x030)); // 02466BCE00C0 0x30 SetCrashlyticsCollectionEnabledString ( 0001866738F0 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
