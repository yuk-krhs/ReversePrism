using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 ProfileTag                               string IL2CPP_TYPE_STRING
    // 000 ProfileSampler                           ProfileSampler IL2CPP_TYPE_CLASS
    // 010 DrawPassNames                            000185D08628 ModelEnumListType List`1<ShaderTagId> List`1<ShaderTagId> List<ShaderTagId> Pointer
    // 018 FilteringSettings                        000185B7F650 ModelEnumListType FilteringSettings[] FilteringSettings[] List<FilteringSettings> Pointer
    public partial class DrawBloomPass
    {
        public List<ShaderTagId>?                       DrawPassNames                           { get; set; }
        public List<FilteringSettings>?                 FilteringSettings                       { get; set; }

        public static DrawBloomPass? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DrawBloomPass();

            value.DrawPassNames                             = GetEnumList<ShaderTagId>(new IntPtr(p + 0x010)); // 0270D0AC0280 0x10 DrawPassNames               ( 000185D08628 ModelEnumListType List`1<ShaderTagId> List`1<ShaderTagId> List<ShaderTagId> Pointer )
            value.FilteringSettings                         = GetEnumList<FilteringSettings>(new IntPtr(p + 0x018)); // 0270D0AC02A0 0x18 FilteringSettings           ( 000185B7F650 ModelEnumListType FilteringSettings[] FilteringSettings[] List<FilteringSettings> Pointer )

            return value;
        }
    }
}
