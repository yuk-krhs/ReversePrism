using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 onUpdateUsableCountSubject               Subject`1<ValueTuple`3<int, int, int>> IL2CPP_TYPE_GENERICINST
    // 018 onOverWriteCost                          Subject`1<ValueTuple`2<int, int>> IL2CPP_TYPE_GENERICINST
    // 020 SkillSubscribers                         0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 028 onPreUseSkill                            Subject`1<ValueTuple`2<int, IngameSkillModel>> IL2CPP_TYPE_GENERICINST
    // 030 TotalSkillUseCount                       0001865F2AF0 ModelPrimitiveType int int int Int32
    // 038 SkillModels                              000185D112C8 ModelClassListType IReadOnlyList`1<IngameSkillModel> IReadOnlyList`1<IngameSkillModel> List<IngameSkillModel> Pointer
    public partial class IngameSkillListModel : DataModel
    {
        public CompositeDisposable?                     SkillSubscribers                        { get; set; }
        public int                                      TotalSkillUseCount                      { get; set; }
        public List<IngameSkillModel>?                  SkillModels                             { get; set; }

        public static IngameSkillListModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IngameSkillListModel() { Pointer= p0 };

            value.SkillSubscribers                          = GetObject<CompositeDisposable>(new IntPtr(p + 0x020), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 024665BCFDF0 0x20 SkillSubscribers            ( 0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.TotalSkillUseCount                        = GetInt32(new IntPtr(p + 0x030)); // 024665BCFE30 0x30 TotalSkillUseCount          ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.SkillModels                               = GetObjectList<IngameSkillModel>(new IntPtr(p + 0x038), ReversePrism.DataModels.IngameSkillModel.FromPointer); // 024665BCFE50 0x38 SkillModels                 ( 000185D112C8 ModelClassListType IReadOnlyList`1<IngameSkillModel> IReadOnlyList`1<IngameSkillModel> List<IngameSkillModel> Pointer )

            return value;
        }
    }
}
