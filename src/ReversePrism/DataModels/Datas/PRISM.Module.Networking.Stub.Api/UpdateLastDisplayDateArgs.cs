using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<UpdateLastDisplayDateArgs> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 TabTypeFieldNumber                       int IL2CPP_TYPE_I4
    // 018 TabType                                  000186709870 ModelEnumType SeasonMissionTabType SeasonMissionTabType SeasonMissionTabType Int32
    public partial class UpdateLastDisplayDateArgs
    {
        public SeasonMissionTabType                     TabType                                 { get; set; }

        public static UpdateLastDisplayDateArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UpdateLastDisplayDateArgs();

            value.TabType                                   = (SeasonMissionTabType)GetInt32(new IntPtr(p + 0x018)); // 0270D278D8A0 0x18 TabType                     ( 000186709870 ModelEnumType SeasonMissionTabType SeasonMissionTabType SeasonMissionTabType Int32 )

            return value;
        }
    }
}
