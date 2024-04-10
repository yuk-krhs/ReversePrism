using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Bitarray                                 000186593200 ModelClassType BitArray BitArray BitArray Pointer
    // 018 Index                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 01C Version                                  0001865F2AF0 ModelPrimitiveType int int int Int32
    // 020 CurrentElement                           000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class BitArrayEnumeratorSimple : DataModel
    {
        public BitArray?                                Bitarray                                { get; set; }
        public int                                      Index                                   { get; set; }
        public int                                      Version                                 { get; set; }
        public bool                                     CurrentElement                          { get; set; }

        public static BitArrayEnumeratorSimple? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BitArrayEnumeratorSimple() { Pointer= p0 };

            value.Bitarray                                  = GetObject<BitArray>(new IntPtr(p + 0x010), ReversePrism.DataModels.BitArray.FromPointer); // 024666DD3548 0x10 Bitarray                    ( 000186593200 ModelClassType BitArray BitArray BitArray Pointer )
            value.Index                                     = GetInt32(new IntPtr(p + 0x018)); // 024666DD3568 0x18 Index                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Version                                   = GetInt32(new IntPtr(p + 0x01C)); // 024666DD3588 0x1C Version                     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.CurrentElement                            = GetBool(new IntPtr(p + 0x020)); // 024666DD35A8 0x20 CurrentElement              ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
