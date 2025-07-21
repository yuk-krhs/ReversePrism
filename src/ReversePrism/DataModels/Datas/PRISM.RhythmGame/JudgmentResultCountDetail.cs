using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Total                                    ModelPrimitiveType int int int Int32
    // 014 Fast                                     ModelPrimitiveType int int int Int32
    // 018 Slow                                     ModelPrimitiveType int int int Int32
    // 01C Reverse                                  ModelPrimitiveType int int int Int32
    public partial class JudgmentResultCountDetail : DataModel
    {
        public int                                      Total                                   { get; set; }
        public int                                      Fast                                    { get; set; }
        public int                                      Slow                                    { get; set; }
        public int                                      Reverse                                 { get; set; }

        public static JudgmentResultCountDetail? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new JudgmentResultCountDetail() { Pointer= p0 };

            value.Total                                     = GetInt32(new IntPtr(p + 0x010)); // 0x10 Total                       ( ModelPrimitiveType int int int Int32 )
            value.Fast                                      = GetInt32(new IntPtr(p + 0x014)); // 0x14 Fast                        ( ModelPrimitiveType int int int Int32 )
            value.Slow                                      = GetInt32(new IntPtr(p + 0x018)); // 0x18 Slow                        ( ModelPrimitiveType int int int Int32 )
            value.Reverse                                   = GetInt32(new IntPtr(p + 0x01C)); // 0x1C Reverse                     ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
