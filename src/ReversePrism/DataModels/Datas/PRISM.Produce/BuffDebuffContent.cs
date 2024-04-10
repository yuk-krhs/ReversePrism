using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 BlinkStartTime                           float IL2CPP_TYPE_R4
    // 020 BuffIconOrijin                           000186779F00 ModelClassType BuffIcon BuffIcon BuffIcon Pointer
    // 028 BuffLayoutGroup                          0001866D5C00 ModelClassType HorizontalLayoutGroup HorizontalLayoutGroup HorizontalLayoutGroup Pointer
    // 030 BuffIconAtlas                            00018654FA50 ModelClassType SpriteAtlas SpriteAtlas SpriteAtlas Pointer
    // 038 BuffIcons                                000185CCFEB8 ModelClassListType List`1<BuffIcon> List`1<BuffIcon> List<BuffIcon> Pointer
    // 000 BlinkDuaration                           float IL2CPP_TYPE_R4
    // 040 FadeValue                                0001866656B0 ModelPrimitiveType float float float Single
    // 048 Tweener                                  0001866C3DE0 ModelClassType Tweener Tweener Tweener Pointer
    // 050 BlinkAlpha                               0001866656B0 ModelPrimitiveType float float float Single
    // 058 onClickIcon                              Subject`1<int> IL2CPP_TYPE_GENERICINST
    public partial class BuffDebuffContent : DataModel
    {
        public BuffIcon?                                BuffIconOrijin                          { get; set; }
        public HorizontalLayoutGroup?                   BuffLayoutGroup                         { get; set; }
        public SpriteAtlas?                             BuffIconAtlas                           { get; set; }
        public List<BuffIcon>?                          BuffIcons                               { get; set; }
        public float                                    FadeValue                               { get; set; }
        public Tweener?                                 Tweener                                 { get; set; }
        public float                                    BlinkAlpha                              { get; set; }

        public static BuffDebuffContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BuffDebuffContent() { Pointer= p0 };

            value.BuffIconOrijin                            = GetObject<BuffIcon>(new IntPtr(p + 0x020), ReversePrism.DataModels.BuffIcon.FromPointer); // 024665C39FC8 0x20 BuffIconOrijin              ( 000186779F00 ModelClassType BuffIcon BuffIcon BuffIcon Pointer )
            value.BuffLayoutGroup                           = GetObject<HorizontalLayoutGroup>(new IntPtr(p + 0x028), ReversePrism.DataModels.HorizontalLayoutGroup.FromPointer); // 024665C39FE8 0x28 BuffLayoutGroup             ( 0001866D5C00 ModelClassType HorizontalLayoutGroup HorizontalLayoutGroup HorizontalLayoutGroup Pointer )
            value.BuffIconAtlas                             = GetObject<SpriteAtlas>(new IntPtr(p + 0x030), ReversePrism.DataModels.SpriteAtlas.FromPointer); // 024665C3A008 0x30 BuffIconAtlas               ( 00018654FA50 ModelClassType SpriteAtlas SpriteAtlas SpriteAtlas Pointer )
            value.BuffIcons                                 = GetObjectList<BuffIcon>(new IntPtr(p + 0x038), ReversePrism.DataModels.BuffIcon.FromPointer); // 024665C3A028 0x38 BuffIcons                   ( 000185CCFEB8 ModelClassListType List`1<BuffIcon> List`1<BuffIcon> List<BuffIcon> Pointer )
            value.FadeValue                                 = GetSingle(new IntPtr(p + 0x040)); // 024665C3A068 0x40 FadeValue                   ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.Tweener                                   = GetObject<Tweener>(new IntPtr(p + 0x048), ReversePrism.DataModels.Tweener.FromPointer); // 024665C3A088 0x48 Tweener                     ( 0001866C3DE0 ModelClassType Tweener Tweener Tweener Pointer )
            value.BlinkAlpha                                = GetSingle(new IntPtr(p + 0x050)); // 024665C3A0A8 0x50 BlinkAlpha                  ( 0001866656B0 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
