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
    // 018 Story                                    ModelClassType StoryStatus StoryStatus StoryStatus Pointer
    // 000 MstExtraStoryCategoryIdFieldNumber       int IL2CPP_TYPE_I4
    // 020 MstExtraStoryCategoryId                  ModelPrimitiveType int int int Int32
    // 000 MstExtraStorySubCategoryIdFieldNumber    int IL2CPP_TYPE_I4
    // 024 MstExtraStorySubCategoryId               ModelPrimitiveType int int int Int32
    // 000 UnlockPremiseMstExtraStoryIdFieldNumber  int IL2CPP_TYPE_I4
    // 028 UnlockPremiseMstExtraStoryId             ModelPrimitiveType int int int Int32
    // 000 ExtraStoryTypeFieldNumber                int IL2CPP_TYPE_I4
    // 02C ExtraStoryType                           ModelEnumType ExtraStoryType ExtraStoryType ExtraStoryType Int32
    // 000 ScenarioIdFieldNumber                    int IL2CPP_TYPE_I4
    // 030 ScenarioId                               ModelPrimitiveType string string string String
    public partial class ExtraStoryStatus : DataModel
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
            var value   = new ExtraStoryStatus() { Pointer= p0 };

            value.Story                                     = GetObject<StoryStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.StoryStatus.FromPointer); // 0x18 Story                       ( ModelClassType StoryStatus StoryStatus StoryStatus Pointer )
            value.MstExtraStoryCategoryId                   = GetInt32(new IntPtr(p + 0x020)); // 0x20 MstExtraStoryCategoryId     ( ModelPrimitiveType int int int Int32 )
            value.MstExtraStorySubCategoryId                = GetInt32(new IntPtr(p + 0x024)); // 0x24 MstExtraStorySubCategoryId  ( ModelPrimitiveType int int int Int32 )
            value.UnlockPremiseMstExtraStoryId              = GetInt32(new IntPtr(p + 0x028)); // 0x28 UnlockPremiseMstExtraStoryId ( ModelPrimitiveType int int int Int32 )
            value.ExtraStoryType                            = (ExtraStoryType)GetInt32(new IntPtr(p + 0x02C)); // 0x2C ExtraStoryType              ( ModelEnumType ExtraStoryType ExtraStoryType ExtraStoryType Int32 )
            value.ScenarioId                                = GetString(new IntPtr(p + 0x030)); // 0x30 ScenarioId                  ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
