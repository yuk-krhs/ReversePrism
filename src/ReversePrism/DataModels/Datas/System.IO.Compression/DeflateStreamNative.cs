using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Feeder                                   000186599790 ModelClassType UnmanagedReadOrWrite UnmanagedReadOrWrite UnmanagedReadOrWrite Pointer
    // 018 Base_stream                              000186670270 ModelClassType Stream Stream Stream Pointer
    // 020 Z_stream                                 000186599290 ModelClassType SafeDeflateStreamHandle SafeDeflateStreamHandle SafeDeflateStreamHandle Pointer
    // 028 Data                                     0001865D9120 ModelEnumType GCHandle GCHandle GCHandle Int32
    // 030 Disposed                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 038 Io_buffer                                000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 040 Last_error                               0001865CA820 ModelClassType Exception Exception Exception Pointer
    public partial class DeflateStreamNative
    {
        public UnmanagedReadOrWrite?                    Feeder                                  { get; set; }
        public Stream?                                  Base_stream                             { get; set; }
        public SafeDeflateStreamHandle?                 Z_stream                                { get; set; }
        public GCHandle                                 Data                                    { get; set; }
        public bool                                     Disposed                                { get; set; }
        public List<sbyte>?                             Io_buffer                               { get; set; }
        public Exception?                               Last_error                              { get; set; }

        public static DeflateStreamNative? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DeflateStreamNative();

            value.Feeder                                    = GetObject<UnmanagedReadOrWrite>(new IntPtr(p + 0x010), ReversePrism.DataModels.UnmanagedReadOrWrite.FromPointer); // 0270D7BDD528 0x10 Feeder                      ( 000186599790 ModelClassType UnmanagedReadOrWrite UnmanagedReadOrWrite UnmanagedReadOrWrite Pointer )
            value.Base_stream                               = GetObject<Stream>(new IntPtr(p + 0x018), ReversePrism.DataModels.Stream.FromPointer); // 0270D7BDD548 0x18 Base_stream                 ( 000186670270 ModelClassType Stream Stream Stream Pointer )
            value.Z_stream                                  = GetObject<SafeDeflateStreamHandle>(new IntPtr(p + 0x020), ReversePrism.DataModels.SafeDeflateStreamHandle.FromPointer); // 0270D7BDD568 0x20 Z_stream                    ( 000186599290 ModelClassType SafeDeflateStreamHandle SafeDeflateStreamHandle SafeDeflateStreamHandle Pointer )
            value.Data                                      = (GCHandle)GetInt32(new IntPtr(p + 0x028)); // 0270D7BDD588 0x28 Data                        ( 0001865D9120 ModelEnumType GCHandle GCHandle GCHandle Int32 )
            value.Disposed                                  = GetBool(new IntPtr(p + 0x030)); // 0270D7BDD5A8 0x30 Disposed                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Io_buffer                                 = GetSByteList(new IntPtr(p + 0x038)); // 0270D7BDD5C8 0x38 Io_buffer                   ( 000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Last_error                                = GetObject<Exception>(new IntPtr(p + 0x040), ReversePrism.DataModels.Exception.FromPointer); // 0270D7BDD5E8 0x40 Last_error                  ( 0001865CA820 ModelClassType Exception Exception Exception Pointer )

            return value;
        }
    }
}
