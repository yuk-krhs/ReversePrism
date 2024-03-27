using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 050 SdCharaIcons                             000185CC34B8 ModelClassListType GameObjectImagePair[] GameObjectImagePair[] List<GameObjectImagePair> Pointer
    public partial class SupportEffectContentViewWithSDCharaIcon
    {
        public List<GameObjectImagePair>?               SdCharaIcons                            { get; set; }

        public static SupportEffectContentViewWithSDCharaIcon? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SupportEffectContentViewWithSDCharaIcon();

            value.SdCharaIcons                              = GetObjectList<GameObjectImagePair>(new IntPtr(p + 0x050), ReversePrism.DataModels.GameObjectImagePair.FromPointer); // 0270D5472AC8 0x50 SdCharaIcons                ( 000185CC34B8 ModelClassListType GameObjectImagePair[] GameObjectImagePair[] List<GameObjectImagePair> Pointer )

            return value;
        }
    }
}
