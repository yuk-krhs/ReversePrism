using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Bitarray                                 ModelClassType BitArray BitArray BitArray Pointer
    // 018 Index                                    ModelPrimitiveType int int int Int32
    // 01C Version                                  ModelPrimitiveType int int int Int32
    // 020 CurrentElement                           ModelPrimitiveType bool bool bool Bool
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

            value.Bitarray                                  = GetObject<BitArray>(new IntPtr(p + 0x010), ReversePrism.DataModels.BitArray.FromPointer); // 0x10 Bitarray                    ( ModelClassType BitArray BitArray BitArray Pointer )
            value.Index                                     = GetInt32(new IntPtr(p + 0x018)); // 0x18 Index                       ( ModelPrimitiveType int int int Int32 )
            value.Version                                   = GetInt32(new IntPtr(p + 0x01C)); // 0x1C Version                     ( ModelPrimitiveType int int int Int32 )
            value.CurrentElement                            = GetBool(new IntPtr(p + 0x020)); // 0x20 CurrentElement              ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
