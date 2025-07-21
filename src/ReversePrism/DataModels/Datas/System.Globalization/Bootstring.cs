using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 delimiter                                char IL2CPP_TYPE_CHAR
    // 014 Base_num                                 ModelPrimitiveType int int int Int32
    // 018 Tmin                                     ModelPrimitiveType int int int Int32
    // 01C Tmax                                     ModelPrimitiveType int int int Int32
    // 020 Skew                                     ModelPrimitiveType int int int Int32
    // 024 Damp                                     ModelPrimitiveType int int int Int32
    // 028 Initial_bias                             ModelPrimitiveType int int int Int32
    // 02C Initial_n                                ModelPrimitiveType int int int Int32
    public partial class Bootstring : DataModel
    {
        public int                                      Base_num                                { get; set; }
        public int                                      Tmin                                    { get; set; }
        public int                                      Tmax                                    { get; set; }
        public int                                      Skew                                    { get; set; }
        public int                                      Damp                                    { get; set; }
        public int                                      Initial_bias                            { get; set; }
        public int                                      Initial_n                               { get; set; }

        public static Bootstring? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Bootstring() { Pointer= p0 };

            value.Base_num                                  = GetInt32(new IntPtr(p + 0x014)); // 0x14 Base_num                    ( ModelPrimitiveType int int int Int32 )
            value.Tmin                                      = GetInt32(new IntPtr(p + 0x018)); // 0x18 Tmin                        ( ModelPrimitiveType int int int Int32 )
            value.Tmax                                      = GetInt32(new IntPtr(p + 0x01C)); // 0x1C Tmax                        ( ModelPrimitiveType int int int Int32 )
            value.Skew                                      = GetInt32(new IntPtr(p + 0x020)); // 0x20 Skew                        ( ModelPrimitiveType int int int Int32 )
            value.Damp                                      = GetInt32(new IntPtr(p + 0x024)); // 0x24 Damp                        ( ModelPrimitiveType int int int Int32 )
            value.Initial_bias                              = GetInt32(new IntPtr(p + 0x028)); // 0x28 Initial_bias                ( ModelPrimitiveType int int int Int32 )
            value.Initial_n                                 = GetInt32(new IntPtr(p + 0x02C)); // 0x2C Initial_n                   ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
