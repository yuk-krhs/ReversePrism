using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Boxes                                    ModelClassListType IStrongBox[] IStrongBox[] List<IStrongBox> Pointer
    public partial class RuntimeVariables : DataModel
    {
        public List<IStrongBox>?                        Boxes                                   { get; set; }

        public static RuntimeVariables? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RuntimeVariables() { Pointer= p0 };

            value.Boxes                                     = GetObjectList<IStrongBox>(new IntPtr(p + 0x010), ReversePrism.DataModels.IStrongBox.FromPointer); // 0x10 Boxes                       ( ModelClassListType IStrongBox[] IStrongBox[] List<IStrongBox> Pointer )

            return value;
        }
    }
}
