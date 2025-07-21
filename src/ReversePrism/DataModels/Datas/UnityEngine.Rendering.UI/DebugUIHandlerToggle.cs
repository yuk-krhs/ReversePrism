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
    // 078 M_Field                                  ModelClassType BoolField BoolField BoolField Pointer
    public partial class DebugUIHandlerToggle : DataModel
    {
        public Text?                                    NameLabel                               { get; set; }
        public Toggle?                                  ValueToggle                             { get; set; }
        public Image?                                   CheckmarkImage                          { get; set; }
        public BoolField?                               M_Field                                 { get; set; }

        public static DebugUIHandlerToggle? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DebugUIHandlerToggle() { Pointer= p0 };

            value.NameLabel                                 = GetObject<Text>(new IntPtr(p + 0x060), ReversePrism.DataModels.Text.FromPointer); // 0x60 NameLabel                   ( ModelClassType Text Text Text Pointer )
            value.ValueToggle                               = GetObject<Toggle>(new IntPtr(p + 0x068), ReversePrism.DataModels.Toggle.FromPointer); // 0x68 ValueToggle                 ( ModelClassType Toggle Toggle Toggle Pointer )
            value.CheckmarkImage                            = GetObject<Image>(new IntPtr(p + 0x070), ReversePrism.DataModels.Image.FromPointer); // 0x70 CheckmarkImage              ( ModelClassType Image Image Image Pointer )
            value.M_Field                                   = GetObject<BoolField>(new IntPtr(p + 0x078), ReversePrism.DataModels.BoolField.FromPointer); // 0x78 M_Field                     ( ModelClassType BoolField BoolField BoolField Pointer )

            return value;
        }
    }
}
