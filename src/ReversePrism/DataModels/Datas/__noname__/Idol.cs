using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       0001865F36C0 ModelPrimitiveType int int int Int32
    // 014 Vocal                                    0001865F36C0 ModelPrimitiveType int int int Int32
    // 018 Dance                                    0001865F36C0 ModelPrimitiveType int int int Int32
    // 01C Visual                                   0001865F36C0 ModelPrimitiveType int int int Int32
    // 020 Mental                                   0001865F36C0 ModelPrimitiveType int int int Int32
    public partial class Idol : DataModel
    {
        public int                                      Id                                      { get; set; }
        public int                                      Vocal                                   { get; set; }
        public int                                      Dance                                   { get; set; }
        public int                                      Visual                                  { get; set; }
        public int                                      Mental                                  { get; set; }

        public static Idol? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Idol() { Pointer= p0 };

            value.Id                                        = GetInt32(new IntPtr(p + 0x010)); // 0246652E1F50 0x10 Id                          ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Vocal                                     = GetInt32(new IntPtr(p + 0x014)); // 0246652E1F70 0x14 Vocal                       ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Dance                                     = GetInt32(new IntPtr(p + 0x018)); // 0246652E1F90 0x18 Dance                       ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Visual                                    = GetInt32(new IntPtr(p + 0x01C)); // 0246652E1FB0 0x1C Visual                      ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Mental                                    = GetInt32(new IntPtr(p + 0x020)); // 0246652E1FD0 0x20 Mental                      ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
