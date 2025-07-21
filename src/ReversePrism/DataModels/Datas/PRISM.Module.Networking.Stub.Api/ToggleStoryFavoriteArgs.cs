using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<ToggleStoryFavoriteArgs> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 StoryIdFieldNumber                       int IL2CPP_TYPE_I4
    // 018 StoryId                                  ModelClassType StoryIDStatus StoryIDStatus StoryIDStatus Pointer
    public partial class ToggleStoryFavoriteArgs : DataModel
    {
        public StoryIDStatus?                           StoryId                                 { get; set; }

        public static ToggleStoryFavoriteArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ToggleStoryFavoriteArgs() { Pointer= p0 };

            value.StoryId                                   = GetObject<StoryIDStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.StoryIDStatus.FromPointer); // 0x18 StoryId                     ( ModelClassType StoryIDStatus StoryIDStatus StoryIDStatus Pointer )

            return value;
        }
    }
}
