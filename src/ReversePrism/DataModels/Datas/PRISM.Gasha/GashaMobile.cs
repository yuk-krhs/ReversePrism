using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TemplateR                                ModelClassType GameObject GameObject GameObject Pointer
    // 028 TemplateSR                               ModelClassType GameObject GameObject GameObject Pointer
    // 030 TemplateSSR                              ModelClassType GameObject GameObject GameObject Pointer
    // 038 MessageRoots                             ModelClassListType Transform[] Transform[] List<Transform> Pointer
    // 040 MessageText                              ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 AnimatorWithEvent                        ModelClassType AnimatorWithEvent AnimatorWithEvent AnimatorWithEvent Pointer
    // 050 List                                     ModelPrimitiveListType int[] int[] List<int> Pointer
    // 058 GashaMessages                            ModelClassListType List`1<GameObject> List`1<GameObject> List<GameObject> Pointer
    // 060 IsTouchScreen                            ModelPrimitiveType bool bool bool Bool
    public partial class GashaMobile : DataModel
    {
        public GameObject?                              TemplateR                               { get; set; }
        public GameObject?                              TemplateSR                              { get; set; }
        public GameObject?                              TemplateSSR                             { get; set; }
        public List<Transform>?                         MessageRoots                            { get; set; }
        public UITextMeshProUGUI?                       MessageText                             { get; set; }
        public AnimatorWithEvent?                       AnimatorWithEvent                       { get; set; }
        public List<int>?                               List                                    { get; set; }
        public List<GameObject>?                        GashaMessages                           { get; set; }
        public bool                                     IsTouchScreen                           { get; set; }

        public static GashaMobile? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GashaMobile() { Pointer= p0 };

            value.TemplateR                                 = GetObject<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 0x20 TemplateR                   ( ModelClassType GameObject GameObject GameObject Pointer )
            value.TemplateSR                                = GetObject<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 0x28 TemplateSR                  ( ModelClassType GameObject GameObject GameObject Pointer )
            value.TemplateSSR                               = GetObject<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 0x30 TemplateSSR                 ( ModelClassType GameObject GameObject GameObject Pointer )
            value.MessageRoots                              = GetObjectList<Transform>(new IntPtr(p + 0x038), ReversePrism.DataModels.Transform.FromPointer); // 0x38 MessageRoots                ( ModelClassListType Transform[] Transform[] List<Transform> Pointer )
            value.MessageText                               = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x40 MessageText                 ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.AnimatorWithEvent                         = GetObject<AnimatorWithEvent>(new IntPtr(p + 0x048), ReversePrism.DataModels.AnimatorWithEvent.FromPointer); // 0x48 AnimatorWithEvent           ( ModelClassType AnimatorWithEvent AnimatorWithEvent AnimatorWithEvent Pointer )
            value.List                                      = GetInt32List(new IntPtr(p + 0x050)); // 0x50 List                        ( ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.GashaMessages                             = GetObjectList<GameObject>(new IntPtr(p + 0x058), ReversePrism.DataModels.GameObject.FromPointer); // 0x58 GashaMessages               ( ModelClassListType List`1<GameObject> List`1<GameObject> List<GameObject> Pointer )
            value.IsTouchScreen                             = GetBool(new IntPtr(p + 0x060)); // 0x60 IsTouchScreen               ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
