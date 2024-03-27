using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       000186697760 ModelPrimitiveType ushort ushort ushort UInt16
    // 012 Flags                                    000186697760 ModelPrimitiveType ushort ushort ushort UInt16
    // 014 Color                                    0001865AD8F0 ModelEnumType Color32 Color32 Color32 Int32
    // 018 Reserved0                                0001865F4260 ModelPrimitiveType int int int Int32
    // 01C NameUtf8Len                              0001865F4940 ModelPrimitiveType int int int Int32
    // 020 NameUtf8                                 IntPtr IL2CPP_TYPE_PTR
    public partial class ProfilerCategoryDescription
    {
        public ushort                                   Id                                      { get; set; }
        public ushort                                   Flags                                   { get; set; }
        public Color32                                  Color                                   { get; set; }
        public int                                      Reserved0                               { get; set; }
        public int                                      NameUtf8Len                             { get; set; }

        public static ProfilerCategoryDescription? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProfilerCategoryDescription();

            value.Id                                        = GetUInt16(new IntPtr(p + 0x010)); // 0270068A42B0 0x10 Id                          ( 000186697760 ModelPrimitiveType ushort ushort ushort UInt16 )
            value.Flags                                     = GetUInt16(new IntPtr(p + 0x012)); // 0270068A42D0 0x12 Flags                       ( 000186697760 ModelPrimitiveType ushort ushort ushort UInt16 )
            value.Color                                     = (Color32)GetInt32(new IntPtr(p + 0x014)); // 0270068A42F0 0x14 Color                       ( 0001865AD8F0 ModelEnumType Color32 Color32 Color32 Int32 )
            value.Reserved0                                 = GetInt32(new IntPtr(p + 0x018)); // 0270068A4310 0x18 Reserved0                   ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.NameUtf8Len                               = GetInt32(new IntPtr(p + 0x01C)); // 0270068A4330 0x1C NameUtf8Len                 ( 0001865F4940 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
