using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 Stream                                   000186670270 ModelClassType Stream Stream Stream Pointer
    // 030 StoredBuffer                             000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 038 StoredLength                             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 03C StoredOffset                             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 040 ReadMore                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class BufferedReadStream : DataModel
    {
        public Stream?                                  Stream                                  { get; set; }
        public List<sbyte>?                             StoredBuffer                            { get; set; }
        public int                                      StoredLength                            { get; set; }
        public int                                      StoredOffset                            { get; set; }
        public bool                                     ReadMore                                { get; set; }

        public static BufferedReadStream? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BufferedReadStream() { Pointer= p0 };

            value.Stream                                    = GetObject<Stream>(new IntPtr(p + 0x028), ReversePrism.DataModels.Stream.FromPointer); // 024667CF2648 0x28 Stream                      ( 000186670270 ModelClassType Stream Stream Stream Pointer )
            value.StoredBuffer                              = GetSByteList(new IntPtr(p + 0x030)); // 024667CF2668 0x30 StoredBuffer                ( 000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.StoredLength                              = GetInt32(new IntPtr(p + 0x038)); // 024667CF2688 0x38 StoredLength                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.StoredOffset                              = GetInt32(new IntPtr(p + 0x03C)); // 024667CF26A8 0x3C StoredOffset                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ReadMore                                  = GetBool(new IntPtr(p + 0x040)); // 024667CF26C8 0x40 ReadMore                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
