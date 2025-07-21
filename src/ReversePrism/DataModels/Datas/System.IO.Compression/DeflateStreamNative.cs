using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Feeder                                   ModelClassType UnmanagedReadOrWrite UnmanagedReadOrWrite UnmanagedReadOrWrite Pointer
    // 018 Base_stream                              ModelClassType Stream Stream Stream Pointer
    // 020 Z_stream                                 ModelClassType SafeDeflateStreamHandle SafeDeflateStreamHandle SafeDeflateStreamHandle Pointer
    // 028 Data                                     ModelEnumType GCHandle GCHandle GCHandle Int32
    // 030 Disposed                                 ModelPrimitiveType bool bool bool Bool
    // 038 Io_buffer                                ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 040 Last_error                               ModelClassType Exception Exception Exception Pointer
    public partial class DeflateStreamNative : DataModel
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
            var value   = new DeflateStreamNative() { Pointer= p0 };

            value.Feeder                                    = GetObject<UnmanagedReadOrWrite>(new IntPtr(p + 0x010), ReversePrism.DataModels.UnmanagedReadOrWrite.FromPointer); // 0x10 Feeder                      ( ModelClassType UnmanagedReadOrWrite UnmanagedReadOrWrite UnmanagedReadOrWrite Pointer )
            value.Base_stream                               = GetObject<Stream>(new IntPtr(p + 0x018), ReversePrism.DataModels.Stream.FromPointer); // 0x18 Base_stream                 ( ModelClassType Stream Stream Stream Pointer )
            value.Z_stream                                  = GetObject<SafeDeflateStreamHandle>(new IntPtr(p + 0x020), ReversePrism.DataModels.SafeDeflateStreamHandle.FromPointer); // 0x20 Z_stream                    ( ModelClassType SafeDeflateStreamHandle SafeDeflateStreamHandle SafeDeflateStreamHandle Pointer )
            value.Data                                      = (GCHandle)GetInt32(new IntPtr(p + 0x028)); // 0x28 Data                        ( ModelEnumType GCHandle GCHandle GCHandle Int32 )
            value.Disposed                                  = GetBool(new IntPtr(p + 0x030)); // 0x30 Disposed                    ( ModelPrimitiveType bool bool bool Bool )
            value.Io_buffer                                 = GetSByteList(new IntPtr(p + 0x038)); // 0x38 Io_buffer                   ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Last_error                                = GetObject<Exception>(new IntPtr(p + 0x040), ReversePrism.DataModels.Exception.FromPointer); // 0x40 Last_error                  ( ModelClassType Exception Exception Exception Pointer )

            return value;
        }
    }
}
