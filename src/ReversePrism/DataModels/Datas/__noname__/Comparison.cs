using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Terminates                               000186595960 ModelPrimitiveType bool bool bool Bool
    // 014 Result                                   0001865F36C0 ModelPrimitiveType int int int Int32
    public partial class Comparison
    {
        public bool                                     Terminates                              { get; set; }
        public int                                      Result                                  { get; set; }

        public static Comparison? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Comparison();

            value.Terminates                                = GetBool(new IntPtr(p + 0x010)); // 0270D9C64760 0x10 Terminates                  ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.Result                                    = GetInt32(new IntPtr(p + 0x014)); // 0270D9C64780 0x14 Result                      ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
