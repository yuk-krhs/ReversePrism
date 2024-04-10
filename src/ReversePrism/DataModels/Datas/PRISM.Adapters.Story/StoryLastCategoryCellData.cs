using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Story                                    00018665DA10 ModelClassType IStoryStatus IStoryStatus IStoryStatus Pointer
    // 018 ForceHideNewBadge                        0001865965D0 ModelPrimitiveType bool bool bool Bool
    // 020 AdvScenarioInfo                          0001866EF790 ModelClassType IAdvScenarioInfo IAdvScenarioInfo IAdvScenarioInfo Pointer
    // 028 SortId                                   0001865F4260 ModelPrimitiveType int int int Int32
    // 030 MainTitle                                000186672F10 ModelPrimitiveType string string string String
    // 038 SubTitle                                 000186672F10 ModelPrimitiveType string string string String
    // 040 LockMessage                              000186672F10 ModelPrimitiveType string string string String
    public partial class StoryLastCategoryCellData : DataModel
    {
        public IStoryStatus?                            Story                                   { get; set; }
        public bool                                     ForceHideNewBadge                       { get; set; }
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

            value.Story                                     = GetObject<IStoryStatus>(new IntPtr(p + 0x010), ReversePrism.DataModels.IStoryStatus.FromPointer); // 024666827020 0x10 Story                       ( 00018665DA10 ModelClassType IStoryStatus IStoryStatus IStoryStatus Pointer )
            value.ForceHideNewBadge                         = GetBool(new IntPtr(p + 0x018)); // 024666827040 0x18 ForceHideNewBadge           ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )
            value.AdvScenarioInfo                           = GetObject<IAdvScenarioInfo>(new IntPtr(p + 0x020), ReversePrism.DataModels.IAdvScenarioInfo.FromPointer); // 024666827060 0x20 AdvScenarioInfo             ( 0001866EF790 ModelClassType IAdvScenarioInfo IAdvScenarioInfo IAdvScenarioInfo Pointer )
            value.SortId                                    = GetInt32(new IntPtr(p + 0x028)); // 024666827080 0x28 SortId                      ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.MainTitle                                 = GetString(new IntPtr(p + 0x030)); // 0246668270A0 0x30 MainTitle                   ( 000186672F10 ModelPrimitiveType string string string String )
            value.SubTitle                                  = GetString(new IntPtr(p + 0x038)); // 0246668270C0 0x38 SubTitle                    ( 000186672F10 ModelPrimitiveType string string string String )
            value.LockMessage                               = GetString(new IntPtr(p + 0x040)); // 0246668270E0 0x40 LockMessage                 ( 000186672F10 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
