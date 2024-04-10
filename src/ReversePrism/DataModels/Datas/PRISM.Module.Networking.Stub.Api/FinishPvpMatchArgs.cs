using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<FinishPvpMatchArgs> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 InGameResultFieldNumber                  int IL2CPP_TYPE_I4
    // 018 InGameResult                             0001865E7180 ModelClassType PvpInGameResultStatus PvpInGameResultStatus PvpInGameResultStatus Pointer
    public partial class FinishPvpMatchArgs : DataModel
    {
        public PvpInGameResultStatus?                   InGameResult                            { get; set; }

        public static FinishPvpMatchArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FinishPvpMatchArgs() { Pointer= p0 };

            value.InGameResult                              = GetObject<PvpInGameResultStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.PvpInGameResultStatus.FromPointer); // 0246626B8EB0 0x18 InGameResult                ( 0001865E7180 ModelClassType PvpInGameResultStatus PvpInGameResultStatus PvpInGameResultStatus Pointer )

            return value;
        }
    }
}
