using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ArrResponse                              ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 018 CadMrm                                   ModelClassType CADMethodReturnMessage CADMethodReturnMessage CADMethodReturnMessage Pointer
    public partial class ProcessMessageRes : DataModel
    {
        public List<sbyte>?                             ArrResponse                             { get; set; }
        public CADMethodReturnMessage?                  CadMrm                                  { get; set; }

        public static ProcessMessageRes? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProcessMessageRes() { Pointer= p0 };

            value.ArrResponse                               = GetSByteList(new IntPtr(p + 0x010)); // 0x10 ArrResponse                 ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.CadMrm                                    = GetObject<CADMethodReturnMessage>(new IntPtr(p + 0x018), ReversePrism.DataModels.CADMethodReturnMessage.FromPointer); // 0x18 CadMrm                      ( ModelClassType CADMethodReturnMessage CADMethodReturnMessage CADMethodReturnMessage Pointer )

            return value;
        }
    }
}
