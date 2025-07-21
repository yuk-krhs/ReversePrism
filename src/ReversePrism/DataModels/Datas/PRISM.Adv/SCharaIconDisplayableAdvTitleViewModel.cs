using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 BaseViewModel                            ModelClassType AdvTitleViewModel AdvTitleViewModel AdvTitleViewModel Pointer
    // 018 CharacterId                              ModelPrimitiveType int int int Int32
    // 01C Rarity                                   ModelPrimitiveType int int int Int32
    // 020 CardId                                   ModelPrimitiveType int int int Int32
    public partial class SCharaIconDisplayableAdvTitleViewModel : DataModel
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
            var value   = new SCharaIconDisplayableAdvTitleViewModel() { Pointer= p0 };

            value.BaseViewModel                             = GetObject<AdvTitleViewModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.AdvTitleViewModel.FromPointer); // 0x10 BaseViewModel               ( ModelClassType AdvTitleViewModel AdvTitleViewModel AdvTitleViewModel Pointer )
            value.CharacterId                               = GetInt32(new IntPtr(p + 0x018)); // 0x18 CharacterId                 ( ModelPrimitiveType int int int Int32 )
            value.Rarity                                    = GetInt32(new IntPtr(p + 0x01C)); // 0x1C Rarity                      ( ModelPrimitiveType int int int Int32 )
            value.CardId                                    = GetInt32(new IntPtr(p + 0x020)); // 0x20 CardId                      ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
