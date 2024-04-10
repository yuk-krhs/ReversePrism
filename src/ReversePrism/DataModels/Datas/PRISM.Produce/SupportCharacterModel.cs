using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SupportCharacterStatus                   000186669DA0 ModelClassType ISupportCharacterStatus ISupportCharacterStatus ISupportCharacterStatus Pointer
    // 018 CharaId                                  0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class SupportCharacterModel : DataModel
    {
        public ISupportCharacterStatus?                 SupportCharacterStatus                  { get; set; }
        public int                                      CharaId                                 { get; set; }

        public static SupportCharacterModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SupportCharacterModel() { Pointer= p0 };

            value.SupportCharacterStatus                    = GetObject<ISupportCharacterStatus>(new IntPtr(p + 0x010), ReversePrism.DataModels.ISupportCharacterStatus.FromPointer); // 0245A3B1B038 0x10 SupportCharacterStatus      ( 000186669DA0 ModelClassType ISupportCharacterStatus ISupportCharacterStatus ISupportCharacterStatus Pointer )
            value.CharaId                                   = GetInt32(new IntPtr(p + 0x018)); // 0245A3B1B058 0x18 CharaId                     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
