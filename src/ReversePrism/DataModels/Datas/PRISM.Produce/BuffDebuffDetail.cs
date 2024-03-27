using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 048 BuffIcon                                 0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer
    // 050 EffectGroup                              000186557080 ModelClassType ProduceInGameEffectGroup ProduceInGameEffectGroup ProduceInGameEffectGroup Pointer
    // 058 BuffIconAtlas                            00018654FA50 ModelClassType SpriteAtlas SpriteAtlas SpriteAtlas Pointer
    public partial class BuffDebuffDetail
    {
        public UIImage?                                 BuffIcon                                { get; set; }
        public ProduceInGameEffectGroup?                EffectGroup                             { get; set; }
        public SpriteAtlas?                             BuffIconAtlas                           { get; set; }

        public static BuffDebuffDetail? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BuffDebuffDetail();

            value.BuffIcon                                  = GetObject<UIImage>(new IntPtr(p + 0x048), ReversePrism.DataModels.UIImage.FromPointer); // 0270D5C49020 0x48 BuffIcon                    ( 0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer )
            value.EffectGroup                               = GetObject<ProduceInGameEffectGroup>(new IntPtr(p + 0x050), ReversePrism.DataModels.ProduceInGameEffectGroup.FromPointer); // 0270D5C49040 0x50 EffectGroup                 ( 000186557080 ModelClassType ProduceInGameEffectGroup ProduceInGameEffectGroup ProduceInGameEffectGroup Pointer )
            value.BuffIconAtlas                             = GetObject<SpriteAtlas>(new IntPtr(p + 0x058), ReversePrism.DataModels.SpriteAtlas.FromPointer); // 0270D5C49060 0x58 BuffIconAtlas               ( 00018654FA50 ModelClassType SpriteAtlas SpriteAtlas SpriteAtlas Pointer )

            return value;
        }
    }
}
