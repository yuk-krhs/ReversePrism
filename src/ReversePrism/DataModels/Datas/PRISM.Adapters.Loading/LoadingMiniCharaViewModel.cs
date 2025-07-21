using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 DefaultCharacterId                       int IL2CPP_TYPE_I4
    // 010 CharacterIds                             ModelPrimitiveListType int[] int[] List<int> Pointer
    public partial class LoadingMiniCharaViewModel : DataModel
    {
        public List<int>?                               CharacterIds                            { get; set; }

        public static LoadingMiniCharaViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LoadingMiniCharaViewModel() { Pointer= p0 };

            value.CharacterIds                              = GetInt32List(new IntPtr(p + 0x010)); // 0x10 CharacterIds                ( ModelPrimitiveListType int[] int[] List<int> Pointer )

            return value;
        }
    }
}
