using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Offset0000                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 020 Offset0016                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 030 Offset0032                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 040 Offset0048                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 050 Offset0064                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 060 Offset0080                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 070 Offset0096                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 080 Offset0112                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 090 Offset0128                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 0A0 Offset0144                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 0B0 Offset0160                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 0C0 Offset0176                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 0D0 Offset0192                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 0E0 Offset0208                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 0F0 Offset0224                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 100 Offset0240                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 110 Offset0256                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 120 Offset0272                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 130 Offset0288                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 140 Offset0304                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 150 Offset0320                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 160 Offset0336                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 170 Offset0352                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 180 Offset0368                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 190 Offset0384                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 1A0 Offset0400                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 1B0 Offset0416                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 1C0 Offset0432                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 1D0 Offset0448                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 1E0 Offset0464                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 1F0 Offset0480                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 200 Byte0496                                 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 201 Byte0497                                 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 202 Byte0498                                 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 203 Byte0499                                 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 204 Byte0500                                 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 205 Byte0501                                 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 206 Byte0502                                 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 207 Byte0503                                 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 208 Byte0504                                 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 209 Byte0505                                 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 20A Byte0506                                 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 20B Byte0507                                 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 20C Byte0508                                 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 20D Byte0509                                 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    public partial class FixedBytes510
    {
        public FixedBytes16                             Offset0000                              { get; set; }
        public FixedBytes16                             Offset0016                              { get; set; }
        public FixedBytes16                             Offset0032                              { get; set; }
        public FixedBytes16                             Offset0048                              { get; set; }
        public FixedBytes16                             Offset0064                              { get; set; }
        public FixedBytes16                             Offset0080                              { get; set; }
        public FixedBytes16                             Offset0096                              { get; set; }
        public FixedBytes16                             Offset0112                              { get; set; }
        public FixedBytes16                             Offset0128                              { get; set; }
        public FixedBytes16                             Offset0144                              { get; set; }
        public FixedBytes16                             Offset0160                              { get; set; }
        public FixedBytes16                             Offset0176                              { get; set; }
        public FixedBytes16                             Offset0192                              { get; set; }
        public FixedBytes16                             Offset0208                              { get; set; }
        public FixedBytes16                             Offset0224                              { get; set; }
        public FixedBytes16                             Offset0240                              { get; set; }
        public FixedBytes16                             Offset0256                              { get; set; }
        public FixedBytes16                             Offset0272                              { get; set; }
        public FixedBytes16                             Offset0288                              { get; set; }
        public FixedBytes16                             Offset0304                              { get; set; }
        public FixedBytes16                             Offset0320                              { get; set; }
        public FixedBytes16                             Offset0336                              { get; set; }
        public FixedBytes16                             Offset0352                              { get; set; }
        public FixedBytes16                             Offset0368                              { get; set; }
        public FixedBytes16                             Offset0384                              { get; set; }
        public FixedBytes16                             Offset0400                              { get; set; }
        public FixedBytes16                             Offset0416                              { get; set; }
        public FixedBytes16                             Offset0432                              { get; set; }
        public FixedBytes16                             Offset0448                              { get; set; }
        public FixedBytes16                             Offset0464                              { get; set; }
        public FixedBytes16                             Offset0480                              { get; set; }
        public sbyte                                    Byte0496                                { get; set; }
        public sbyte                                    Byte0497                                { get; set; }
        public sbyte                                    Byte0498                                { get; set; }
        public sbyte                                    Byte0499                                { get; set; }
        public sbyte                                    Byte0500                                { get; set; }
        public sbyte                                    Byte0501                                { get; set; }
        public sbyte                                    Byte0502                                { get; set; }
        public sbyte                                    Byte0503                                { get; set; }
        public sbyte                                    Byte0504                                { get; set; }
        public sbyte                                    Byte0505                                { get; set; }
        public sbyte                                    Byte0506                                { get; set; }
        public sbyte                                    Byte0507                                { get; set; }
        public sbyte                                    Byte0508                                { get; set; }
        public sbyte                                    Byte0509                                { get; set; }

        public static FixedBytes510? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FixedBytes510();

            value.Offset0000                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x010)); // 0270D98AC268 0x10 Offset0000                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset0016                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x020)); // 0270D98AC288 0x20 Offset0016                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset0032                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x030)); // 0270D98AC2A8 0x30 Offset0032                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset0048                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x040)); // 0270D98AC2C8 0x40 Offset0048                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset0064                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x050)); // 0270D98AC2E8 0x50 Offset0064                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset0080                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x060)); // 0270D98AC308 0x60 Offset0080                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset0096                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x070)); // 0270D98AC328 0x70 Offset0096                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset0112                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x080)); // 0270D98AC348 0x80 Offset0112                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset0128                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x090)); // 0270D98AC368 0x90 Offset0128                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset0144                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x0A0)); // 0270D98AC388 0xA0 Offset0144                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset0160                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x0B0)); // 0270D98AC3A8 0xB0 Offset0160                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset0176                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x0C0)); // 0270D98AC3C8 0xC0 Offset0176                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset0192                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x0D0)); // 0270D98AC3E8 0xD0 Offset0192                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset0208                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x0E0)); // 0270D98AC408 0xE0 Offset0208                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset0224                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x0F0)); // 0270D98AC428 0xF0 Offset0224                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset0240                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x100)); // 0270D98AC448 0x100 Offset0240                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset0256                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x110)); // 0270D98AC468 0x110 Offset0256                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset0272                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x120)); // 0270D98AC488 0x120 Offset0272                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset0288                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x130)); // 0270D98AC4A8 0x130 Offset0288                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset0304                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x140)); // 0270D98AC4C8 0x140 Offset0304                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset0320                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x150)); // 0270D98AC4E8 0x150 Offset0320                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset0336                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x160)); // 0270D98AC508 0x160 Offset0336                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset0352                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x170)); // 0270D98AC528 0x170 Offset0352                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset0368                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x180)); // 0270D98AC548 0x180 Offset0368                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset0384                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x190)); // 0270D98AC568 0x190 Offset0384                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset0400                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x1A0)); // 0270D98AC588 0x1A0 Offset0400                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset0416                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x1B0)); // 0270D98AC5A8 0x1B0 Offset0416                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset0432                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x1C0)); // 0270D98AC5C8 0x1C0 Offset0432                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset0448                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x1D0)); // 0270D98AC5E8 0x1D0 Offset0448                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset0464                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x1E0)); // 0270D98AC608 0x1E0 Offset0464                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset0480                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x1F0)); // 0270D98AC628 0x1F0 Offset0480                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Byte0496                                  = GetSByte(new IntPtr(p + 0x200)); // 0270D98AC648 0x200 Byte0496                    ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte0497                                  = GetSByte(new IntPtr(p + 0x201)); // 0270D98AC668 0x201 Byte0497                    ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte0498                                  = GetSByte(new IntPtr(p + 0x202)); // 0270D98AC688 0x202 Byte0498                    ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte0499                                  = GetSByte(new IntPtr(p + 0x203)); // 0270D98AC6A8 0x203 Byte0499                    ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte0500                                  = GetSByte(new IntPtr(p + 0x204)); // 0270D98AC6C8 0x204 Byte0500                    ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte0501                                  = GetSByte(new IntPtr(p + 0x205)); // 0270D98AC6E8 0x205 Byte0501                    ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte0502                                  = GetSByte(new IntPtr(p + 0x206)); // 0270D98AC708 0x206 Byte0502                    ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte0503                                  = GetSByte(new IntPtr(p + 0x207)); // 0270D98AC728 0x207 Byte0503                    ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte0504                                  = GetSByte(new IntPtr(p + 0x208)); // 0270D98AC748 0x208 Byte0504                    ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte0505                                  = GetSByte(new IntPtr(p + 0x209)); // 0270D98AC768 0x209 Byte0505                    ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte0506                                  = GetSByte(new IntPtr(p + 0x20A)); // 0270D98AC788 0x20A Byte0506                    ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte0507                                  = GetSByte(new IntPtr(p + 0x20B)); // 0270D98AC7A8 0x20B Byte0507                    ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte0508                                  = GetSByte(new IntPtr(p + 0x20C)); // 0270D98AC7C8 0x20C Byte0508                    ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte0509                                  = GetSByte(new IntPtr(p + 0x20D)); // 0270D98AC7E8 0x20D Byte0509                    ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )

            return value;
        }
    }
}
