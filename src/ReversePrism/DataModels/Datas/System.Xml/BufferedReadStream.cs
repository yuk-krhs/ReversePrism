using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 Stream                                   ModelClassType Stream Stream Stream Pointer
    // 030 StoredBuffer                             ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 038 StoredLength                             ModelPrimitiveType int int int Int32
    // 03C StoredOffset                             ModelPrimitiveType int int int Int32
    // 040 ReadMore                                 ModelPrimitiveType bool bool bool Bool
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

            value.Stream                                    = GetObject<Stream>(new IntPtr(p + 0x028), ReversePrism.DataModels.Stream.FromPointer); // 0x28 Stream                      ( ModelClassType Stream Stream Stream Pointer )
            value.StoredBuffer                              = GetSByteList(new IntPtr(p + 0x030)); // 0x30 StoredBuffer                ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.StoredLength                              = GetInt32(new IntPtr(p + 0x038)); // 0x38 StoredLength                ( ModelPrimitiveType int int int Int32 )
            value.StoredOffset                              = GetInt32(new IntPtr(p + 0x03C)); // 0x3C StoredOffset                ( ModelPrimitiveType int int int Int32 )
            value.ReadMore                                  = GetBool(new IntPtr(p + 0x040)); // 0x40 ReadMore                    ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
