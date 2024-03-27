using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 Column                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    // 02C IsMatched                                000186595210 ModelPrimitiveType bool bool bool Bool
    // 030 Ks                                       00018676F7C0 ModelClassType KeySequence KeySequence KeySequence Pointer
    public partial class LocatedActiveAxis
    {
        public int                                      Column                                  { get; set; }
        public bool                                     IsMatched                               { get; set; }
        public KeySequence?                             Ks                                      { get; set; }

        public static LocatedActiveAxis? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LocatedActiveAxis();

            value.Column                                    = GetInt32(new IntPtr(p + 0x028)); // 0270D74FA110 0x28 Column                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.IsMatched                                 = GetBool(new IntPtr(p + 0x02C)); // 0270D74FA130 0x2C IsMatched                   ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.Ks                                        = GetObject<KeySequence>(new IntPtr(p + 0x030), ReversePrism.DataModels.KeySequence.FromPointer); // 0270D74FA150 0x30 Ks                          ( 00018676F7C0 ModelClassType KeySequence KeySequence KeySequence Pointer )

            return value;
        }
    }
}
