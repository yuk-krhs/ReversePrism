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
    // 060 ButtonGroup                              ModelClassType GameObject GameObject GameObject Pointer
    // 068 TextArea                                 ModelClassType GameObject GameObject GameObject Pointer
    // 070 ButtonDistance                           ModelPrimitiveType int int int Int32
    // 074 TextMargin                               ModelPrimitiveType int int int Int32
    public partial class TwoChoicesContent : DataModel
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
            var value   = new TwoChoicesContent() { Pointer= p0 };

            value.ButtonGroup                               = GetObject<GameObject>(new IntPtr(p + 0x060), ReversePrism.DataModels.GameObject.FromPointer); // 0x60 ButtonGroup                 ( ModelClassType GameObject GameObject GameObject Pointer )
            value.TextArea                                  = GetObject<GameObject>(new IntPtr(p + 0x068), ReversePrism.DataModels.GameObject.FromPointer); // 0x68 TextArea                    ( ModelClassType GameObject GameObject GameObject Pointer )
            value.ButtonDistance                            = GetInt32(new IntPtr(p + 0x070)); // 0x70 ButtonDistance              ( ModelPrimitiveType int int int Int32 )
            value.TextMargin                                = GetInt32(new IntPtr(p + 0x074)); // 0x74 TextMargin                  ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
