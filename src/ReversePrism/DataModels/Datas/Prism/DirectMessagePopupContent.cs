using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 UigreadSystem                            0001866F0C40 ModelClassType UIRepeatedGridLayout UIRepeatedGridLayout UIRepeatedGridLayout Pointer
    // 068 MessageTables                            000185B7A6D0 ModelClassListType DirectMessageModel[] DirectMessageModel[] List<DirectMessageModel> Pointer
    public partial class DirectMessagePopupContent
    {
        public UIRepeatedGridLayout?                    UigreadSystem                           { get; set; }
        public List<DirectMessageModel>?                MessageTables                           { get; set; }

        public static DirectMessagePopupContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DirectMessagePopupContent();

            value.UigreadSystem                             = GetObject<UIRepeatedGridLayout>(new IntPtr(p + 0x060), ReversePrism.DataModels.UIRepeatedGridLayout.FromPointer); // 0270D4CAE598 0x60 UigreadSystem               ( 0001866F0C40 ModelClassType UIRepeatedGridLayout UIRepeatedGridLayout UIRepeatedGridLayout Pointer )
            value.MessageTables                             = GetObjectList<DirectMessageModel>(new IntPtr(p + 0x068), ReversePrism.DataModels.DirectMessageModel.FromPointer); // 0270D4CAE5B8 0x68 MessageTables               ( 000185B7A6D0 ModelClassListType DirectMessageModel[] DirectMessageModel[] List<DirectMessageModel> Pointer )

            return value;
        }
    }
}
