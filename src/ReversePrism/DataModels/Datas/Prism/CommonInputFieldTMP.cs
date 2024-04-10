using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 2F8 PlaceHolderObject                        0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 300 SavedColors                              0001865CC0F0 ModelEnumType ColorBlock ColorBlock ColorBlock Int32
    // 358 onValueChangedSubject                    Subject`1<string> IL2CPP_TYPE_GENERICINST
    // 360 onEndEditSubject                         Subject`1<string> IL2CPP_TYPE_GENERICINST
    // 368 EmptyString                              000186672F10 ModelPrimitiveType string string string String
    public partial class CommonInputFieldTMP : DataModel
    {
        public GameObject?                              PlaceHolderObject                       { get; set; }
        public ColorBlock                               SavedColors                             { get; set; }
        public string                                   EmptyString                             { get; set; }

        public static CommonInputFieldTMP? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CommonInputFieldTMP() { Pointer= p0 };

            value.PlaceHolderObject                         = GetObject<GameObject>(new IntPtr(p + 0x2F8), ReversePrism.DataModels.GameObject.FromPointer); // 0245A4428338 0x2F8 PlaceHolderObject           ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.SavedColors                               = (ColorBlock)GetInt32(new IntPtr(p + 0x300)); // 0245A4428358 0x300 SavedColors                 ( 0001865CC0F0 ModelEnumType ColorBlock ColorBlock ColorBlock Int32 )
            value.EmptyString                               = GetString(new IntPtr(p + 0x368)); // 0245A44283B8 0x368 EmptyString                 ( 000186672F10 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
