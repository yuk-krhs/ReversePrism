using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Null                                     BinaryWriter IL2CPP_TYPE_CLASS
    // 010 OutStream                                000186670700 ModelClassType Stream Stream Stream Pointer
    // 018 Buffer                                   000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 020 Encoding                                 00018672D9E0 ModelClassType Encoding Encoding Encoding Pointer
    // 028 Encoder                                  00018672B2A0 ModelClassType Encoder Encoder Encoder Pointer
    // 030 LeaveOpen                                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 038 LargeByteBuffer                          000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 040 MaxChars                                 0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class BinaryWriter
    {
        public Stream?                                  OutStream                               { get; set; }
        public List<sbyte>?                             Buffer                                  { get; set; }
        public Encoding?                                Encoding                                { get; set; }
        public Encoder?                                 Encoder                                 { get; set; }
        public bool                                     LeaveOpen                               { get; set; }
        public List<sbyte>?                             LargeByteBuffer                         { get; set; }
        public int                                      MaxChars                                { get; set; }

        public static BinaryWriter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BinaryWriter();

            value.OutStream                                 = GetObject<Stream>(new IntPtr(p + 0x010), ReversePrism.DataModels.Stream.FromPointer); // 0270D6C53CE0 0x10 OutStream                   ( 000186670700 ModelClassType Stream Stream Stream Pointer )
            value.Buffer                                    = GetSByteList(new IntPtr(p + 0x018)); // 0270D6C53D00 0x18 Buffer                      ( 000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Encoding                                  = GetObject<Encoding>(new IntPtr(p + 0x020), ReversePrism.DataModels.Encoding.FromPointer); // 0270D6C53D20 0x20 Encoding                    ( 00018672D9E0 ModelClassType Encoding Encoding Encoding Pointer )
            value.Encoder                                   = GetObject<Encoder>(new IntPtr(p + 0x028), ReversePrism.DataModels.Encoder.FromPointer); // 0270D6C53D40 0x28 Encoder                     ( 00018672B2A0 ModelClassType Encoder Encoder Encoder Pointer )
            value.LeaveOpen                                 = GetBool(new IntPtr(p + 0x030)); // 0270D6C53D60 0x30 LeaveOpen                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.LargeByteBuffer                           = GetSByteList(new IntPtr(p + 0x038)); // 0270D6C53D80 0x38 LargeByteBuffer             ( 000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.MaxChars                                  = GetInt32(new IntPtr(p + 0x040)); // 0270D6C53DA0 0x40 MaxChars                    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
