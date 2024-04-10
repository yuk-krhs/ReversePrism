using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CharacterIds                             000185B7D9E0 ModelPrimitiveListType int[] int[] List<int> Pointer
    public partial class LoadingTipsViewModel : DataModel
    {
        public List<int>?                               CharacterIds                            { get; set; }

        public static LoadingTipsViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LoadingTipsViewModel() { Pointer= p0 };

            value.CharacterIds                              = GetInt32List(new IntPtr(p + 0x010)); // 0245A1EA02F8 0x10 CharacterIds                ( 000185B7D9E0 ModelPrimitiveListType int[] int[] List<int> Pointer )

            return value;
        }
    }
}
