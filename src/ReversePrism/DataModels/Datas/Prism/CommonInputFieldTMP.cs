using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 2F8 PlaceHolderObject                        ModelClassType GameObject GameObject GameObject Pointer
    // 300 SavedColors                              ModelEnumType ColorBlock ColorBlock ColorBlock Int32
    // 358 onValueChangedSubject                    Subject`1<string> IL2CPP_TYPE_GENERICINST
    // 360 onEndEditSubject                         Subject`1<string> IL2CPP_TYPE_GENERICINST
    // 368 EmptyString                              ModelPrimitiveType string string string String
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

            value.PlaceHolderObject                         = GetObject<GameObject>(new IntPtr(p + 0x2F8), ReversePrism.DataModels.GameObject.FromPointer); // 0x2F8 PlaceHolderObject           ( ModelClassType GameObject GameObject GameObject Pointer )
            value.SavedColors                               = (ColorBlock)GetInt32(new IntPtr(p + 0x300)); // 0x300 SavedColors                 ( ModelEnumType ColorBlock ColorBlock ColorBlock Int32 )
            value.EmptyString                               = GetString(new IntPtr(p + 0x368)); // 0x368 EmptyString                 ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
