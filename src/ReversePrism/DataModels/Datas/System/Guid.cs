using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Empty                                    Guid IL2CPP_TYPE_VALUETYPE
    // 010 A                                        ModelPrimitiveType int int int Int32
    // 014 B                                        ModelPrimitiveType short short short Int16
    // 016 C                                        ModelPrimitiveType short short short Int16
    // 018 D                                        ModelPrimitiveType sbyte sbyte sbyte SByte
    // 019 E                                        ModelPrimitiveType sbyte sbyte sbyte SByte
    // 01A F                                        ModelPrimitiveType sbyte sbyte sbyte SByte
    // 01B G                                        ModelPrimitiveType sbyte sbyte sbyte SByte
    // 01C H                                        ModelPrimitiveType sbyte sbyte sbyte SByte
    // 01D I                                        ModelPrimitiveType sbyte sbyte sbyte SByte
    // 01E J                                        ModelPrimitiveType sbyte sbyte sbyte SByte
    // 01F K                                        ModelPrimitiveType sbyte sbyte sbyte SByte
    public partial class Guid : DataModel
    {
        public int                                      A                                       { get; set; }
        public short                                    B                                       { get; set; }
        public short                                    C                                       { get; set; }
        public sbyte                                    D                                       { get; set; }
        public sbyte                                    E                                       { get; set; }
        public sbyte                                    F                                       { get; set; }
        public sbyte                                    G                                       { get; set; }
        public sbyte                                    H                                       { get; set; }
        public sbyte                                    I                                       { get; set; }
        public sbyte                                    J                                       { get; set; }
        public sbyte                                    K                                       { get; set; }

        public static Guid? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Guid() { Pointer= p0 };

            value.A                                         = GetInt32(new IntPtr(p + 0x010)); // 0x10 A                           ( ModelPrimitiveType int int int Int32 )
            value.B                                         = GetInt16(new IntPtr(p + 0x014)); // 0x14 B                           ( ModelPrimitiveType short short short Int16 )
            value.C                                         = GetInt16(new IntPtr(p + 0x016)); // 0x16 C                           ( ModelPrimitiveType short short short Int16 )
            value.D                                         = GetSByte(new IntPtr(p + 0x018)); // 0x18 D                           ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.E                                         = GetSByte(new IntPtr(p + 0x019)); // 0x19 E                           ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.F                                         = GetSByte(new IntPtr(p + 0x01A)); // 0x1A F                           ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.G                                         = GetSByte(new IntPtr(p + 0x01B)); // 0x1B G                           ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.H                                         = GetSByte(new IntPtr(p + 0x01C)); // 0x1C H                           ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.I                                         = GetSByte(new IntPtr(p + 0x01D)); // 0x1D I                           ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.J                                         = GetSByte(new IntPtr(p + 0x01E)); // 0x1E J                           ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.K                                         = GetSByte(new IntPtr(p + 0x01F)); // 0x1F K                           ( ModelPrimitiveType sbyte sbyte sbyte SByte )

            return value;
        }
    }
}
