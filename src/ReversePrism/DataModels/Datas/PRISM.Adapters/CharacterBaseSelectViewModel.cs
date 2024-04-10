using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 unitMembers                              Dictionary`2<int, List`1<IIdolBaseStatus>> IL2CPP_TYPE_GENERICINST
    // 018 permanentDataPackage                     SavableJsonObject`1<CharacterBaseSelectPermanentData> IL2CPP_TYPE_GENERICINST
    // 020 SelectedUnitId                           0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class CharacterBaseSelectViewModel : DataModel
    {
        public int                                      SelectedUnitId                          { get; set; }

        public static CharacterBaseSelectViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CharacterBaseSelectViewModel() { Pointer= p0 };

            value.SelectedUnitId                            = GetInt32(new IntPtr(p + 0x020)); // 024665F02AC0 0x20 SelectedUnitId              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
