using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Db                                       ModelClassType SavedataDB SavedataDB SavedataDB Pointer
    // 018 pendings                                 Dictionary`2<string, SavablePropertyBase> IL2CPP_TYPE_GENERICINST
    // 020 bufferDic                                Dictionary`2<string, string> IL2CPP_TYPE_GENERICINST
    public partial class BufferedSavedataProxy : DataModel
    {
        public SavedataDB?                              Db                                      { get; set; }

        public static BufferedSavedataProxy? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BufferedSavedataProxy() { Pointer= p0 };

            value.Db                                        = GetObject<SavedataDB>(new IntPtr(p + 0x010), ReversePrism.DataModels.SavedataDB.FromPointer); // 0x10 Db                          ( ModelClassType SavedataDB SavedataDB SavedataDB Pointer )

            return value;
        }
    }
}
