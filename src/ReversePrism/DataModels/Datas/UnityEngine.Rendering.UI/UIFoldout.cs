using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 128 Content                                  0001865D8420 ModelClassType GameObject GameObject GameObject Pointer
    // 130 ArrowOpened                              0001865D8420 ModelClassType GameObject GameObject GameObject Pointer
    // 138 ArrowClosed                              0001865D8420 ModelClassType GameObject GameObject GameObject Pointer
    public partial class UIFoldout : DataModel
    {
        public GameObject?                              Content                                 { get; set; }
        public GameObject?                              ArrowOpened                             { get; set; }
        public GameObject?                              ArrowClosed                             { get; set; }

        public static UIFoldout? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UIFoldout() { Pointer= p0 };

            value.Content                                   = GetObject<GameObject>(new IntPtr(p + 0x128), ReversePrism.DataModels.GameObject.FromPointer); // 024669366318 0x128 Content                     ( 0001865D8420 ModelClassType GameObject GameObject GameObject Pointer )
            value.ArrowOpened                               = GetObject<GameObject>(new IntPtr(p + 0x130), ReversePrism.DataModels.GameObject.FromPointer); // 024669366338 0x130 ArrowOpened                 ( 0001865D8420 ModelClassType GameObject GameObject GameObject Pointer )
            value.ArrowClosed                               = GetObject<GameObject>(new IntPtr(p + 0x138), ReversePrism.DataModels.GameObject.FromPointer); // 024669366358 0x138 ArrowClosed                 ( 0001865D8420 ModelClassType GameObject GameObject GameObject Pointer )

            return value;
        }
    }
}
