using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 LimitIconPrefab                          000186683C40 ModelClassType ToggleButton ToggleButton ToggleButton Pointer
    // 028 IconGroupPrefab                          0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 030 IconArea                                 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 038 HorizontalMax                            0001865F2AF0 ModelPrimitiveType int int int Int32
    // 040 NoLimitIcon                              0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 048 Icons                                    000185D153A8 ModelClassListType List`1<ToggleButton> List`1<ToggleButton> List<ToggleButton> Pointer
    // 050 IconGroups                               000185CDD468 ModelClassListType List`1<GameObject> List`1<GameObject> List<GameObject> Pointer
    public partial class SkillLimitPanel
    {
        public ToggleButton?                            LimitIconPrefab                         { get; set; }
        public GameObject?                              IconGroupPrefab                         { get; set; }
        public RectTransform?                           IconArea                                { get; set; }
        public int                                      HorizontalMax                           { get; set; }
        public GameObject?                              NoLimitIcon                             { get; set; }
        public List<ToggleButton>?                      Icons                                   { get; set; }
        public List<GameObject>?                        IconGroups                              { get; set; }

        public static SkillLimitPanel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SkillLimitPanel();

            value.LimitIconPrefab                           = GetObject<ToggleButton>(new IntPtr(p + 0x020), ReversePrism.DataModels.ToggleButton.FromPointer); // 0270D5C4E2A8 0x20 LimitIconPrefab             ( 000186683C40 ModelClassType ToggleButton ToggleButton ToggleButton Pointer )
            value.IconGroupPrefab                           = GetObject<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 0270D5C4E2C8 0x28 IconGroupPrefab             ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.IconArea                                  = GetObject<RectTransform>(new IntPtr(p + 0x030), ReversePrism.DataModels.RectTransform.FromPointer); // 0270D5C4E2E8 0x30 IconArea                    ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.HorizontalMax                             = GetInt32(new IntPtr(p + 0x038)); // 0270D5C4E308 0x38 HorizontalMax               ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.NoLimitIcon                               = GetObject<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 0270D5C4E328 0x40 NoLimitIcon                 ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.Icons                                     = GetObjectList<ToggleButton>(new IntPtr(p + 0x048), ReversePrism.DataModels.ToggleButton.FromPointer); // 0270D5C4E348 0x48 Icons                       ( 000185D153A8 ModelClassListType List`1<ToggleButton> List`1<ToggleButton> List<ToggleButton> Pointer )
            value.IconGroups                                = GetObjectList<GameObject>(new IntPtr(p + 0x050), ReversePrism.DataModels.GameObject.FromPointer); // 0270D5C4E368 0x50 IconGroups                  ( 000185CDD468 ModelClassListType List`1<GameObject> List`1<GameObject> List<GameObject> Pointer )

            return value;
        }
    }
}
