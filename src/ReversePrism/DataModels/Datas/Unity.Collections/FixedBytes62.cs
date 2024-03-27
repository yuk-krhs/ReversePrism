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
    // 040 Byte0048                                 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 041 Byte0049                                 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 042 Byte0050                                 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 043 Byte0051                                 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 044 Byte0052                                 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 045 Byte0053                                 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 046 Byte0054                                 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 047 Byte0055                                 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 048 Byte0056                                 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 049 Byte0057                                 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 04A Byte0058                                 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 04B Byte0059                                 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 04C Byte0060                                 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 04D Byte0061                                 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    public partial class FixedBytes62
    {
        public FixedBytes16                             Offset0000                              { get; set; }
        public FixedBytes16                             Offset0016                              { get; set; }
        public FixedBytes16                             Offset0032                              { get; set; }
        public sbyte                                    Byte0048                                { get; set; }
        public sbyte                                    Byte0049                                { get; set; }
        public sbyte                                    Byte0050                                { get; set; }
        public sbyte                                    Byte0051                                { get; set; }
        public sbyte                                    Byte0052                                { get; set; }
        public sbyte                                    Byte0053                                { get; set; }
        public sbyte                                    Byte0054                                { get; set; }
        public sbyte                                    Byte0055                                { get; set; }
        public sbyte                                    Byte0056                                { get; set; }
        public sbyte                                    Byte0057                                { get; set; }
        public sbyte                                    Byte0058                                { get; set; }
        public sbyte                                    Byte0059                                { get; set; }
        public sbyte                                    Byte0060                                { get; set; }
        public sbyte                                    Byte0061                                { get; set; }

        public static FixedBytes62? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FixedBytes62();

            value.Offset0000                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x010)); // 0270D98A8390 0x10 Offset0000                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset0016                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x020)); // 0270D98A83B0 0x20 Offset0016                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset0032                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x030)); // 0270D98A83D0 0x30 Offset0032                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Byte0048                                  = GetSByte(new IntPtr(p + 0x040)); // 0270D98A83F0 0x40 Byte0048                    ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte0049                                  = GetSByte(new IntPtr(p + 0x041)); // 0270D98A8410 0x41 Byte0049                    ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte0050                                  = GetSByte(new IntPtr(p + 0x042)); // 0270D98A8430 0x42 Byte0050                    ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte0051                                  = GetSByte(new IntPtr(p + 0x043)); // 0270D98A8450 0x43 Byte0051                    ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte0052                                  = GetSByte(new IntPtr(p + 0x044)); // 0270D98A8470 0x44 Byte0052                    ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte0053                                  = GetSByte(new IntPtr(p + 0x045)); // 0270D98A8490 0x45 Byte0053                    ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte0054                                  = GetSByte(new IntPtr(p + 0x046)); // 0270D98A84B0 0x46 Byte0054                    ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte0055                                  = GetSByte(new IntPtr(p + 0x047)); // 0270D98A84D0 0x47 Byte0055                    ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte0056                                  = GetSByte(new IntPtr(p + 0x048)); // 0270D98A84F0 0x48 Byte0056                    ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte0057                                  = GetSByte(new IntPtr(p + 0x049)); // 0270D98A8510 0x49 Byte0057                    ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte0058                                  = GetSByte(new IntPtr(p + 0x04A)); // 0270D98A8530 0x4A Byte0058                    ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte0059                                  = GetSByte(new IntPtr(p + 0x04B)); // 0270D98A8550 0x4B Byte0059                    ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte0060                                  = GetSByte(new IntPtr(p + 0x04C)); // 0270D98A8570 0x4C Byte0060                    ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte0061                                  = GetSByte(new IntPtr(p + 0x04D)); // 0270D98A8590 0x4D Byte0061                    ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )

            return value;
        }
    }
}
