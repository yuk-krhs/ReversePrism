using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 graphicsFormatSupport                    Dictionary`2<GraphicsFormat, Dictionary`2<FormatUsage, bool>> IL2CPP_TYPE_GENERICINST
    // 008 OpaqueFilteringSettings                  FilteringSettings[] IL2CPP_TYPE_SZARRAY
    // 010 BeforeCharacterFilteringSettings         ModelEnumListType FilteringSettings[] FilteringSettings[] List<FilteringSettings> Pointer
    // 018 CharacterFilteringSettings               ModelEnumListType FilteringSettings[] FilteringSettings[] List<FilteringSettings> Pointer
    // 020 AfterCharacterFilteringSettings          ModelEnumListType FilteringSettings[] FilteringSettings[] List<FilteringSettings> Pointer
    // 028 TransparentFilteringSettings             ModelEnumType FilteringSettings FilteringSettings FilteringSettings Int32
    // 040 BloomFilteringSettings                   ModelEnumListType FilteringSettings[] FilteringSettings[] List<FilteringSettings> Pointer
    public partial class RenderingUtils : DataModel
    {
        public List<FilteringSettings>?                 BeforeCharacterFilteringSettings        { get; set; }
        public List<FilteringSettings>?                 CharacterFilteringSettings              { get; set; }
        public List<FilteringSettings>?                 AfterCharacterFilteringSettings         { get; set; }
        public FilteringSettings                        TransparentFilteringSettings            { get; set; }
        public List<FilteringSettings>?                 BloomFilteringSettings                  { get; set; }

        public static RenderingUtils? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RenderingUtils() { Pointer= p0 };

            value.BeforeCharacterFilteringSettings          = GetEnumList<FilteringSettings>(new IntPtr(p + 0x010)); // 0x10 BeforeCharacterFilteringSettings ( ModelEnumListType FilteringSettings[] FilteringSettings[] List<FilteringSettings> Pointer )
            value.CharacterFilteringSettings                = GetEnumList<FilteringSettings>(new IntPtr(p + 0x018)); // 0x18 CharacterFilteringSettings  ( ModelEnumListType FilteringSettings[] FilteringSettings[] List<FilteringSettings> Pointer )
            value.AfterCharacterFilteringSettings           = GetEnumList<FilteringSettings>(new IntPtr(p + 0x020)); // 0x20 AfterCharacterFilteringSettings ( ModelEnumListType FilteringSettings[] FilteringSettings[] List<FilteringSettings> Pointer )
            value.TransparentFilteringSettings              = (FilteringSettings)GetInt32(new IntPtr(p + 0x028)); // 0x28 TransparentFilteringSettings ( ModelEnumType FilteringSettings FilteringSettings FilteringSettings Int32 )
            value.BloomFilteringSettings                    = GetEnumList<FilteringSettings>(new IntPtr(p + 0x040)); // 0x40 BloomFilteringSettings      ( ModelEnumListType FilteringSettings[] FilteringSettings[] List<FilteringSettings> Pointer )

            return value;
        }
    }
}
