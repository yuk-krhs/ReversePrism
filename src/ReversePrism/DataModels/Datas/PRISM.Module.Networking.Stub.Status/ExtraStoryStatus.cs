using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<ExtraStoryStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 StoryFieldNumber                         int IL2CPP_TYPE_I4
    // 018 Story                                    0001865A4D90 ModelClassType StoryStatus StoryStatus StoryStatus Pointer
    // 000 MstExtraStoryCategoryIdFieldNumber       int IL2CPP_TYPE_I4
    // 020 MstExtraStoryCategoryId                  0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 MstExtraStorySubCategoryIdFieldNumber    int IL2CPP_TYPE_I4
    // 024 MstExtraStorySubCategoryId               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 UnlockPremiseMstExtraStoryIdFieldNumber  int IL2CPP_TYPE_I4
    // 028 UnlockPremiseMstExtraStoryId             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 ExtraStoryTypeFieldNumber                int IL2CPP_TYPE_I4
    // 02C ExtraStoryType                           00018653F870 ModelEnumType ExtraStoryType ExtraStoryType ExtraStoryType Int32
    // 000 ScenarioIdFieldNumber                    int IL2CPP_TYPE_I4
    // 030 ScenarioId                               000186671910 ModelPrimitiveType string string string String
    public partial class ExtraStoryStatus
    {
        public StoryStatus?                             Story                                   { get; set; }
        public int                                      MstExtraStoryCategoryId                 { get; set; }
        public int                                      MstExtraStorySubCategoryId              { get; set; }
        public int                                      UnlockPremiseMstExtraStoryId            { get; set; }
        public ExtraStoryType                           ExtraStoryType                          { get; set; }
        public string                                   ScenarioId                              { get; set; }

        public static ExtraStoryStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExtraStoryStatus();

            value.Story                                     = GetObject<StoryStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.StoryStatus.FromPointer); // 0270D2A37120 0x18 Story                       ( 0001865A4D90 ModelClassType StoryStatus StoryStatus StoryStatus Pointer )
            value.MstExtraStoryCategoryId                   = GetInt32(new IntPtr(p + 0x020)); // 0270D2A37160 0x20 MstExtraStoryCategoryId     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MstExtraStorySubCategoryId                = GetInt32(new IntPtr(p + 0x024)); // 0270D2A371A0 0x24 MstExtraStorySubCategoryId  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.UnlockPremiseMstExtraStoryId              = GetInt32(new IntPtr(p + 0x028)); // 0270D2A371E0 0x28 UnlockPremiseMstExtraStoryId ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ExtraStoryType                            = (ExtraStoryType)GetInt32(new IntPtr(p + 0x02C)); // 0270D2A37220 0x2C ExtraStoryType              ( 00018653F870 ModelEnumType ExtraStoryType ExtraStoryType ExtraStoryType Int32 )
            value.ScenarioId                                = GetString(new IntPtr(p + 0x030)); // 0270D2A37260 0x30 ScenarioId                  ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
