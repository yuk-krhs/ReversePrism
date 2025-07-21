using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 050 SdCharaIcons                             ModelClassListType GameObjectImagePair[] GameObjectImagePair[] List<GameObjectImagePair> Pointer
    public partial class SupportEffectContentViewWithSDCharaIcon : DataModel
    {
        public List<GameObjectImagePair>?               SdCharaIcons                            { get; set; }

        public static SupportEffectContentViewWithSDCharaIcon? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SupportEffectContentViewWithSDCharaIcon() { Pointer= p0 };

            value.SdCharaIcons                              = GetObjectList<GameObjectImagePair>(new IntPtr(p + 0x050), ReversePrism.DataModels.GameObjectImagePair.FromPointer); // 0x50 SdCharaIcons                ( ModelClassListType GameObjectImagePair[] GameObjectImagePair[] List<GameObjectImagePair> Pointer )

            return value;
        }
    }
}
