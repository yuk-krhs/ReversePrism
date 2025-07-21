using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 DataList                                 ModelClassListType List`1<UserSaveData> List`1<UserSaveData> List<UserSaveData> Pointer
    // 018 SelectedIndex                            ModelPrimitiveType int int int Int32
    public partial class UserSaveDataCollection : DataModel
    {
        public List<UserSaveData>?                      DataList                                { get; set; }
        public int                                      SelectedIndex                           { get; set; }

        public static UserSaveDataCollection? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UserSaveDataCollection() { Pointer= p0 };

            value.DataList                                  = GetObjectList<UserSaveData>(new IntPtr(p + 0x010), ReversePrism.DataModels.UserSaveData.FromPointer); // 0x10 DataList                    ( ModelClassListType List`1<UserSaveData> List`1<UserSaveData> List<UserSaveData> Pointer )
            value.SelectedIndex                             = GetInt32(new IntPtr(p + 0x018)); // 0x18 SelectedIndex               ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
