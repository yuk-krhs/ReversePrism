using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 058 R0                                       ModelPrimitiveType ushort ushort ushort UInt16
    // 05A R1                                       ModelPrimitiveType ushort ushort ushort UInt16
    // 05C R2                                       ModelPrimitiveType ushort ushort ushort UInt16
    // 05E R3                                       ModelPrimitiveType ushort ushort ushort UInt16
    // 060 K                                        ModelPrimitiveListType ushort[] ushort[] List<ushort> Pointer
    // 068 J                                        ModelPrimitiveType int int int Int32
    // 000 pitable                                  sbyte[] IL2CPP_TYPE_SZARRAY
    public partial class RC2Transform : DataModel
    {
        public ushort                                   R0                                      { get; set; }
        public ushort                                   R1                                      { get; set; }
        public ushort                                   R2                                      { get; set; }
        public ushort                                   R3                                      { get; set; }
        public List<ushort>?                            K                                       { get; set; }
        public int                                      J                                       { get; set; }

        public static RC2Transform? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RC2Transform() { Pointer= p0 };

            value.R0                                        = GetUInt16(new IntPtr(p + 0x058)); // 0x58 R0                          ( ModelPrimitiveType ushort ushort ushort UInt16 )
            value.R1                                        = GetUInt16(new IntPtr(p + 0x05A)); // 0x5A R1                          ( ModelPrimitiveType ushort ushort ushort UInt16 )
            value.R2                                        = GetUInt16(new IntPtr(p + 0x05C)); // 0x5C R2                          ( ModelPrimitiveType ushort ushort ushort UInt16 )
            value.R3                                        = GetUInt16(new IntPtr(p + 0x05E)); // 0x5E R3                          ( ModelPrimitiveType ushort ushort ushort UInt16 )
            value.K                                         = GetUInt16List(new IntPtr(p + 0x060)); // 0x60 K                           ( ModelPrimitiveListType ushort[] ushort[] List<ushort> Pointer )
            value.J                                         = GetInt32(new IntPtr(p + 0x068)); // 0x68 J                           ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
