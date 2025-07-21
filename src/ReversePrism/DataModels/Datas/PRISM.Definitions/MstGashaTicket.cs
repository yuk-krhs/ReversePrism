using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       ModelPrimitiveType int int int Int32
    // 014 SortId                                   ModelPrimitiveType int int int Int32
    // 018 GashaResourceIdList                      ModelPrimitiveListType string[] string[] List<string> Pointer
    public partial class MstGashaTicket : DataModel
    {
        public int                                      Id                                      { get; set; }
        public int                                      SortId                                  { get; set; }
        public List<string>?                            GashaResourceIdList                     { get; set; }

        public static MstGashaTicket? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MstGashaTicket() { Pointer= p0 };

            value.Id                                        = GetInt32(new IntPtr(p + 0x010)); // 0x10 Id                          ( ModelPrimitiveType int int int Int32 )
            value.SortId                                    = GetInt32(new IntPtr(p + 0x014)); // 0x14 SortId                      ( ModelPrimitiveType int int int Int32 )
            value.GashaResourceIdList                       = GetStringList(new IntPtr(p + 0x018)); // 0x18 GashaResourceIdList         ( ModelPrimitiveListType string[] string[] List<string> Pointer )

            return value;
        }
    }
}
