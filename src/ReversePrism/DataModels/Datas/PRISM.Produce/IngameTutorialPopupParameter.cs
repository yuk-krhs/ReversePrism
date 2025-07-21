using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 090 UnitID                                   ModelPrimitiveType int int int Int32
    // 098 ManualData                               ModelClassType HowToPlayProduceManualData HowToPlayProduceManualData HowToPlayProduceManualData Pointer
    public partial class IngameTutorialPopupParameter : DataModel
    {
        public int                                      UnitID                                  { get; set; }
        public HowToPlayProduceManualData?              ManualData                              { get; set; }

        public static IngameTutorialPopupParameter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IngameTutorialPopupParameter() { Pointer= p0 };

            value.UnitID                                    = GetInt32(new IntPtr(p + 0x090)); // 0x90 UnitID                      ( ModelPrimitiveType int int int Int32 )
            value.ManualData                                = GetObject<HowToPlayProduceManualData>(new IntPtr(p + 0x098), ReversePrism.DataModels.HowToPlayProduceManualData.FromPointer); // 0x98 ManualData                  ( ModelClassType HowToPlayProduceManualData HowToPlayProduceManualData HowToPlayProduceManualData Pointer )

            return value;
        }
    }
}
