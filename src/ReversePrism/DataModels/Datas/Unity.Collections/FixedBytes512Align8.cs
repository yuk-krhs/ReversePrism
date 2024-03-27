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
    // 090 Offset0128                               00018659C1C0 ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 0A0 Offset0144                               00018659C1C0 ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 0B0 Offset0160                               00018659C1C0 ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 0C0 Offset0176                               00018659C1C0 ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 0D0 Offset0192                               00018659C1C0 ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 0E0 Offset0208                               00018659C1C0 ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 0F0 Offset0224                               00018659C1C0 ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 100 Offset0240                               00018659C1C0 ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 110 Offset0256                               00018659C1C0 ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 120 Offset0272                               00018659C1C0 ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 130 Offset0288                               00018659C1C0 ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 140 Offset0304                               00018659C1C0 ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 150 Offset0320                               00018659C1C0 ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 160 Offset0336                               00018659C1C0 ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 170 Offset0352                               00018659C1C0 ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 180 Offset0368                               00018659C1C0 ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 190 Offset0384                               00018659C1C0 ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 1A0 Offset0400                               00018659C1C0 ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 1B0 Offset0416                               00018659C1C0 ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 1C0 Offset0432                               00018659C1C0 ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 1D0 Offset0448                               00018659C1C0 ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 1E0 Offset0464                               00018659C1C0 ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 1F0 Offset0480                               00018659C1C0 ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 200 Offset0496                               00018659C1C0 ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    public partial class FixedBytes512Align8
    {
        public FixedBytes16Align8                       Offset0000                              { get; set; }
        public FixedBytes16Align8                       Offset0016                              { get; set; }
        public FixedBytes16Align8                       Offset0032                              { get; set; }
        public FixedBytes16Align8                       Offset0048                              { get; set; }
        public FixedBytes16Align8                       Offset0064                              { get; set; }
        public FixedBytes16Align8                       Offset0080                              { get; set; }
        public FixedBytes16Align8                       Offset0096                              { get; set; }
        public FixedBytes16Align8                       Offset0112                              { get; set; }
        public FixedBytes16Align8                       Offset0128                              { get; set; }
        public FixedBytes16Align8                       Offset0144                              { get; set; }
        public FixedBytes16Align8                       Offset0160                              { get; set; }
        public FixedBytes16Align8                       Offset0176                              { get; set; }
        public FixedBytes16Align8                       Offset0192                              { get; set; }
        public FixedBytes16Align8                       Offset0208                              { get; set; }
        public FixedBytes16Align8                       Offset0224                              { get; set; }
        public FixedBytes16Align8                       Offset0240                              { get; set; }
        public FixedBytes16Align8                       Offset0256                              { get; set; }
        public FixedBytes16Align8                       Offset0272                              { get; set; }
        public FixedBytes16Align8                       Offset0288                              { get; set; }
        public FixedBytes16Align8                       Offset0304                              { get; set; }
        public FixedBytes16Align8                       Offset0320                              { get; set; }
        public FixedBytes16Align8                       Offset0336                              { get; set; }
        public FixedBytes16Align8                       Offset0352                              { get; set; }
        public FixedBytes16Align8                       Offset0368                              { get; set; }
        public FixedBytes16Align8                       Offset0384                              { get; set; }
        public FixedBytes16Align8                       Offset0400                              { get; set; }
        public FixedBytes16Align8                       Offset0416                              { get; set; }
        public FixedBytes16Align8                       Offset0432                              { get; set; }
        public FixedBytes16Align8                       Offset0448                              { get; set; }
        public FixedBytes16Align8                       Offset0464                              { get; set; }
        public FixedBytes16Align8                       Offset0480                              { get; set; }
        public FixedBytes16Align8                       Offset0496                              { get; set; }

        public static FixedBytes512Align8? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FixedBytes512Align8();

            value.Offset0000                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x010)); // 027003560C90 0x10 Offset0000                  ( 00018659C1C0 ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset0016                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x020)); // 027003560CB0 0x20 Offset0016                  ( 00018659C1C0 ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset0032                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x030)); // 027003560CD0 0x30 Offset0032                  ( 00018659C1C0 ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset0048                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x040)); // 027003560CF0 0x40 Offset0048                  ( 00018659C1C0 ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset0064                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x050)); // 027003560D10 0x50 Offset0064                  ( 00018659C1C0 ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset0080                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x060)); // 027003560D30 0x60 Offset0080                  ( 00018659C1C0 ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset0096                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x070)); // 027003560D50 0x70 Offset0096                  ( 00018659C1C0 ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset0112                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x080)); // 027003560D70 0x80 Offset0112                  ( 00018659C1C0 ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset0128                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x090)); // 027003560D90 0x90 Offset0128                  ( 00018659C1C0 ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset0144                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x0A0)); // 027003560DB0 0xA0 Offset0144                  ( 00018659C1C0 ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset0160                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x0B0)); // 027003560DD0 0xB0 Offset0160                  ( 00018659C1C0 ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset0176                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x0C0)); // 027003560DF0 0xC0 Offset0176                  ( 00018659C1C0 ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset0192                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x0D0)); // 027003560E10 0xD0 Offset0192                  ( 00018659C1C0 ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset0208                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x0E0)); // 027003560E30 0xE0 Offset0208                  ( 00018659C1C0 ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset0224                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x0F0)); // 027003560E50 0xF0 Offset0224                  ( 00018659C1C0 ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset0240                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x100)); // 027003560E70 0x100 Offset0240                  ( 00018659C1C0 ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset0256                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x110)); // 027003560E90 0x110 Offset0256                  ( 00018659C1C0 ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset0272                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x120)); // 027003560EB0 0x120 Offset0272                  ( 00018659C1C0 ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset0288                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x130)); // 027003560ED0 0x130 Offset0288                  ( 00018659C1C0 ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset0304                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x140)); // 027003560EF0 0x140 Offset0304                  ( 00018659C1C0 ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset0320                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x150)); // 027003560F10 0x150 Offset0320                  ( 00018659C1C0 ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset0336                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x160)); // 027003560F30 0x160 Offset0336                  ( 00018659C1C0 ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset0352                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x170)); // 027003560F50 0x170 Offset0352                  ( 00018659C1C0 ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset0368                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x180)); // 027003560F70 0x180 Offset0368                  ( 00018659C1C0 ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset0384                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x190)); // 027003560F90 0x190 Offset0384                  ( 00018659C1C0 ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset0400                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x1A0)); // 027003560FB0 0x1A0 Offset0400                  ( 00018659C1C0 ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset0416                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x1B0)); // 027003560FD0 0x1B0 Offset0416                  ( 00018659C1C0 ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset0432                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x1C0)); // 027003560FF0 0x1C0 Offset0432                  ( 00018659C1C0 ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset0448                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x1D0)); // 027003561010 0x1D0 Offset0448                  ( 00018659C1C0 ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset0464                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x1E0)); // 027003561030 0x1E0 Offset0464                  ( 00018659C1C0 ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset0480                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x1F0)); // 027003561050 0x1F0 Offset0480                  ( 00018659C1C0 ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset0496                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x200)); // 027003561070 0x200 Offset0496                  ( 00018659C1C0 ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )

            return value;
        }
    }
}
