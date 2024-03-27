using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 LeftIDStart                              int IL2CPP_TYPE_I4
    // 000 RightIDStart                             int IL2CPP_TYPE_I4
    // 060 ButtonGroup                              0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 068 TextArea                                 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 070 ButtonDistance                           0001865F2AF0 ModelPrimitiveType int int int Int32
    // 074 TextMargin                               0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class TwoChoicesContent
    {
        public GameObject?                              ButtonGroup                             { get; set; }
        public GameObject?                              TextArea                                { get; set; }
        public int                                      ButtonDistance                          { get; set; }
        public int                                      TextMargin                              { get; set; }

        public static TwoChoicesContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TwoChoicesContent();

            value.ButtonGroup                               = GetObject<GameObject>(new IntPtr(p + 0x060), ReversePrism.DataModels.GameObject.FromPointer); // 027004393418 0x60 ButtonGroup                 ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.TextArea                                  = GetObject<GameObject>(new IntPtr(p + 0x068), ReversePrism.DataModels.GameObject.FromPointer); // 027004393438 0x68 TextArea                    ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.ButtonDistance                            = GetInt32(new IntPtr(p + 0x070)); // 027004393458 0x70 ButtonDistance              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.TextMargin                                = GetInt32(new IntPtr(p + 0x074)); // 027004393478 0x74 TextMargin                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
