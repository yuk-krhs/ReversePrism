using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Chara                                    000185CC1F08 ModelClassListType CharaData[] CharaData[] List<CharaData> Pointer
    public partial class CharacterData : DataModel
    {
        public List<CharaData>?                         Chara                                   { get; set; }

        public static CharacterData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CharacterData() { Pointer= p0 };

            value.Chara                                     = GetObjectList<CharaData>(new IntPtr(p + 0x010), ReversePrism.DataModels.CharaData.FromPointer); // 0245A6AF16F8 0x10 Chara                       ( 000185CC1F08 ModelClassListType CharaData[] CharaData[] List<CharaData> Pointer )

            return value;
        }
    }
}
