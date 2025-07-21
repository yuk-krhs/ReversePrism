using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GetSettingReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 GameSettingFieldNumber                   int IL2CPP_TYPE_I4
    // 018 GameSetting                              ModelClassType GameSettingStatus GameSettingStatus GameSettingStatus Pointer
    public partial class GetSettingReply : DataModel
    {
        public GameSettingStatus?                       GameSetting                             { get; set; }

        public static GetSettingReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetSettingReply() { Pointer= p0 };

            value.GameSetting                               = GetObject<GameSettingStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.GameSettingStatus.FromPointer); // 0x18 GameSetting                 ( ModelClassType GameSettingStatus GameSettingStatus GameSettingStatus Pointer )

            return value;
        }
    }
}
