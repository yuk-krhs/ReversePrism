using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 UseEditorLoader                          000186594D10 ModelPrimitiveType bool bool bool Bool
    // 021 IsReactivating                           000186594D10 ModelPrimitiveType bool bool bool Bool
    // 022 InAction                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 028 beforeUnloadScene                        Func`2<Scene, UniTask> IL2CPP_TYPE_GENERICINST
    // 030 PrepareUnload                            0001866792B0 ModelClassType Action Action Action Pointer
    // 038 BeforeLoad                               0001866792B0 ModelClassType Action Action Action Pointer
    // 040 AfterLoad                                0001866792B0 ModelClassType Action Action Action Pointer
    // 048 _SceneStack                              000185D2B3B8 ModelClassListType List`1<SceneDish> List`1<SceneDish> List<SceneDish> Pointer
    public partial class SceneStack
    {
        public bool                                     UseEditorLoader                         { get; set; }
        public bool                                     IsReactivating                          { get; set; }
        public bool                                     InAction                                { get; set; }
        public Action?                                  PrepareUnload                           { get; set; }
        public Action?                                  BeforeLoad                              { get; set; }
        public Action?                                  AfterLoad                               { get; set; }
        public List<SceneDish>?                         _SceneStack                             { get; set; }

        public static SceneStack? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SceneStack();

            value.UseEditorLoader                           = GetBool(new IntPtr(p + 0x020)); // 027003EE4608 0x20 UseEditorLoader             ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsReactivating                            = GetBool(new IntPtr(p + 0x021)); // 027003EE4628 0x21 IsReactivating              ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.InAction                                  = GetBool(new IntPtr(p + 0x022)); // 027003EE4648 0x22 InAction                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.PrepareUnload                             = GetObject<Action>(new IntPtr(p + 0x030), ReversePrism.DataModels.Action.FromPointer); // 027003EE4688 0x30 PrepareUnload               ( 0001866792B0 ModelClassType Action Action Action Pointer )
            value.BeforeLoad                                = GetObject<Action>(new IntPtr(p + 0x038), ReversePrism.DataModels.Action.FromPointer); // 027003EE46A8 0x38 BeforeLoad                  ( 0001866792B0 ModelClassType Action Action Action Pointer )
            value.AfterLoad                                 = GetObject<Action>(new IntPtr(p + 0x040), ReversePrism.DataModels.Action.FromPointer); // 027003EE46C8 0x40 AfterLoad                   ( 0001866792B0 ModelClassType Action Action Action Pointer )
            value._SceneStack                               = GetObjectList<SceneDish>(new IntPtr(p + 0x048), ReversePrism.DataModels.SceneDish.FromPointer); // 027003EE46E8 0x48 _SceneStack                 ( 000185D2B3B8 ModelClassListType List`1<SceneDish> List`1<SceneDish> List<SceneDish> Pointer )

            return value;
        }
    }
}
