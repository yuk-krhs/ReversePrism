using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 UnitId                                   ModelPrimitiveType int int int Int32
    // 018 MvName                                   ModelPrimitiveType string string string String
    // 020 UnitIdols                                ModelClassListType UnitIdol[] UnitIdol[] List<UnitIdol> Pointer
    // 028 BgPrefabName                             ModelPrimitiveType string string string String
    public partial class PvpInGameUnitSceneData : DataModel
    {
        public int                                      UnitId                                  { get; set; }
        public string                                   MvName                                  { get; set; }
        public List<UnitIdol>?                          UnitIdols                               { get; set; }
        public string                                   BgPrefabName                            { get; set; }

        public static PvpInGameUnitSceneData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PvpInGameUnitSceneData() { Pointer= p0 };

            value.UnitId                                    = GetInt32(new IntPtr(p + 0x010)); // 0x10 UnitId                      ( ModelPrimitiveType int int int Int32 )
            value.MvName                                    = GetString(new IntPtr(p + 0x018)); // 0x18 MvName                      ( ModelPrimitiveType string string string String )
            value.UnitIdols                                 = GetObjectList<UnitIdol>(new IntPtr(p + 0x020), ReversePrism.DataModels.UnitIdol.FromPointer); // 0x20 UnitIdols                   ( ModelClassListType UnitIdol[] UnitIdol[] List<UnitIdol> Pointer )
            value.BgPrefabName                              = GetString(new IntPtr(p + 0x028)); // 0x28 BgPrefabName                ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
