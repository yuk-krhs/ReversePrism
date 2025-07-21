using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 BaseObject                               ModelClassType GameObject GameObject GameObject Pointer
    // 028 ParamTex                                 ModelClassListType Texture2D[] Texture2D[] List<Texture2D> Pointer
    // 030 Anim                                     ModelClassType Animator Animator Animator Pointer
    public partial class FaceController : DataModel
    {
        public GameObject?                              BaseObject                              { get; set; }
        public List<Texture2D>?                         ParamTex                                { get; set; }
        public Animator?                                Anim                                    { get; set; }

        public static FaceController? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FaceController() { Pointer= p0 };

            value.BaseObject                                = GetObject<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 0x20 BaseObject                  ( ModelClassType GameObject GameObject GameObject Pointer )
            value.ParamTex                                  = GetObjectList<Texture2D>(new IntPtr(p + 0x028), ReversePrism.DataModels.Texture2D.FromPointer); // 0x28 ParamTex                    ( ModelClassListType Texture2D[] Texture2D[] List<Texture2D> Pointer )
            value.Anim                                      = GetObject<Animator>(new IntPtr(p + 0x030), ReversePrism.DataModels.Animator.FromPointer); // 0x30 Anim                        ( ModelClassType Animator Animator Animator Pointer )

            return value;
        }
    }
}
