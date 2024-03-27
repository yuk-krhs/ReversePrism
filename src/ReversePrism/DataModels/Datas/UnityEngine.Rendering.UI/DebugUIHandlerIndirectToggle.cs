using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 NameLabel                                0001866320F0 ModelClassType Text Text Text Pointer
    // 068 ValueToggle                              000186682980 ModelClassType Toggle Toggle Toggle Pointer
    // 070 CheckmarkImage                           0001866CD270 ModelClassType Image Image Image Pointer
    // 078 getter                                   Func`2<int, bool> IL2CPP_TYPE_GENERICINST
    // 080 setter                                   Action`2<int, bool> IL2CPP_TYPE_GENERICINST
    // 088 Index                                    0001865F2F90 ModelPrimitiveType int int int Int32
    public partial class DebugUIHandlerIndirectToggle
    {
        public Text?                                    NameLabel                               { get; set; }
        public Toggle?                                  ValueToggle                             { get; set; }
        public Image?                                   CheckmarkImage                          { get; set; }
        public int                                      Index                                   { get; set; }

        public static DebugUIHandlerIndirectToggle? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DebugUIHandlerIndirectToggle();

            value.NameLabel                                 = GetObject<Text>(new IntPtr(p + 0x060), ReversePrism.DataModels.Text.FromPointer); // 0270D9306EE0 0x60 NameLabel                   ( 0001866320F0 ModelClassType Text Text Text Pointer )
            value.ValueToggle                               = GetObject<Toggle>(new IntPtr(p + 0x068), ReversePrism.DataModels.Toggle.FromPointer); // 0270D9306F00 0x68 ValueToggle                 ( 000186682980 ModelClassType Toggle Toggle Toggle Pointer )
            value.CheckmarkImage                            = GetObject<Image>(new IntPtr(p + 0x070), ReversePrism.DataModels.Image.FromPointer); // 0270D9306F20 0x70 CheckmarkImage              ( 0001866CD270 ModelClassType Image Image Image Pointer )
            value.Index                                     = GetInt32(new IntPtr(p + 0x088)); // 0270D9306F80 0x88 Index                       ( 0001865F2F90 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
