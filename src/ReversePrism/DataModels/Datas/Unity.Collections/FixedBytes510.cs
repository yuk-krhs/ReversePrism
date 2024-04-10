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
    public partial class FixedBytes510 : DataModel
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
            var value   = new FixedBytes510() { Pointer= p0 };

            value.Offset0000                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x010)); // 024669912A78 0x10 Offset0000                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset0016                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x020)); // 024669912A98 0x20 Offset0016                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset0032                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x030)); // 024669912AB8 0x30 Offset0032                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset0048                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x040)); // 024669912AD8 0x40 Offset0048                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset0064                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x050)); // 024669912AF8 0x50 Offset0064                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset0080                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x060)); // 024669912B18 0x60 Offset0080                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset0096                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x070)); // 024669912B38 0x70 Offset0096                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset0112                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x080)); // 024669912B58 0x80 Offset0112                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset0128                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x090)); // 024669912B78 0x90 Offset0128                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset0144                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x0A0)); // 024669912B98 0xA0 Offset0144                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset0160                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x0B0)); // 024669912BB8 0xB0 Offset0160                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset0176                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x0C0)); // 024669912BD8 0xC0 Offset0176                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset0192                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x0D0)); // 024669912BF8 0xD0 Offset0192                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset0208                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x0E0)); // 024669912C18 0xE0 Offset0208                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset0224                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x0F0)); // 024669912C38 0xF0 Offset0224                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset0240                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x100)); // 024669912C58 0x100 Offset0240                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset0256                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x110)); // 024669912C78 0x110 Offset0256                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset0272                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x120)); // 024669912C98 0x120 Offset0272                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset0288                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x130)); // 024669912CB8 0x130 Offset0288                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset0304                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x140)); // 024669912CD8 0x140 Offset0304                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset0320                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x150)); // 024669912CF8 0x150 Offset0320                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset0336                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x160)); // 024669912D18 0x160 Offset0336                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset0352                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x170)); // 024669912D38 0x170 Offset0352                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset0368                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x180)); // 024669912D58 0x180 Offset0368                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset0384                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x190)); // 024669912D78 0x190 Offset0384                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset0400                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x1A0)); // 024669912D98 0x1A0 Offset0400                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset0416                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x1B0)); // 024669912DB8 0x1B0 Offset0416                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset0432                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x1C0)); // 024669912DD8 0x1C0 Offset0432                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset0448                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x1D0)); // 024669912DF8 0x1D0 Offset0448                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset0464                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x1E0)); // 024669912E18 0x1E0 Offset0464                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset0480                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x1F0)); // 024669912E38 0x1F0 Offset0480                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Byte0496                                  = GetSByte(new IntPtr(p + 0x200)); // 024669912E58 0x200 Byte0496                    ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte0497                                  = GetSByte(new IntPtr(p + 0x201)); // 024669912E78 0x201 Byte0497                    ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte0498                                  = GetSByte(new IntPtr(p + 0x202)); // 024669912E98 0x202 Byte0498                    ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte0499                                  = GetSByte(new IntPtr(p + 0x203)); // 024669912EB8 0x203 Byte0499                    ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte0500                                  = GetSByte(new IntPtr(p + 0x204)); // 024669912ED8 0x204 Byte0500                    ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte0501                                  = GetSByte(new IntPtr(p + 0x205)); // 024669912EF8 0x205 Byte0501                    ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte0502                                  = GetSByte(new IntPtr(p + 0x206)); // 024669912F18 0x206 Byte0502                    ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte0503                                  = GetSByte(new IntPtr(p + 0x207)); // 024669912F38 0x207 Byte0503                    ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte0504                                  = GetSByte(new IntPtr(p + 0x208)); // 024669912F58 0x208 Byte0504                    ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte0505                                  = GetSByte(new IntPtr(p + 0x209)); // 024669912F78 0x209 Byte0505                    ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte0506                                  = GetSByte(new IntPtr(p + 0x20A)); // 024669912F98 0x20A Byte0506                    ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte0507                                  = GetSByte(new IntPtr(p + 0x20B)); // 024669912FB8 0x20B Byte0507                    ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte0508                                  = GetSByte(new IntPtr(p + 0x20C)); // 024669912FD8 0x20C Byte0508                    ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte0509                                  = GetSByte(new IntPtr(p + 0x20D)); // 024669912FF8 0x20D Byte0509                    ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )

            return value;
        }
    }
}
