using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 MusicDifficulties                        ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    public partial class MusicDifficultyIcon : DataModel
    {
        public List<GameObject>?                        MusicDifficulties                       { get; set; }

        public static MusicDifficultyIcon? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MusicDifficultyIcon() { Pointer= p0 };

            value.MusicDifficulties                         = GetObjectList<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 0x20 MusicDifficulties           ( ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )

            return value;
        }
    }
}
