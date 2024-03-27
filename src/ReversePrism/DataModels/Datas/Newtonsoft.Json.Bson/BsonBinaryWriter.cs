using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Encoding                                 Encoding IL2CPP_TYPE_CLASS
    // 010 Writer                                   00018675C180 ModelClassType BinaryWriter BinaryWriter BinaryWriter Pointer
    // 018 LargeByteBuffer                          000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 020 DateTimeKindHandling                     0001865BC190 ModelEnumType DateTimeKind DateTimeKind DateTimeKind Int32
    public partial class BsonBinaryWriter
    {
        public BinaryWriter?                            Writer                                  { get; set; }
        public List<sbyte>?                             LargeByteBuffer                         { get; set; }
        public DateTimeKind                             DateTimeKindHandling                    { get; set; }

        public static BsonBinaryWriter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BsonBinaryWriter();

            value.Writer                                    = GetObject<BinaryWriter>(new IntPtr(p + 0x010), ReversePrism.DataModels.BinaryWriter.FromPointer); // 0270D88824D8 0x10 Writer                      ( 00018675C180 ModelClassType BinaryWriter BinaryWriter BinaryWriter Pointer )
            value.LargeByteBuffer                           = GetSByteList(new IntPtr(p + 0x018)); // 0270D88824F8 0x18 LargeByteBuffer             ( 000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.DateTimeKindHandling                      = (DateTimeKind)GetInt32(new IntPtr(p + 0x020)); // 0270D8882518 0x20 DateTimeKindHandling        ( 0001865BC190 ModelEnumType DateTimeKind DateTimeKind DateTimeKind Int32 )

            return value;
        }
    }
}
