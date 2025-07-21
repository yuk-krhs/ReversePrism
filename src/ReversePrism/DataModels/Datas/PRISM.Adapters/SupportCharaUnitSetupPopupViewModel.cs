using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 UnitId                                   ModelPrimitiveType int int int Int32
    // 018 UnitName                                 ModelPrimitiveType string string string String
    // 020 AllSupportCharacters                     ModelClassListType IReadOnlyList`1<ISupportCharacterStatus> IReadOnlyList`1<ISupportCharacterStatus> List<ISupportCharacterStatus> Pointer
    // 028 InitialSupportCharacters                 ModelClassListType IReadOnlyList`1<ISupportCharacterStatus> IReadOnlyList`1<ISupportCharacterStatus> List<ISupportCharacterStatus> Pointer
    // 030 SelfSupportCharacters                    ModelClassListType List`1<ISupportCharacterStatus> List`1<ISupportCharacterStatus> List<ISupportCharacterStatus> Pointer
    public partial class SupportCharaUnitSetupPopupViewModel : DataModel
    {
        public int                                      UnitId                                  { get; set; }
        public string                                   UnitName                                { get; set; }
        public List<ISupportCharacterStatus>?           AllSupportCharacters                    { get; set; }
        public List<ISupportCharacterStatus>?           InitialSupportCharacters                { get; set; }
        public List<ISupportCharacterStatus>?           SelfSupportCharacters                   { get; set; }

        public static SupportCharaUnitSetupPopupViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SupportCharaUnitSetupPopupViewModel() { Pointer= p0 };

            value.UnitId                                    = GetInt32(new IntPtr(p + 0x010)); // 0x10 UnitId                      ( ModelPrimitiveType int int int Int32 )
            value.UnitName                                  = GetString(new IntPtr(p + 0x018)); // 0x18 UnitName                    ( ModelPrimitiveType string string string String )
            value.AllSupportCharacters                      = GetObjectList<ISupportCharacterStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.ISupportCharacterStatus.FromPointer); // 0x20 AllSupportCharacters        ( ModelClassListType IReadOnlyList`1<ISupportCharacterStatus> IReadOnlyList`1<ISupportCharacterStatus> List<ISupportCharacterStatus> Pointer )
            value.InitialSupportCharacters                  = GetObjectList<ISupportCharacterStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.ISupportCharacterStatus.FromPointer); // 0x28 InitialSupportCharacters    ( ModelClassListType IReadOnlyList`1<ISupportCharacterStatus> IReadOnlyList`1<ISupportCharacterStatus> List<ISupportCharacterStatus> Pointer )
            value.SelfSupportCharacters                     = GetObjectList<ISupportCharacterStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.ISupportCharacterStatus.FromPointer); // 0x30 SelfSupportCharacters       ( ModelClassListType List`1<ISupportCharacterStatus> List`1<ISupportCharacterStatus> List<ISupportCharacterStatus> Pointer )

            return value;
        }
    }
}
