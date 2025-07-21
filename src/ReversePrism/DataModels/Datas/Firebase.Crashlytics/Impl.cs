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
    // 010 SetUserIdentifierString                  ModelPrimitiveType string string string String
    // 018 LogExceptionString                       ModelPrimitiveType string string string String
    // 020 LogExceptionAsFatalString                ModelPrimitiveType string string string String
    // 028 IsCrashlyticsCollectionEnabledString     ModelPrimitiveType string string string String
    // 030 SetCrashlyticsCollectionEnabledString    ModelPrimitiveType string string string String
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

            value.SetUserIdentifierString                   = GetString(new IntPtr(p + 0x010)); // 0x10 SetUserIdentifierString     ( ModelPrimitiveType string string string String )
            value.LogExceptionString                        = GetString(new IntPtr(p + 0x018)); // 0x18 LogExceptionString          ( ModelPrimitiveType string string string String )
            value.LogExceptionAsFatalString                 = GetString(new IntPtr(p + 0x020)); // 0x20 LogExceptionAsFatalString   ( ModelPrimitiveType string string string String )
            value.IsCrashlyticsCollectionEnabledString      = GetString(new IntPtr(p + 0x028)); // 0x28 IsCrashlyticsCollectionEnabledString ( ModelPrimitiveType string string string String )
            value.SetCrashlyticsCollectionEnabledString     = GetString(new IntPtr(p + 0x030)); // 0x30 SetCrashlyticsCollectionEnabledString ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
