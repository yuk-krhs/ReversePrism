using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_validityDateTimeFormatInfo             DateTimeFormatInfo IL2CPP_TYPE_CLASS
    // 008 s_utf8EncodingWithExceptionFallback      Encoding IL2CPP_TYPE_CLASS
    // 010 S_latin1Encoding                         ModelClassType Encoding Encoding Encoding Pointer
    // 010 Data                                     ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 018 End                                      ModelPrimitiveType int int int Int32
    // 01C Position                                 ModelPrimitiveType int int int Int32
    // 020 ContentLength                            ModelPrimitiveType int int int Int32
    public partial class DerSequenceReader : DataModel
    {
        public Encoding?                                S_latin1Encoding                        { get; set; }
        public List<sbyte>?                             Data                                    { get; set; }
        public int                                      End                                     { get; set; }
        public int                                      Position                                { get; set; }
        public int                                      ContentLength                           { get; set; }

        public static DerSequenceReader? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DerSequenceReader() { Pointer= p0 };

            value.S_latin1Encoding                          = GetObject<Encoding>(new IntPtr(p + 0x010), ReversePrism.DataModels.Encoding.FromPointer); // 0x10 S_latin1Encoding            ( ModelClassType Encoding Encoding Encoding Pointer )
            value.Data                                      = GetSByteList(new IntPtr(p + 0x010)); // 0x10 Data                        ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.End                                       = GetInt32(new IntPtr(p + 0x018)); // 0x18 End                         ( ModelPrimitiveType int int int Int32 )
            value.Position                                  = GetInt32(new IntPtr(p + 0x01C)); // 0x1C Position                    ( ModelPrimitiveType int int int Int32 )
            value.ContentLength                             = GetInt32(new IntPtr(p + 0x020)); // 0x20 ContentLength               ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
