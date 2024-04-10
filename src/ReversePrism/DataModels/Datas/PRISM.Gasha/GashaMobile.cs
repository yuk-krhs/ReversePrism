using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TemplateR                                0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 028 TemplateSR                               0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 030 TemplateSSR                              0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 038 MessageRoots                             000185CACE28 ModelClassListType Transform[] Transform[] List<Transform> Pointer
    // 040 AnimatorWithEvent                        0001866BBE80 ModelClassType AnimatorWithEvent AnimatorWithEvent AnimatorWithEvent Pointer
    // 048 List                                     000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 050 GashaMessages                            000185CDD468 ModelClassListType List`1<GameObject> List`1<GameObject> List<GameObject> Pointer
    // 058 IsTouchScreen                            000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class GashaMobile : DataModel
    {
        public GameObject?                              TemplateR                               { get; set; }
        public GameObject?                              TemplateSR                              { get; set; }
        public GameObject?                              TemplateSSR                             { get; set; }
        public List<Transform>?                         MessageRoots                            { get; set; }
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

            value.TemplateR                                 = GetObject<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 02466537E098 0x20 TemplateR                   ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.TemplateSR                                = GetObject<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 02466537E0B8 0x28 TemplateSR                  ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.TemplateSSR                               = GetObject<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 02466537E0D8 0x30 TemplateSSR                 ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.MessageRoots                              = GetObjectList<Transform>(new IntPtr(p + 0x038), ReversePrism.DataModels.Transform.FromPointer); // 02466537E0F8 0x38 MessageRoots                ( 000185CACE28 ModelClassListType Transform[] Transform[] List<Transform> Pointer )
            value.AnimatorWithEvent                         = GetObject<AnimatorWithEvent>(new IntPtr(p + 0x040), ReversePrism.DataModels.AnimatorWithEvent.FromPointer); // 02466537E118 0x40 AnimatorWithEvent           ( 0001866BBE80 ModelClassType AnimatorWithEvent AnimatorWithEvent AnimatorWithEvent Pointer )
            value.List                                      = GetInt32List(new IntPtr(p + 0x048)); // 02466537E138 0x48 List                        ( 000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.GashaMessages                             = GetObjectList<GameObject>(new IntPtr(p + 0x050), ReversePrism.DataModels.GameObject.FromPointer); // 02466537E158 0x50 GashaMessages               ( 000185CDD468 ModelClassListType List`1<GameObject> List`1<GameObject> List<GameObject> Pointer )
            value.IsTouchScreen                             = GetBool(new IntPtr(p + 0x058)); // 02466537E178 0x58 IsTouchScreen               ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
