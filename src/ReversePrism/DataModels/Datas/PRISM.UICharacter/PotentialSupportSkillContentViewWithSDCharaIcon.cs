using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 SdCharaIcons                             000185CC03F8 ModelClassListType GameObjectImagePair[] GameObjectImagePair[] List<GameObjectImagePair> Pointer
    public partial class PotentialSupportSkillContentViewWithSDCharaIcon : DataModel
    {
        public List<GameObjectImagePair>?               SdCharaIcons                            { get; set; }

        public static PotentialSupportSkillContentViewWithSDCharaIcon? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PotentialSupportSkillContentViewWithSDCharaIcon() { Pointer= p0 };

            value.SdCharaIcons                              = GetObjectList<GameObjectImagePair>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObjectImagePair.FromPointer); // 0246654E5700 0x38 SdCharaIcons                ( 000185CC03F8 ModelClassListType GameObjectImagePair[] GameObjectImagePair[] List<GameObjectImagePair> Pointer )

            return value;
        }
    }
}
