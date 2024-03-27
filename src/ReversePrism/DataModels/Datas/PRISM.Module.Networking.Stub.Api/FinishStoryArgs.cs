using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<FinishStoryArgs> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 StoryIdFieldNumber                       int IL2CPP_TYPE_I4
    // 018 StoryId                                  0001865979C0 ModelClassType StoryIDStatus StoryIDStatus StoryIDStatus Pointer
    // 000 StoryModeFieldNumber                     int IL2CPP_TYPE_I4
    // 020 StoryMode                                000186598FF0 ModelEnumType StoryMode StoryMode StoryMode Int32
    public partial class FinishStoryArgs
    {
        public StoryIDStatus?                           StoryId                                 { get; set; }
        public StoryMode                                StoryMode                               { get; set; }

        public static FinishStoryArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FinishStoryArgs();

            value.StoryId                                   = GetObject<StoryIDStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.StoryIDStatus.FromPointer); // 0270D2A28EA8 0x18 StoryId                     ( 0001865979C0 ModelClassType StoryIDStatus StoryIDStatus StoryIDStatus Pointer )
            value.StoryMode                                 = (StoryMode)GetInt32(new IntPtr(p + 0x020)); // 0270D2A28EE8 0x20 StoryMode                   ( 000186598FF0 ModelEnumType StoryMode StoryMode StoryMode Int32 )

            return value;
        }
    }
}
