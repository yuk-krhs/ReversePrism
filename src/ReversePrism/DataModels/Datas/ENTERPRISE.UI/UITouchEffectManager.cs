using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TouchEffectPrefab                        ModelClassType GameObject GameObject GameObject Pointer
    // 028 DragEffectPrefab                         ModelClassType GameObject GameObject GameObject Pointer
    // 030 TouchEffects                             ModelClassListType UIEffectAlive[] UIEffectAlive[] List<UIEffectAlive> Pointer
    // 038 DragEffect                               ModelClassType UIDragEffect UIDragEffect UIDragEffect Pointer
    // 040 TouchEffectsMaxNum                       ModelPrimitiveType int int int Int32
    // 044 TouchEffectsNum                          ModelPrimitiveType int int int Int32
    // 048 CurrentTouchIndex                        ModelPrimitiveType int int int Int32
    // 04C DragDistance                             ModelPrimitiveType float float float Single
    // 000 <RequestEnable>k__BackingField           bool IL2CPP_TYPE_BOOLEAN
    public partial class UITouchEffectManager : DataModel
    {
        public GameObject?                              TouchEffectPrefab                       { get; set; }
        public GameObject?                              DragEffectPrefab                        { get; set; }
        public List<UIEffectAlive>?                     TouchEffects                            { get; set; }
        public UIDragEffect?                            DragEffect                              { get; set; }
        public int                                      TouchEffectsMaxNum                      { get; set; }
        public int                                      TouchEffectsNum                         { get; set; }
        public int                                      CurrentTouchIndex                       { get; set; }
        public float                                    DragDistance                            { get; set; }

        public static UITouchEffectManager? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UITouchEffectManager() { Pointer= p0 };

            value.TouchEffectPrefab                         = GetObject<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 0x20 TouchEffectPrefab           ( ModelClassType GameObject GameObject GameObject Pointer )
            value.DragEffectPrefab                          = GetObject<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 0x28 DragEffectPrefab            ( ModelClassType GameObject GameObject GameObject Pointer )
            value.TouchEffects                              = GetObjectList<UIEffectAlive>(new IntPtr(p + 0x030), ReversePrism.DataModels.UIEffectAlive.FromPointer); // 0x30 TouchEffects                ( ModelClassListType UIEffectAlive[] UIEffectAlive[] List<UIEffectAlive> Pointer )
            value.DragEffect                                = GetObject<UIDragEffect>(new IntPtr(p + 0x038), ReversePrism.DataModels.UIDragEffect.FromPointer); // 0x38 DragEffect                  ( ModelClassType UIDragEffect UIDragEffect UIDragEffect Pointer )
            value.TouchEffectsMaxNum                        = GetInt32(new IntPtr(p + 0x040)); // 0x40 TouchEffectsMaxNum          ( ModelPrimitiveType int int int Int32 )
            value.TouchEffectsNum                           = GetInt32(new IntPtr(p + 0x044)); // 0x44 TouchEffectsNum             ( ModelPrimitiveType int int int Int32 )
            value.CurrentTouchIndex                         = GetInt32(new IntPtr(p + 0x048)); // 0x48 CurrentTouchIndex           ( ModelPrimitiveType int int int Int32 )
            value.DragDistance                              = GetSingle(new IntPtr(p + 0x04C)); // 0x4C DragDistance                ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
