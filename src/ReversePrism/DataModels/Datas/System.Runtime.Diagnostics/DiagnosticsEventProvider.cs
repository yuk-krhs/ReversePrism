using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 EtwCallback                              0001866B7E00 ModelClassType EtwEnableCallback EtwEnableCallback EtwEnableCallback Pointer
    // 018 TraceRegistrationHandle                  0001865F7700 ModelPrimitiveType long long long Int64
    // 020 CurrentTraceLevel                        00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 028 AnyKeywordMask                           0001865F7700 ModelPrimitiveType long long long Int64
    // 030 AllKeywordMask                           0001865F7700 ModelPrimitiveType long long long Int64
    // 038 IsProviderEnabled                        000186594D10 ModelPrimitiveType bool bool bool Bool
    // 03C ProviderId                               0001865DBED0 ModelEnumType Guid Guid Guid Int32
    // 04C IsDisposed                               0001865F2AF0 ModelPrimitiveType int int int Int32
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

            value.EtwCallback                               = GetObject<EtwEnableCallback>(new IntPtr(p + 0x010), ReversePrism.DataModels.EtwEnableCallback.FromPointer); // 0245A4D41738 0x10 EtwCallback                 ( 0001866B7E00 ModelClassType EtwEnableCallback EtwEnableCallback EtwEnableCallback Pointer )
            value.TraceRegistrationHandle                   = GetInt64(new IntPtr(p + 0x018)); // 0245A4D41758 0x18 TraceRegistrationHandle     ( 0001865F7700 ModelPrimitiveType long long long Int64 )
            value.CurrentTraceLevel                         = GetSByte(new IntPtr(p + 0x020)); // 0245A4D41778 0x20 CurrentTraceLevel           ( 00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.AnyKeywordMask                            = GetInt64(new IntPtr(p + 0x028)); // 0245A4D41798 0x28 AnyKeywordMask              ( 0001865F7700 ModelPrimitiveType long long long Int64 )
            value.AllKeywordMask                            = GetInt64(new IntPtr(p + 0x030)); // 0245A4D417B8 0x30 AllKeywordMask              ( 0001865F7700 ModelPrimitiveType long long long Int64 )
            value.IsProviderEnabled                         = GetBool(new IntPtr(p + 0x038)); // 0245A4D417D8 0x38 IsProviderEnabled           ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.ProviderId                                = (Guid)GetInt32(new IntPtr(p + 0x03C)); // 0245A4D417F8 0x3C ProviderId                  ( 0001865DBED0 ModelEnumType Guid Guid Guid Int32 )
            value.IsDisposed                                = GetInt32(new IntPtr(p + 0x04C)); // 0245A4D41818 0x4C IsDisposed                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
