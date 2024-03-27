using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Stream                                   000186670270 ModelClassType Stream Stream Stream Pointer
    // 018 BoundaryBytes                            000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 020 State                                    000186619A60 ModelEnumType MimeWriterState MimeWriterState MimeWriterState Int32
    // 028 BufferedWrite                            00018650DC10 ModelClassType BufferedWrite BufferedWrite BufferedWrite Pointer
    // 030 ContentStream                            000186670270 ModelClassType Stream Stream Stream Pointer
    public partial class MimeWriter
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
            var value   = new MimeWriter();

            value.Stream                                    = GetObject<Stream>(new IntPtr(p + 0x010), ReversePrism.DataModels.Stream.FromPointer); // 0270D7C98F78 0x10 Stream                      ( 000186670270 ModelClassType Stream Stream Stream Pointer )
            value.BoundaryBytes                             = GetSByteList(new IntPtr(p + 0x018)); // 0270D7C98F98 0x18 BoundaryBytes               ( 000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.State                                     = (MimeWriterState)GetInt32(new IntPtr(p + 0x020)); // 0270D7C98FB8 0x20 State                       ( 000186619A60 ModelEnumType MimeWriterState MimeWriterState MimeWriterState Int32 )
            value.BufferedWrite                             = GetObject<BufferedWrite>(new IntPtr(p + 0x028), ReversePrism.DataModels.BufferedWrite.FromPointer); // 0270D7C98FD8 0x28 BufferedWrite               ( 00018650DC10 ModelClassType BufferedWrite BufferedWrite BufferedWrite Pointer )
            value.ContentStream                             = GetObject<Stream>(new IntPtr(p + 0x030), ReversePrism.DataModels.Stream.FromPointer); // 0270D7C98FF8 0x30 ContentStream               ( 000186670270 ModelClassType Stream Stream Stream Pointer )

            return value;
        }
    }
}
