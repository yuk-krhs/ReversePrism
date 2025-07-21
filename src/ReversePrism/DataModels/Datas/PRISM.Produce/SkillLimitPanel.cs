using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 LimitIconPrefab                          ModelClassType ToggleButton ToggleButton ToggleButton Pointer
    // 028 IconGroupPrefab                          ModelClassType GameObject GameObject GameObject Pointer
    // 030 IconArea                                 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 038 HorizontalMax                            ModelPrimitiveType int int int Int32
    // 040 NoLimitIcon                              ModelClassType GameObject GameObject GameObject Pointer
    // 048 Icons                                    ModelClassListType List`1<ToggleButton> List`1<ToggleButton> List<ToggleButton> Pointer
    // 050 IconGroups                               ModelClassListType List`1<GameObject> List`1<GameObject> List<GameObject> Pointer
    public partial class SkillLimitPanel : DataModel
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
            var value   = new SkillLimitPanel() { Pointer= p0 };

            value.LimitIconPrefab                           = GetObject<ToggleButton>(new IntPtr(p + 0x020), ReversePrism.DataModels.ToggleButton.FromPointer); // 0x20 LimitIconPrefab             ( ModelClassType ToggleButton ToggleButton ToggleButton Pointer )
            value.IconGroupPrefab                           = GetObject<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 0x28 IconGroupPrefab             ( ModelClassType GameObject GameObject GameObject Pointer )
            value.IconArea                                  = GetObject<RectTransform>(new IntPtr(p + 0x030), ReversePrism.DataModels.RectTransform.FromPointer); // 0x30 IconArea                    ( ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.HorizontalMax                             = GetInt32(new IntPtr(p + 0x038)); // 0x38 HorizontalMax               ( ModelPrimitiveType int int int Int32 )
            value.NoLimitIcon                               = GetObject<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 0x40 NoLimitIcon                 ( ModelClassType GameObject GameObject GameObject Pointer )
            value.Icons                                     = GetObjectList<ToggleButton>(new IntPtr(p + 0x048), ReversePrism.DataModels.ToggleButton.FromPointer); // 0x48 Icons                       ( ModelClassListType List`1<ToggleButton> List`1<ToggleButton> List<ToggleButton> Pointer )
            value.IconGroups                                = GetObjectList<GameObject>(new IntPtr(p + 0x050), ReversePrism.DataModels.GameObject.FromPointer); // 0x50 IconGroups                  ( ModelClassListType List`1<GameObject> List`1<GameObject> List<GameObject> Pointer )

            return value;
        }
    }
}
