using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ProduceCardContent                       ModelClassType ProduceCardContent ProduceCardContent ProduceCardContent Pointer
    // 028 NormalCostUIArea                         ModelClassType GameObject GameObject GameObject Pointer
    // 030 BuffCostUI                               ModelClassType CostUI CostUI CostUI Pointer
    // 038 DeBuffCostUI                             ModelClassType CostUI CostUI CostUI Pointer
    // 040 CardRankUpIcons                          ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 048 NotAvailableUI                           ModelClassType GameObject GameObject GameObject Pointer
    // 050 PrevBaseCost                             ModelPrimitiveType int int int Int32
    // 054 PrevCalcCost                             ModelPrimitiveType int int int Int32
    public partial class InGamePCardContent : DataModel
    {
        public ProduceCardContent?                      ProduceCardContent                      { get; set; }
        public GameObject?                              NormalCostUIArea                        { get; set; }
        public CostUI?                                  BuffCostUI                              { get; set; }
        public CostUI?                                  DeBuffCostUI                            { get; set; }
        public List<GameObject>?                        CardRankUpIcons                         { get; set; }
        public GameObject?                              NotAvailableUI                          { get; set; }
        public int                                      PrevBaseCost                            { get; set; }
        public int                                      PrevCalcCost                            { get; set; }

        public static InGamePCardContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InGamePCardContent() { Pointer= p0 };

            value.ProduceCardContent                        = GetObject<ProduceCardContent>(new IntPtr(p + 0x020), ReversePrism.DataModels.ProduceCardContent.FromPointer); // 0x20 ProduceCardContent          ( ModelClassType ProduceCardContent ProduceCardContent ProduceCardContent Pointer )
            value.NormalCostUIArea                          = GetObject<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 0x28 NormalCostUIArea            ( ModelClassType GameObject GameObject GameObject Pointer )
            value.BuffCostUI                                = GetObject<CostUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.CostUI.FromPointer); // 0x30 BuffCostUI                  ( ModelClassType CostUI CostUI CostUI Pointer )
            value.DeBuffCostUI                              = GetObject<CostUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.CostUI.FromPointer); // 0x38 DeBuffCostUI                ( ModelClassType CostUI CostUI CostUI Pointer )
            value.CardRankUpIcons                           = GetObjectList<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 0x40 CardRankUpIcons             ( ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.NotAvailableUI                            = GetObject<GameObject>(new IntPtr(p + 0x048), ReversePrism.DataModels.GameObject.FromPointer); // 0x48 NotAvailableUI              ( ModelClassType GameObject GameObject GameObject Pointer )
            value.PrevBaseCost                              = GetInt32(new IntPtr(p + 0x050)); // 0x50 PrevBaseCost                ( ModelPrimitiveType int int int Int32 )
            value.PrevCalcCost                              = GetInt32(new IntPtr(p + 0x054)); // 0x54 PrevCalcCost                ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
