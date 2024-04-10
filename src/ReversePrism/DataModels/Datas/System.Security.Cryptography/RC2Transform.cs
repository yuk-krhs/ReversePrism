using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 058 R0                                       000186696AE0 ModelPrimitiveType ushort ushort ushort UInt16
    // 05A R1                                       000186696AE0 ModelPrimitiveType ushort ushort ushort UInt16
    // 05C R2                                       000186696AE0 ModelPrimitiveType ushort ushort ushort UInt16
    // 05E R3                                       000186696AE0 ModelPrimitiveType ushort ushort ushort UInt16
    // 060 K                                        000185CAEB28 ModelPrimitiveListType ushort[] ushort[] List<ushort> Pointer
    // 068 J                                        0001865F2AF0 ModelPrimitiveType int int int Int32
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

            value.R0                                        = GetUInt16(new IntPtr(p + 0x058)); // 024666C28BF0 0x58 R0                          ( 000186696AE0 ModelPrimitiveType ushort ushort ushort UInt16 )
            value.R1                                        = GetUInt16(new IntPtr(p + 0x05A)); // 024666C28C10 0x5A R1                          ( 000186696AE0 ModelPrimitiveType ushort ushort ushort UInt16 )
            value.R2                                        = GetUInt16(new IntPtr(p + 0x05C)); // 024666C28C30 0x5C R2                          ( 000186696AE0 ModelPrimitiveType ushort ushort ushort UInt16 )
            value.R3                                        = GetUInt16(new IntPtr(p + 0x05E)); // 024666C28C50 0x5E R3                          ( 000186696AE0 ModelPrimitiveType ushort ushort ushort UInt16 )
            value.K                                         = GetUInt16List(new IntPtr(p + 0x060)); // 024666C28C70 0x60 K                           ( 000185CAEB28 ModelPrimitiveListType ushort[] ushort[] List<ushort> Pointer )
            value.J                                         = GetInt32(new IntPtr(p + 0x068)); // 024666C28C90 0x68 J                           ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
