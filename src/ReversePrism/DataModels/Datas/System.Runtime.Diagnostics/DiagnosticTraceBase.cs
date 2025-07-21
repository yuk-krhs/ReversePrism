using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 AppDomainFriendlyName                    string IL2CPP_TYPE_STRING
    // 010 thisLock                                 <object> IL2CPP_TYPE_OBJECT
    // 018 TracingEnabled                           ModelPrimitiveType bool bool bool Bool
    // 019 CalledShutdown                           ModelPrimitiveType bool bool bool Bool
    // 01A HaveListeners                            ModelPrimitiveType bool bool bool Bool
    // 01C Level                                    ModelEnumType SourceLevels SourceLevels SourceLevels Int32
    // 020 TraceSourceName                          ModelPrimitiveType string string string String
    // 028 TraceSource                              ModelClassType TraceSource TraceSource TraceSource Pointer
    // 030 EventSourceName                          ModelPrimitiveType string string string String
    // 038 LastFailure                              ModelPrimitiveType DateTime DateTime DateTime DateTime
    public partial class DiagnosticTraceBase : DataModel
    {
        public bool                                     TracingEnabled                          { get; set; }
        public bool                                     CalledShutdown                          { get; set; }
        public bool                                     HaveListeners                           { get; set; }
        public SourceLevels                             Level                                   { get; set; }
        public string                                   TraceSourceName                         { get; set; }
        public TraceSource?                             TraceSource                             { get; set; }
        public string                                   EventSourceName                         { get; set; }
        public DateTime                                 LastFailure                             { get; set; }

        public static DiagnosticTraceBase? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DiagnosticTraceBase() { Pointer= p0 };

            value.TracingEnabled                            = GetBool(new IntPtr(p + 0x018)); // 0x18 TracingEnabled              ( ModelPrimitiveType bool bool bool Bool )
            value.CalledShutdown                            = GetBool(new IntPtr(p + 0x019)); // 0x19 CalledShutdown              ( ModelPrimitiveType bool bool bool Bool )
            value.HaveListeners                             = GetBool(new IntPtr(p + 0x01A)); // 0x1A HaveListeners               ( ModelPrimitiveType bool bool bool Bool )
            value.Level                                     = (SourceLevels)GetInt32(new IntPtr(p + 0x01C)); // 0x1C Level                       ( ModelEnumType SourceLevels SourceLevels SourceLevels Int32 )
            value.TraceSourceName                           = GetString(new IntPtr(p + 0x020)); // 0x20 TraceSourceName             ( ModelPrimitiveType string string string String )
            value.TraceSource                               = GetObject<TraceSource>(new IntPtr(p + 0x028), ReversePrism.DataModels.TraceSource.FromPointer); // 0x28 TraceSource                 ( ModelClassType TraceSource TraceSource TraceSource Pointer )
            value.EventSourceName                           = GetString(new IntPtr(p + 0x030)); // 0x30 EventSourceName             ( ModelPrimitiveType string string string String )
            value.LastFailure                               = GetDateTime(new IntPtr(p + 0x038)); // 0x38 LastFailure                 ( ModelPrimitiveType DateTime DateTime DateTime DateTime )

            return value;
        }
    }
}
