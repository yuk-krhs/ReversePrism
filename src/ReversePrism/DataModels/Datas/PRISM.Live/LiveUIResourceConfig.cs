using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 MusicRankIconSprites                     000185CA4898 ModelClassListType Sprite[] Sprite[] List<Sprite> Pointer
    // 020 LiveResultMusicRankIconSprites           000185CA4898 ModelClassListType Sprite[] Sprite[] List<Sprite> Pointer
    // 028 UnitColors                               000185B75890 ModelEnumListType Color[] Color[] List<Color> Pointer
    public partial class LiveUIResourceConfig
    {
        public List<Sprite>?                            MusicRankIconSprites                    { get; set; }
        public List<Sprite>?                            LiveResultMusicRankIconSprites          { get; set; }
        public List<Color>?                             UnitColors                              { get; set; }

        public static LiveUIResourceConfig? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveUIResourceConfig();

            value.MusicRankIconSprites                      = GetObjectList<Sprite>(new IntPtr(p + 0x018), ReversePrism.DataModels.Sprite.FromPointer); // 0270D510ED38 0x18 MusicRankIconSprites        ( 000185CA4898 ModelClassListType Sprite[] Sprite[] List<Sprite> Pointer )
            value.LiveResultMusicRankIconSprites            = GetObjectList<Sprite>(new IntPtr(p + 0x020), ReversePrism.DataModels.Sprite.FromPointer); // 0270D510ED58 0x20 LiveResultMusicRankIconSprites ( 000185CA4898 ModelClassListType Sprite[] Sprite[] List<Sprite> Pointer )
            value.UnitColors                                = GetEnumList<Color>(new IntPtr(p + 0x028)); // 0270D510ED78 0x28 UnitColors                  ( 000185B75890 ModelEnumListType Color[] Color[] List<Color> Pointer )

            return value;
        }
    }
}
