using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 EtwCallback                              ModelClassType EtwEnableCallback EtwEnableCallback EtwEnableCallback Pointer
    // 018 TraceRegistrationHandle                  ModelPrimitiveType long long long Int64
    // 020 CurrentTraceLevel                        ModelPrimitiveType sbyte sbyte sbyte SByte
    // 028 AnyKeywordMask                           ModelPrimitiveType long long long Int64
    // 030 AllKeywordMask                           ModelPrimitiveType long long long Int64
    // 038 IsProviderEnabled                        ModelPrimitiveType bool bool bool Bool
    // 03C ProviderId                               ModelEnumType Guid Guid Guid Int32
    // 04C IsDisposed                               ModelPrimitiveType int int int Int32
    // FFFFFFFF errorCode                                WriteEventErrorCode IL2CPP_TYPE_VALUETYPE
    public partial class DiagnosticsEventProvider : DataModel
    {
        public EtwEnableCallback?                       EtwCallback                             { get; set; }
        public long                                     TraceRegistrationHandle                 { get; set; }
        public sbyte                                    CurrentTraceLevel                       { get; set; }
        public long                                     AnyKeywordMask                          { get; set; }
        public long                                     AllKeywordMask                          { get; set; }
        public bool                                     IsProviderEnabled                       { get; set; }
        public Guid                                     ProviderId                              { get; set; }
        public int                                      IsDisposed                              { get; set; }

        public static DiagnosticsEventProvider? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DiagnosticsEventProvider() { Pointer= p0 };

            value.EtwCallback                               = GetObject<EtwEnableCallback>(new IntPtr(p + 0x010), ReversePrism.DataModels.EtwEnableCallback.FromPointer); // 0x10 EtwCallback                 ( ModelClassType EtwEnableCallback EtwEnableCallback EtwEnableCallback Pointer )
            value.TraceRegistrationHandle                   = GetInt64(new IntPtr(p + 0x018)); // 0x18 TraceRegistrationHandle     ( ModelPrimitiveType long long long Int64 )
            value.CurrentTraceLevel                         = GetSByte(new IntPtr(p + 0x020)); // 0x20 CurrentTraceLevel           ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.AnyKeywordMask                            = GetInt64(new IntPtr(p + 0x028)); // 0x28 AnyKeywordMask              ( ModelPrimitiveType long long long Int64 )
            value.AllKeywordMask                            = GetInt64(new IntPtr(p + 0x030)); // 0x30 AllKeywordMask              ( ModelPrimitiveType long long long Int64 )
            value.IsProviderEnabled                         = GetBool(new IntPtr(p + 0x038)); // 0x38 IsProviderEnabled           ( ModelPrimitiveType bool bool bool Bool )
            value.ProviderId                                = (Guid)GetInt32(new IntPtr(p + 0x03C)); // 0x3C ProviderId                  ( ModelEnumType Guid Guid Guid Int32 )
            value.IsDisposed                                = GetInt32(new IntPtr(p + 0x04C)); // 0x4C IsDisposed                  ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
