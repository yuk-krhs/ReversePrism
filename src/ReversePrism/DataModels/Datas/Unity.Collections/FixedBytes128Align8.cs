using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Offset0000                               00018659C1C0 ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 020 Offset0016                               00018659C1C0 ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 030 Offset0032                               00018659C1C0 ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 040 Offset0048                               00018659C1C0 ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 050 Offset0064                               00018659C1C0 ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 060 Offset0080                               00018659C1C0 ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 070 Offset0096                               00018659C1C0 ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 080 Offset0112                               00018659C1C0 ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    public partial class FixedBytes128Align8
    {
        public FixedBytes16Align8                       Offset0000                              { get; set; }
        public FixedBytes16Align8                       Offset0016                              { get; set; }
        public FixedBytes16Align8                       Offset0032                              { get; set; }
        public FixedBytes16Align8                       Offset0048                              { get; set; }
        public FixedBytes16Align8                       Offset0064                              { get; set; }
        public FixedBytes16Align8                       Offset0080                              { get; set; }
        public FixedBytes16Align8                       Offset0096                              { get; set; }
        public FixedBytes16Align8                       Offset0112                              { get; set; }

        public static FixedBytes128Align8? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FixedBytes128Align8();

            value.Offset0000                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x010)); // 0270035606F8 0x10 Offset0000                  ( 00018659C1C0 ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset0016                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x020)); // 027003560718 0x20 Offset0016                  ( 00018659C1C0 ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset0032                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x030)); // 027003560738 0x30 Offset0032                  ( 00018659C1C0 ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset0048                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x040)); // 027003560758 0x40 Offset0048                  ( 00018659C1C0 ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset0064                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x050)); // 027003560778 0x50 Offset0064                  ( 00018659C1C0 ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset0080                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x060)); // 027003560798 0x60 Offset0080                  ( 00018659C1C0 ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset0096                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x070)); // 0270035607B8 0x70 Offset0096                  ( 00018659C1C0 ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset0112                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x080)); // 0270035607D8 0x80 Offset0112                  ( 00018659C1C0 ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )

            return value;
        }
    }
}
