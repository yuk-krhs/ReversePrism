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
    // 010 FormatUInt                               ModelEnumType FourCC FourCC FourCC Int32
    // 000 kFormatUInt                              int IL2CPP_TYPE_I4
    // 014 FormatShort                              ModelEnumType FourCC FourCC FourCC Int32
    // 000 kFormatShort                             int IL2CPP_TYPE_I4
    // 018 FormatUShort                             ModelEnumType FourCC FourCC FourCC Int32
    // 000 kFormatUShort                            int IL2CPP_TYPE_I4
    // 01C FormatByte                               ModelEnumType FourCC FourCC FourCC Int32
    // 000 kFormatByte                              int IL2CPP_TYPE_I4
    // 020 FormatSByte                              ModelEnumType FourCC FourCC FourCC Int32
    // 000 kFormatSByte                             int IL2CPP_TYPE_I4
    // 024 FormatLong                               ModelEnumType FourCC FourCC FourCC Int32
    // 000 kFormatLong                              int IL2CPP_TYPE_I4
    // 028 FormatULong                              ModelEnumType FourCC FourCC FourCC Int32
    // 000 kFormatULong                             int IL2CPP_TYPE_I4
    // 02C FormatFloat                              ModelEnumType FourCC FourCC FourCC Int32
    // 000 kFormatFloat                             int IL2CPP_TYPE_I4
    // 030 FormatDouble                             ModelEnumType FourCC FourCC FourCC Int32
    // 000 kFormatDouble                            int IL2CPP_TYPE_I4
    // 034 FormatVector2                            ModelEnumType FourCC FourCC FourCC Int32
    // 000 kFormatVector2                           int IL2CPP_TYPE_I4
    // 038 FormatVector3                            ModelEnumType FourCC FourCC FourCC Int32
    // 000 kFormatVector3                           int IL2CPP_TYPE_I4
    // 03C FormatQuaternion                         ModelEnumType FourCC FourCC FourCC Int32
    // 000 kFormatQuaternion                        int IL2CPP_TYPE_I4
    // 040 FormatVector2Short                       ModelEnumType FourCC FourCC FourCC Int32
    // 044 FormatVector3Short                       ModelEnumType FourCC FourCC FourCC Int32
    // 048 FormatVector2Byte                        ModelEnumType FourCC FourCC FourCC Int32
    // 04C FormatVector3Byte                        ModelEnumType FourCC FourCC FourCC Int32
    // 050 FormatPose                               ModelEnumType FourCC FourCC FourCC Int32
    // 000 kFormatPose                              int IL2CPP_TYPE_I4
    // 010 Format                                   ModelEnumType FourCC FourCC FourCC Int32
    // 014 M_ByteOffset                             ModelPrimitiveType uint uint uint UInt32
    // 018 BitOffset                                ModelPrimitiveType uint uint uint UInt32
    // 01C SizeInBits                               ModelPrimitiveType uint uint uint UInt32
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

            value.FormatUInt                                = (FourCC)GetInt32(new IntPtr(p + 0x010)); // 0x10 FormatUInt                  ( ModelEnumType FourCC FourCC FourCC Int32 )
            value.FormatShort                               = (FourCC)GetInt32(new IntPtr(p + 0x014)); // 0x14 FormatShort                 ( ModelEnumType FourCC FourCC FourCC Int32 )
            value.FormatUShort                              = (FourCC)GetInt32(new IntPtr(p + 0x018)); // 0x18 FormatUShort                ( ModelEnumType FourCC FourCC FourCC Int32 )
            value.FormatByte                                = (FourCC)GetInt32(new IntPtr(p + 0x01C)); // 0x1C FormatByte                  ( ModelEnumType FourCC FourCC FourCC Int32 )
            value.FormatSByte                               = (FourCC)GetInt32(new IntPtr(p + 0x020)); // 0x20 FormatSByte                 ( ModelEnumType FourCC FourCC FourCC Int32 )
            value.FormatLong                                = (FourCC)GetInt32(new IntPtr(p + 0x024)); // 0x24 FormatLong                  ( ModelEnumType FourCC FourCC FourCC Int32 )
            value.FormatULong                               = (FourCC)GetInt32(new IntPtr(p + 0x028)); // 0x28 FormatULong                 ( ModelEnumType FourCC FourCC FourCC Int32 )
            value.FormatFloat                               = (FourCC)GetInt32(new IntPtr(p + 0x02C)); // 0x2C FormatFloat                 ( ModelEnumType FourCC FourCC FourCC Int32 )
            value.FormatDouble                              = (FourCC)GetInt32(new IntPtr(p + 0x030)); // 0x30 FormatDouble                ( ModelEnumType FourCC FourCC FourCC Int32 )
            value.FormatVector2                             = (FourCC)GetInt32(new IntPtr(p + 0x034)); // 0x34 FormatVector2               ( ModelEnumType FourCC FourCC FourCC Int32 )
            value.FormatVector3                             = (FourCC)GetInt32(new IntPtr(p + 0x038)); // 0x38 FormatVector3               ( ModelEnumType FourCC FourCC FourCC Int32 )
            value.FormatQuaternion                          = (FourCC)GetInt32(new IntPtr(p + 0x03C)); // 0x3C FormatQuaternion            ( ModelEnumType FourCC FourCC FourCC Int32 )
            value.FormatVector2Short                        = (FourCC)GetInt32(new IntPtr(p + 0x040)); // 0x40 FormatVector2Short          ( ModelEnumType FourCC FourCC FourCC Int32 )
            value.FormatVector3Short                        = (FourCC)GetInt32(new IntPtr(p + 0x044)); // 0x44 FormatVector3Short          ( ModelEnumType FourCC FourCC FourCC Int32 )
            value.FormatVector2Byte                         = (FourCC)GetInt32(new IntPtr(p + 0x048)); // 0x48 FormatVector2Byte           ( ModelEnumType FourCC FourCC FourCC Int32 )
            value.FormatVector3Byte                         = (FourCC)GetInt32(new IntPtr(p + 0x04C)); // 0x4C FormatVector3Byte           ( ModelEnumType FourCC FourCC FourCC Int32 )
            value.FormatPose                                = (FourCC)GetInt32(new IntPtr(p + 0x050)); // 0x50 FormatPose                  ( ModelEnumType FourCC FourCC FourCC Int32 )
            value.Format                                    = (FourCC)GetInt32(new IntPtr(p + 0x010)); // 0x10 Format                      ( ModelEnumType FourCC FourCC FourCC Int32 )
            value.M_ByteOffset                              = GetUInt32(new IntPtr(p + 0x014)); // 0x14 M_ByteOffset                ( ModelPrimitiveType uint uint uint UInt32 )
            value.BitOffset                                 = GetUInt32(new IntPtr(p + 0x018)); // 0x18 BitOffset                   ( ModelPrimitiveType uint uint uint UInt32 )
            value.SizeInBits                                = GetUInt32(new IntPtr(p + 0x01C)); // 0x1C SizeInBits                  ( ModelPrimitiveType uint uint uint UInt32 )

            return value;
        }
    }
}
