using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 InvalidOffset                            uint IL2CPP_TYPE_U4
    // 000 AutomaticOffset                          uint IL2CPP_TYPE_U4
    // 000 FormatInvalid                            FourCC IL2CPP_TYPE_VALUETYPE
    // 000 kFormatInvalid                           int IL2CPP_TYPE_I4
    // 004 FormatBit                                FourCC IL2CPP_TYPE_VALUETYPE
    // 000 kFormatBit                               int IL2CPP_TYPE_I4
    // 008 FormatSBit                               FourCC IL2CPP_TYPE_VALUETYPE
    // 000 kFormatSBit                              int IL2CPP_TYPE_I4
    // 00C FormatInt                                FourCC IL2CPP_TYPE_VALUETYPE
    // 000 kFormatInt                               int IL2CPP_TYPE_I4
    // 010 FormatUInt                               0001865BBBA0 ModelEnumType FourCC FourCC FourCC Int32
    // 000 kFormatUInt                              int IL2CPP_TYPE_I4
    // 014 FormatShort                              0001865BBBA0 ModelEnumType FourCC FourCC FourCC Int32
    // 000 kFormatShort                             int IL2CPP_TYPE_I4
    // 018 FormatUShort                             0001865BBBA0 ModelEnumType FourCC FourCC FourCC Int32
    // 000 kFormatUShort                            int IL2CPP_TYPE_I4
    // 01C FormatByte                               0001865BBBA0 ModelEnumType FourCC FourCC FourCC Int32
    // 000 kFormatByte                              int IL2CPP_TYPE_I4
    // 020 FormatSByte                              0001865BBBA0 ModelEnumType FourCC FourCC FourCC Int32
    // 000 kFormatSByte                             int IL2CPP_TYPE_I4
    // 024 FormatLong                               0001865BBBA0 ModelEnumType FourCC FourCC FourCC Int32
    // 000 kFormatLong                              int IL2CPP_TYPE_I4
    // 028 FormatULong                              0001865BBBA0 ModelEnumType FourCC FourCC FourCC Int32
    // 000 kFormatULong                             int IL2CPP_TYPE_I4
    // 02C FormatFloat                              0001865BBBA0 ModelEnumType FourCC FourCC FourCC Int32
    // 000 kFormatFloat                             int IL2CPP_TYPE_I4
    // 030 FormatDouble                             0001865BBBA0 ModelEnumType FourCC FourCC FourCC Int32
    // 000 kFormatDouble                            int IL2CPP_TYPE_I4
    // 034 FormatVector2                            0001865BBBA0 ModelEnumType FourCC FourCC FourCC Int32
    // 000 kFormatVector2                           int IL2CPP_TYPE_I4
    // 038 FormatVector3                            0001865BBBA0 ModelEnumType FourCC FourCC FourCC Int32
    // 000 kFormatVector3                           int IL2CPP_TYPE_I4
    // 03C FormatQuaternion                         0001865BBBA0 ModelEnumType FourCC FourCC FourCC Int32
    // 000 kFormatQuaternion                        int IL2CPP_TYPE_I4
    // 040 FormatVector2Short                       0001865BBBA0 ModelEnumType FourCC FourCC FourCC Int32
    // 044 FormatVector3Short                       0001865BBBA0 ModelEnumType FourCC FourCC FourCC Int32
    // 048 FormatVector2Byte                        0001865BBBA0 ModelEnumType FourCC FourCC FourCC Int32
    // 04C FormatVector3Byte                        0001865BBBA0 ModelEnumType FourCC FourCC FourCC Int32
    // 050 FormatPose                               0001865BBBA0 ModelEnumType FourCC FourCC FourCC Int32
    // 000 kFormatPose                              int IL2CPP_TYPE_I4
    // 010 Format                                   0001865BB210 ModelEnumType FourCC FourCC FourCC Int32
    // 014 M_ByteOffset                             000186698DF0 ModelPrimitiveType uint uint uint UInt32
    // 018 BitOffset                                000186698B70 ModelPrimitiveType uint uint uint UInt32
    // 01C SizeInBits                               000186698B70 ModelPrimitiveType uint uint uint UInt32
    public partial class InputStateBlock : DataModel
    {
        public FourCC                                   FormatUInt                              { get; set; }
        public FourCC                                   FormatShort                             { get; set; }
        public FourCC                                   FormatUShort                            { get; set; }
        public FourCC                                   FormatByte                              { get; set; }
        public FourCC                                   FormatSByte                             { get; set; }
        public FourCC                                   FormatLong                              { get; set; }
        public FourCC                                   FormatULong                             { get; set; }
        public FourCC                                   FormatFloat                             { get; set; }
        public FourCC                                   FormatDouble                            { get; set; }
        public FourCC                                   FormatVector2                           { get; set; }
        public FourCC                                   FormatVector3                           { get; set; }
        public FourCC                                   FormatQuaternion                        { get; set; }
        public FourCC                                   FormatVector2Short                      { get; set; }
        public FourCC                                   FormatVector3Short                      { get; set; }
        public FourCC                                   FormatVector2Byte                       { get; set; }
        public FourCC                                   FormatVector3Byte                       { get; set; }
        public FourCC                                   FormatPose                              { get; set; }
        public FourCC                                   Format                                  { get; set; }
        public uint                                     M_ByteOffset                            { get; set; }
        public uint                                     BitOffset                               { get; set; }
        public uint                                     SizeInBits                              { get; set; }

        public static InputStateBlock? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InputStateBlock() { Pointer= p0 };

            value.FormatUInt                                = (FourCC)GetInt32(new IntPtr(p + 0x010)); // 0245A2E35AF8 0x10 FormatUInt                  ( 0001865BBBA0 ModelEnumType FourCC FourCC FourCC Int32 )
            value.FormatShort                               = (FourCC)GetInt32(new IntPtr(p + 0x014)); // 0245A2E35B38 0x14 FormatShort                 ( 0001865BBBA0 ModelEnumType FourCC FourCC FourCC Int32 )
            value.FormatUShort                              = (FourCC)GetInt32(new IntPtr(p + 0x018)); // 0245A2E35B78 0x18 FormatUShort                ( 0001865BBBA0 ModelEnumType FourCC FourCC FourCC Int32 )
            value.FormatByte                                = (FourCC)GetInt32(new IntPtr(p + 0x01C)); // 0245A2E35BB8 0x1C FormatByte                  ( 0001865BBBA0 ModelEnumType FourCC FourCC FourCC Int32 )
            value.FormatSByte                               = (FourCC)GetInt32(new IntPtr(p + 0x020)); // 0245A2E35BF8 0x20 FormatSByte                 ( 0001865BBBA0 ModelEnumType FourCC FourCC FourCC Int32 )
            value.FormatLong                                = (FourCC)GetInt32(new IntPtr(p + 0x024)); // 0245A2E35C38 0x24 FormatLong                  ( 0001865BBBA0 ModelEnumType FourCC FourCC FourCC Int32 )
            value.FormatULong                               = (FourCC)GetInt32(new IntPtr(p + 0x028)); // 0245A2E35C78 0x28 FormatULong                 ( 0001865BBBA0 ModelEnumType FourCC FourCC FourCC Int32 )
            value.FormatFloat                               = (FourCC)GetInt32(new IntPtr(p + 0x02C)); // 0245A2E35CB8 0x2C FormatFloat                 ( 0001865BBBA0 ModelEnumType FourCC FourCC FourCC Int32 )
            value.FormatDouble                              = (FourCC)GetInt32(new IntPtr(p + 0x030)); // 0245A2E35CF8 0x30 FormatDouble                ( 0001865BBBA0 ModelEnumType FourCC FourCC FourCC Int32 )
            value.FormatVector2                             = (FourCC)GetInt32(new IntPtr(p + 0x034)); // 0245A2E35D38 0x34 FormatVector2               ( 0001865BBBA0 ModelEnumType FourCC FourCC FourCC Int32 )
            value.FormatVector3                             = (FourCC)GetInt32(new IntPtr(p + 0x038)); // 0245A2E35D78 0x38 FormatVector3               ( 0001865BBBA0 ModelEnumType FourCC FourCC FourCC Int32 )
            value.FormatQuaternion                          = (FourCC)GetInt32(new IntPtr(p + 0x03C)); // 0245A2E35DB8 0x3C FormatQuaternion            ( 0001865BBBA0 ModelEnumType FourCC FourCC FourCC Int32 )
            value.FormatVector2Short                        = (FourCC)GetInt32(new IntPtr(p + 0x040)); // 0245A2E35DF8 0x40 FormatVector2Short          ( 0001865BBBA0 ModelEnumType FourCC FourCC FourCC Int32 )
            value.FormatVector3Short                        = (FourCC)GetInt32(new IntPtr(p + 0x044)); // 0245A2E35E18 0x44 FormatVector3Short          ( 0001865BBBA0 ModelEnumType FourCC FourCC FourCC Int32 )
            value.FormatVector2Byte                         = (FourCC)GetInt32(new IntPtr(p + 0x048)); // 0245A2E35E38 0x48 FormatVector2Byte           ( 0001865BBBA0 ModelEnumType FourCC FourCC FourCC Int32 )
            value.FormatVector3Byte                         = (FourCC)GetInt32(new IntPtr(p + 0x04C)); // 0245A2E35E58 0x4C FormatVector3Byte           ( 0001865BBBA0 ModelEnumType FourCC FourCC FourCC Int32 )
            value.FormatPose                                = (FourCC)GetInt32(new IntPtr(p + 0x050)); // 0245A2E35E78 0x50 FormatPose                  ( 0001865BBBA0 ModelEnumType FourCC FourCC FourCC Int32 )
            value.Format                                    = (FourCC)GetInt32(new IntPtr(p + 0x010)); // 0245A2E35EB8 0x10 Format                      ( 0001865BB210 ModelEnumType FourCC FourCC FourCC Int32 )
            value.M_ByteOffset                              = GetUInt32(new IntPtr(p + 0x014)); // 0245A2E35ED8 0x14 M_ByteOffset                ( 000186698DF0 ModelPrimitiveType uint uint uint UInt32 )
            value.BitOffset                                 = GetUInt32(new IntPtr(p + 0x018)); // 0245A2E35EF8 0x18 BitOffset                   ( 000186698B70 ModelPrimitiveType uint uint uint UInt32 )
            value.SizeInBits                                = GetUInt32(new IntPtr(p + 0x01C)); // 0245A2E35F18 0x1C SizeInBits                  ( 000186698B70 ModelPrimitiveType uint uint uint UInt32 )

            return value;
        }
    }
}
