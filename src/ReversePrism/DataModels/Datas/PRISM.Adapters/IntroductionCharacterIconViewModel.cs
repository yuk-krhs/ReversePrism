using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Master                                   00018661C140 ModelClassType MstCharacterInfo MstCharacterInfo MstCharacterInfo Pointer
    // 018 CharaId                                  0001865F4260 ModelPrimitiveType int int int Int32
    // 020 IconViewModel                            000186599E70 ModelClassType CharacterBaseIconViewModel CharacterBaseIconViewModel CharacterBaseIconViewModel Pointer
    public partial class IntroductionCharacterIconViewModel
    {
        public MstCharacterInfo?                        Master                                  { get; set; }
        public int                                      CharaId                                 { get; set; }
        public CharacterBaseIconViewModel?              IconViewModel                           { get; set; }

        public static IntroductionCharacterIconViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IntroductionCharacterIconViewModel();

            value.Master                                    = GetObject<MstCharacterInfo>(new IntPtr(p + 0x010), ReversePrism.DataModels.MstCharacterInfo.FromPointer); // 0270D63AC4F0 0x10 Master                      ( 00018661C140 ModelClassType MstCharacterInfo MstCharacterInfo MstCharacterInfo Pointer )
            value.CharaId                                   = GetInt32(new IntPtr(p + 0x018)); // 0270D63AC510 0x18 CharaId                     ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.IconViewModel                             = GetObject<CharacterBaseIconViewModel>(new IntPtr(p + 0x020), ReversePrism.DataModels.CharacterBaseIconViewModel.FromPointer); // 0270D63AC530 0x20 IconViewModel               ( 000186599E70 ModelClassType CharacterBaseIconViewModel CharacterBaseIconViewModel CharacterBaseIconViewModel Pointer )

            return value;
        }
    }
}
