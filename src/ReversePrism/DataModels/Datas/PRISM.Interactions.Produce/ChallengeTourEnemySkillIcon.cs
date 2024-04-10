using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Button                                   0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 028 IconImage                                0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 030 CostText                                 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 onClick                                  Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 040 DataIndex                                0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class ChallengeTourEnemySkillIcon : DataModel
    {
        public UIButton?                                Button                                  { get; set; }
        public UIRawImage?                              IconImage                               { get; set; }
        public UITextMeshProUGUI?                       CostText                                { get; set; }
        public int                                      DataIndex                               { get; set; }

        public static ChallengeTourEnemySkillIcon? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChallengeTourEnemySkillIcon() { Pointer= p0 };

            value.Button                                    = GetObject<UIButton>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIButton.FromPointer); // 02466A227740 0x20 Button                      ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.IconImage                                 = GetObject<UIRawImage>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIRawImage.FromPointer); // 02466A227760 0x28 IconImage                   ( 0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.CostText                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466A227780 0x30 CostText                    ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.DataIndex                                 = GetInt32(new IntPtr(p + 0x040)); // 02466A2277C0 0x40 DataIndex                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
