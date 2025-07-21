using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Null                                     BinaryWriter IL2CPP_TYPE_CLASS
    // 010 OutStream                                ModelClassType Stream Stream Stream Pointer
    // 018 Buffer                                   ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 020 Encoding                                 ModelClassType Encoding Encoding Encoding Pointer
    // 028 Encoder                                  ModelClassType Encoder Encoder Encoder Pointer
    // 030 LeaveOpen                                ModelPrimitiveType bool bool bool Bool
    // 038 LargeByteBuffer                          ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 040 MaxChars                                 ModelPrimitiveType int int int Int32
    public partial class BinaryWriter : DataModel
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
            var value   = new BinaryWriter() { Pointer= p0 };

            value.OutStream                                 = GetObject<Stream>(new IntPtr(p + 0x010), ReversePrism.DataModels.Stream.FromPointer); // 0x10 OutStream                   ( ModelClassType Stream Stream Stream Pointer )
            value.Buffer                                    = GetSByteList(new IntPtr(p + 0x018)); // 0x18 Buffer                      ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Encoding                                  = GetObject<Encoding>(new IntPtr(p + 0x020), ReversePrism.DataModels.Encoding.FromPointer); // 0x20 Encoding                    ( ModelClassType Encoding Encoding Encoding Pointer )
            value.Encoder                                   = GetObject<Encoder>(new IntPtr(p + 0x028), ReversePrism.DataModels.Encoder.FromPointer); // 0x28 Encoder                     ( ModelClassType Encoder Encoder Encoder Pointer )
            value.LeaveOpen                                 = GetBool(new IntPtr(p + 0x030)); // 0x30 LeaveOpen                   ( ModelPrimitiveType bool bool bool Bool )
            value.LargeByteBuffer                           = GetSByteList(new IntPtr(p + 0x038)); // 0x38 LargeByteBuffer             ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.MaxChars                                  = GetInt32(new IntPtr(p + 0x040)); // 0x40 MaxChars                    ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
