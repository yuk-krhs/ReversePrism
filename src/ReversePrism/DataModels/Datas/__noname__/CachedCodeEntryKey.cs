using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Options                                  00018663F0B0 ModelEnumType RegexOptions RegexOptions RegexOptions Int32
    // 018 CultureKey                               000186672F10 ModelPrimitiveType string string string String
    // 020 Pattern                                  000186672F10 ModelPrimitiveType string string string String
    public partial class CachedCodeEntryKey
    {
        public RegexOptions                             Options                                 { get; set; }
        public string                                   CultureKey                              { get; set; }
        public string                                   Pattern                                 { get; set; }

        public static CachedCodeEntryKey? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CachedCodeEntryKey();

            value.Options                                   = (RegexOptions)GetInt32(new IntPtr(p + 0x010)); // 0270033F5158 0x10 Options                     ( 00018663F0B0 ModelEnumType RegexOptions RegexOptions RegexOptions Int32 )
            value.CultureKey                                = GetString(new IntPtr(p + 0x018)); // 0270033F5178 0x18 CultureKey                  ( 000186672F10 ModelPrimitiveType string string string String )
            value.Pattern                                   = GetString(new IntPtr(p + 0x020)); // 0270033F5198 0x20 Pattern                     ( 000186672F10 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
