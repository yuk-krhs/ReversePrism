using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Source                                   00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 011 Replace                                  00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    public partial class Level2Map
    {
        public sbyte                                    Source                                  { get; set; }
        public sbyte                                    Replace                                 { get; set; }

        public static Level2Map? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Level2Map();

            value.Source                                    = GetSByte(new IntPtr(p + 0x010)); // 027003CE39C8 0x10 Source                      ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Replace                                   = GetSByte(new IntPtr(p + 0x011)); // 027003CE39E8 0x11 Replace                     ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )

            return value;
        }
    }
}
