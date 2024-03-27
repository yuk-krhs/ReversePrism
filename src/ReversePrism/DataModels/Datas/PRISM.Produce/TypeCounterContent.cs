using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ParameterUIs                             000185CC4838 ModelClassListType ParameterUI[] ParameterUI[] List<ParameterUI> Pointer
    public partial class TypeCounterContent
    {
        public List<ParameterUI>?                       ParameterUIs                            { get; set; }

        public static TypeCounterContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TypeCounterContent();

            value.ParameterUIs                              = GetObjectList<ParameterUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.ParameterUI.FromPointer); // 0270D5BC6040 0x20 ParameterUIs                ( 000185CC4838 ModelClassListType ParameterUI[] ParameterUI[] List<ParameterUI> Pointer )

            return value;
        }
    }
}
