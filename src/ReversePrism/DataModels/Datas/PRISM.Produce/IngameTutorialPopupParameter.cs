using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 090 UnitID                                   0001865F36C0 ModelPrimitiveType int int int Int32
    // 098 ManualData                               0001866DA720 ModelClassType HowToPlayProduceManualData HowToPlayProduceManualData HowToPlayProduceManualData Pointer
    public partial class IngameTutorialPopupParameter
    {
        public int                                      UnitID                                  { get; set; }
        public HowToPlayProduceManualData?              ManualData                              { get; set; }

        public static IngameTutorialPopupParameter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IngameTutorialPopupParameter();

            value.UnitID                                    = GetInt32(new IntPtr(p + 0x090)); // 0270D5C7DD50 0x90 UnitID                      ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.ManualData                                = GetObject<HowToPlayProduceManualData>(new IntPtr(p + 0x098), ReversePrism.DataModels.HowToPlayProduceManualData.FromPointer); // 0270D5C7DD70 0x98 ManualData                  ( 0001866DA720 ModelClassType HowToPlayProduceManualData HowToPlayProduceManualData HowToPlayProduceManualData Pointer )

            return value;
        }
    }
}
