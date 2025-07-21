using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Source                                   ModelPrimitiveType sbyte sbyte sbyte SByte
    // 011 Replace                                  ModelPrimitiveType sbyte sbyte sbyte SByte
    public partial class Level2Map : DataModel
    {
        public sbyte                                    Source                                  { get; set; }
        public sbyte                                    Replace                                 { get; set; }

        public static Level2Map? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Level2Map() { Pointer= p0 };

            value.Source                                    = GetSByte(new IntPtr(p + 0x010)); // 0x10 Source                      ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Replace                                   = GetSByte(new IntPtr(p + 0x011)); // 0x11 Replace                     ( ModelPrimitiveType sbyte sbyte sbyte SByte )

            return value;
        }
    }
}
