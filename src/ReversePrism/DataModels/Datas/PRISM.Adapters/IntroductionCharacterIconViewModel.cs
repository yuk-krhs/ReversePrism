using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Master                                   ModelClassType MstCharacterInfo MstCharacterInfo MstCharacterInfo Pointer
    // 018 CharaId                                  ModelPrimitiveType int int int Int32
    // 020 IconViewModel                            ModelClassType CharacterBaseIconViewModel CharacterBaseIconViewModel CharacterBaseIconViewModel Pointer
    public partial class IntroductionCharacterIconViewModel : DataModel
    {
        public MstCharacterInfo?                        Master                                  { get; set; }
        public int                                      CharaId                                 { get; set; }
        public CharacterBaseIconViewModel?              IconViewModel                           { get; set; }

        public static IntroductionCharacterIconViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IntroductionCharacterIconViewModel() { Pointer= p0 };

            value.Master                                    = GetObject<MstCharacterInfo>(new IntPtr(p + 0x010), ReversePrism.DataModels.MstCharacterInfo.FromPointer); // 0x10 Master                      ( ModelClassType MstCharacterInfo MstCharacterInfo MstCharacterInfo Pointer )
            value.CharaId                                   = GetInt32(new IntPtr(p + 0x018)); // 0x18 CharaId                     ( ModelPrimitiveType int int int Int32 )
            value.IconViewModel                             = GetObject<CharacterBaseIconViewModel>(new IntPtr(p + 0x020), ReversePrism.DataModels.CharacterBaseIconViewModel.FromPointer); // 0x20 IconViewModel               ( ModelClassType CharacterBaseIconViewModel CharacterBaseIconViewModel CharacterBaseIconViewModel Pointer )

            return value;
        }
    }
}
