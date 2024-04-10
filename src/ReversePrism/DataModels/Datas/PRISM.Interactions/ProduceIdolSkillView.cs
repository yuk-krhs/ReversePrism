using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CanvasGroup                              000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 028 GoNormalText                             0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 030 SkillListView                            00018654E4B0 ModelClassType ProduceIdolSkillListView ProduceIdolSkillListView ProduceIdolSkillListView Pointer
    // 038 OperationView                            00018654E9B0 ModelClassType ProduceIdolSkillLvUpView ProduceIdolSkillLvUpView ProduceIdolSkillLvUpView Pointer
    // 040 onHowToGetItems                          Subject`1<List`1<ValueTuple`3<ProductKey, long, long>>> IL2CPP_TYPE_GENERICINST
    // 048 onIdolSkillLvUp                          Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 050 onSkillKeyWord                           Subject`1<List`1<int>> IL2CPP_TYPE_GENERICINST
    // 058 Vm                                       0001866C1440 ModelClassType IdolSkillLvUpModel IdolSkillLvUpModel IdolSkillLvUpModel Pointer
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

            value.CanvasGroup                               = GetObject<CanvasGroup>(new IntPtr(p + 0x020), ReversePrism.DataModels.CanvasGroup.FromPointer); // 02466A3BF9A0 0x20 CanvasGroup                 ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.GoNormalText                              = GetObject<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 02466A3BF9C0 0x28 GoNormalText                ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.SkillListView                             = GetObject<ProduceIdolSkillListView>(new IntPtr(p + 0x030), ReversePrism.DataModels.ProduceIdolSkillListView.FromPointer); // 02466A3BF9E0 0x30 SkillListView               ( 00018654E4B0 ModelClassType ProduceIdolSkillListView ProduceIdolSkillListView ProduceIdolSkillListView Pointer )
            value.OperationView                             = GetObject<ProduceIdolSkillLvUpView>(new IntPtr(p + 0x038), ReversePrism.DataModels.ProduceIdolSkillLvUpView.FromPointer); // 02466A3BFA00 0x38 OperationView               ( 00018654E9B0 ModelClassType ProduceIdolSkillLvUpView ProduceIdolSkillLvUpView ProduceIdolSkillLvUpView Pointer )
            value.Vm                                        = GetObject<IdolSkillLvUpModel>(new IntPtr(p + 0x058), ReversePrism.DataModels.IdolSkillLvUpModel.FromPointer); // 02466A3BFA80 0x58 Vm                          ( 0001866C1440 ModelClassType IdolSkillLvUpModel IdolSkillLvUpModel IdolSkillLvUpModel Pointer )

            return value;
        }
    }
}
