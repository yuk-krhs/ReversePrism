using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       0001865F4260 ModelPrimitiveType int int int Int32
    // 014 SortId                                   0001865F4260 ModelPrimitiveType int int int Int32
    // 018 GashaResourceIdList                      000185B81DA0 ModelPrimitiveListType string[] string[] List<string> Pointer
    public partial class MstGashaCompensationTicket
    {
        public int                                      Id                                      { get; set; }
        public int                                      SortId                                  { get; set; }
        public List<string>?                            GashaResourceIdList                     { get; set; }

        public static MstGashaCompensationTicket? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MstGashaCompensationTicket();

            value.Id                                        = GetInt32(new IntPtr(p + 0x010)); // 0270045FDB00 0x10 Id                          ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.SortId                                    = GetInt32(new IntPtr(p + 0x014)); // 0270045FDB20 0x14 SortId                      ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.GashaResourceIdList                       = GetStringList(new IntPtr(p + 0x018)); // 0270045FDB40 0x18 GashaResourceIdList         ( 000185B81DA0 ModelPrimitiveListType string[] string[] List<string> Pointer )

            return value;
        }
    }
}
