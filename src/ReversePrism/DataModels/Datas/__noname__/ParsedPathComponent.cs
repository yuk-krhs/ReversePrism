using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Layout                                 0001865DAC30 ModelEnumType Substring Substring Substring Int32
    // 020 m_Usages                                 InlinedArray`1<Substring> IL2CPP_TYPE_GENERICINST
    // 040 M_Name                                   0001865DAC30 ModelEnumType Substring Substring Substring Int32
    // 050 M_DisplayName                            0001865DAC30 ModelEnumType Substring Substring Substring Int32
    public partial class ParsedPathComponent
    {
        public Substring                                M_Layout                                { get; set; }
        public Substring                                M_Name                                  { get; set; }
        public Substring                                M_DisplayName                           { get; set; }

        public static ParsedPathComponent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ParsedPathComponent();

            value.M_Layout                                  = (Substring)GetInt32(new IntPtr(p + 0x010)); // 0270D76D66B0 0x10 M_Layout                    ( 0001865DAC30 ModelEnumType Substring Substring Substring Int32 )
            value.M_Name                                    = (Substring)GetInt32(new IntPtr(p + 0x040)); // 0270D76D66F0 0x40 M_Name                      ( 0001865DAC30 ModelEnumType Substring Substring Substring Int32 )
            value.M_DisplayName                             = (Substring)GetInt32(new IntPtr(p + 0x050)); // 0270D76D6710 0x50 M_DisplayName               ( 0001865DAC30 ModelEnumType Substring Substring Substring Int32 )

            return value;
        }
    }
}
