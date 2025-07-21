using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 <IsFavorite>k__BackingField              Nullable`1<bool> IL2CPP_TYPE_GENERICINST
    // 012 ChoiceExists                             ModelPrimitiveType bool bool bool Bool
    public partial class AdvMenuOptionButtonContainerViewModel : DataModel
    {
        public bool                                     ChoiceExists                            { get; set; }

        public static AdvMenuOptionButtonContainerViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AdvMenuOptionButtonContainerViewModel() { Pointer= p0 };

            value.ChoiceExists                              = GetBool(new IntPtr(p + 0x012)); // 0x12 ChoiceExists                ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
