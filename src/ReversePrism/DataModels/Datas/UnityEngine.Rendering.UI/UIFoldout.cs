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
    public partial class UIFoldout
    {
        public GameObject?                              Content                                 { get; set; }
        public GameObject?                              ArrowOpened                             { get; set; }
        public GameObject?                              ArrowClosed                             { get; set; }

        public static UIFoldout? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UIFoldout();

            value.Content                                   = GetObject<GameObject>(new IntPtr(p + 0x128), ReversePrism.DataModels.GameObject.FromPointer); // 0270D9303E10 0x128 Content                     ( 0001865D8420 ModelClassType GameObject GameObject GameObject Pointer )
            value.ArrowOpened                               = GetObject<GameObject>(new IntPtr(p + 0x130), ReversePrism.DataModels.GameObject.FromPointer); // 0270D9303E30 0x130 ArrowOpened                 ( 0001865D8420 ModelClassType GameObject GameObject GameObject Pointer )
            value.ArrowClosed                               = GetObject<GameObject>(new IntPtr(p + 0x138), ReversePrism.DataModels.GameObject.FromPointer); // 0270D9303E50 0x138 ArrowClosed                 ( 0001865D8420 ModelClassType GameObject GameObject GameObject Pointer )

            return value;
        }
    }
}
