using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CharacterIds                             000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 000 DefaultCharacterId                       int IL2CPP_TYPE_I4
    public partial class LoadingMiniCharaViewModel
    {
        public List<int>?                               CharacterIds                            { get; set; }

        public static LoadingMiniCharaViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LoadingMiniCharaViewModel();

            value.CharacterIds                              = GetInt32List(new IntPtr(p + 0x010)); // 027001E9DBB0 0x10 CharacterIds                ( 000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer )

            return value;
        }
    }
}
