using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 NameLabel                                ModelClassType Text Text Text Pointer
    // 068 ValueToggle                              ModelClassType Toggle Toggle Toggle Pointer
    // 070 CheckmarkImage                           ModelClassType Image Image Image Pointer
    // 078 getter                                   Func`2<int, bool> IL2CPP_TYPE_GENERICINST
    // 080 setter                                   Action`2<int, bool> IL2CPP_TYPE_GENERICINST
    // 088 Index                                    ModelPrimitiveType int int int Int32
    public partial class DebugUIHandlerIndirectToggle : DataModel
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
            var value   = new DebugUIHandlerIndirectToggle() { Pointer= p0 };

            value.NameLabel                                 = GetObject<Text>(new IntPtr(p + 0x060), ReversePrism.DataModels.Text.FromPointer); // 0x60 NameLabel                   ( ModelClassType Text Text Text Pointer )
            value.ValueToggle                               = GetObject<Toggle>(new IntPtr(p + 0x068), ReversePrism.DataModels.Toggle.FromPointer); // 0x68 ValueToggle                 ( ModelClassType Toggle Toggle Toggle Pointer )
            value.CheckmarkImage                            = GetObject<Image>(new IntPtr(p + 0x070), ReversePrism.DataModels.Image.FromPointer); // 0x70 CheckmarkImage              ( ModelClassType Image Image Image Pointer )
            value.Index                                     = GetInt32(new IntPtr(p + 0x088)); // 0x88 Index                       ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
