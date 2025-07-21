using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 UigreadSystem                            ModelClassType UIRepeatedGridLayout UIRepeatedGridLayout UIRepeatedGridLayout Pointer
    // 068 MessageTables                            ModelClassListType DirectMessageModel[] DirectMessageModel[] List<DirectMessageModel> Pointer
    public partial class DirectMessagePopupContent : DataModel
    {
        public UIRepeatedGridLayout?                    UigreadSystem                           { get; set; }
        public List<DirectMessageModel>?                MessageTables                           { get; set; }

        public static DirectMessagePopupContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DirectMessagePopupContent() { Pointer= p0 };

            value.UigreadSystem                             = GetObject<UIRepeatedGridLayout>(new IntPtr(p + 0x060), ReversePrism.DataModels.UIRepeatedGridLayout.FromPointer); // 0x60 UigreadSystem               ( ModelClassType UIRepeatedGridLayout UIRepeatedGridLayout UIRepeatedGridLayout Pointer )
            value.MessageTables                             = GetObjectList<DirectMessageModel>(new IntPtr(p + 0x068), ReversePrism.DataModels.DirectMessageModel.FromPointer); // 0x68 MessageTables               ( ModelClassListType DirectMessageModel[] DirectMessageModel[] List<DirectMessageModel> Pointer )

            return value;
        }
    }
}
