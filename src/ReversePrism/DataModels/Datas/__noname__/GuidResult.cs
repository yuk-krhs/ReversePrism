using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ParsedGuid                               0001865DC120 ModelEnumType Guid Guid Guid Int32
    // 020 ThrowStyle                               000186527550 ModelEnumType GuidParseThrowStyle GuidParseThrowStyle GuidParseThrowStyle Int32
    // 024 Failure                                  0001865281B0 ModelEnumType ParseFailureKind ParseFailureKind ParseFailureKind Int32
    // 028 FailureMessageID                         000186671910 ModelPrimitiveType string string string String
    // 030 _failureMessageFormatArgument            <object> IL2CPP_TYPE_OBJECT
    // 038 FailureArgumentName                      000186671910 ModelPrimitiveType string string string String
    // 040 InnerException                           0001865CA820 ModelClassType Exception Exception Exception Pointer
    public partial class GuidResult : DataModel
    {
        public Guid                                     ParsedGuid                              { get; set; }
        public GuidParseThrowStyle                      ThrowStyle                              { get; set; }
        public ParseFailureKind                         Failure                                 { get; set; }
        public string                                   FailureMessageID                        { get; set; }
        public string                                   FailureArgumentName                     { get; set; }
        public Exception?                               InnerException                          { get; set; }

        public static GuidResult? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GuidResult() { Pointer= p0 };

            value.ParsedGuid                                = (Guid)GetInt32(new IntPtr(p + 0x010)); // 024666A0DC78 0x10 ParsedGuid                  ( 0001865DC120 ModelEnumType Guid Guid Guid Int32 )
            value.ThrowStyle                                = (GuidParseThrowStyle)GetInt32(new IntPtr(p + 0x020)); // 024666A0DC98 0x20 ThrowStyle                  ( 000186527550 ModelEnumType GuidParseThrowStyle GuidParseThrowStyle GuidParseThrowStyle Int32 )
            value.Failure                                   = (ParseFailureKind)GetInt32(new IntPtr(p + 0x024)); // 024666A0DCB8 0x24 Failure                     ( 0001865281B0 ModelEnumType ParseFailureKind ParseFailureKind ParseFailureKind Int32 )
            value.FailureMessageID                          = GetString(new IntPtr(p + 0x028)); // 024666A0DCD8 0x28 FailureMessageID            ( 000186671910 ModelPrimitiveType string string string String )
            value.FailureArgumentName                       = GetString(new IntPtr(p + 0x038)); // 024666A0DD18 0x38 FailureArgumentName         ( 000186671910 ModelPrimitiveType string string string String )
            value.InnerException                            = GetObject<Exception>(new IntPtr(p + 0x040), ReversePrism.DataModels.Exception.FromPointer); // 024666A0DD38 0x40 InnerException              ( 0001865CA820 ModelClassType Exception Exception Exception Pointer )

            return value;
        }
    }
}
