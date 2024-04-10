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
    public partial class FixedBytes62 : DataModel
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
            var value   = new FixedBytes62() { Pointer= p0 };

            value.Offset0000                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x010)); // 02466990DE80 0x10 Offset0000                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset0016                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x020)); // 02466990DEA0 0x20 Offset0016                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset0032                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x030)); // 02466990DEC0 0x30 Offset0032                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Byte0048                                  = GetSByte(new IntPtr(p + 0x040)); // 02466990DEE0 0x40 Byte0048                    ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte0049                                  = GetSByte(new IntPtr(p + 0x041)); // 02466990DF00 0x41 Byte0049                    ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte0050                                  = GetSByte(new IntPtr(p + 0x042)); // 02466990DF20 0x42 Byte0050                    ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte0051                                  = GetSByte(new IntPtr(p + 0x043)); // 02466990DF40 0x43 Byte0051                    ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte0052                                  = GetSByte(new IntPtr(p + 0x044)); // 02466990DF60 0x44 Byte0052                    ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte0053                                  = GetSByte(new IntPtr(p + 0x045)); // 02466990DF80 0x45 Byte0053                    ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte0054                                  = GetSByte(new IntPtr(p + 0x046)); // 02466990DFA0 0x46 Byte0054                    ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte0055                                  = GetSByte(new IntPtr(p + 0x047)); // 02466990DFC0 0x47 Byte0055                    ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte0056                                  = GetSByte(new IntPtr(p + 0x048)); // 02466990DFE0 0x48 Byte0056                    ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte0057                                  = GetSByte(new IntPtr(p + 0x049)); // 02466990E000 0x49 Byte0057                    ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte0058                                  = GetSByte(new IntPtr(p + 0x04A)); // 02466990E020 0x4A Byte0058                    ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte0059                                  = GetSByte(new IntPtr(p + 0x04B)); // 02466990E040 0x4B Byte0059                    ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte0060                                  = GetSByte(new IntPtr(p + 0x04C)); // 02466990E060 0x4C Byte0060                    ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte0061                                  = GetSByte(new IntPtr(p + 0x04D)); // 02466990E080 0x4D Byte0061                    ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )

            return value;
        }
    }
}
