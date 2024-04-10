using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 isChangeCloth                            bool IL2CPP_TYPE_BOOLEAN
    // 008 changeClothDic                           Dictionary`2<string, UnitIdol> IL2CPP_TYPE_GENERICINST
    // 010 changeBaseDic                            Dictionary`2<string, UnitIdol> IL2CPP_TYPE_GENERICINST
    public partial class UnitIdolDataIO : DataModel
    {

        public static UnitIdolDataIO? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UnitIdolDataIO() { Pointer= p0 };


            return value;
        }
    }
}
