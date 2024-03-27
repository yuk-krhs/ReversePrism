using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 S0                                       0001865F2AF0 ModelPrimitiveType int int int Int32
    // 014 S1                                       0001865F2AF0 ModelPrimitiveType int int int Int32
    // 018 S2                                       0001865F2AF0 ModelPrimitiveType int int int Int32
    // 01C S3                                       0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class State
    {
        public int                                      S0                                      { get; set; }
        public int                                      S1                                      { get; set; }
        public int                                      S2                                      { get; set; }
        public int                                      S3                                      { get; set; }

        public static State? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new State();

            value.S0                                        = GetInt32(new IntPtr(p + 0x010)); // 0270068B87B8 0x10 S0                          ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.S1                                        = GetInt32(new IntPtr(p + 0x014)); // 0270068B87D8 0x14 S1                          ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.S2                                        = GetInt32(new IntPtr(p + 0x018)); // 0270068B87F8 0x18 S2                          ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.S3                                        = GetInt32(new IntPtr(p + 0x01C)); // 0270068B8818 0x1C S3                          ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
