using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ArrResponse                              000185B79C30 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 018 CadMrm                                   00018659FB50 ModelClassType CADMethodReturnMessage CADMethodReturnMessage CADMethodReturnMessage Pointer
    public partial class ProcessMessageRes
    {
        public List<sbyte>?                             ArrResponse                             { get; set; }
        public CADMethodReturnMessage?                  CadMrm                                  { get; set; }

        public static ProcessMessageRes? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProcessMessageRes();

            value.ArrResponse                               = GetSByteList(new IntPtr(p + 0x010)); // 0270D6BE55C8 0x10 ArrResponse                 ( 000185B79C30 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.CadMrm                                    = GetObject<CADMethodReturnMessage>(new IntPtr(p + 0x018), ReversePrism.DataModels.CADMethodReturnMessage.FromPointer); // 0270D6BE55E8 0x18 CadMrm                      ( 00018659FB50 ModelClassType CADMethodReturnMessage CADMethodReturnMessage CADMethodReturnMessage Pointer )

            return value;
        }
    }
}
