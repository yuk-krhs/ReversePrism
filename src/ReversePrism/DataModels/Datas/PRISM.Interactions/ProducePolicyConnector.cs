using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 088 AdvUI                                    ModelClassType AdvScreenView AdvScreenView AdvScreenView Pointer
    // 090 IsAlreadyDisplayedHowToPlay              ModelPrimitiveType bool bool bool Bool
    public partial class ProducePolicyConnector : DataModel
    {
        public AdvScreenView?                           AdvUI                                   { get; set; }
        public bool                                     IsAlreadyDisplayedHowToPlay             { get; set; }

        public static ProducePolicyConnector? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProducePolicyConnector() { Pointer= p0 };

            value.AdvUI                                     = GetObject<AdvScreenView>(new IntPtr(p + 0x088), ReversePrism.DataModels.AdvScreenView.FromPointer); // 0x88 AdvUI                       ( ModelClassType AdvScreenView AdvScreenView AdvScreenView Pointer )
            value.IsAlreadyDisplayedHowToPlay               = GetBool(new IntPtr(p + 0x090)); // 0x90 IsAlreadyDisplayedHowToPlay ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
