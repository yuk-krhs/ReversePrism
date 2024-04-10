using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ProduceCardContent                       0001865353C0 ModelClassType ProduceCardContent ProduceCardContent ProduceCardContent Pointer
    // 028 NormalCostUIArea                         0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 030 BuffCostUI                               0001866070B0 ModelClassType CostUI CostUI CostUI Pointer
    // 038 DeBuffCostUI                             0001866070B0 ModelClassType CostUI CostUI CostUI Pointer
    // 040 CardRankUpIcons                          000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 048 NotAvailableUI                           0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    public partial class InGamePCardContent : DataModel
    {
        public ProduceCardContent?                      ProduceCardContent                      { get; set; }
        public GameObject?                              NormalCostUIArea                        { get; set; }
        public CostUI?                                  BuffCostUI                              { get; set; }
        public CostUI?                                  DeBuffCostUI                            { get; set; }
        public List<GameObject>?                        CardRankUpIcons                         { get; set; }
        public GameObject?                              NotAvailableUI                          { get; set; }

        public static InGamePCardContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InGamePCardContent() { Pointer= p0 };

            value.ProduceCardContent                        = GetObject<ProduceCardContent>(new IntPtr(p + 0x020), ReversePrism.DataModels.ProduceCardContent.FromPointer); // 024665B63B78 0x20 ProduceCardContent          ( 0001865353C0 ModelClassType ProduceCardContent ProduceCardContent ProduceCardContent Pointer )
            value.NormalCostUIArea                          = GetObject<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 024665B63B98 0x28 NormalCostUIArea            ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.BuffCostUI                                = GetObject<CostUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.CostUI.FromPointer); // 024665B63BB8 0x30 BuffCostUI                  ( 0001866070B0 ModelClassType CostUI CostUI CostUI Pointer )
            value.DeBuffCostUI                              = GetObject<CostUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.CostUI.FromPointer); // 024665B63BD8 0x38 DeBuffCostUI                ( 0001866070B0 ModelClassType CostUI CostUI CostUI Pointer )
            value.CardRankUpIcons                           = GetObjectList<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 024665B63BF8 0x40 CardRankUpIcons             ( 000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.NotAvailableUI                            = GetObject<GameObject>(new IntPtr(p + 0x048), ReversePrism.DataModels.GameObject.FromPointer); // 024665B63C18 0x48 NotAvailableUI              ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )

            return value;
        }
    }
}
