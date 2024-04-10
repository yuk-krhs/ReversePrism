using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 BasePath                                 string IL2CPP_TYPE_STRING
    // 010 PopupPaths                               000185B81DA0 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 018 DirectMessageModels                      000185B7A6D0 ModelClassListType DirectMessageModel[] DirectMessageModel[] List<DirectMessageModel> Pointer
    public partial class DirectMessageManager : DataModel
    {
        public List<string>?                            PopupPaths                              { get; set; }
        public List<DirectMessageModel>?                DirectMessageModels                     { get; set; }

        public static DirectMessageManager? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DirectMessageManager() { Pointer= p0 };

            value.PopupPaths                                = GetStringList(new IntPtr(p + 0x010)); // 024664D17480 0x10 PopupPaths                  ( 000185B81DA0 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.DirectMessageModels                       = GetObjectList<DirectMessageModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.DirectMessageModel.FromPointer); // 024664D174A0 0x18 DirectMessageModels         ( 000185B7A6D0 ModelClassListType DirectMessageModel[] DirectMessageModel[] List<DirectMessageModel> Pointer )

            return value;
        }
    }
}
