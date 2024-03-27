using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 058 InitialSelectedIndex                     0001865F2AF0 ModelPrimitiveType int int int Int32
    // 060 <OnCellLongClicked>k__BackingField       Action`2<int, GameObject> IL2CPP_TYPE_GENERICINST
    public partial class ProfilePIdolSelectGridContext
    {
        public int                                      InitialSelectedIndex                    { get; set; }

        public static ProfilePIdolSelectGridContext? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProfilePIdolSelectGridContext();

            value.InitialSelectedIndex                      = GetInt32(new IntPtr(p + 0x058)); // 0270DB741E68 0x58 InitialSelectedIndex        ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
