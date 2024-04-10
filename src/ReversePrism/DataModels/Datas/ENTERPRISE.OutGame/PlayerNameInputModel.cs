using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 MAX_NAME_LENGTH                          int IL2CPP_TYPE_I4
    // 000 MAX_INPUT_NAME_LENGTH                    int IL2CPP_TYPE_I4
    public partial class PlayerNameInputModel : DataModel
    {

        public static PlayerNameInputModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PlayerNameInputModel() { Pointer= p0 };


            return value;
        }
    }
}
