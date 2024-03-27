using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Button                                   0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 028 CharacterBaseIcon                        000186599240 ModelClassType CharacterBaseIcon CharacterBaseIcon CharacterBaseIcon Pointer
    // 030 NewBadge                                 0001865D81D0 ModelClassType GameObject GameObject GameObject Pointer
    // 038 UnreadBadge                              0001865D81D0 ModelClassType GameObject GameObject GameObject Pointer
    // 040 UiGrayOutController                      0001866EA450 ModelClassType UIGrayOutController UIGrayOutController UIGrayOutController Pointer
    // 048 LockIcon                                 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    public partial class IdolStoryFirstCategoryCell
    {
        public UIButton?                                Button                                  { get; set; }
        public CharacterBaseIcon?                       CharacterBaseIcon                       { get; set; }
        public GameObject?                              NewBadge                                { get; set; }
        public GameObject?                              UnreadBadge                             { get; set; }
        public UIGrayOutController?                     UiGrayOutController                     { get; set; }
        public GameObject?                              LockIcon                                { get; set; }

        public static IdolStoryFirstCategoryCell? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IdolStoryFirstCategoryCell();

            value.Button                                    = GetObject<UIButton>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIButton.FromPointer); // 0270DB9969E0 0x20 Button                      ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.CharacterBaseIcon                         = GetObject<CharacterBaseIcon>(new IntPtr(p + 0x028), ReversePrism.DataModels.CharacterBaseIcon.FromPointer); // 0270DB996A00 0x28 CharacterBaseIcon           ( 000186599240 ModelClassType CharacterBaseIcon CharacterBaseIcon CharacterBaseIcon Pointer )
            value.NewBadge                                  = GetObject<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 0270DB996A20 0x30 NewBadge                    ( 0001865D81D0 ModelClassType GameObject GameObject GameObject Pointer )
            value.UnreadBadge                               = GetObject<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 0270DB996A40 0x38 UnreadBadge                 ( 0001865D81D0 ModelClassType GameObject GameObject GameObject Pointer )
            value.UiGrayOutController                       = GetObject<UIGrayOutController>(new IntPtr(p + 0x040), ReversePrism.DataModels.UIGrayOutController.FromPointer); // 0270DB996A60 0x40 UiGrayOutController         ( 0001866EA450 ModelClassType UIGrayOutController UIGrayOutController UIGrayOutController Pointer )
            value.LockIcon                                  = GetObject<GameObject>(new IntPtr(p + 0x048), ReversePrism.DataModels.GameObject.FromPointer); // 0270DB996A80 0x48 LockIcon                    ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )

            return value;
        }
    }
}
