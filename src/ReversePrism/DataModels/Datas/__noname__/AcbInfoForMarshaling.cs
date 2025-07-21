using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 namePtr                                  <int> IL2CPP_TYPE_I
    // 018 Size                                     ModelPrimitiveType uint uint uint UInt32
    // 01C Version                                  ModelPrimitiveType uint uint uint UInt32
    // 020 CharacterEncoding                        ModelEnumType CharacterEncoding CharacterEncoding CharacterEncoding Int32
    // 024 Volume                                   ModelPrimitiveType float float float Single
    // 028 NumCues                                  ModelPrimitiveType int int int Int32
    public partial class AcbInfoForMarshaling : DataModel
    {
        public uint                                     Size                                    { get; set; }
        public uint                                     Version                                 { get; set; }
        public CharacterEncoding                        CharacterEncoding                       { get; set; }
        public float                                    Volume                                  { get; set; }
        public int                                      NumCues                                 { get; set; }

        public static AcbInfoForMarshaling? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AcbInfoForMarshaling() { Pointer= p0 };

            value.Size                                      = GetUInt32(new IntPtr(p + 0x018)); // 0x18 Size                        ( ModelPrimitiveType uint uint uint UInt32 )
            value.Version                                   = GetUInt32(new IntPtr(p + 0x01C)); // 0x1C Version                     ( ModelPrimitiveType uint uint uint UInt32 )
            value.CharacterEncoding                         = (CharacterEncoding)GetInt32(new IntPtr(p + 0x020)); // 0x20 CharacterEncoding           ( ModelEnumType CharacterEncoding CharacterEncoding CharacterEncoding Int32 )
            value.Volume                                    = GetSingle(new IntPtr(p + 0x024)); // 0x24 Volume                      ( ModelPrimitiveType float float float Single )
            value.NumCues                                   = GetInt32(new IntPtr(p + 0x028)); // 0x28 NumCues                     ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
