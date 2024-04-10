using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 OnSelected                               000186769300 ModelClassType BoolReactiveProperty BoolReactiveProperty BoolReactiveProperty Pointer
    // 018 IconViewModel                            000186599990 ModelClassType CharacterBaseIconViewModel CharacterBaseIconViewModel CharacterBaseIconViewModel Pointer
    // 020 IsSetting                                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 028 CharacterInfo                            00018661BCB0 ModelClassType MstCharacterInfo MstCharacterInfo MstCharacterInfo Pointer
    // 030 CharaId                                  0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class HomeSettingsIdolIconViewModel : DataModel
    {
        public BoolReactiveProperty?                    OnSelected                              { get; set; }
        public CharacterBaseIconViewModel?              IconViewModel                           { get; set; }
        public bool                                     IsSetting                               { get; set; }
        public MstCharacterInfo?                        CharacterInfo                           { get; set; }
        public int                                      CharaId                                 { get; set; }

        public static HomeSettingsIdolIconViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HomeSettingsIdolIconViewModel() { Pointer= p0 };

            value.OnSelected                                = GetObject<BoolReactiveProperty>(new IntPtr(p + 0x010), ReversePrism.DataModels.BoolReactiveProperty.FromPointer); // 0245A5D4A1A8 0x10 OnSelected                  ( 000186769300 ModelClassType BoolReactiveProperty BoolReactiveProperty BoolReactiveProperty Pointer )
            value.IconViewModel                             = GetObject<CharacterBaseIconViewModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.CharacterBaseIconViewModel.FromPointer); // 0245A5D4A1C8 0x18 IconViewModel               ( 000186599990 ModelClassType CharacterBaseIconViewModel CharacterBaseIconViewModel CharacterBaseIconViewModel Pointer )
            value.IsSetting                                 = GetBool(new IntPtr(p + 0x020)); // 0245A5D4A1E8 0x20 IsSetting                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.CharacterInfo                             = GetObject<MstCharacterInfo>(new IntPtr(p + 0x028), ReversePrism.DataModels.MstCharacterInfo.FromPointer); // 0245A5D4A208 0x28 CharacterInfo               ( 00018661BCB0 ModelClassType MstCharacterInfo MstCharacterInfo MstCharacterInfo Pointer )
            value.CharaId                                   = GetInt32(new IntPtr(p + 0x030)); // 0245A5D4A228 0x30 CharaId                     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
