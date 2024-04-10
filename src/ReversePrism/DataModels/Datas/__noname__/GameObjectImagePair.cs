using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 GameObject                               0001865D8420 ModelClassType GameObject GameObject GameObject Pointer
    // 018 Image                                    0001866EB310 ModelClassType UIImage UIImage UIImage Pointer
    public partial class GameObjectImagePair : DataModel
    {
        public GameObject?                              GameObject                              { get; set; }
        public UIImage?                                 Image                                   { get; set; }

        public static GameObjectImagePair? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GameObjectImagePair() { Pointer= p0 };

            value.GameObject                                = GetObject<GameObject>(new IntPtr(p + 0x010), ReversePrism.DataModels.GameObject.FromPointer); // 024665E206C8 0x10 GameObject                  ( 0001865D8420 ModelClassType GameObject GameObject GameObject Pointer )
            value.Image                                     = GetObject<UIImage>(new IntPtr(p + 0x018), ReversePrism.DataModels.UIImage.FromPointer); // 024665E206E8 0x18 Image                       ( 0001866EB310 ModelClassType UIImage UIImage UIImage Pointer )

            return value;
        }
    }
}
