using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 LCID                                     0001865F4940 ModelPrimitiveType int int int Int32
    // 014 TailoringIndex                           0001865F4940 ModelPrimitiveType int int int Int32
    // 018 TailoringCount                           0001865F4940 ModelPrimitiveType int int int Int32
    // 01C FrenchSort                               000186596AF0 ModelPrimitiveType bool bool bool Bool
    public partial class TailoringInfo
    {
        public int                                      LCID                                    { get; set; }
        public int                                      TailoringIndex                          { get; set; }
        public int                                      TailoringCount                          { get; set; }
        public bool                                     FrenchSort                              { get; set; }

        public static TailoringInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TailoringInfo();

            value.LCID                                      = GetInt32(new IntPtr(p + 0x010)); // 027003CBEB00 0x10 LCID                        ( 0001865F4940 ModelPrimitiveType int int int Int32 )
            value.TailoringIndex                            = GetInt32(new IntPtr(p + 0x014)); // 027003CBEB20 0x14 TailoringIndex              ( 0001865F4940 ModelPrimitiveType int int int Int32 )
            value.TailoringCount                            = GetInt32(new IntPtr(p + 0x018)); // 027003CBEB40 0x18 TailoringCount              ( 0001865F4940 ModelPrimitiveType int int int Int32 )
            value.FrenchSort                                = GetBool(new IntPtr(p + 0x01C)); // 027003CBEB60 0x1C FrenchSort                  ( 000186596AF0 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
