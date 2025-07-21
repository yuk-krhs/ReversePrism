using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Story                                    ModelClassType IStoryStatus IStoryStatus IStoryStatus Pointer
    // 018 ForceHideNewBadge                        ModelPrimitiveType bool bool bool Bool
    // 019 IsEveryStoryReadNotionCell               ModelPrimitiveType bool bool bool Bool
    // 020 AdvScenarioInfo                          ModelClassType IAdvScenarioInfo IAdvScenarioInfo IAdvScenarioInfo Pointer
    // 028 SortId                                   ModelPrimitiveType int int int Int32
    // 030 MainTitle                                ModelPrimitiveType string string string String
    // 038 SubTitle                                 ModelPrimitiveType string string string String
    // 040 LockMessage                              ModelPrimitiveType string string string String
    public partial class StoryLastCategoryCellData : DataModel
    {
        public IStoryStatus?                            Story                                   { get; set; }
        public bool                                     ForceHideNewBadge                       { get; set; }
        public bool                                     IsEveryStoryReadNotionCell              { get; set; }
        public IAdvScenarioInfo?                        AdvScenarioInfo                         { get; set; }
        public int                                      SortId                                  { get; set; }
        public string                                   MainTitle                               { get; set; }
        public string                                   SubTitle                                { get; set; }
        public string                                   LockMessage                             { get; set; }

        public static StoryLastCategoryCellData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StoryLastCategoryCellData() { Pointer= p0 };

            value.Story                                     = GetObject<IStoryStatus>(new IntPtr(p + 0x010), ReversePrism.DataModels.IStoryStatus.FromPointer); // 0x10 Story                       ( ModelClassType IStoryStatus IStoryStatus IStoryStatus Pointer )
            value.ForceHideNewBadge                         = GetBool(new IntPtr(p + 0x018)); // 0x18 ForceHideNewBadge           ( ModelPrimitiveType bool bool bool Bool )
            value.IsEveryStoryReadNotionCell                = GetBool(new IntPtr(p + 0x019)); // 0x19 IsEveryStoryReadNotionCell  ( ModelPrimitiveType bool bool bool Bool )
            value.AdvScenarioInfo                           = GetObject<IAdvScenarioInfo>(new IntPtr(p + 0x020), ReversePrism.DataModels.IAdvScenarioInfo.FromPointer); // 0x20 AdvScenarioInfo             ( ModelClassType IAdvScenarioInfo IAdvScenarioInfo IAdvScenarioInfo Pointer )
            value.SortId                                    = GetInt32(new IntPtr(p + 0x028)); // 0x28 SortId                      ( ModelPrimitiveType int int int Int32 )
            value.MainTitle                                 = GetString(new IntPtr(p + 0x030)); // 0x30 MainTitle                   ( ModelPrimitiveType string string string String )
            value.SubTitle                                  = GetString(new IntPtr(p + 0x038)); // 0x38 SubTitle                    ( ModelPrimitiveType string string string String )
            value.LockMessage                               = GetString(new IntPtr(p + 0x040)); // 0x40 LockMessage                 ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
