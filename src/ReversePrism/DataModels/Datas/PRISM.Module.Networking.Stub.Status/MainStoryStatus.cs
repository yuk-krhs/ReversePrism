using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<MainStoryStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 StoryFieldNumber                         int IL2CPP_TYPE_I4
    // 018 Story                                    ModelClassType StoryStatus StoryStatus StoryStatus Pointer
    // 000 MstMainStoryChapterIdFieldNumber         int IL2CPP_TYPE_I4
    // 020 MstMainStoryChapterId                    ModelPrimitiveType int int int Int32
    // 000 UnlockPremiseMstMainStoryIdFieldNumber   int IL2CPP_TYPE_I4
    // 024 UnlockPremiseMstMainStoryId              ModelPrimitiveType int int int Int32
    // 000 MstUnitIdFieldNumber                     int IL2CPP_TYPE_I4
    // 028 MstUnitId                                ModelPrimitiveType int int int Int32
    public partial class MainStoryStatus : DataModel
    {
        public StoryStatus?                             Story                                   { get; set; }
        public int                                      MstMainStoryChapterId                   { get; set; }
        public int                                      UnlockPremiseMstMainStoryId             { get; set; }
        public int                                      MstUnitId                               { get; set; }

        public static MainStoryStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MainStoryStatus() { Pointer= p0 };

            value.Story                                     = GetObject<StoryStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.StoryStatus.FromPointer); // 0x18 Story                       ( ModelClassType StoryStatus StoryStatus StoryStatus Pointer )
            value.MstMainStoryChapterId                     = GetInt32(new IntPtr(p + 0x020)); // 0x20 MstMainStoryChapterId       ( ModelPrimitiveType int int int Int32 )
            value.UnlockPremiseMstMainStoryId               = GetInt32(new IntPtr(p + 0x024)); // 0x24 UnlockPremiseMstMainStoryId ( ModelPrimitiveType int int int Int32 )
            value.MstUnitId                                 = GetInt32(new IntPtr(p + 0x028)); // 0x28 MstUnitId                   ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
