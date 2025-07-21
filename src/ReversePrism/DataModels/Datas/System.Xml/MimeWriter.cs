using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Stream                                   ModelClassType Stream Stream Stream Pointer
    // 018 BoundaryBytes                            ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 020 State                                    ModelEnumType MimeWriterState MimeWriterState MimeWriterState Int32
    // 028 BufferedWrite                            ModelClassType BufferedWrite BufferedWrite BufferedWrite Pointer
    // 030 ContentStream                            ModelClassType Stream Stream Stream Pointer
    public partial class MimeWriter : DataModel
    {
        public Stream?                                  Stream                                  { get; set; }
        public List<sbyte>?                             BoundaryBytes                           { get; set; }
        public MimeWriterState                          State                                   { get; set; }
        public BufferedWrite?                           BufferedWrite                           { get; set; }
        public Stream?                                  ContentStream                           { get; set; }

        public static MimeWriter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MimeWriter() { Pointer= p0 };

            value.Stream                                    = GetObject<Stream>(new IntPtr(p + 0x010), ReversePrism.DataModels.Stream.FromPointer); // 0x10 Stream                      ( ModelClassType Stream Stream Stream Pointer )
            value.BoundaryBytes                             = GetSByteList(new IntPtr(p + 0x018)); // 0x18 BoundaryBytes               ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.State                                     = (MimeWriterState)GetInt32(new IntPtr(p + 0x020)); // 0x20 State                       ( ModelEnumType MimeWriterState MimeWriterState MimeWriterState Int32 )
            value.BufferedWrite                             = GetObject<BufferedWrite>(new IntPtr(p + 0x028), ReversePrism.DataModels.BufferedWrite.FromPointer); // 0x28 BufferedWrite               ( ModelClassType BufferedWrite BufferedWrite BufferedWrite Pointer )
            value.ContentStream                             = GetObject<Stream>(new IntPtr(p + 0x030), ReversePrism.DataModels.Stream.FromPointer); // 0x30 ContentStream               ( ModelClassType Stream Stream Stream Pointer )

            return value;
        }
    }
}
