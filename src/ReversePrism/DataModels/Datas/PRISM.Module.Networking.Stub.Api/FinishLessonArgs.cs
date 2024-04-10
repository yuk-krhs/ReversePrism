using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<FinishLessonArgs> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 InGameResultFieldNumber                  int IL2CPP_TYPE_I4
    // 018 InGameResult                             0001866D9390 ModelClassType InGameResultStatus InGameResultStatus InGameResultStatus Pointer
    public partial class FinishLessonArgs : DataModel
    {
        public InGameResultStatus?                      InGameResult                            { get; set; }

        public static FinishLessonArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FinishLessonArgs() { Pointer= p0 };

            value.InGameResult                              = GetObject<InGameResultStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.InGameResultStatus.FromPointer); // 0246625136F8 0x18 InGameResult                ( 0001866D9390 ModelClassType InGameResultStatus InGameResultStatus InGameResultStatus Pointer )

            return value;
        }
    }
}
