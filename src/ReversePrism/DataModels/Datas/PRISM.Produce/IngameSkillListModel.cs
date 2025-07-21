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
    // 020 SkillSubscribers                         ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 028 onPreUseSkill                            Subject`1<ValueTuple`2<int, IngameSkillModel>> IL2CPP_TYPE_GENERICINST
    // 030 TotalSkillUseCount                       ModelPrimitiveType int int int Int32
    // 038 SkillModelList                           ModelClassListType List`1<IngameSkillModel> List`1<IngameSkillModel> List<IngameSkillModel> Pointer
    public partial class IngameSkillListModel : DataModel
    {
        public CompositeDisposable?                     SkillSubscribers                        { get; set; }
        public int                                      TotalSkillUseCount                      { get; set; }
        public List<IngameSkillModel>?                  SkillModelList                          { get; set; }

        public static IngameSkillListModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IngameSkillListModel() { Pointer= p0 };

            value.SkillSubscribers                          = GetObject<CompositeDisposable>(new IntPtr(p + 0x020), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0x20 SkillSubscribers            ( ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.TotalSkillUseCount                        = GetInt32(new IntPtr(p + 0x030)); // 0x30 TotalSkillUseCount          ( ModelPrimitiveType int int int Int32 )
            value.SkillModelList                            = GetObjectList<IngameSkillModel>(new IntPtr(p + 0x038), ReversePrism.DataModels.IngameSkillModel.FromPointer); // 0x38 SkillModelList              ( ModelClassListType List`1<IngameSkillModel> List`1<IngameSkillModel> List<IngameSkillModel> Pointer )

            return value;
        }
    }
}
