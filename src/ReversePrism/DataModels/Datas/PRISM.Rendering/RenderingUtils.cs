using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 renderTextureFormatSupport               Dictionary`2<RenderTextureFormat, bool> IL2CPP_TYPE_GENERICINST
    // 008 graphicsFormatSupport                    Dictionary`2<GraphicsFormat, Dictionary`2<FormatUsage, bool>> IL2CPP_TYPE_GENERICINST
    // 010 renderTextureRandomWriteSupport          Dictionary`2<RenderTextureFormat, bool> IL2CPP_TYPE_GENERICINST
    // 018 OpaqueFilteringSettings                  000185B7F720 ModelEnumListType FilteringSettings[] FilteringSettings[] List<FilteringSettings> Pointer
    // 020 BeforeCharacterFilteringSettings         000185B7F720 ModelEnumListType FilteringSettings[] FilteringSettings[] List<FilteringSettings> Pointer
    // 028 CharacterFilteringSettings               000185B7F720 ModelEnumListType FilteringSettings[] FilteringSettings[] List<FilteringSettings> Pointer
    // 030 AfterCharacterFilteringSettings          000185B7F720 ModelEnumListType FilteringSettings[] FilteringSettings[] List<FilteringSettings> Pointer
    public partial class RenderingUtils
    {
        public List<FilteringSettings>?                 OpaqueFilteringSettings                 { get; set; }
        public List<FilteringSettings>?                 BeforeCharacterFilteringSettings        { get; set; }
        public List<FilteringSettings>?                 CharacterFilteringSettings              { get; set; }
        public List<FilteringSettings>?                 AfterCharacterFilteringSettings         { get; set; }

        public static RenderingUtils? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RenderingUtils();

            value.OpaqueFilteringSettings                   = GetEnumList<FilteringSettings>(new IntPtr(p + 0x018)); // 0270D0AC5D18 0x18 OpaqueFilteringSettings     ( 000185B7F720 ModelEnumListType FilteringSettings[] FilteringSettings[] List<FilteringSettings> Pointer )
            value.BeforeCharacterFilteringSettings          = GetEnumList<FilteringSettings>(new IntPtr(p + 0x020)); // 0270D0AC5D38 0x20 BeforeCharacterFilteringSettings ( 000185B7F720 ModelEnumListType FilteringSettings[] FilteringSettings[] List<FilteringSettings> Pointer )
            value.CharacterFilteringSettings                = GetEnumList<FilteringSettings>(new IntPtr(p + 0x028)); // 0270D0AC5D58 0x28 CharacterFilteringSettings  ( 000185B7F720 ModelEnumListType FilteringSettings[] FilteringSettings[] List<FilteringSettings> Pointer )
            value.AfterCharacterFilteringSettings           = GetEnumList<FilteringSettings>(new IntPtr(p + 0x030)); // 0270D0AC5D78 0x30 AfterCharacterFilteringSettings ( 000185B7F720 ModelEnumListType FilteringSettings[] FilteringSettings[] List<FilteringSettings> Pointer )

            return value;
        }
    }
}
