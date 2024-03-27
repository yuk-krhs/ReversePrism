using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 kSize                                    int IL2CPP_TYPE_I4
    // 000 ExpectedReplyInputReportId               sbyte IL2CPP_TYPE_U1
    // 010 ReportType                               00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 011 CommandId                                00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    public partial class SwitchMagicOutputReport
    {
        public sbyte                                    ReportType                              { get; set; }
        public sbyte                                    CommandId                               { get; set; }

        public static SwitchMagicOutputReport? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SwitchMagicOutputReport();

            value.ReportType                                = GetSByte(new IntPtr(p + 0x010)); // 0270D77BBBB0 0x10 ReportType                  ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.CommandId                                 = GetSByte(new IntPtr(p + 0x011)); // 0270D77BBBD0 0x11 CommandId                   ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )

            return value;
        }
    }
}
