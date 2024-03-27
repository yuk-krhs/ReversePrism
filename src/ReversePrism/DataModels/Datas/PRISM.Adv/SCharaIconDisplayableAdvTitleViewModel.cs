using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 BaseViewModel                            0001866985C0 ModelClassType AdvTitleViewModel AdvTitleViewModel AdvTitleViewModel Pointer
    // 018 CharacterId                              0001865F4260 ModelPrimitiveType int int int Int32
    // 01C Rarity                                   0001865F4260 ModelPrimitiveType int int int Int32
    // 020 CardId                                   0001865F4260 ModelPrimitiveType int int int Int32
    public partial class SCharaIconDisplayableAdvTitleViewModel
    {
        public AdvTitleViewModel?                       BaseViewModel                           { get; set; }
        public int                                      CharacterId                             { get; set; }
        public int                                      Rarity                                  { get; set; }
        public int                                      CardId                                  { get; set; }

        public static SCharaIconDisplayableAdvTitleViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SCharaIconDisplayableAdvTitleViewModel();

            value.BaseViewModel                             = GetObject<AdvTitleViewModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.AdvTitleViewModel.FromPointer); // 0270D5DD3348 0x10 BaseViewModel               ( 0001866985C0 ModelClassType AdvTitleViewModel AdvTitleViewModel AdvTitleViewModel Pointer )
            value.CharacterId                               = GetInt32(new IntPtr(p + 0x018)); // 0270D5DD3368 0x18 CharacterId                 ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.Rarity                                    = GetInt32(new IntPtr(p + 0x01C)); // 0270D5DD3388 0x1C Rarity                      ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.CardId                                    = GetInt32(new IntPtr(p + 0x020)); // 0270D5DD33A8 0x20 CardId                      ( 0001865F4260 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
