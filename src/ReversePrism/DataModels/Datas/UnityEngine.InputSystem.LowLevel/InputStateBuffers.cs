using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SizePerBuffer                            0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 014 TotalSize                                0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 018 defaultStateBuffer                       IntPtr IL2CPP_TYPE_PTR
    // 020 noiseMaskBuffer                          IntPtr IL2CPP_TYPE_PTR
    // 028 resetMaskBuffer                          IntPtr IL2CPP_TYPE_PTR
    // 030 m_AllBuffers                             IntPtr IL2CPP_TYPE_PTR
    // 038 M_PlayerStateBuffers                     00018663A430 ModelEnumType DoubleBuffers DoubleBuffers DoubleBuffers Int32
    // 000 s_DefaultStateBuffer                     IntPtr IL2CPP_TYPE_PTR
    // 008 s_NoiseMaskBuffer                        IntPtr IL2CPP_TYPE_PTR
    // 010 s_ResetMaskBuffer                        IntPtr IL2CPP_TYPE_PTR
    // 018 S_CurrentBuffers                         00018663A6A0 ModelEnumType DoubleBuffers DoubleBuffers DoubleBuffers Int32
    public partial class InputStateBuffers
    {
        public uint                                     SizePerBuffer                           { get; set; }
        public uint                                     TotalSize                               { get; set; }
        public DoubleBuffers                            M_PlayerStateBuffers                    { get; set; }
        public DoubleBuffers                            S_CurrentBuffers                        { get; set; }

        public static InputStateBuffers? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InputStateBuffers();

            value.SizePerBuffer                             = GetUInt32(new IntPtr(p + 0x010)); // 02700334C430 0x10 SizePerBuffer               ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.TotalSize                                 = GetUInt32(new IntPtr(p + 0x014)); // 02700334C450 0x14 TotalSize                   ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.M_PlayerStateBuffers                      = (DoubleBuffers)GetInt32(new IntPtr(p + 0x038)); // 02700334C4F0 0x38 M_PlayerStateBuffers        ( 00018663A430 ModelEnumType DoubleBuffers DoubleBuffers DoubleBuffers Int32 )
            value.S_CurrentBuffers                          = (DoubleBuffers)GetInt32(new IntPtr(p + 0x018)); // 02700334C570 0x18 S_CurrentBuffers            ( 00018663A6A0 ModelEnumType DoubleBuffers DoubleBuffers DoubleBuffers Int32 )

            return value;
        }
    }
}
