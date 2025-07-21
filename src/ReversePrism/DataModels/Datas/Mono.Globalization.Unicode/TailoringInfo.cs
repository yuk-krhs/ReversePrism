using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 LCID                                     ModelPrimitiveType int int int Int32
    // 014 TailoringIndex                           ModelPrimitiveType int int int Int32
    // 018 TailoringCount                           ModelPrimitiveType int int int Int32
    // 01C FrenchSort                               ModelPrimitiveType bool bool bool Bool
    public partial class TailoringInfo : DataModel
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
            var value   = new TailoringInfo() { Pointer= p0 };

            value.LCID                                      = GetInt32(new IntPtr(p + 0x010)); // 0x10 LCID                        ( ModelPrimitiveType int int int Int32 )
            value.TailoringIndex                            = GetInt32(new IntPtr(p + 0x014)); // 0x14 TailoringIndex              ( ModelPrimitiveType int int int Int32 )
            value.TailoringCount                            = GetInt32(new IntPtr(p + 0x018)); // 0x18 TailoringCount              ( ModelPrimitiveType int int int Int32 )
            value.FrenchSort                                = GetBool(new IntPtr(p + 0x01C)); // 0x1C FrenchSort                  ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
