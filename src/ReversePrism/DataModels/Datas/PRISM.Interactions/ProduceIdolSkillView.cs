using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CanvasGroup                              ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 028 GoNormalText                             ModelClassType GameObject GameObject GameObject Pointer
    // 030 SkillListView                            ModelClassType ProduceIdolSkillListView ProduceIdolSkillListView ProduceIdolSkillListView Pointer
    // 038 OperationView                            ModelClassType ProduceIdolSkillLvUpView ProduceIdolSkillLvUpView ProduceIdolSkillLvUpView Pointer
    // 040 onIdolSkillLvUp                          Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 048 onSkillKeyWord                           Subject`1<List`1<int>> IL2CPP_TYPE_GENERICINST
    // 050 Vm                                       ModelClassType IdolSkillLvUpModel IdolSkillLvUpModel IdolSkillLvUpModel Pointer
    public partial class ProduceIdolSkillView : DataModel
    {
        public CanvasGroup?                             CanvasGroup                             { get; set; }
        public GameObject?                              GoNormalText                            { get; set; }
        public ProduceIdolSkillListView?                SkillListView                           { get; set; }
        public ProduceIdolSkillLvUpView?                OperationView                           { get; set; }
        public IdolSkillLvUpModel?                      Vm                                      { get; set; }

        public static ProduceIdolSkillView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceIdolSkillView() { Pointer= p0 };

            value.CanvasGroup                               = GetObject<CanvasGroup>(new IntPtr(p + 0x020), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0x20 CanvasGroup                 ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.GoNormalText                              = GetObject<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 0x28 GoNormalText                ( ModelClassType GameObject GameObject GameObject Pointer )
            value.SkillListView                             = GetObject<ProduceIdolSkillListView>(new IntPtr(p + 0x030), ReversePrism.DataModels.ProduceIdolSkillListView.FromPointer); // 0x30 SkillListView               ( ModelClassType ProduceIdolSkillListView ProduceIdolSkillListView ProduceIdolSkillListView Pointer )
            value.OperationView                             = GetObject<ProduceIdolSkillLvUpView>(new IntPtr(p + 0x038), ReversePrism.DataModels.ProduceIdolSkillLvUpView.FromPointer); // 0x38 OperationView               ( ModelClassType ProduceIdolSkillLvUpView ProduceIdolSkillLvUpView ProduceIdolSkillLvUpView Pointer )
            value.Vm                                        = GetObject<IdolSkillLvUpModel>(new IntPtr(p + 0x050), ReversePrism.DataModels.IdolSkillLvUpModel.FromPointer); // 0x50 Vm                          ( ModelClassType IdolSkillLvUpModel IdolSkillLvUpModel IdolSkillLvUpModel Pointer )

            return value;
        }
    }
}
